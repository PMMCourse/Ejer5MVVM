using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.Services
{
    public class CalcServices
    {
        String OperationResult;
        public CalcServices(String OperationResult) {
            this.OperationResult = OperationResult;
        }
        public string DoCalc() {
            PerformInsertNumber();
            return OperationResult;
        }

        public void PerformInsertNumber()
        {
            Double numero1, numero2;
            String[] array = null;
            if (OperationResult.Contains("+"))
            {
                array = OperationResult.Split('+');
                PerformOperationSum(array);
            }
            else if (OperationResult.Contains("-"))
            {
                array = OperationResult.Split('-');
                PerformOperationDeduct(array);
            }
            else if (OperationResult.Contains("*"))
            {
                array = OperationResult.Split('*');
                PerformOperationMultiplication(array);
            }
            else if (OperationResult.Contains("/"))
            {
                array = OperationResult.Split('/');
                PerformOperationDivide(array);
            }
        }
        private static Double[] PerformOperationTrim(String[] array)
        {
            Double number1 = Convert.ToDouble(array[0].Trim());
            Double number2 = Convert.ToDouble(array[1].Trim());
            Double[] array2 = new Double[] { number1, number2 };
            return array2;
        }
        private void PerformOperationSum(String[] array)
        {
            Double[] array2 = PerformOperationTrim(array);
            Double resultado = array2[0] + array2[1];
            OperationResult = resultado.ToString();
        }

        private void PerformOperationDeduct(String[] array)
        {
            Double[] array2 = PerformOperationTrim(array);
            Double resultado = array2[0] - array2[1];
            OperationResult = resultado.ToString();
        }

        private void PerformOperationMultiplication(String[] array)
        {
            Double[] array2 = PerformOperationTrim(array);
            Double resultado = array2[0] * array2[1];
            OperationResult = resultado.ToString();
        }

        private void PerformOperationDivide(String[] array)
        {
            Double[] array2 = PerformOperationTrim(array);
            Double resultado = array2[0] / array2[1];
            OperationResult = resultado.ToString();
        }
    }
}
