using System.Web.Hosting;
using EPiServer.Framework.TypeScanner;
using EPiServer.Shell.Modules;

namespace Geta.EPi.HotspotsEditor
{
    public class HotspotsCmsModule : ShellModule
    {
        public HotspotsCmsModule(string name, string routeBasePath, string resourceBasePath) : base(name, routeBasePath, resourceBasePath)
        {
        }

        public HotspotsCmsModule(string name, string routeBasePath, string resourceBasePath, ITypeScannerLookup typeScannerLookup, VirtualPathProvider virtualPathProvider) : base(name, routeBasePath, resourceBasePath, typeScannerLookup, virtualPathProvider)
        {
        }
    }
}