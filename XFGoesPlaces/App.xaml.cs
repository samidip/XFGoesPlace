using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFGoesPlaces
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PostsList();
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
