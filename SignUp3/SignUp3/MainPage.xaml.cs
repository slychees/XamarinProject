using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamlMobileAppProject;

namespace SignUp3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

        private async void LoginBtn_Clicked(object sender, EventArgs e) //Click button event//
        {
            if (string.IsNullOrEmpty(EntUserName.Text) || string.IsNullOrEmpty(EntPass.Text))
            {
                await DisplayAlert("Message", "Empty fields", "Ok");
            }
            else
            {

                await DisplayAlert("Message", $"Registered {EntUserName.Text}", "Ok");
                EntUserName.Text = string.Empty;
                EntPass.Text = string.Empty;


            }



            {
                await Navigation.PushModalAsync(new NavigationPage(new HomPage()));
            }

        }
        






        private async void SignUp_Clicked(object sender, EventArgs e)  //Sign Up click button event//
        {
            if (string.IsNullOrEmpty(NewEmail.Text) || string.IsNullOrEmpty(NewUser.Text) || string.IsNullOrEmpty(NewPass.Text) || string.IsNullOrEmpty(ConfirmPass.Text))
            {
                await DisplayAlert("Message", "Empty fields", "Ok");
            }
            else
            {
                if (ConfirmPass.Text != NewPass.Text)
                {
                    await DisplayAlert("Message", "Password does not match", "Ok");
                }
                else
                {
                    await DisplayAlert("Welcome", $"Registered {EntUserName.Text}", "Ok");
                    NewPass.Text = string.Empty;
                    NewEmail.Text = string.Empty;
                    NewUser.Text = string.Empty;
                    ConfirmPass.Text = string.Empty;
                }
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ResetPassword()));
        }
    }
}
