﻿using System;
using System.Runtime.Serialization.Formatters;
using EPiServer.Core;
using Newtonsoft.Json;

namespace Geta.EPi.HotspotsEditor.Cms.Properties
{
    public abstract class PropertyJsonSerializedObject<T> : PropertyLongString where T : class
    {
        protected T _value;

        public override Type PropertyValueType => typeof(T);

        public override object Value
        {
            get
            {
                if (_value != null) return _value;

                var str = base.Value as string;
                if (str == null) return default(T);

                try
                {
                    _value = JsonConvert.DeserializeObject<T>(str, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Objects
                    });
                }
                catch (Exception)
                {
                    _value = default(T);
                }

                return _value;
            }
            set
            {
                if (value is T)
                {
                    _value = default(T);

                    try
                    {
                        base.Value = JsonConvert.SerializeObject(value, new JsonSerializerSettings
                        {
                            TypeNameHandling = TypeNameHandling.Objects,
                            TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
                        });
                    }
                    catch (Exception)
                    {
                        base.Value = value;
                    }
                }
                else
                {
                    base.Value = value;
                }
            }
        }

        public override object SaveData(PropertyDataCollection properties)
        {
            return LongString;
        }

        [Obsolete("Use IPropertyControlFactory to create property controls")]
        public override IPropertyControl CreatePropertyControl()
        {
            return null;
        }
    }
}