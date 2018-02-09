using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvxFormsVmDuplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvxFormsVmDuplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();

            var childContentView = new ChildContentView();
            var vm = new ChildContentViewModel();
            childContentView.ViewModel = vm;
	        Content = childContentView;
            vm.SomeText = "This text is being set after construction";
        }
    }
}