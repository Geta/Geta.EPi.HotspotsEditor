using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System.Collections.Generic;
using Geta.EPi.HotspotsEditor.Cms.Models;

namespace Geta.EPi.HotspotsEditor.Cms.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(IEnumerable<HotSpotContainer>), UIHint = UIHint.HotspotsEditor)]
    public class HotspotsEditorDescriptor : EditorDescriptor
    {
        public HotspotsEditorDescriptor()
        {
            ClientEditingClass = "hotspots/editors/HotspotsEditor";
        }
    }
}