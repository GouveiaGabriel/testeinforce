using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ObjetoRetorno
    {
        public decimal Value { get; set; }
        public decimal Cotacao { get; set; }

        public ObjetoRetorno(decimal value, decimal cotacao)
        {
            this.Value = value;
            this.Cotacao = cotacao;
        }
    }
}