using App1_XFDesEve.Modelo;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscricaoPage : ContentPage
    {
        Evento _evento;
        public InscricaoPage(Evento evento, Boolean admin)
        {
            _evento = evento;
            this.BindingContext = evento;
            InitializeComponent();
        }

        private async void BtnInsc_Clicked(Object sender, EventArgs ars)
        {
            var Admin = false;
            await Navigation.PushAsync(new ListaDeEventosAdmin());
        }
    }
}