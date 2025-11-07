using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public string Ano;

        public Carro(string ma, string m, string a)
        {
            Marca = ma;
            Modelo = m;
            Ano = a;

            Console.WriteLine($"A marca do seu carro é {Marca}, o é {Modelo} e o ano é {Ano}!");
            
        }
        

    }
}