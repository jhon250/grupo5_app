using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_FPR_XForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login_Page : ContentPage
    {
        public Login_Page()
        {
            InitializeComponent();


        }

        private async void Button_Entrar(object sender, EventArgs e)
        {


            if (usuarioGui.Text == "admi")
            {

                if (contraseñaGui.Text == "1234")
                {


                    // navegando a ventana de inicio
                    await Navigation.PushAsync(new Home_Page());


                    // limpiando contraseña
                    usuarioGui.Text = "";
                    contraseñaGui.Text = "";

                }

                else
                {
                    // mensaje de alerta de contraseña
                    _ = DisplayAlert("Usuario", "Contraseña incorrecta", "OK");
                }

            }

            else
            {
                // mensaje de alerta de Usuario
                _ = DisplayAlert("Usuario", "Usuario incorrecto", "OK");
            }



        }

    }
}