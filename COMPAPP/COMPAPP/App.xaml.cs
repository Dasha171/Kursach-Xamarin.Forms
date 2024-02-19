using COMPAPP.Services;
using COMPAPP.Views;
using System;
using Xamarin.Forms;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPAPP
{
    public partial class App : Application
    {

            public App()
            {
                InitializeComponent();

                DependencyService.Register<MockDataStore>();
               MainPage = new NavigationPage(new COMPAPP.Views.Avtorization());
            }

        private static ProductDatabase database;

        public static ProductDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProductDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "products.db3"));
                }
                return database;
            }
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
