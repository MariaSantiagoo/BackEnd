using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor
    {
        //Propriedades
        public string Marca;
        public string Modelo;
        public string Cor;
        public int Ano;

        public Moto(string M, string Mo, string C, int A)
        {
            Marca = M;
            Modelo = Mo;
            Cor = C;
            Ano = A;

        }

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
            Console.WriteLine($"Moto acelerando... Vruuummmmmmmmmmmm");
        }

        public void Frear()
        {
            Console.WriteLine($"Moto freiando... iiiirrrrrrrhh");
        }
    }
}