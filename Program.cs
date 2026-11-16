using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4, 2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");
            double t1=Conversoes.ConverterTemperatura(Aritmetica.ConversaoTemperatura.CelsiusFahrneit, 36);
            Console.WriteLine($"36ºC = {t1}ºF");
            double t2 = Conversoes.ConverterTemperatura(Aritmetica.ConversaoTemperatura.FahrenheitCelsius, 96.8);
            Console.WriteLine($"96.8ºF = {t2}ºC");
            Console.ReadKey();
        }
    }
}
