using COMPAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace COMPAPP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}