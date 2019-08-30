using App1_XFDesEve.Modelo;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroDeEvento : ContentPage
    {
        Evento evento = new Evento();
        bool admin = true;

        public CadastroDeEvento()
        {
            this.BindingContext = this;
            InitializeComponent();
        }

        public CadastroDeEvento(bool _admin)
        {
            this.BindingContext = this;
            InitializeComponent();
            this.admin = _admin;
        }

        private async void cancelarEvent(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaDeEventosAdmin(this.admin));
        }

        private async void clicked_cadastrar(object sender, EventArgs e)
        {

            string nome = eventName.Text.Trim();
            string local = eventLocal.Text.Trim();
            string data = eventData.Text.Trim();
            string hora = eventHorario.Text.Trim();

            evento.NomeEvento = nome;
            evento.LocalEvento = local;
            evento.DataEvento = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (evento.NomeEvento != null && evento.LocalEvento != null && evento.DataEvento != null)
            {
                await Navigation.PushAsync(new ListaDeEventosAdmin(evento, this.admin));
            }
            else
            {
                return;
            }
        }
    }
}