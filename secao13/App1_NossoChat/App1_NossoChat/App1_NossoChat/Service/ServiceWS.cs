using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Http;
using App1_NossoChat.Model;

namespace App1_NossoChat.Service
{
    public class ServiceWS
    {
        private static string EnderecoBase = "http://ws.spacedu.com.br/xf2018/rest/api";
        public static Usuario GetUsuario(Usuario usuario)
        {
            var URL = EnderecoBase + "/usuario";

            //MODO 1:
            //StringContent param = new StringContent(string.Format("?nome{0}&password={1}", usuario.nome, usuario.password));

            //MODO 2:
            FormUrlEncodedContent param = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string,string>("nome",usuario.nome),
                new KeyValuePair<string,string>("password",usuario.password),
            });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if(resposta.StatusCode == HttpStatusCode.OK)
            {
                //deserializar, retorna 
            }

            return null;
        }
    }
}
