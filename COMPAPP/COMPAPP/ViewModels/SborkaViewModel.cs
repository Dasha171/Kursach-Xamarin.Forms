using COMPAPP.Models;
using COMPAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace COMPAPP.ViewModels
{
    public class SborkaViewModel : INotifyPropertyChanged
    {
        private SelectedItems selectedItems;

        public SelectedItems SelectedItems
        {
            get => selectedItems;
            set
            {
                if (selectedItems != value)
                {
                    selectedItems = value;
                    OnPropertyChanged(nameof(SelectedItems));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public decimal TotalPrice
        {
            get
            {
                decimal productPrice = SelectedItems?.SelectedProduct?.Price ?? 0;
                decimal productItemPrice = SelectedItems?.SelectedProductItem?.Price ?? 0;
                decimal productMater = SelectedItems?.SelectedProductMater?.Price ?? 0;
                decimal productOperative = SelectedItems?.SelectedProductOperative?.Price ?? 0;
                decimal productVideo = SelectedItems?.SelectedProductVideo?.Price ?? 0;
                decimal productDisk = SelectedItems?.SelectedProductDisk?.Price ?? 0;
                decimal productSsd = SelectedItems?.SelectedProductSsd?.Price ?? 0;
                decimal productKorpus = SelectedItems?.SelectedProductKorpus?.Price ?? 0;
                decimal productPitanie = SelectedItems?.SelectedProductPitanie?.Price ?? 0;
                return productPrice + productItemPrice + productMater + productOperative + productVideo + productDisk + productSsd + productKorpus + productPitanie;
            }
        }
        // Методы для удаления товаров
        public ICommand RemoveSelectedProductCommand => new Command(RemoveSelectedProduct);
        public ICommand RemoveSelectedProductItemCommand => new Command(RemoveSelectedProductItem);
        public ICommand RemoveSelectedProductMaterCommand => new Command(RemoveSelectedProductMater);
        public ICommand RemoveSelectedProductOperativeCommand => new Command(RemoveSelectedProductOperative);
        public ICommand RemoveSelectedProductVideoCommand => new Command(RemoveSelectedProductVideo);
        public ICommand RemoveSelectedProductDiskCommand => new Command(RemoveSelectedProductDisk); 
        public ICommand RemoveSelectedProductSsdCommand => new Command(RemoveSelectedProductSsd);
        public ICommand RemoveSelectedProductKorpusCommand => new Command(RemoveSelectedProductKorpus);
        public ICommand RemoveSelectedProductPitanieCommand => new Command(RemoveSelectedProductPitanie);

        public void RemoveSelectedProduct()
        {
            SelectedItems.SelectedProduct = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductItem()
        {
            SelectedItems.SelectedProductItem = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductMater()
        {
            SelectedItems.SelectedProductMater = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductOperative()
        {
            SelectedItems.SelectedProductOperative = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductVideo()
        {
            SelectedItems.SelectedProductVideo = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductDisk()
        {
            SelectedItems.SelectedProductDisk = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductSsd()
        {
            SelectedItems.SelectedProductSsd = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductKorpus()
        {
            SelectedItems.SelectedProductKorpus = null;
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveSelectedProductPitanie()
        {
            SelectedItems.SelectedProductPitanie = null;
            OnPropertyChanged(nameof(TotalPrice));
        }
    }

}
