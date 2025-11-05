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

        //métodos

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");

        }
    }
}