using System;
using System.Collections.Generic;
using System.Text;

namespace Consumindo_Servicos_SOA_e_Rest.Model
{
    public class Mensagem
    {
        public int id { get; set; }
        public int id_chat { get; set; }
        public int id_usuario { get; set; }
        public string  mensagem { get; set; }
        public Usuario usuario { get; set; }



    }
}
