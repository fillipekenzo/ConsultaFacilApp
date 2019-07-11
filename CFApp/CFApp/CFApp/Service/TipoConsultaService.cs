using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CFApp.Service
{
    public class TipoConsulta
    {
        string url = "https://localhost:44315/api/TipoConsulta";
        HttpClient client = new HttpClient();
        public async Task<List<TipoConsulta>> GetTipoConsultasAsync()
        {

            var response = await client.GetStringAsync(url);
            var tipoConsultas = JsonConvert.DeserializeObject<List<TipoConsulta>>(response);
            return tipoConsultas;

        }
    }
}
