using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Http;
using Consumindo_Servicos_SOA_e_Rest.Model;

namespace Consumindo_Servicos_SOA_e_Rest.Service
{
    public class ServiceWS
    {
        private static string EnderecoBase = "http://ws.spacedu.com.br/xf2018/rest/api";
        public static Usuario GetUsuario(Usuario usuario)
        {
            var url = EnderecoBase + "/usuario";

            // StringContent param = new StringContent(string.Format("&nome={0}&password={1}", usuario.nome, usuario.password);
            FormUrlEncodedContent param = new FormUrlEncodedContent(new[]{
                    new KeyValuePair<string,string>("nome", usuario.nome),
                    new KeyValuePair<string,string>("password", usuario.password)
               });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(url, param).GetAwaiter().GetResult();

            if(resposta.StatusCode == HttpStatusCode.OK)
            {
                //TODO - Deserializar, retornar no met e salva como Login
            }
            return null;
        }
    }
}
