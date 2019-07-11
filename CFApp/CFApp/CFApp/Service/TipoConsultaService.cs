using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CFApp.Service
{
    public class TipoConsultaService
    {
        string url = "https://localhost:44315/api/TipoConsulta";
        HttpClient client = new HttpClient();
        public async Task<List<TipoConsultaService>> GetTipoConsultasAsync()
        {

            var response = await client.GetStringAsync(url);
            var tipoConsultas = JsonConvert.DeserializeObject<List<TipoConsultaService>>(response);
            return tipoConsultas;

        }
    }
}
