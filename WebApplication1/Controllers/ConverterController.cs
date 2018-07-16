using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("Converter")]
    public class ConverterController : ApiController
    {
        public ObjetoRetorno Get(string basex, string to, decimal value)
        {
            ValorMoeda valormoeda = ValorMoeda.GetByMoeda(basex, to);

            return new ObjetoRetorno(value * valormoeda.Valor, valormoeda.Valor); 
        }
    }
}
