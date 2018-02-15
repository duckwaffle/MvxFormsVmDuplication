using MvvmCross.Forms.Views.Attributes;
using Xamarin.Forms.Xaml;

namespace MvxFormsVmDuplication.UI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(NoHistory = true, WrapInNavigationPage = true)]
	public partial class HomePage
    {
		public HomePage()
		{
			InitializeComponent();
		}
	}
}