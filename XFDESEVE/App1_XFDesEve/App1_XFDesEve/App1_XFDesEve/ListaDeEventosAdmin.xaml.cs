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
        public ListaDeEventosAdmin()
        {
            InitializeComponent();

            List<Evento> listaEventos = new List<Evento>();
            listaEventos.Add(new Evento { NomeEvento = "Cobol Day", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture)});
            listaEventos.Add(new Evento { NomeEvento = "Material Design Day", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture) });
            listaEventos.Add(new Evento { NomeEvento = "Java for Beginners", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture) });
            listaEventos.Add(new Evento { NomeEvento = "Best Pratice DAy", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture) });
            listaEventos.Add(new Evento { NomeEvento = ".NET Core Day", LocalEvento = "Uberlândia", DataEvento = DateTime.Parse("01/01/2019", CultureInfo.InvariantCulture) });

            ListaEventos.ItemsSource = listaEventos;
        }

        private void BtnNovoEvento(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroDeEvento());
        }

        private async void ListaEventos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var evento = e.Item as Evento;
          

            if(e.Item == null)
            {
                return;
            }
            var eventoTapped = (Evento)e.Item;
            await Navigation.PushAsync(new InscricaoPage(e.Item));//passando o Evento como argumento para a pagina de incrição
            await DisplayAlert("Evento", "Evento " + evento.NomeEvento.ToUpper() + " selecionado", "Ok");
            
        }
    }
}