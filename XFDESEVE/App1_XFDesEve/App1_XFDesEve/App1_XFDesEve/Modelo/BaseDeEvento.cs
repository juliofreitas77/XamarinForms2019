using System;
using System.Collections.Generic;
using System.Text;

namespace App1_XFDesEve.Modelo
{
   
    public  class BaseDeEvento
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
