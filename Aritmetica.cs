using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    ///  Implementa operações aritméticas básicas
    /// </summary>
    internal class Aritmetica
    {   /// <summary>
        ///  Enumeração para conversão de temperatura   
        public enum ConversaoTemperatura
        {Nulo=0,
        CelsiusFahrneit,
        FahrenheitCelsius
        }
        /// <summary>
        ///  Soma dois números inteiros
        /// </summary>

        /// <returns>Retorna a soma de a e b</returns>
       public int Somar(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        ///  Subtrai dois números inteiros
        /// </summary>
        /// 
        /// <returns>Retorna o resultado da subtração de 2 números</returns>
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public double ConverterTemperatura( ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrneit)            {
                return (temperatura * 9 / 5) + 32;
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (temperatura - 32) * 5 / 9;
            }
            return -1;
            return resultado;
        }
    }
}
