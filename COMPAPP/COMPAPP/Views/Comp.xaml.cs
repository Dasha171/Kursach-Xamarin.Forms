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
using SQLite;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using COMPAPP.Models;
using System.IO;
using Button = Xamarin.Forms.Button;


namespace COMPAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Comp : ContentPage
	{
        private ComputerBuildDatabase _database;

        public ObservableCollection<ComputerBuild> Builds { get; set; }

        public Comp ()
		{
			InitializeComponent ();
            _database = new ComputerBuildDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "builds.db"));//builds.db3
            Builds = new ObservableCollection<ComputerBuild>(_database.GetComputerBuilds());
/*            BuildsCollectionView.ItemsSource = Builds;*/
            BindingContext = this;
            var newBuild1 = new ComputerBuild { ImageURL = "edelcomp.png", ProductName = "EDELWEISS CAPTAIN", Description = "Процессор: Intel Core i3-10100F 3600 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE GT 1030 2Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte H410M\n\nОхлаждение: AMD Original TM\n\nЖесткий диск: 500Gb\n", Price = "51 000 ₽" };
            var newBuild2 = new ComputerBuild { ImageURL = "edelhuntcomp.png", ProductName = "EDELWEISS HUNTER", Description = "Процессор: AMD Ryzen 5 3600 3600 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE GT 1030 2Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: MS-Challenger A520M\n\nОхлаждение: AMD Original TM\n\nЖесткий диск: 500Gb\n", Price = "49 100 ₽" };
            var newBuild3 = new ComputerBuild { ImageURL = "edelcyborgcomp.png", ProductName = "EDELWEISS CYBORG", Description = "Процессор: Intel Core i3-10100F 3600 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE GTX 1650 4Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte H410M\n\nОхлаждение: Intel Box\n\nЖесткий диск: 1Тб", Price = "57 900 ₽" };
            var newBuild4 = new ComputerBuild { ImageURL = "edelvortcomp.png", ProductName = "EDELWEISS VORTEX", Description = "Процессор: AMD Ryzen 5 3600 3600 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE GTX 1650 4Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: MS-Challenger A520M\n\nОхлаждение: AMD Original TM\n\nЖесткий диск: 1Тб", Price = "63 600 ₽" };
            var newBuild5 = new ComputerBuild { ImageURL = "edelstormcomp.png", ProductName = "EDELWEISS STORM", Description = "Процессор: AMD Ryzen 5 3600 3600 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE GTX 1660 SUPER 6Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte A520M\n\nОхлаждение: AMD Original TM\n\nЖесткий диск: 1Тб", Price= "65 700 ₽" };
            var newBuild6 = new ComputerBuild { ImageURL = "edelvilicomp.png", ProductName = "EDELWEISS VILLAIN", Description = "Процессор: Intel Core i5-10400F 2900 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE GTX 1650 4Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte H410M\n✔️Охлаждение: DeepCool Mini\n\nЖесткий диск: 1Тб", Price= "70 800 ₽" };
            var newBuild7 = new ComputerBuild { ImageURL = "vampirinc.png", ProductName = "EDELWEISS CRUSADER", Description = "Процессор: Intel Core i5-10400F 2900 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE RTX 3050 8 Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte H410M\n\nОхлаждение: Deepcool GAMMAXX 300 R\n\nЖесткий диск: 1Тб", Price = "89 460 ₽" };
            var newBuild8 = new ComputerBuild { ImageURL = "edelcentcomp.png", ProductName = "EDELWEISS CENTURION", Description = "Процессор: Intel Core i3-13100F 3300 МГц\n\nСистема: Windows 10\n\nВидео-карта: PALIT NVIDIA GЕFORCE RTX 4060 8Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte B760 DS3H D4\n\nОхлаждение: ID-COOLING SE-224-RGB\n\nЖесткий диск: 1Тб", Price = "103 980 ₽" };
            var newBuild9 = new ComputerBuild { ImageURL = "edelcscomp.png", ProductName = "EDELWEISS CS:GO", Description = "Процессор: Intel Core i5-12400F 2500 МГц\n\nСистема: Windows 10\n\nВидео-карта: NVIDIA GЕFORCE RTX 4060 TI 8Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: ASUS PRIME H610M-K D4\n\nОхлаждение: ID-COOLING SE-224-RGB\n\nЖесткий диск: 1Тб", Price = "129 170 ₽" };
            var newBuild10 = new ComputerBuild { ImageURL = "edelerscomp.png", ProductName = "EDELWEISS BERSERK", Description = "Процессор: Intel Core i5-12600KF 3700 МГц\n\nСистема: Windows 10\n\nВидео-карта: PALIT NVIDIA GЕFORCE RTX 4060 8Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: ASUS PRIME H610M-K D4\n\nОхлаждение: ID-COOLING SE-224-RGB\n\nЖесткий диск: 1Тб", Price = "132 930 ₽" };
            var newBuild11 = new ComputerBuild { ImageURL = "edelzverocomp.png", ProductName = "EDELWEISS ZVEROBOY", Description = "Процессор: Intel Core i7-13700F 3200 МГц\n\nСистема: Windows 10\n\nВидео-карта: NVIDIA GЕFORCE RTX 4060 TI 8Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte B760 DS3H D4\n\nОхлаждение: ID-COOLING SE-224-RGB\n\nЖесткий диск: 2Тб", Price = "155 080 ₽" };
            var newBuild12 = new ComputerBuild { ImageURL = "edelraptorcomp.png", ProductName = "EDELWEISS RAPTOR", Description = "Процессор: Intel Core i7-12600KF 3700 МГц\n\nСистема: Windows 10\n\nВидео-карта: NVIDIA GЕFORCE RTX 4060 TI 8Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: ASUS B660M-K PRIME\n\nОхлаждение: ID COOLING SE-226-XT\n\nЖесткий диск: 2Тб", Price = "157 700 ₽" };
            var newBuild13 = new ComputerBuild { ImageURL = "edeltemcomp.png", ProductName = "EDELWEISS TERMINATOR", Description = "Процессор: Intel Core i7-13600KF 3500 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE RTX 4070 Ti 12Гб\n\nОперативная память: 16Gb\n\nМатеринская плата: Gigabyte B660 HD3 D4\n\nОхлаждение: ID-COOLING SE-224-RGB\n\nЖесткий диск: 2Тб", Price = "219 140 ₽" };
            var newBuild14 = new ComputerBuild { ImageURL = "edelcoucomp.png", ProductName = "EDELWEISS COUGAR", Description = "Процессор: Intel Core i9-13900F 3000 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE RTX 4090 GAMING 16 Гб\n\nОперативная память: 32Gb\n\nМатеринская плата: Gigabyte B760 DS3H D5\n\nОхлаждение: ID-COOLING AURAFLOW X 360\n\nЖесткий диск: 4Тб", Price = "350 920 ₽" };
            var newBuild15 = new ComputerBuild { ImageURL = "edelluccomp.png", ProductName = "EDELWEISS LUCIFER", Description = "Процессор: Intel Core i9-13900KF 3200 МГц\n\nСистема: Windows 10\n\nВидео-карта: GEFORCE RTX 4080 GAMING 16 Гб\n\nОперативная память: 32Gb\n\nМатеринская плата: MSI PRO Z790-P DDR4 GAMING\n\nОхлаждение: ID-COOLING AURAFLOW X 360\n\nЖесткий диск: 6Тб", Price = "367 010 ₽" };

            // Добавление новых записей в базу данных
            _database.AddComputerBuild(newBuild1);
            _database.AddComputerBuild(newBuild2);
            _database.AddComputerBuild(newBuild3);
            _database.AddComputerBuild(newBuild4);
            _database.AddComputerBuild(newBuild5);
            _database.AddComputerBuild(newBuild6);
            _database.AddComputerBuild(newBuild7);
            _database.AddComputerBuild(newBuild8);
            _database.AddComputerBuild(newBuild9);
            _database.AddComputerBuild(newBuild10);
            _database.AddComputerBuild(newBuild11);
            _database.AddComputerBuild(newBuild12);
            _database.AddComputerBuild(newBuild13);
            _database.AddComputerBuild(newBuild14);
            _database.AddComputerBuild(newBuild15);

            // Обновление списка Builds
            Builds.Clear();
            Builds.Add(newBuild1);
            Builds.Add(newBuild2);
            Builds.Add(newBuild3);
            Builds.Add(newBuild4);
            Builds.Add(newBuild5);
            Builds.Add(newBuild6);
            Builds.Add(newBuild7);
            Builds.Add(newBuild8);
            Builds.Add(newBuild9);
            Builds.Add(newBuild10);
            Builds.Add(newBuild11);
            Builds.Add(newBuild12);
            Builds.Add(newBuild13);
            Builds.Add(newBuild14);
            Builds.Add(newBuild15);

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

        private async void OnViewClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is ComputerBuild selectedBuild)
            {
                await Navigation.PushAsync(new CompOpisaniePage(selectedBuild));
            }
        }


    }
}