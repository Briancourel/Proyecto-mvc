using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL.Models;

namespace PARCIAL.Views
{
    class ClientViews
    {
        public static ClientModel CrearCliente()
        {
            Console.WriteLine("=== Crear Cliente ===");
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Apellido: ");
            string lastName = Console.ReadLine();
            Console.Write("ID (DNI o Pasaporte): ");
            int id =int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            return new ClientModel(name, lastName, id, email);
        }

        public static void ShowClient(ClientModel client)
        {
            Console.WriteLine($"Cliente: {client.Name}{ client.LastName}-ID: { client.id} -Email: { client.Email} ");
        }
    }
}
    

