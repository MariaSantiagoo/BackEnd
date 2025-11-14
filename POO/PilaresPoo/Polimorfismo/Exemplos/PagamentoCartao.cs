using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class PagamentoCartao : Pagamento
    {

        private float Acrescimo = 5.38f;

        public float ValorCompra;

        public override float CalcularTotal()
        {
            float ValorAcrescimo = ValorCompra / 100 * Acrescimo;

            return ValorCompra = ValorCompra + ValorAcrescimo;
        }
    }
}