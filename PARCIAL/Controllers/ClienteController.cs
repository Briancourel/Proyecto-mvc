using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL.Models;
using PARCIAL.Views;


namespace PARCIAL.Controllers
{
    class ClienteController
    {
        public ClientModel LoadClient() => ClientViews.CrearCliente();
        public void ShowClient(ClientModel c) => ClientViews.ShowClient(c);
    }
}
