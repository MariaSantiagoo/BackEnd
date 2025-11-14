using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Pessoa
    {
                public string Nome;

        public int Idade;

        public void ExibirDados()
        {
            Console.WriteLine($"O nome da pessoa é {Nome} e a idade é {Idade} anos");

        }
    }
}