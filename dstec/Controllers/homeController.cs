using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class homeController : Controller
    {
        // GET: taxaJuros
        [HttpGet("/taxaJuros")]
        public double taxaJuros()
        {
            double taxa = 1.00/100.00;
            return taxa;
        }

        // GET: calculaJuros
        [HttpGet("/calculaJuros")]
        public string calculaJuros(double valorInicial = 0.00, int tempo = 0)
        {
            double taxa = taxaJuros();
            double montante = valorInicial * Math.Pow((1 + taxa), tempo);
            return string.Format(CultureInfo.InvariantCulture, "{0:0.00}", montante);
        }

        // GET: showmethecode
        [HttpGet("/showmethecode")]
        public string showmethecode()
        {
            String urlGit = "https://github.com/ManoelPjr/ds_tec";
            return urlGit;
        }


    }
}
