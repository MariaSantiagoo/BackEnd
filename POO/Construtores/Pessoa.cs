using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{

    //Atributos

    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //Construtor
        public Pessoa()
        {
            Console.WriteLine($"Objeto Criado!");


        }
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;

        }

        public Pessoa(string n)
        {
            Nome = n;
        }

        public Pessoa (string n, int i, string xpto)
        {
            Nome = n;
            Idade = i;
             Console.WriteLine($"Seu texto é: {xpto}");
             
        }

        //métodos

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");

        }
    }
}