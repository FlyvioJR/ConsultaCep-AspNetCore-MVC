using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCep.Models
{
    public class Endereco
    {
        [JsonProperty("cep")]
        public string Cep { get; private set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; private set; }

        [JsonProperty("complemento")]
        public string Complemento { get; private set; }

        [JsonProperty("bairro")]
        public string Bairro { get; private set; }

        [JsonProperty("localidade")]
        public string Localidade { get; private set; }

        [JsonProperty("uf")]
        public string UF { get; private set; }

        [JsonProperty("ibge")]
        public string Populacao { get; private set; }

        [JsonProperty("ddd")]
        public string DDD { get; private set; }
    }
}
