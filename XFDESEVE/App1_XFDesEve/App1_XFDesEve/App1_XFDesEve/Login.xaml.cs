using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        public Login()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.IsBusy = false;

            BtnLogin.Clicked += BtnLogin_Clicked;
        }

        private async void BtnLogin_Clicked(object sender, EventArgs ars)
        {
            this.IsBusy = true;
            // implementar o codigo para validação de login
            await atraso(5000);
            Application.Current.MainPage = new NavigationPage(new ListaDeEventosAdmin());
        }

        async Task atraso(int valor)
        {
            await Task.Delay(valor);
        }

    }
}