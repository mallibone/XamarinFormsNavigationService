using System;
using Xamarin.Forms;

namespace NavigationService.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly INavigationService _navigationService;
        private readonly int _depth;

        public MainPage()
        {
            InitializeComponent();
            _navigationService = App.NavigationService;
        }

        private async void ModalNavigationOnClicked(object sender, EventArgs e)
        {
            await _navigationService.NavigateModalAsync(nameof(ModalNavigationPage), "root page misses you");
        }

        private async void PushNavigationOnClicked(object sender, EventArgs e)
        {
            await _navigationService.NavigateAsync(nameof(PushNavigationPage), "root page misses you");
        }

        private void NavigateBackOnClicked(object sender, EventArgs e)
        {
            _navigationService.GoBack();
        }
    }
}
