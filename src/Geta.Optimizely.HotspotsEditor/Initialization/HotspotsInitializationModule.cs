using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Initialization.Internal;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Modules;
using EPiServer.Shell.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Geta.Optimizely.HotspotsEditor.Initialization
{

    [ModuleDependency(typeof(InitializationModule))]
    [ModuleDependency(typeof(CmsRuntimeInitialization))]
    internal class HotspotsInitializationModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            var services = context.Services;

            services.Configure<ProtectedModuleOptions>(module =>
            {
                if (!module.Items.Any(i => i.Name.Equals(Constants.ModuleName, StringComparison.OrdinalIgnoreCase)))
                {
                    module.Items.Add(new ModuleDetails { Name = Constants.ModuleName });
                }
            });
        }

        public void Initialize(InitializationEngine context)
        {
            // No logic needed inside Initialize
        }

        public void Uninitialize(InitializationEngine context)
        {
            // No logic needed inside Uninitialize
        }
    }
}
