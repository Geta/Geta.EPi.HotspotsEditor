# Geta.EPi.HotspotsEditor

![](http://tc.geta.no/app/rest/builds/buildType:(id:GetaPackages_EPiHotspotsEditor_00ci),branch:master/statusIcon)

**For ASP.NET 6+ and Episerver/Optimizely 12+ see: https://github.com/Geta/geta-optimizely-hotspotseditor**

An editor for image hotspots.

## Installation
Type the following into your package manager console.
```
Install-Package Geta.EPi.HotspotsEditor
```

## Configuration
Add a property an existing instance of `ImageData` or create a new one like the following.

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
The hotspot editor should now be visible on a tab named 'Hotspots' when editing 'All properties' on an image inside EPiServer edit mode.
The hotspot data saved during edit is then persisted into the property defined above.

## Changelog
[Changelog](CHANGELOG.md)
