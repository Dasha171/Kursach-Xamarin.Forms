using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using System.Collections;
using Button = Xamarin.Forms.Button;
using SQLite;
using COMPAPP.ViewModels;
using COMPAPP.Models;

namespace COMPAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Game : ContentPage
	{
        public IList<Product> IList { get; set; }
        public IList<ProductItem> IList2 { get; set; }
        public IList<ProductMater> IList3 { get; set; }
        public IList<ProductOperative> IList4 { get; set; }
        public IList<ProductVideo> IList5 { get; set; }
        public IList<ProductDisk> IList6 { get; set; }
        public IList<ProductSsd> IList7 { get; set; }
        public IList<ProductKorpus> IList8 { get; set; }
        public IList<ProductPitanie> IList9 { get; set; }
        private SelectedItems selectedItems;

        public Game()
        {
            InitializeComponent();
            //
            IList = new List<Product> {
            new Product { ProductName = "Intel Core i3-12100F 3300 МГц", Description = "Количество ядер: 4\nОхлаждение подойдет: ID-COOLING SE", ImageURL = "intel3.jpg", Price = 9600 },
            new Product { ProductName = "Intel Core i5-11400F 2600 МГц", Description = "Количество ядер: 6\nОхлаждение подойдет: DEEPCOOL AK620", ImageURL = "intel5.jpg", Price = 13700 },
            new Product { ProductName = "Intel Core i7-12700KF 3600 МГц", Description = "Количество ядер: 12\nОхлаждение подойдет: PCCooler Paladin", ImageURL = "intel7.jpg", Price = 35300 },
            new Product { ProductName = "Intel Core i9-11900KF 3500 МГц", Description = "Количество ядер: 8\nОхлаждение подойдет: ID-COOLING SE", ImageURL = "intel9.jpg", Price = 34500 },
            new Product { ProductName = "AMD Ryzen 5 7600X 4700/5000 МГц", Description = "Количество ядер: 8\nОхлаждение подойдет: DEEPCOOL AK620", ImageURL = "amd5.png", Price = 25700 },
            new Product { ProductName = "AMD Ryzen 7 5800X 3900 МГц", Description = "Количество ядер: 8\nОхлаждение подойдет: Thermaltake TH360", ImageURL = "amd7.png", Price = 29500 },
            new Product { ProductName = "AMD Ryzen 9 5900X 3700 МГц", Description = "Количество ядер: 12\nОхлаждение подойдет: Corsair H150i", ImageURL = "amd9.png", Price = 39300 }
              };
            Colll.ItemsSource = IList;
            BindingContext = this;

            IList2 = new List<ProductItem>
            {
                new ProductItem { ProductName = "ID-COOLING AURAFLOW 120", Description = "Скорость вращения: 700 - 1800 об/мин\nУровень шума: 18 - 35.2 дБ", ImageURL = "id.png", Price = 5500 },
                new ProductItem { ProductName = "Gigabyte Aorus Liquid Cooler 360", Description = "Материал радиатора: алюминий\nВоздушный поток: 59.25", ImageURL = "gigabyte.png", Price = 23500 },
                new ProductItem { ProductName = "Thermaltake TH360 ARGB Sync", Description = "Материал радиатора: алюминий\nВоздушный поток: 59.28", ImageURL = "themb.png", Price = 14900 },
                new ProductItem { ProductName = "Corsair H150i PRO RGB", Description = "Скорость вращения: 700 - 1800 об/мин\nУровень шума: 18 - 35.2", ImageURL = "corsair.png", Price = 27500 },
                new ProductItem { ProductName = "PCCooler Paladin S9", Description = "Скорость вращения: 1600 об/мин\nУровень шума: 25", ImageURL = "pcc.png", Price = 7200 },
                new ProductItem { ProductName = "DEEPCOOL AK620 ZERO DARK", Description = "Скорость вращения: 1500 об/мин\nУровень шума: 24.3", ImageURL = "deepcool.png", Price = 8400 },
                new ProductItem { ProductName = "AMD Original TM", Description = "Высота: 80", ImageURL = "amdorig.png", Price = 900 },
                new ProductItem { ProductName = "ID-COOLING SE-224-RGB", Description = "Воздушный поток: 56.5 CFM\nТип подшипника: 2ч качения", ImageURL = "idcool.png", Price = 4100 }
            };
            Colll2.ItemsSource = IList2;
            BindingContext = this;

            IList3 = new List<ProductMater>
            {
                new ProductMater { ProductName = "Gigabyte A520M", Description = "Слоты памяти: 4\nСлоты расширения: PCI-E 3.0 x16, 2 x PCI-E x1,PCI-E M.2", ImageURL = "gigaMat.png", Price = 6900 },
                new ProductMater { ProductName = "Gigabyte B650M GAMING X AX", Description =  "Слоты памяти: 4\nСлоты расширения: 2 x PCI-E 4.0 x16, 3 x PCI-E x1,2 x PCI-E M.2", ImageURL = "xax.png", Price = 25200 },
                new ProductMater { ProductName = "Gigabyte Z690 Gaming X D4", Description =  "Слоты памяти: 4\nСлоты расширения: 3 x PCI-E M.2, 2 x PCI-E x1,PCI-E M.2", ImageURL = "d4.png", Price = 30000 },
                new ProductMater { ProductName = "Gigabyte X570 AORUS MASTER", Description =  "Слоты памяти: 4\nСлоты расширения: PCI-E 3.0 x16, 2 xPCI-E x1,PCI-E M.2", ImageURL = "strix.png" , Price = 50000},
                new ProductMater { ProductName = "ASUS TUF GAMING B650M", Description =  "Слоты памяти: 4\nСлоты расширения: PCI-E 3.0 x16, 2 x PCI-E x1,PCI-E M.2", ImageURL = "asusom.png", Price = 29500 },
                new ProductMater { ProductName = "ASUS PRIME X570-PRO", Description =  "Слоты памяти: 4\nСлоты расширения: 2 x PCI-E 4.0 x16,3 xPCI-E x1", ImageURL = "pro.png", Price = 33900 },
                new ProductMater { ProductName = "ASUS PRIME B450M", Description = "Слоты памяти: 2\nСлоты расширения: PCI-E 3.0 x16,2x PCI-E x1", ImageURL = "om.png", Price = 7600 },
                new ProductMater { ProductName = "ASUS PRIME H510M", Description = "Слоты памяти: 2\nСлоты расширения: PCI-E 3.0 x16,2 x PCI-E x1", ImageURL = "asusprime.png", Price = 11200 },
                new ProductMater { ProductName = "ASUS ROG MAXIMUS XII HERO (WI-FI)", Description =  "Слоты памяти: 4\nСлоты расширения: 3 xPCI-E 3.0 x16,3 x PCI-E x1", ImageURL = "maximum.png", Price = 52100 },
                new ProductMater { ProductName = "MSI MAG B550M BAZOOKA", Description =  "Слоты памяти: 4\nСлоты расширения: PCI-E 3.0 x16,2 x PCI-E x1,PCI-E M.2", ImageURL = "bazooka.png", Price = 13830 }
            };
            Colll3.ItemsSource = IList3;
            BindingContext = this;

            IList4 = new List<ProductOperative>
            {
                new ProductOperative { ProductName = "8 GB Gigabyte Aorus RGB 3200МГц", Description = "Частота: 3200МГц", ImageURL = "aur8gb.png", Price = 4900 },
                new ProductOperative { ProductName = "8Гб Kingston HyperX Fury 3000МГц", Description ="Частота: 3000МГц", ImageURL = "gbkin8.png", Price = 4400 },
                new ProductOperative { ProductName = "16Гб Kingston HyperX Fury RGB 3600МГц", Description = "Частота: 3600МГц", ImageURL = "king816.png", Price = 9800 },
                new ProductOperative { ProductName = "32ГБ Kingston HyperX Fury 3600МГц", Description = "Частота: 3600МГц", ImageURL = "king816.png", Price = 15800 },
                new ProductOperative { ProductName = "16 Гб G.Skill Trident Z5 6000МГц", Description = "Частота: 6000МГц", ImageURL = "gbkin16.png", Price = 10200 },
                new ProductOperative { ProductName = "8 Гб TOUGHRAM Z-ONE RGB 3600МГц", Description = "Частота: 3600МГц", ImageURL = "gbtou8.png", Price = 6200 },
                new ProductOperative { ProductName = "8Гб DDR4 R 3000 МГц", Description ="Частота: 3000МГц", ImageURL = "gbddr8.png", Price = 3300 },
                new ProductOperative { ProductName = "16Гб DDR5 VULCAN 5600 МГц", Description = "Частота: 5600МГц", ImageURL = "gbddr16.png", Price = 8900 }
            };
            Colll4.ItemsSource = IList4;
            BindingContext = this;

            IList5 = new List<ProductVideo>
            {
                new ProductVideo { ProductName = "GEFORCE GTX 1650 4Гб", Description = "Объем видеопамяти: 6144 Мб", ImageURL = "gEFORCEGTX16504.png", Price = 17700 },
                new ProductVideo { ProductName = "GEFORCE GTX 1660 SUPER 6Гб", Description = "Объем видеопамяти: 6144 Мб", ImageURL = "gEFORCEGTX1660SUPER6.png", Price = 20900 },
                new ProductVideo { ProductName = "GEFORCE RTX 3050 8 Гб", Description = "Объем видеопамяти: 8192 Мб", ImageURL = "gEFORCERTX30508.png", Price = 27500 },
                new ProductVideo { ProductName = "NVIDIA GEFORCE RTX 3060 8Гб", Description = "Объем видеопамяти: 12 Гб", ImageURL = "nVIDIAGEFORCERTX30608.png", Price = 32700 },
                new ProductVideo { ProductName = "PALIT GЕFORCE RTX 3060 TI 8Гб", Description = "Объем видеопамяти: 8 Гб", ImageURL = "nVIDIAGEFORCERTX30608.png", Price = 42700 },
                new ProductVideo { ProductName = "PALIT NVIDIA GЕFORCE RTX 4060 8Гб", Description = "Объем видеопамяти: 8 Гб", ImageURL = "paliiiiit.png", Price = 38900 },
                new ProductVideo { ProductName = "NVIDIA GЕFORCE RTX 4060 TI 8Гб", Description = "Объем видеопамяти: 8 Гб", ImageURL = "paliiiiit.png", Price = 53500 },
                new ProductVideo { ProductName = "NVIDIA GEFORCE RTX 4070 12Гб", Description = "Объем видеопамяти: 12 ГБ", ImageURL = "nvidgeg.png", Price = 78900 },
                 new ProductVideo { ProductName = "GIGABYTE GEFORCE RTX 4090 24 Гб", Description = "Объем видеопамяти: 24 Гб", ImageURL = "gIGABYTEGEFORCERTX409024.png", Price = 245900 },
                new ProductVideo { ProductName = "NVIDIA GЕFORCE RTX 4060 TI 8Гб", Description ="Объем видеопамяти: 8 ГБ", ImageURL = "paliiiiit.png", Price = 53500 },
                new ProductVideo { ProductName = "NVIDIA QUADRO T1000 4Гб", Description = "Объем видеопамяти: 4 Гб", ImageURL = "nVIDIAQUADROT10004.png", Price = 52500 },
                 new ProductVideo { ProductName = "NVIDIA QUADRO RTX A2000 6Гб", Description = "Объем видеопамяти: 6 Гб", ImageURL = "quadrok.png", Price = 77900 },
                 new ProductVideo { ProductName = "RADEON RX 7800 XT 16 Гб", Description ="Объем видеопамяти: 16 Гб", ImageURL = "rADEONRX7800XT16.png", Price = 89500 }
            };
            Colll5.ItemsSource = IList5;
            BindingContext = this;

            IList6 = new List<ProductDisk>
            {
                new ProductDisk { ProductName = "1 Тб Toshiba", Description = " ", ImageURL = "toshiba.png", Price = 5900 },
                new ProductDisk { ProductName = "1 Тб Western Digital Black", Description = " ", ImageURL = "westernDigitalBlack.png", Price = 9500 },
                new ProductDisk { ProductName = "2 Тб Toshiba", Description = " ", ImageURL = "toshiba.png" , Price = 8500},
                new ProductDisk { ProductName = "2 Тб Seagate", Description = " ", ImageURL = "Seagate.png", Price = 8500 },
                new ProductDisk { ProductName = "4 Тб WesternDigital Gold", Description = " ", ImageURL = "westernDigitalGold.png", Price = 28500 },
                new ProductDisk { ProductName = "10 Тб Seagate IRONWOLF", Description = " ", ImageURL = "seagateIRONWOLF.png", Price = 29700 }
            };
            Colll6.ItemsSource = IList6;
            BindingContext = this;

            IList7 = new List<ProductSsd>
            {
                new ProductSsd { ProductName = "250 Гб Samsung 970 EVO Plus", Description = " ", ImageURL = "samsung970EVOPlus.png", Price = 4900 },
                new ProductSsd { ProductName = "480 Гб Kingston", Description = " ", ImageURL = "king480.png", Price = 4700 },
                new ProductSsd { ProductName = "500Gb Samsung 980 Pro", Description = " ", ImageURL = "samsungpro500.png", Price = 9900 },
                new ProductSsd { ProductName = "1000 Гб Kingston M.2", Description = " ", ImageURL = "kingm2.png", Price = 9900 },
                new ProductSsd { ProductName = "1000 Гб Gigabyte Aorus M.2", Description = " ", ImageURL = "gigam2.png" , Price = 22500},
                new ProductSsd { ProductName = "2000 Гб Kingston M.2", Description = " ", ImageURL = "kingm2.png", Price = 11900 },
                new ProductSsd { ProductName = "2000 Гб Samsung 980 PRO М.2", Description = " ", ImageURL = "samsungpro500.png" , Price = 22900}
            };
            Colll7.ItemsSource = IList7;
            BindingContext = this;

            IList8 = new List<ProductKorpus>
            {
                new ProductKorpus { ProductName = "Zalman X3 White", Description = "Рекомендуемый блок питания: 750 Вт", ImageURL = "Zalmanx3.png", Price = 17000 },
                new ProductKorpus { ProductName = "Cooler Master MasterBox 5 Lite RGB", Description = "Рекомендуемый блок питания: 400 - 700 Вт ", ImageURL = "coolerMaster.png", Price = 16000 },
                new ProductKorpus { ProductName = "Cougar PANZER-G", Description = "13 500 ₽", ImageURL = "Рекомендуемый блок питания: 1200 Вт", Price = 13500 },
                new ProductKorpus { ProductName = "AeroCool Cylon Black", Description = "Рекомендуемый блок питания: 700 Вт", ImageURL = "areocool.png", Price = 5900 },
                new ProductKorpus { ProductName = "Deepcool Matrexx 50 ADD-RGB Black", Description = "Рекомендуемый блок питания: 650 Вт", ImageURL = "deepcoolMatrex.png", Price = 9900 },
                new ProductKorpus { ProductName = "Deepcool Matrexx 70 ADD-RGB 3F Black", Description ="Рекомендуемый блок питания: 600 Вт", ImageURL = "depcool70dd.png", Price = 13400 },
                new ProductKorpus { ProductName = "Deepcool Quadstellar Black", Description = "Рекомендуемый блок питания: 850-1200 Вт", ImageURL = "quadblack.png", Price = 43000 },
                new ProductKorpus { ProductName = "ASUS ROG Strix Helios RGB Black", Description ="Рекомендуемый блок питания: 850-1200 Вт", ImageURL = "asushelios.png", Price = 43000 },
                new ProductKorpus { ProductName = "ASUS ROG STRIX HYPERION RGB", Description = "Рекомендуемый блок питания: ", ImageURL = "asushyoer.png", Price = 53500 },
                new ProductKorpus { ProductName = "Corsair Carbide Series Spec-Delta RGB Black", Description = "Рекомендуемый блок питания: 750 Вт", ImageURL = "corsaircarbiba.png", Price = 9500 },
                new ProductKorpus { ProductName = "Corsair Carbide Spec-Omega RGB", Description ="Рекомендуемый блок питания: 750 Вт", ImageURL = "corsaisCarbibe.png", Price = 15000 },
                new ProductKorpus { ProductName = "Corsair Cristal 570X RGB", Description ="Рекомендуемый блок питания: 850 Вт", ImageURL = "corsaircrystal.png" , Price = 22000},
                new ProductKorpus { ProductName = "Thermaltake View 28", Description = "Рекомендуемый блок питания: 400 Вт", ImageURL = "themView.png", Price = 6900 },
                new ProductKorpus { ProductName = "MSI MAG VAMPIRIC 010", Description = "Рекомендуемый блок питания: 750 Вт", ImageURL = "vampirinc.png" , Price = 7300},
                new ProductKorpus { ProductName = "GIGABYTE AORUS C700P Glass", Description ="Рекомендуемый блок питания: 1200 Вт", ImageURL = "aourus.png", Price = 57700 },
                new ProductKorpus { ProductName = "Jonsbo TR03 Black", Description = "Рекомендуемый блок питания: 850 Вт", ImageURL = "msivv.png", Price = 29800 },
                new ProductKorpus { ProductName = "Jonsbo MOD5 Gray GAMING", Description = "Рекомендуемый блок питания: 850-1200 Вт", ImageURL = "josboo.png", Price = 43000 }

            };
            Colll8.ItemsSource = IList8;
            BindingContext = this;

            IList9 = new List<ProductPitanie>
            {
                new ProductPitanie { ProductName = "500W Zalman", Description = " ", ImageURL = "zalman500.png", Price = 4200 },
                new ProductPitanie { ProductName = "600W be quiet!", Description = " ", ImageURL = "be600.png", Price = 7300 },
                new ProductPitanie { ProductName = "600W Zalman", Description = " ", ImageURL = "zalman500.png", Price = 5200 },
                new ProductPitanie { ProductName = "700W Zalman", Description = " ", ImageURL = "zalman700.png", Price = 6500 },
                new ProductPitanie { ProductName = "750W Gigabyte GP-P750GM", Description = " ", ImageURL = "giga750.png", Price = 50660 },
                new ProductPitanie { ProductName = "1000W Gigabyte P1000GM", Description = " ", ImageURL = "giga1000.png" , Price = 20500},
                new ProductPitanie { ProductName = "1000W Zalman", Description = " ", ImageURL = "zalman1000.png", Price = 16200 }
            };
            Colll9.ItemsSource = IList9;
            BindingContext = this;
            selectedItems = new SelectedItems(); // Инициализация объекта для хранения выбранных элементов
            BindingContext = this;

            //
            ToolbarItem tb = new ToolbarItem
            {
                Text = "Авторизация",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "ava26.png"
                }
            };

            tb.Clicked += async (s, e) =>
            {
                bool result = await DisplayAlert("Авторизация", "Вы вошли ", "Выйти", "Назад");
                if (result)
                {
                    // Переход на страницу авторизации
                    await Navigation.PushAsync(new Avtorization());
                }
            };

            ToolbarItem tb1 = new ToolbarItem
            {
                Text = "Статьи",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1
            };
            ToolbarItem tb2 = new ToolbarItem
            {
                Text = "Поддержка",
                Order = ToolbarItemOrder.Secondary,
                Priority = 2
            };

            tb2.Clicked += async (s, e) =>
            {
                string telegramBotUsername = "@CompDasha_bot"; // Замените на имя пользователя вашего чат-бота
                string telegramUri = $"tg://resolve?domain={telegramBotUsername}";

                // Проверка наличия Telegram на устройстве
                bool isTelegramInstalled = await Launcher.CanOpenAsync(telegramUri);

                if (isTelegramInstalled)
                {
                    Device.OpenUri(new Uri(telegramUri));
                }
                else
                {

                    await DisplayAlert("Вы не установили телеграмм", "Установите Телеграмм", "Ок");
                }
            };
            ToolbarItem tb3 = new ToolbarItem
            {
                Text = "О компании",
                Order = ToolbarItemOrder.Secondary,
                Priority = 3
            };

            ToolbarItems.Add(tb);
            ToolbarItems.Add(tb1);
            ToolbarItems.Add(tb2);
            ToolbarItems.Add(tb3);
        }

        public void SearchButton(object s, TextChangedEventArgs e)
        {
            var result = IList.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll.ItemsSource = result;
            var result2 = IList2.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll2.ItemsSource = result2;
            var result3 = IList3.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll3.ItemsSource = result3;
            var result4 = IList4.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll4.ItemsSource = result4;
            var result5 = IList5.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll5.ItemsSource = result5;
            var result6 = IList6.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll6.ItemsSource = result6;
            var result7 = IList7.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll7.ItemsSource = result7;
            var result8 = IList8.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll8.ItemsSource = result8;
            var result9 = IList9.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Colll9.ItemsSource = result9;
        }

        private async void OnSelectButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is object selectedItem)
            {
                if (selectedItem is Product selectedProduct)
                {
                    selectedItems.SelectedProduct = selectedProduct;
                }
                else if (selectedItem is ProductItem selectedProductItem)
                {
                    selectedItems.SelectedProductItem = selectedProductItem;
                }
                else if (selectedItem is ProductMater selectedProductMater)
                {
                    selectedItems.SelectedProductMater = selectedProductMater;
                }
                else if (selectedItem is ProductOperative selectedProductOperative)
                {
                    selectedItems.SelectedProductOperative = selectedProductOperative;
                }
                else if (selectedItem is ProductVideo selectedProductVideo)
                {
                    selectedItems.SelectedProductVideo = selectedProductVideo;
                }
                else if (selectedItem is ProductDisk selectedProductDisk)
                {
                    selectedItems.SelectedProductDisk = selectedProductDisk;
                }
                else if (selectedItem is ProductSsd SelectedProductSsd)
                {
                    selectedItems.SelectedProductSsd = SelectedProductSsd;
                }
                else if (selectedItem is ProductKorpus selectedProductKorpus)
                {
                    selectedItems.SelectedProductKorpus = selectedProductKorpus;
                }
                else if (selectedItem is ProductPitanie selectedProductPitanie)
                {
                    selectedItems.SelectedProductPitanie = selectedProductPitanie;
                }

                // Переходим на страницу Sborka, передавая объект SelectedItems
                await Navigation.PushAsync(new Sborka(new SborkaViewModel { SelectedItems = selectedItems }));
            }
        }
    }

    

    public class Product 
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductItem
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductMater
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductOperative
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductVideo
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductDisk
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price
        {
            get; set;
        }
    }

    public class ProductSsd
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price
        {
            get; set;
        }
    }


    public class ProductKorpus
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price
        {
            get; set;
       }
    }
    public class ProductPitanie
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }         
        public decimal Price
        {
            get; set;
        }
    }



}