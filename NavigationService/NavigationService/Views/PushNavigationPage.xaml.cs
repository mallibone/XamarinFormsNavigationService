using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationService.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PushNavigationPage : ContentPage
    {
        public PushNavigationPage()
        {
            InitializeComponent();
        }

        public PushNavigationPage(string parameter) : this()
        {
            DisplayText.Text = $"Welcome, I received the following navigation parameter {parameter}";
        }

        private INavigationService NavigationService { get; } = App.NavigationService;

        private void ModalNavigationOnClicked(object sender, EventArgs e)
        {
            NavigationService.NavigateModalAsync(nameof(ModalNavigationPage), "root page misses you");
        }

        private void PushNavigationOnClicked(object sender, EventArgs e)
        {
            NavigationService.NavigateAsync(nameof(PushNavigationPage), "root page misses you");
        }
    }
}