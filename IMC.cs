using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula71_ExercicioIMC
{
    internal class IMC
    {
        public double Altura;
        public double Peso;

        public double CalculoIMC()
        {
            return Peso / (Altura * Altura);
        }
    }
}
