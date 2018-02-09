using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;
using MvxFormsVmDuplication.ViewModels;

namespace MvxFormsVmDuplication
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<HomeViewModel>();
        }
    }
}
