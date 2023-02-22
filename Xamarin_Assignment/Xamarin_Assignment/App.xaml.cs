using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Assignment.Services;
using Xamarin_Assignment.Views;

namespace Xamarin_Assignment
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Layout_3();
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
