using CFApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CFApp.Service
{
    public class ConsultaService
    {
        string url = "https://localhost:44315/api/Consulta";
        HttpClient client = new HttpClient();
        public async Task<List<Consulta>> GetConsultaAsync()
        {
            var response = await client.GetStringAsync(url);
            var consultas = JsonConvert.DeserializeObject<List<Consulta>>(response);
            return consultas;
        }
        public async Task AddConsultaAsync(Consulta consulta)
        {
            //string url = "http://www.macwebapi.somee.com/api/produtos/{0}";
            var uri = new Uri(string.Format(url, consulta.Id));
            var data = JsonConvert.SerializeObject(consulta);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await client.PostAsync(uri, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao incluir produto");
            }
        }
    }
}