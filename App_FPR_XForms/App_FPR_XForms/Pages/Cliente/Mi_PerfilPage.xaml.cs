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
    public partial class Mi_PerfilPage : ContentPage
    {
        public Mi_PerfilPage()
        {
            InitializeComponent();

            

        }

        private async void Button_Edit_Info(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Edit_PerfilPage());
        }
    }
}