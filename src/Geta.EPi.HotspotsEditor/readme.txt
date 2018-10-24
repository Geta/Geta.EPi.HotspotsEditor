Geta.EPi.HotspotsEditor
---

1. Add a property on an existing instance of `ImageData` or create a new one like the following.

```
using Geta.EPi.HotspotsEditor.Cms.Models;
using Geta.EPi.HotspotsEditor.Cms.Properties;

[ContentType(GUID = "d28c84b4-c4bd-40e7-b5b2-9c0cf79dd9c5")]
[MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
public class ImageFile : ImageData
{
    [Display(
        Name = "Hotspot configuration",
        Description = "Hotspot editor",
        GroupName = "Hotspots"
    )]
    [UIHint(Geta.EPi.HotspotsEditor.Cms.UIHint.HotspotsEditor)]
    [BackingType(typeof(PropertyHotspotContainerList))]
    public virtual IEnumerable<HotSpotContainer> HotSpots { get; set; }
}
```

2. The hotspot editor should now be visible on a tab named 'Hotspots' when editing 'All properties' on an image inside EPiServer edit mode.
3. The hotspot data saved during edit is then persisted into the property defined above.