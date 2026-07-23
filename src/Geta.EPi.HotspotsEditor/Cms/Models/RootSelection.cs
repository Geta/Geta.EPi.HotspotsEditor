using System;

namespace Geta.EPi.HotspotsEditor.Cms.Models
{
    [Flags]
    public enum RootSelection
    {
        None = 0,
        RootPage = 1,
        StartPage = 1 << 1,
        CommerceRootPage = 1 << 2,
        All = RootPage | StartPage | CommerceRootPage,
    }
}
