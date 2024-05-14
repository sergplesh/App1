using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            MainPage = new NavigationPage(new MainPage()); // Устанавливает MainPage в качестве первой страницы для навигации
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
