using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    class Coche
    {
        protected string Color { get; set; }
        protected string Modelo { get; set; }
        protected string Marca { get; set; }
        public Coche(string Color, string Marca,string Modelo)
        {
            this.Marca = Marca;
            this.Color = Color;
            this.Modelo = Modelo;
        }

        public virtual void DescribeCoche()
        {
            Console.WriteLine("Color del coche {0}, marca del coche {1}, modelo del coche {2}",
                                                   this.Color, this.Marca, this.Modelo);
            MostrarDetalles();
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine("El coche basico no tiene mas detalles");
            Program.Asteriscos();
        }
      
    }
}
