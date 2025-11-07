using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public float Nota;

        public Aluno()
        {
            Console.WriteLine($"Aluno criado!");
            
        }

        public Aluno(string n, float No)
        {
            Nome = n;
            Nota = No;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"O nome do aluno é {Nome} e a nota é {Nota}");
            
        }
    }
}