using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_FPR_XForms.Pages.Cliente;
using App_FPR_XForms.Pages.Profecionales;
using App_FPR_XForms.Pages;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_FPR_XForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        // ------------- Inicio -------------------------------------
        private async void Button_Inicio(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina DetailPage
            await App.MasterDet.Detail.Navigation.PushAsync(new DetailPage());

        }


        // ------------- Mi Perfil -------------------------------------
        private async void Button_Perfil(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina Mi_PerfilPage
            await App.MasterDet.Detail.Navigation.PushAsync(new Mi_PerfilPage());
        }


        // ------------- Servicios Contratados ------------------------------
        private async void Button_ServiContratado(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina de servicioContratadoPage
            await App.MasterDet.Detail.Navigation.PushAsync(new ServicioContratadoPage());
        }


        // ------------- Mis servicios -------------------------------------
        private async void Button_MisServicios(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina MisServiciosPage
            await App.MasterDet.Detail.Navigation.PushAsync(new MisServiciosPage());
        }


        // ------------- Crear servicio -------------------------------------
        private async void Button_CrearServicios(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina CrearServicioPage
            await App.MasterDet.Detail.Navigation.PushAsync(new CrearServicioPage());
        }


        // ------------- Configuraciones -------------------------------------
        private async void Configuracion(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina ConfiguracionPage
            await App.MasterDet.Detail.Navigation.PushAsync(new ConfiguracionPage());
        }


        // ------------- Acerca de nosotros -------------------------------------
        private async void Button_Acerca_nosotros(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina DetailPage
            await App.MasterDet.Detail.Navigation.PushAsync(new DetailPage());
        }


        // ------------- Cerrar sesion -------------------------------------
        private async void Button_CerrarSesion(object sender, EventArgs e)
        {
            // Borra el menu una ve que llame a este boton
            App.MasterDet.IsPresented = false;

            // Navegacion a la pagina Login_Page
            await App.MasterDet.Detail.Navigation.PushAsync(new Login_Page());
        }


    }
}