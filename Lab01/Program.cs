// See https://aka.ms/new-console-template for more information
using Lab01;
using System.Collections.Generic;

Vehiculo vehiculo = new Vehiculo("Marca", "Modelo", 2003);

Automovil automovil = new Automovil("Marca", "Modelo", 2003, "Combustible");

Camion camion = new Camion("Marca", "Modelo", 2003, 23.21);



List<Vehiculo> Listavehiculos = new List<Vehiculo>();

Listavehiculos.Add(camion);
Listavehiculos.Add(automovil);

Flota flota = new Flota();

flota.MostrarFlota();

Console.WriteLine("Ingrese Una de las opciones");
Console.WriteLine("A: Mostrar información de vehiculos");
Console.WriteLine("B: Calcular costo de viaje");
Console.WriteLine("C: Salida");

