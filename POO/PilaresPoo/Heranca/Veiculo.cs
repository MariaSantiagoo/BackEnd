using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }
        
        public void Acelerar()
        {
            Console.WriteLine($"Acelerando o veiculo...");
            
        }
    }
}