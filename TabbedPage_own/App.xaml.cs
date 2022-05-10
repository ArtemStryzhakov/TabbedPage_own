using System;
using TabbedPage_own.Services;
using TabbedPage_own.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage_own
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
