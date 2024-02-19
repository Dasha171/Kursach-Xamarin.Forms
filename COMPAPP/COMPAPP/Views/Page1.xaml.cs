using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace COMPAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
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
        private async void GameClick1(object sender, EventArgs e)
        {
            await DisplayAlert("Рекомендованная сборка", "✔️Процессор: AMD Ryzen 5 5600X\n✔️Система: Windows 10\n✔️Видео-карта: GEFORCE RTX 3050\n✔️Оперативная память: 16Gb\n", "Ок");
        }
        private async void GameClick2(object sender, EventArgs e)
        {
            await DisplayAlert("Рекомендованная сборка", "✔️Процессор: Intel Core i5-12400F 2500X\n✔️Система: Windows 10\n✔️Видео-карта: NVIDIA GEFORCE RTX 3060\n✔️Оперативная память: 16Gb\n", "Ок");
        }
        private async void GameClick3(object sender, EventArgs e)
        {
            await DisplayAlert("Рекомендованная сборка", "✔️Процессор: Intel Core i5-12400F\n✔️Система: Windows 10\n✔️Видео-карта: GEFORCE GTX 1660 SUPER\n✔️Оперативная память: 8Gb\n", "Ок");
        }
        private async void GameClick4(object sender, EventArgs e)
        {
            await DisplayAlert("Рекомендованная сборка", "✔️Процессор: Intel Core i7-10700F\n✔️Система: Windows 10\n✔️Видео-карта: GEFORCE RTX 3050\n✔️Оперативная память: 16Gb\n", "Ок");
        }
        private async void GameClick5(object sender, EventArgs e)
        {
            await DisplayAlert("Рекомендованная сборка", "✔️Процессор: Intel Core i7-13700KF\n✔️Система: Windows 10\n✔️Видео-карта: NVIDIA GЕFORCE RTX 4060\n✔️Оперативная память: 16Gb\n", "Ок");
        }
        private async void GameClick6(object sender, EventArgs e)
        {
            await DisplayAlert("Рекомендованная сборка", "✔️Процессор: Intel Core i9-13900KF 3200 МГц\n✔️Система: Windows 10\n✔️Видео-карта: PALIT RTX 4080 GAMING PRO 16 Гб\n✔️Оперативная память: 32Gb\n", "Ок");
        }

        public async void CheckNov1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game());
        }
    }
}