using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace dstec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class calculajurosController : Controller
    {
        // GET: calculaJurosController
        [HttpGet]
        public string calculaJuros(double valorInicial,int tempo)
        {
            double taxa = 0.01;
            double temp = valorInicial * (1 + taxa);
            double valorFinal = (Math.Pow(temp, tempo))/100;
            valorFinal = Math.Truncate(valorFinal) / 100;
            return String.Format(CultureInfo.InvariantCulture, "{0:0.00}", valorFinal);
        }
    }
}
