using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        string Nome;

        float Preco;

        int Estoque;


        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.Clear();
            Console.WriteLine($"O produto é {Nome}, o preço é {Preco} e a quantidade em estoque é {Estoque}!");
            
        }

    }
}