using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SignUp3;

namespace XamlMobileAppProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutputPage : ContentPage
    {
        public OutputPage()
        {
            InitializeComponent();
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HomPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.PathFind))
            {
                conn.CreateTable<SQLiteDB>();
                var sQLiteDB = conn.Table<SQLiteDB>().ToList();
                contactListView.ItemsSource = sQLiteDB;
            }
        }
    }
}