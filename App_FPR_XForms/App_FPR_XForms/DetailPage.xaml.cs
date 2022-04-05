using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_FPR_XForms.Pages.Servicios;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_FPR_XForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();

            // llamando a Servicio 1
            servicio_1.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Servicios_1();
                })
            });


            // llamando a Servicio 2
            servicio_2.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Servicios_2();
                })
            });

            // llamando a Servicio 3
            servicio_3.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Servicios_3();
                })
            });

            // llamando a Servicio 4
            servicio_4.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Servicios_4();
                })
            });

            // llamando a Servicio 5
            servicio_5.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Servicios_5();
                })
            });


            // llamando a Servicio 6
            servicio_6.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Servicios_6();
                })
            });


        }

        // ---------- Servicio 1 --------------------------------
        private async void Servicios_1()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new ServiciosPage());
        }


        // ---------- Servicio 2 --------------------------------
        private async void Servicios_2()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new ServiciosPage());
        }


        // ---------- Servicio 3 --------------------------------
        private async void Servicios_3()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new ServiciosPage());
        }


        // ---------- Servicio 4 --------------------------------
        private async void Servicios_4()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new ServiciosPage());
        }


        // ---------- Servicio 5 --------------------------------
        private async void Servicios_5()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new ServiciosPage());
        }


        // ---------- Servicio 6 --------------------------------
        private async void Servicios_6()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new ServiciosPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}