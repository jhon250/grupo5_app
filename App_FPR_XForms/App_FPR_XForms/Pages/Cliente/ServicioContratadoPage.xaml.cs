using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_FPR_XForms.Pages.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicioContratadoPage : ContentPage
    {
        public ServicioContratadoPage()
        {
            InitializeComponent();
            // llamando a Image Mi Cuenta
            AgregarServicioContratar.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    agregar();
                })
            });

        }

        // campo Mi cuenta
        private async void agregar()
        {
            //  navegando a ventana de inicio del MiCuentaAlumnoPage
            await Navigation.PushAsync(new DetailPage());
        }
    }
}