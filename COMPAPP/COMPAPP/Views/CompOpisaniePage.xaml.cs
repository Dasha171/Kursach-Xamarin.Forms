using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using COMPAPP.Models;

namespace COMPAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompOpisaniePage : ContentPage
    {
        private ComputerBuildDatabase _database;

        public CompOpisaniePage(ComputerBuild selectedBuild)
        {
            InitializeComponent();
            _database = new ComputerBuildDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "builds.db"));

            if (selectedBuild != null)
            {
                Debug.WriteLine($"ProductName: {selectedBuild.ProductName}, Description: {selectedBuild.Description}");

                BindingContext = selectedBuild;
            }
        }
    }

}