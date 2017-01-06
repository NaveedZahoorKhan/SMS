using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Regions;
using Prism.Unity;

namespace SMS.Presentation.Infrastructure
{
    public class Bootstrapper : UnityBootstrapper
    {
        ShellPresenter _shellPresenter;
        private readonly Helpers _helpers = new Helpers();

        //Here to implement
        //IEnumerable<DefaultView> _defaultViews;
        //AccessRightsService _accessRightsService;

        protected override DependencyObject CreateShell()
        {
            _shellPresenter = Container.Resolve<ShellPresenter>();
            _shellPresenter.Execute();
            return _shellPresenter.View;
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //Register types
            //Container.RegisterType<IGenericRepository, GenericRepository>().

        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var mappings = base.ConfigureRegionAdapterMappings();
            if (mappings != null)
            {
                /*mappings.RegisterMapping(typeof(BarManager), Container.Resolve<BarManagerRegionAdapter>());
                mappings.RegisterMapping(typeof(RibbonControl), Container.Resolve<RibbonRegionAdapter>());
                mappings.RegisterMapping(typeof(LayoutPanel), Container.Resolve<LayoutPanelAdapter>());
                mappings.RegisterMapping(typeof(DocumentGroup), Container.Resolve<DocumentGroupAdapter>());
                mappings.RegisterMapping(typeof(LayoutControl), Container.Resolve<LayoutControlAdapter>());
                mappings.RegisterMapping(typeof(Grid), Container.Resolve<WindowHelperAdapter>());*/
            }
            return mappings;
        }

        protected override void ConfigureModuleCatalog()
        {

        }

        protected override void InitializeModules()
        {
            /* To include another modules here */

        }

    }


}
