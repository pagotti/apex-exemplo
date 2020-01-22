using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP
{
    class CEP
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public bool erro { get; set; }

        public static CEP Busca(string cep)
        {
            HttpClient client = new HttpClient();
            string resultado = client.GetStringAsync($"http://viacep.com.br/ws/{cep}/json/").Result;

            return JsonConvert.DeserializeObject<CEP>(resultado);

        }
    }
}
