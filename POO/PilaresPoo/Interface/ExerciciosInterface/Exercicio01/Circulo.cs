using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public double Raio;

        public double AreaCirculo;

    public Circulo (double R)
        {
            Raio = R;
        }

        public void CalcularArea()
        {
            AreaCirculo = Math.PI *(Raio * 2);
            Console.WriteLine($"Area: {AreaCirculo}");
            
        }
    }
}