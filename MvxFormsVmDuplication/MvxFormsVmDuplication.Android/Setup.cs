using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform.Platform;
using MvxFormsVmDuplication.Core;

namespace MvxFormsVmDuplication.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IEnumerable<Assembly> GetViewAssemblies() => new List<Assembly>(base.GetViewAssemblies().Union(new[] { typeof(UI.FormsApp).GetTypeInfo().Assembly }));

        protected override IMvxApplication CreateApp() => new App();

        protected override MvxFormsApplication CreateFormsApplication() => new UI.FormsApp();

        protected override IMvxTrace CreateDebugTrace() => new DebugTrace();
    }
}