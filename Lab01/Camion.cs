using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Camion : Vehiculo
    {
        public double CapacidadCarga { get; set; }
        public Camion(string Marca, string Modelo, int Año, double CapacidadCarga) : base(Marca, Modelo, Año)
        {
            this.CapacidadCarga = CapacidadCarga;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"CapacidadCarga: {CapacidadCarga}");
        }
    }
}
