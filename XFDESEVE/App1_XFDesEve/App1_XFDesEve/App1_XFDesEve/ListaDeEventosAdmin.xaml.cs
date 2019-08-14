using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_XFDesEve.Modelo;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaDeEventosAdmin : ContentPage
    {
        static List<Evento> eventos = new List<Evento>();

        bool admin = false;
        public ListaDeEventosAdmin()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public ListaDeEventosAdmin(bool _admin)
        {
            this.admin = _admin;
            InitializeComponent();
            this.BindingContext = this;

        }

        public  ListaDeEventosAdmin(Evento evento, bool _admin)
        {
            InitializeComponent();
            eventos.Add(evento);
            ListaEventos.ItemsSource = eventos;
            this.admin = _admin;
            this.BindingContext = this;
        }

        public void BtnNovoEvento(object sender, EventArgs args)
        {
            if( this.admin == true)
            {
                Navigation.PushAsync(new CadastroDeEvento());
            }
            else
            {
                DisplayAlert("Aviso", "Ação permitida apenas para usuários com perfil de administrador!", "Cancelar");
            }
            
        }

        private async void ListaEventos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item == null)
            {
                return;
            }
            var eventoTapped = (Evento)e.Item;
            await Navigation.PushAsync(new InscricaoPage(eventoTapped));//passando o Evento como argumento para a pagina de incrição
         //   await DisplayAlert("Evento", "Evento " + evento.NomeEvento.ToUpper() + " selecionado", "Ok");
        }
            
        private async void ListaEventos_Selected(Object sender, SelectedItemChangedEventArgs e)
        {
            var eventoTapped = (Evento)e.SelectedItem;
            await Navigation.PushAsync(new InscricaoPage(eventoTapped));
        }
    }
}