using COMPAPP;
using ComputerApp;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COMPAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Avtorization : ContentPage
    {
        public Avtorization()
        {
            InitializeComponent();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registr());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<User>().Where(u => u.Username.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();
            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new Page1());
                App.Current.MainPage = new AppShell();

            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed User and Password", "Yes", "Cancel");
                    if (result)
                        await Navigation.PushAsync(new Avtorization());
                    else
                    {
                        await Navigation.PushAsync(new Avtorization());
                    }
                }
               );
            }
        }
    }
}