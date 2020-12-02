using SignUp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlMobileAppProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPassword : ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        
         void ResetPassword_Clicked(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }

        //private void ToolbarItem_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        //}

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }
    }
}