using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



// Crie uma classe Produto com os atributos nome e preco.
// Crie um método AplicarDesconto(double percentual) que reduza o preço do produto com base no valor do desconto.
// Depois mostre o novo preço no console.

namespace ClassesEObjetos
{
    public class Produto
    {
        public string Nome;

        public Double Preco;

        public void AplicarDesconto(double Percentual)

        {
            if (Percentual > 0 && Percentual <= 50)
            {
                Double valorDesconto = Preco * (Percentual / 100);
                Preco -= valorDesconto;
                Console.WriteLine($"Desconto de {Percentual}% foi aplicado, o preço atual é R${Preco}");

            }
            else
             {
                Console.WriteLine($"Percentual de desconto Inválido");
                
            }
        }
    }
}