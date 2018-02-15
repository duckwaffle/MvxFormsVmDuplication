using MvvmCross.Core.ViewModels;
using MvxFormsVmDuplication.Core.ViewModels;

namespace MvxFormsVmDuplication.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<HomeViewModel>();
        }
    }
}
