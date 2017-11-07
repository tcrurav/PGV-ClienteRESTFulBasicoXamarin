using ClienteAPIXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAPIXamarin
{
    class ServicioDeDatos
    {
        HttpClient client = new HttpClient();

        public ServicioDeDatos()
        {

        }

        public async Task<List<Ciclo>> GetCiclosAsync()
        {
            var response = await client.GetStringAsync("http://192.168.1.178:8080/Alumnado/webresources/ciclo");
            var ciclos = JsonConvert.DeserializeObject<List<Ciclo>>(response);
            return ciclos;
        }


    }
}
