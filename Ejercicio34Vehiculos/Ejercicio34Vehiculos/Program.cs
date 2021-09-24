using System;
using Entidades34Vehiculos;

namespace Ejercicio34Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(12, 2, VehiculoTerrestre.Colores.Azul, 6, 100);

            Automovil auto = new Automovil(4, 5, VehiculoTerrestre.Colores.Blanco, 4, 5);

            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 150);

            Console.WriteLine("Camion");
            Console.WriteLine("Cantidad de ruedas: {0}\nCantidad de puertas: {1}\nColor: {2}\nCantidad de marchas: {3}\nPeso carga: {4}", camion.cantidadRuedas, camion.cantidadPuertas, camion.color, camion.cantidadMarchas, camion.pesoCarga);

            Console.WriteLine("Automóvil");
            Console.WriteLine("Cantidad de ruedas: {0}\nCantidad de puertas: {1}\nColor: {2}\nCantidad de marchas: {3}\nCantidad de pasajeros: {4}", auto.cantidadRuedas, auto.cantidadPuertas, auto.color, auto.cantidadMarchas, auto.cantidadPasajeros);


            Console.WriteLine("Moto");
            Console.WriteLine("Cantidad de ruedas: {0}\nCantidad de puertas: {1}\nColor: {2}\nCilindradas: {3}", moto.cantidadRuedas, moto.cantidadPuertas, moto.color, moto.cilindradas);

            Console.ReadKey();
        }
    }
}
