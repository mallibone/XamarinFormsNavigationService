using Xamarin.Forms;

namespace NavigationService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationService.Configure("MainPage", typeof(Views.MainPage));
            NavigationService.Configure("ModalNavigationPage", typeof(Views.ModalNavigationPage));
            NavigationService.Configure("PushNavigationPage", typeof(Views.PushNavigationPage));
            var mainPage = ((ViewNavigationService) NavigationService).SetRootPage("MainPage");

            MainPage = mainPage;
        }

        public static INavigationService NavigationService { get; } = new ViewNavigationService();

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
