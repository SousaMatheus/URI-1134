using System;

namespace URI_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel;
            alcool = 0;
            gasolina = 0;
            diesel = 0;
            int valor = int.Parse(Console.ReadLine());

            while (valor != 4)
            {
                
                if (valor == 1)
                {
                    alcool++;
                }
                if (valor == 2)
                {
                    gasolina++;
                }
                if (valor == 3)
                {
                    diesel++;
                }
                valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
