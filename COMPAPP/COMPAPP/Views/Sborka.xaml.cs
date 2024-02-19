using COMPAPP.Models;
using COMPAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COMPAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sborka : ContentPage
{
        public Sborka(SborkaViewModel viewModel)
        {
            InitializeComponent();

            // для отображения данных
            var selectedItems = viewModel.SelectedItems;
            var selectedProduct = selectedItems.SelectedProduct;
            var selectedProductItem = selectedItems.SelectedProductItem;
            var selectedProductMater = selectedItems.SelectedProductMater;
            var selectedProductOperative = selectedItems.SelectedProductOperative;
            var selectedProductVideo = selectedItems.SelectedProductVideo;
            var selectedProductDisk = selectedItems.SelectedProductDisk;
            var selectedProductSsd = selectedItems.SelectedProductSsd;
            var selectedProductKorpus = selectedItems.SelectedProductKorpus;
            var selectedProductPitanie = selectedItems.SelectedProductPitanie;
            BindingContext = viewModel;

        }
    }

}