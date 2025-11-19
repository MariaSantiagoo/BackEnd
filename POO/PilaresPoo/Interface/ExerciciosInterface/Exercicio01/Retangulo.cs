using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
    
            public float Altura;

            public float Largura;

            public float Area;

            public Retangulo(float A, float L)
        {
            Altura = A;
            Largura = L;

        }

        public void CalcularArea()
        {
            Area = Altura * Largura;

        Console.WriteLine($"Area: {Area}");
        
        }


    }
}