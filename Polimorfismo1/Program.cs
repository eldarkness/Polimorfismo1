using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    class Program
    {
        public static List<Coche> listaCoches = new List<Coche>();
        
        static void Main(string[] args)
        {
            listaCoches.Add(new Coche("Azul", "BMW", "Serie 3"));
            listaCoches.Add(new ConvertibleCoche("Rojo", "Audi", "A6-Ranchera", 7, 1.8, 3.6));
            listaCoches.Add(new Minivan("Negro", "Mercedes", "A-360", 5, 1.7, 3.9));
            TestCoches1();
            TestCoches2();
            TestCoches3();
            TestCoches4();
            Console.ReadKey();
        }

        public static void TestCoches1()
        {
            Console.WriteLine("Comienza TestCoches1");
            Coche coche1 = new Coche("Azul", "BMW", "Serie 3");
            ConvertibleCoche coche2 = new ConvertibleCoche("Rojo", "Audi", "A6-Ranchera", 7, 1.8, 3.6);
            Minivan coche3 = new Minivan("Negro", "Mercedes", "A-360", 5, 1.7, 3.9);

            coche1.DescribeCoche();
            coche2.DescribeCoche();            
            coche3.DescribeCoche();
            /*
             * coche1 es una instancia de tipo coche o sea de la clase padre, cuando se llama al metodo describeCoche solo muestra
             * sus datos basicos ya que el metodo mostrarDetalles declarado para el no muestra mas detalles.
             * 
             * coche3 es una instancia de tipo Minivan por lo que cuando se llama al metodo describeCoche muestra sus datos basicos
             *  pero como el metodo mostrarDetalles esta declarado
             * como override reemplaza ese metodo en la clase Coche y muestra los detalles especificos de una Minivan que son las plazas
             * la altura y la longitud  
             *  
             * coche2 es una instancia de tipo ConvertibleCoche, por lo que cuando se llama al metodo describeCoche muestra sus 
             * datos basicos tal y como ocurre en las demas instancias que heredan de Coche, pero cuando se llama al metodo mostrarDetalles
             * se llama al metodo de la clase Padre porque su metodo mostrarDetalles esta declarado como new por lo tanto no reemplaza al
             * metodo que hereda. Para poder llamar a su metodo mostrarDetalles habria que invocarlo directamente poniendo una instancia
             * del tipo ConvertibleCoche.
             *   
             */
        }

        public static void TestCoches2()
        {
            Console.WriteLine("Comienza TestCoches2");
            /*var listaCoches = new List<Coche>();
            listaCoches.Add(new Coche("Azul", "BMW", "Serie 3"));
            listaCoches.Add(new ConvertibleCoche("Rojo", "Audi", "A6-Ranchera", 7, 1.8, 3.6));
            listaCoches.Add(new Minivan("Negro", "Mercedes", "A-360", 5, 1.7, 3.9));*/
            foreach(Coche c in listaCoches)
            {
                c.DescribeCoche();
            }
            Console.WriteLine(" ");
            /*
             * Funciona practicamente igual que el metodo TestCoches1 solo que aqui usamos una lista y se llama al metodo DescribeCoche
             * por lo tanto muestra el metodo de la clase base Coche "DescribeCoche" porque es llamado con un objeto de tipo Coche que es 
             * el elemento C de la lista asi que para la clase Minivan si se muestra su metodo MostrarDetalles pero para la clase
             * ConvertibleCoche no porque su metodo esta declarado como new.
             * 
             * La diferencia
             * 
             */
        }

        public static void TestCoches3()
        {
            Console.WriteLine("Comienza TestCoches3");
            Minivan coche1 = new Minivan("Negro", "Mercedes", "A-360", 5, 1.7, 3.9);
            ConvertibleCoche coche2 = new ConvertibleCoche("Rojo", "Audi", "A6-Ranchera", 7, 1.8, 3.6);

            coche1.MostrarDetalles();
            coche2.MostrarDetalles();
            Console.WriteLine(" ");
            
        }

        public static void TestCoches4()
        {
            Console.WriteLine("Comienza TestCoches4");
            foreach (Coche c in listaCoches)
            {
                c.DescribeCoche();
            }
        }


        public static void Asteriscos()
        {
            Console.WriteLine("************************************************************************");
        }
    }
}
