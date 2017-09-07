using System.Collections.Generic;
using EPiServer.PlugIn;
using Geta.EPi.HotspotsEditor.Cms.Models;

namespace Geta.EPi.HotspotsEditor.Cms.Properties
{
    [PropertyDefinitionTypePlugIn(Description = "A property for picking hotspots.", DisplayName = "Hotspot list")]
    public class PropertyHotspotContainerList : PropertyJsonSerializedObject<List<HotSpotContainer>>
    {
        
    }
}