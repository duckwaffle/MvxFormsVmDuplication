using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxFormsVmDuplication.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        private MvxAsyncCommand nextPageCommand;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public MvxAsyncCommand NextPageCommand =>
            nextPageCommand ?? (nextPageCommand = new MvxAsyncCommand(ExecuteNextPageCommand));

        private async Task ExecuteNextPageCommand()
        {
            await navigationService.Navigate<NextViewModel>();
        }
    }
}
