using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Automovil : Vehiculo
    {
        public string Combustible { get; set; }

        public Automovil(string Marca, string Modelo, int Año, string Combustible) : base(Marca, Modelo, Año)
        {
            this.Combustible = Combustible;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Combustible: {Combustible}");
        }
    }
}
