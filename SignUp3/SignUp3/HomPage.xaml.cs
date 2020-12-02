using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SignUp3;

namespace XamlMobileAppProject 
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomPage : ContentPage
    {
        public HomPage()
        {
            InitializeComponent();
        }

        async void SaveBtn_Clicked(object sender, System.EventArgs e)
        {
            SQLiteDB sQLiteDB = new SQLiteDB()
            {
                Surname = SurNameEntry.Text,
                FirstName = FirstNameEntry.Text,
                MiddleName = MiddleNameEntry.Text,
                SID = SIDEntry.Text
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.PathFind))
            {
                conn.CreateTable<SQLiteDB>();
                int rowsAdded = conn.Insert(sQLiteDB);
                //conn.Dispose();

            }
            await DisplayAlert("Message", "Data Saved", "Ok");
        }
    
          

        private async void Preview_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OutputPage()));
        }
    }
}