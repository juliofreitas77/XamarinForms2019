using App1_XFDesEve.Modelo;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Globalization;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaDeEventosAdmin : ContentPage
    {
        static List<Evento> eventos;
        bool admin = false;
       
        public ListaDeEventosAdmin(bool _admin)
        {
            eventos = new List<Evento>();
            InitializeComponent();
            eventos.Add(new Evento { NomeEvento = "Cobol Day", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture) });
            eventos.Add(new Evento { NomeEvento = "Material Design Day", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture) });
            this.BindingContext = this;
            this.admin = _admin;
            ListaEventos.ItemsSource = eventos;
        }

        public ListaDeEventosAdmin(Evento evento, bool _admin)
        {
            InitializeComponent();
            eventos.Add(evento);
            ListaEventos.ItemsSource = eventos;
            this.admin = _admin;
            this.BindingContext = this;
         }

        public ListaDeEventosAdmin()
        {
            InitializeComponent();
            ListaEventos.ItemsSource = eventos;
            this.BindingContext = this;
        }

        public void BtnNovoEvento(object sender, EventArgs args)
        {
            if (this.admin == true)
            {
                Navigation.PushAsync(new CadastroDeEvento(admin));
            }
            else
            {
                DisplayAlert("Aviso", "Ação permitida apenas para usuários com perfil de administrador!", "Cancelar");
            }

        }

        private async void ListaEventos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            var eventoTapped = (Evento)e.Item;
            await Navigation.PushAsync(new InscricaoPage(eventoTapped, this.admin));//passando o Evento como argumento para a pagina de incrição
        }
        
        private async void ListaEventos_Selected(Object sender, SelectedItemChangedEventArgs e)
        {
            var eventoTapped = (Evento)e.SelectedItem;
            await Navigation.PushAsync(new InscricaoPage(eventoTapped, this.admin));
        }
    }
}