using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using Geta.Optimizely.HotspotsEditor.Cms.Models;

namespace Geta.Optimizely.HotspotsEditor.Cms.EditorDescriptors
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