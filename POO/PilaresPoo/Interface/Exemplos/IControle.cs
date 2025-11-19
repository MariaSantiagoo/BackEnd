using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IControle
    {
        public void Ligar();

        public void Desligar();

        public void AumentarVolume();

        public void DiminuirVolume();
    }
}