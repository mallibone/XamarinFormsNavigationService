using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationService.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalNavigationPage : ContentPage
    {
        public ModalNavigationPage()
        {
            InitializeComponent();
        }

        public ModalNavigationPage(string navigationParameter) : this()
        {
            NavigationParameterLabel.Text = navigationParameter;
        }

        private INavigationService NavigationService { get; } = App.NavigationService;

        private void OnNavigateBack(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void OnPushNavigate(object sender, EventArgs e)
        {
            NavigationService.NavigateAsync(nameof(PushNavigationPage), "greetings from your modal parent");
        }
    }
}