using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrete
{
    public class Frete
    {
        public int cep { get; set; }
        public double peso { get; set; }

        private ICorreioService correioService;

        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
        }

        public double calcularFrete()
        {
            return correioService.CalculaFrete();
        }

        
    }
}
