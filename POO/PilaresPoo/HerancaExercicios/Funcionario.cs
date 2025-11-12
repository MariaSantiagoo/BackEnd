using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaExercicios
{
    public class Funcionario
    {
        public string Nome;

        public float SalarioBase = 1500f;

        public void ExibirSalario()
        {
            Console.WriteLine($"O salário do {Nome} é: R${SalarioBase}");
        }
    }
}