
using Prism.Unity;
using SMS.Presentation.Infrastructure;

namespace SMS.Presentation
{
    public partial class App
    {
        protected override UnityBootstrapper GetBootstrapper()
        {
            return new Bootstrapper();
        }
    }
}
