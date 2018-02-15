using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Platform;
using MvvmCross.Forms.Uwp;
using MvvmCross.Platform.Logging;

namespace MvxFormsVmDuplication.UWP
{
    public class Setup : MvxFormsWindowsSetup
    {
        public Setup(Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame, e)
        {
        }

        protected override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.None;

        protected override IMvxLogProvider CreateLogProvider() => new VoidLogProvider();

        protected override IEnumerable<Assembly> GetViewAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies().Union(new[] { typeof(UI.FormsApp).GetTypeInfo().Assembly }));
        }

        protected override MvxFormsApplication CreateFormsApplication() => new UI.FormsApp();

        protected override IMvxApplication CreateApp() => new Core.App();
    }
}
