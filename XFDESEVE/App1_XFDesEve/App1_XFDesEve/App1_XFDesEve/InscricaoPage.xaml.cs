using App1_XFDesEve.Modelo;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscricaoPage : ContentPage
    {
        public InscricaoPage(Evento evento)
        {
            this.BindingContext = evento;
            InitializeComponent();
        }

        private async void BtnInsc_Clicked(Object sender, EventArgs ars)
        {
            await Navigation.PushAsync(new ListaDeEventosAdmin());
        }
    }
}