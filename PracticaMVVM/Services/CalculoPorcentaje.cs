using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMVVM.Services
{
    public static class CalculoPorcentaje
    {
        public static double Aplicar10(double numero)
        {
            return (numero * 10) / 100;
        }

        public static double Aplicar20(double numero)
        {
            return (numero * 20) / 100;
        }
    }
}
