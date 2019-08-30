using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public bool Admin { get; set; }

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

            int Matricula = Convert.ToInt32(matriculaEntry.Text.Trim());
            string Email = emailEntry.Text.Trim();
            string Senha = senhaEntry.Text.Trim();


            /*Para efeito de teste: 
             * matricula do admin: 1000
             * email: admin@everis.com
             * senha: 123456
             */

            if (Matricula == 1000 && Email == "admin@everis.com" && Senha == "123456")
            {
                this.Admin = true;
                await atraso(1000);
                Application.Current.MainPage = new NavigationPage(new ListaDeEventosAdmin(this.Admin));
            }
            else if (Matricula == 2000 && Email == "user@everis.com" && Senha == "everis")
            {
                this.Admin = false;
                await atraso(2000);
                Application.Current.MainPage = new NavigationPage(new ListaDeEventosAdmin(this.Admin));
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