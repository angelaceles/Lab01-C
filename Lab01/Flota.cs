using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Flota
    {
        public List<Vehiculo> Vehiculos { get; set; }


        public Flota() 
        { 
            Vehiculos = new List<Vehiculo>();
        }
        public void MostrarFlota()
        {
            foreach (var vehiculo in Vehiculos)
            {
                vehiculo.MostrarInformacion();
            }
        }

    }
}
