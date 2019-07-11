using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CFApp.Models;

namespace CFApp.Service
{
    public class MedicoService
    {
        string url = "https://localhost:44315/api/Postos";
        HttpClient client = new HttpClient();
        public async Task<List<Medico>> GetMedicoAsync()
        {
            var response = await client.GetStringAsync(url);
            var medicos = JsonConvert.DeserializeObject<List<Medico>>(response);
            return medicos;

        }
    }
}
