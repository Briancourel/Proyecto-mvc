using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL.Models;
using PARCIAL.Views;
using Repository;



namespace PARCIAL.Controllers
{
    
    class ReservationController
    {
        private List<ReservationModel> reservationList = new List<ReservationModel>();
        private ClienteController clientController;
        private DestinationController destinationController;

        public ReservationController()
        {
            clientController = new ClienteController();
            destinationController = new DestinationController();
            CargarReservacion();
        }

        public void CargarReservacion()
        {
            reservationList = Repository<ReservationModel>.ObtenerTodos(( "reservas"));
        }
        public void GuardarReservas()
        {
            Repository<ReservationModel>.GuardarLista("reservas", reservationList);
        }

        public  void CrearReserva()
        {
            var cliente = clientController.LoadClient();

            if (cliente == null)
            {
                Console.WriteLine(" No se pudo crear la reserva: cliente inválido.");
                return;
            }
            var reservas = destinationController.LoadDestinationList();
            if (reservas == null)
            {
                Console.WriteLine("No se pudo crear la reserva: lista de reservas vacía.");
            }
            ReservationModel nuevaReservation = new ReservationModel
            {
                Client = cliente
            };
            nuevaReservation.ListDestination = reservas;

            reservationList.Add(nuevaReservation);
            GuardarReservas();

            ReservationViews.showMsg("reserva creada y guardada exitosamente.");
        }

        public void MostrarReservas()
        {
            ReservationViews.showMsg("\n\n-------------LISTA DE RESERVAS-------------\n");
            if (reservationList.Count == 0)
            {
                ReservationViews.showMsg("No hay reservas disponibles");
                return;
            }

            int ind = 0;

            foreach (var o in reservationList)
            {
                ReservationViews.showMsg($"Mostrando reserva de index: {ind}");
                clientController.ShowClient(o.Client);
                ReservationViews.showMsg("\ndDestinos:");
                destinationController.ShowDestinationList(o.ListDestination);


                ReservationViews.showMsg($"Total: ${o.CalculateTotal():0.00} | Total con IVA: ${o.PrecioConImpuestos():0.00}");
                ReservationViews.showMsg(new string('-', 30));


                ind++;
            }
            
             
            
        }

        public void ActualizarReserva()
        {
            MostrarReservas();
            ReservationViews.showMsg("Ingrese el indice de la reserva a actualizar");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= reservationList.Count)
            {
                ReservationViews.showMsg("indice invalido");
                return;
            }

            var nuevoCliente = clientController.LoadClient();
            var nuevodestino = destinationController.LoadDestinationList();

            reservationList[index].Client = nuevoCliente;
            reservationList[index].ListDestination = nuevodestino;

            GuardarReservas();
            ReservationViews.showMsg("reserva actualizada correctamente");
        }

        public void EliminarReserva()
        {
            MostrarReservas();
            ReservationViews.showMsg("ingrese el indice de la reserva a eliminar");
            int index = int.Parse(Console.ReadLine());

            if(index < 0 || index >= reservationList.Count)
            {
                ReservationViews.showMsg("indice invalido");
                return;
            }

            reservationList.RemoveAt(index);
            GuardarReservas();
            ReservationViews.showMsg("reserva eliminada correctamente");
        }
    /*
        public void ActualizarOrden()
        {
            MostrarOrdenes();
            OrderView.showMsg("Ingrese el índice de la orden a actualizar:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= orderList.Count)
            {
                OrderView.showMsg("Índice inválido.");
                return;
            }

            var nuevaCliente = clientController.LoadClient();
            var nuevosProductos = productController.LoadProductList();

            orderList[index].client = nuevaCliente;
            orderList[index].productList = nuevosProductos;

            GuardarOrdenes();
            OrderView.showMsg("Orden actualizada correctamente.");
        }

        public void EliminarOrden()
        {
            MostrarOrdenes();
            OrderView.showMsg("Ingrese el índice de la orden a eliminar:");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= orderList.Count)
            {
                OrderView.showMsg("Índice inválido.");
                return;
            }

            orderList.RemoveAt(index);
            GuardarOrdenes();
            OrderView.showMsg("Orden eliminada correctamente.");
        }
             */
}
    }

