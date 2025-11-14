using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class PagamentoPix : Pagamento
    {
        //desconto de 5%
        private float Desconto = 5;

        public float ValorCompra;

        public override float CalcularTotal()
        {
            float ValorDesconto = ValorCompra / 100 * Desconto;
            
            return ValorCompra = ValorCompra - ValorDesconto;
        }
    }
}