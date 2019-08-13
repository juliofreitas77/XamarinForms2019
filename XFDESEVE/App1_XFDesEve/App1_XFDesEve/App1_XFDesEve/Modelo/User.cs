using System;
using System.Collections.Generic;
using System.Text;

namespace App1_XFDesEve.Modelo
{
    public class User
    {
        public int Matricula { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        enum Perfil
        {
            Administrador,
            Operacional
        };
    }
}
