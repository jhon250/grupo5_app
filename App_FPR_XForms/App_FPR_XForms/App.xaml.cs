using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_FPR_XForms.Pages;

namespace App_FPR_XForms
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDet { get; set; }

        public App()
        {
            InitializeComponent();

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
