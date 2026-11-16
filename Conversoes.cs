using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    
    internal static class Conversoes
    {  ///implementa operações de conversão de temperatura
    public enum ConversaoTemperatura
        {Nulo=0,
        CelsiusFahrneit,
        FahrenheitCelsius
        }
       /// <summary>
       /// Converte a temperatura 
       /// </summary>
       /// <param name="conversao"></param>
       /// <param name="temperatura"></param>
       /// <returns></returns>
       public enum ConversaoDistancia
        {Nulo=0,
        MetrosMilhas,
        MilhasMetros
        }
        public static double ConverterTemperatura(Aritmetica.ConversaoTemperatura conversao, double temperatura)
            {
                if (conversao == Aritmetica.ConversaoTemperatura.CelsiusFahrneit)
                {
                    return (temperatura * 9 / 5) + 32;
                }
                else if (conversao == Aritmetica.ConversaoTemperatura.FahrenheitCelsius)
                {
                    return (temperatura - 32) * 5 / 9;
                }
                return -1;
            }
            public static double ConverterDistancia(Aritmetica.ConversaoDistancia conversao, double distancia)
            {
                if (conversao == Aritmetica.ConversaoDistancia.MetrosMilhas)
                {
                    return distancia * 0.000621371;              
                    }
                else if (conversao == Aritmetica.ConversaoDistancia.MilhasMetros)
                {
                    return distancia * 1609.34;
                }
                return -1;
            }
    }
}
