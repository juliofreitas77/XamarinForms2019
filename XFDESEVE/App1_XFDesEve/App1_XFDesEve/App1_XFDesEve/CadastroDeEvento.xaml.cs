﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_XFDesEve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroDeEvento : ContentPage
    {
        public CadastroDeEvento()
        {
            InitializeComponent();
        }

        private void cancelarEvent(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaDeEventosAdmin());
        }
    }
}