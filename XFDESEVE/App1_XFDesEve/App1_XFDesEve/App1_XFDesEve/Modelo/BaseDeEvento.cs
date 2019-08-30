using System.Collections.Generic;

namespace App1_XFDesEve.Modelo
{

    public class BaseDeEvento
    {
        static List<Evento> eventos;

        public List<Evento> AdicionaEventos(Evento evento)
        {
            eventos = new List<Evento>();
            eventos.Add(evento);
            return eventos;
        }
    }
}
