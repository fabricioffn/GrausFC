using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Double F;
            Double C;
            Console.WriteLine("Conversor de fahrenheit para celsius");
            Console.WriteLine("informe a tempertatura em fahrenheit :");
            F = Convert.ToDouble(Console.ReadLine());

            // conversão

            C = (F - 32) * 5/9;
            Console.WriteLine("a temperatura em Celsius é : " + C);
        }
    }
}
