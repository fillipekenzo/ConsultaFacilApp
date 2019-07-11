using CFApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace CFApp.Service
{
    public class PostoService
    {
        string url = "https://localhost:44315/api/Postos";
        HttpClient client = new HttpClient();
        public async Task<List<Posto>> GetPostoAsync()
        {

            var response = await client.GetStringAsync(url);
            var postos = JsonConvert.DeserializeObject<List<Posto>>(response);
            return postos;

        }
    }
}
