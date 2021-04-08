using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsultaCep.Models.ViewModel
{
    public class EnderecoViewModel
    {
        HttpClient cliente = new HttpClient();

        public EnderecoViewModel()
        {
            cliente.BaseAddress = new Uri("https://viacep.com.br/ws/");

            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Endereco> GetAddressAsync(string cep)
        {
            string cepInformado = cep;
            HttpResponseMessage response = await cliente.GetAsync($"{cepInformado}/json/");
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                
                return JsonConvert.DeserializeObject<Endereco>(dados);
            }
            return new Endereco();
        }
    }
}
