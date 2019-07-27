using App1_ConsultarCep.Servico;
using App1_ConsultarCep.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1_ConsultarCep
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;

        }

        private void BuscarCEP(object sender, EventArgs args)//Metodo tem q receber estes dois parametros
        {
            string cep = CEP.Text.Trim();

            if (isValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereco: {0}, {1}, {2}, {3}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "Endereço nao localizado para o CEP informado: " + CEP, "OK");
                    }
                }catch(Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }

          
            
        }
    
        private bool isValidCep(string cep)
        {
            bool valido = true;

            if(cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP INVÁLIDO! O cep deve conter 8 caractéres.", "OK");
                valido = false;
            }
            int novoCEP = 0;
            if(!int.TryParse(cep, out novoCEP))
            {
                DisplayAlert("ERRO", "CEP INVÁLIDO! O cep deve ser composto apenas por números!", "OK");
                valido = false;
            }
            return true;
        }
        
    }
}
