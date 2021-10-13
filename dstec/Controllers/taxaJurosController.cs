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
    public class TaxaJurosController : Controller
    {
        // GET: TaxaJurosController
        [HttpGet]
        public string taxaJuros()
        {
            double taxa = 0.01;
            return String.Format(CultureInfo.InvariantCulture, "{0:0.00}", taxa);
        }

        
    }
}
