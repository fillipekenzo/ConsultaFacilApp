using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CFApp.Service
{
    public class ConsultaService
    {
        
        private readonly HttpClient _client;
        public ConsultaService()
        {
            var uri = "";
            _client = new HttpClient();
           
        }
        public async void CadastrarConsulta()
        {
            var response = await _client.GetAsync(uri);
        }

            


    }
}
