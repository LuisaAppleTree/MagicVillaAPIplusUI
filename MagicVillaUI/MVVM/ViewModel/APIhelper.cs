using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace MagicVillaUI.MVVM.ViewModel
{
    public static class APIhelper
    {
        public static HttpClient APIcliente { get; set; } = new HttpClient();

        public static void InicializarCliente()
        {
            APIcliente = new HttpClient();
            APIcliente.BaseAddress = new Uri("https://localhost:7100/api/");
            APIcliente.DefaultRequestHeaders.Accept.Clear();
            APIcliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
