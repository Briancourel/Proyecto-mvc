using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL.Models;

namespace PARCIAL.Views
{
    class DestinationViews
    {

        public static List<DestinationModel> CreateDestination()
        {
            List<DestinationModel> destinations = new List<DestinationModel>();
            Console.WriteLine("=== Crear Destino Turístico ===");
            Console.Write("Nombre del destino: ");
            string name = Console.ReadLine();
            Console.Write("País: ");
            string country = Console.ReadLine();
            Console.Write("Precio base: ");
            double basePrice;

            while (!double.TryParse(Console.ReadLine(), out
            basePrice))
            {
                Console.Write("Precio inválido. Ingrese un número: ");
            }
            destinations.Add(new DestinationModel(name, basePrice, country));
            return destinations;
        }
        public static void ShowDestination(List<DestinationModel> destinations)

        {
            foreach (var d in destinations)
            {
                Console.WriteLine($"Destino: {d.Name} - País:  { d.Country} -Precio Base:" +
                $" { d.BasePrice:C} -Precio con Impuesto: { d.PrecioConImpuesto():C}");

            }
        }
    }
}

        

