using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //SI DESEAMOS NAVEGACION DEBEMOS LANZAR
            //UNA NUEVA NavigationPage
            //MainPage = new NavigationPage(new PaginaMenu());
            MainPage = new PaginaEstilos();
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
