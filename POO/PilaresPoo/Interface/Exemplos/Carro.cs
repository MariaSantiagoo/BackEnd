using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Carro : IMotor
    {
        //Propriedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        //Construtores
        public Carro(string C, string M, string Md, int A)
        {
            Cor = C;
            Marca = M;
            Modelo = Md;
            Ano = A;
        }

        //Métodos
        public void ExibirInfo()
        {
            Console.WriteLine($@"
    Informações do Veículo:
            Cor: {Cor}
            Marca: {Marca}
            Modelo: {Modelo}
            Ano: {Ano} 
            ");

        }

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando... Vruum vruumm");

        }

        public void Frear()
        {
            Console.WriteLine($"Carro freiando..... irrrrrrrh");

        }
    }
}