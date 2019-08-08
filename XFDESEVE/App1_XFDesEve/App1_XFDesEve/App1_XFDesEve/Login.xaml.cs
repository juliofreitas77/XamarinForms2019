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

            string matricula = matriculaEntry.Text.Trim();
            string email = emailEntry.Text.Trim();
            string senha = senhaEntry.Text.Trim();
            /*Para efeito de teste: 
             * matricula do admin: 1000
             * email: admin@everis.com
             * senha: 123456
             */
            if(matricula=="1000" && email== "admin@everis.com" && senha == "123456")
            {
                await atraso(5000);
                Application.Current.MainPage = new NavigationPage(new ListaDeEventosAdmin());
            }
            else
            {
                await DisplayAlert("Erro", "Login ou senha incorretos", "Ok");
                return;
            }

        }

        async Task atraso(int valor)
        {
            await Task.Delay(valor);
        }

    }
}