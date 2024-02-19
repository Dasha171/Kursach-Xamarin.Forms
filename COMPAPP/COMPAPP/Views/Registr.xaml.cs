using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerApp;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COMPAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registr : ContentPage
    {
        public Registr()
        {
            InitializeComponent();
        }
        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<User>();
            var item = new User()
            {
                Username = UsernameEntry.Text,
                Password = PasswordEntry.Text
            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Регистрация", "Вы зарегистрировались, перейти ко входу?", "Да", "Назад");
                if (result)
                    await Navigation.PushAsync(new Avtorization());
            }
                );
        }
    }
}