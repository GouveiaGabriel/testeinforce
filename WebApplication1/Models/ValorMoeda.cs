using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ValorMoeda
    {
        public decimal Valor { get; set; }
        public string MoedaOrigem { get; set; }
        public string MoedaConvertida { get; set; }

        public ValorMoeda(decimal valor, string moedaOrigem, string moedaConvertida)
        {
            this.Valor = valor;
            this.MoedaOrigem = moedaOrigem;
            this.MoedaConvertida = moedaConvertida;
        }
        
        public static ValorMoeda DolarToReal = new ValorMoeda((decimal)3.85, "USD", "BRL");
        public static ValorMoeda EuroToReal = new ValorMoeda((decimal)4.49, "EUR", "BRL");

        public static ValorMoeda RealToDolar = new ValorMoeda((decimal)0.38, "BRL", "USD");
        public static ValorMoeda EuroToDolar = new ValorMoeda((decimal)0.064, "EUR", "USD");

        public static ValorMoeda RealtoEuro = new ValorMoeda((decimal)0.44, "BRL", "EUR");
        public static ValorMoeda DolartoEuro = new ValorMoeda((decimal)0.64, "USD", "EUR");

        public static List<ValorMoeda> List()
        {
            return new List<ValorMoeda>
            {
                DolarToReal,
                EuroToReal,
                RealToDolar,
                EuroToDolar,
                RealtoEuro,
                DolartoEuro
            };
        }

        public static ValorMoeda GetByMoeda(string moedaOrigem, string moedaConverter)
        {
            return List().FirstOrDefault(x => x.MoedaOrigem == moedaOrigem && x.MoedaConvertida == moedaConverter);
        }
    }
}