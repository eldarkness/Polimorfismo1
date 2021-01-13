using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCoches1();
            Console.ReadKey();
        }

        public static void TestCoches1()
        {
            Coche coche1 = new Coche("Azul", "BMW", "Serie 3");
            ConvertibleCoche coche2 = new ConvertibleCoche("Rojo", "Audi", "A6-Ranchera", 7, 1.8, 3.6);
            Minivan coche3 = new Minivan("Negro", "Mercedes", "A-360", 5, 1.7, 3.9);

            coche1.DescribeCoche();
            coche2.DescribeCoche();
            coche2.MostrarDetalles();
            coche3.DescribeCoche();
        }

        public static void Asteriscos()
        {
            Console.WriteLine("************************************************************************");
        }
    }
}
