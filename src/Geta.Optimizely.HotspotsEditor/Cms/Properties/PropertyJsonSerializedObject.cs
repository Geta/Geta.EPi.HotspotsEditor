using System;
using EPiServer.Core;
using Newtonsoft.Json;

namespace Geta.Optimizely.HotspotsEditor.Cms.Properties
{
    public abstract class PropertyJsonSerializedObject<T> : PropertyLongString where T : class
    {
        protected T? _value;

        public override Type PropertyValueType => typeof(T);

        public override object? Value
        {
            get
            {
                if (_value != null) return _value;

                var str = base.Value as string;
                if (str == null) return default(T);

                try
                {
                    _value = JsonConvert.DeserializeObject<T>(str);
                }
                catch (Exception)
                {
                    _value = default;
                }

                return _value;
            }
            set
            {
                if (value is T)
                {
                    _value = default;

                    try
                    {
                        base.Value = JsonConvert.SerializeObject(value);
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
    }
}