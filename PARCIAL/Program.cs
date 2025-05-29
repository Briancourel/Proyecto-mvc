using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL.Controllers;

namespace PARCIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            ReservationController controller = new ReservationController();
            // controller.CargarReservacion();

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Crear nueva reserva");
                Console.WriteLine("2. Mostrar todas las reservas");
                Console.WriteLine("3. Eliminar reserva por cliente");
                Console.WriteLine("4. Actualizar reserva");
                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: controller.CrearReserva();Console.ReadKey();break;
                    case 2: controller.MostrarReservas(); Console.ReadKey(); break;
                    case 3: controller.EliminarReserva(); Console.ReadKey(); break;
                    case 4: controller.ActualizarReserva(); Console.ReadKey(); break;
                }

            } while (opcion != 5);
        }
    }
}
