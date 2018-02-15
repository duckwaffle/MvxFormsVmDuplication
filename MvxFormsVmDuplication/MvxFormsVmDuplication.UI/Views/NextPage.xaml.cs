using MvvmCross.Forms.Views.Attributes;
using Xamarin.Forms.Xaml;

namespace MvxFormsVmDuplication.UI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
	public partial class NextPage
    {
		public NextPage()
		{
			InitializeComponent();
		}
	}
}