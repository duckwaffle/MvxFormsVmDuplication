using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Views;
using MvvmCross.Platform;

namespace MvxFormsVmDuplication.Droid
{
    [Activity(Label = "MvxFormsVmDuplication", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();
            InitializeForms(bundle);
        }
    }
}

