using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int QtdAssentos;

        public void Voar()
        {
            Console.WriteLine($"Levantando vôo...");
            
        }


    }
}