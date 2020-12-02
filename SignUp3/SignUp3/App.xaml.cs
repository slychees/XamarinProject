using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamlMobileAppProject;

namespace SignUp3
{
    public partial class App : Application
    {
        public static string PathFind;
        public App()
        {
            InitializeComponent();

            MainPage = new HomPage();
        }
        public App(string pathFind)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            PathFind = pathFind;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
