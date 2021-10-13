using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dstec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class showmethecodeController : Controller
    {
        // GET: showmethecodeController
        [HttpGet]
        public string showmethecode()
        {
            String urlGit = "https://github.com/ManoelPjr/ds_tec";
            return urlGit;
        }
    }
}
