using System;
using System.Collections.Generic;
using System.Linq;
using EPiServer.Cms.Shell.UI.ObjectEditing;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using Geta.Optimizely.HotspotsEditor.Cms.Attributes;
using Geta.Optimizely.HotspotsEditor.Cms.Models;

namespace Geta.Optimizely.HotspotsEditor.Cms.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(IEnumerable<HotSpotContainer>), UIHint = UIHint.HotspotsEditor)]
    public class HotspotsEditorDescriptor : EditorDescriptor
    {
        private readonly AllowedTypesMetadataExtender _allowedTypesMetadataExtender;

        public HotspotsEditorDescriptor(AllowedTypesMetadataExtender allowedTypesMetadataExtender)
        {
            ClientEditingClass = "hotspots/editors/HotspotsEditor";
            this._allowedTypesMetadataExtender = allowedTypesMetadataExtender;
        }

        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            if (attributes?.OfType<TypesAttribute>().FirstOrDefault() is TypesAttribute typesAttribute && metadata.Parent is ExtendedMetadata parent)
            {
                AllowedTypes = typesAttribute.AllowedTypes;
                AllowedTypesFormatSuffix = typesAttribute.TypesFormatSuffix;
            }

            if (attributes?.OfType<RootsAttribute>().FirstOrDefault() is RootsAttribute rootsAttribute)
            {
                metadata.EditorConfiguration["roots"] = rootsAttribute.Roots;
            }

            base.ModifyMetadata(metadata, attributes);
        }
    }
}