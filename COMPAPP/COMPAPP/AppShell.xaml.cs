using COMPAPP.ViewModels;
using COMPAPP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace COMPAPP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }



    }
}
