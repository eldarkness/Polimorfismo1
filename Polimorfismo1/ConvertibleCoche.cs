using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    class ConvertibleCoche:Coche
    {
        protected int Plazas { get; set; }
        protected double Altura { get; set; }
        protected double Longitud { get; set; }
        public ConvertibleCoche(string Color,string Marca, string Modelo, int Plazas, double Altura, double Longitud)
                                :base (Color,Modelo,Marca)
        {
            this.Plazas = Plazas;
            this.Longitud = Longitud;
            this.Altura = Altura;
               
        
        }
        
        public new void MostrarDetalles()
        {
            Console.WriteLine("Datos adicionales de la ConvertibleCoche:\nPlazas: {0}\nAltura: {1}\nLongitud: {2}"
                                                                , this.Plazas, this.Altura, this.Longitud);
            Program.Asteriscos();
        }
    }
}
