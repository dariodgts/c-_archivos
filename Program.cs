using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Base1, Altura, Area, Perimetro;
            
            Console.WriteLine(" Digite la Base:");
            Base1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Altura:");
           Altura = Double.Parse(Console.ReadLine());

            Area = Base1 * Altura / 2;
            Perimetro = Base1 * 3;
          

            Console.WriteLine("\n\nSU AREA ES: "+Area);
            Console.WriteLine("SU PERIMETRO ES: "+Perimetro);
            Console.ReadKey();
        }
    }
}
