using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL.Models
{
    class ReservationModel
    {
        public ClientModel Client { get; set; }
        public List<DestinationModel> ListDestination = new List<DestinationModel>();

        public double PrecioConImpuestos() => ListDestination.Sum(d =>d.PrecioConImpuesto());
        public double CalculateTotal() => ListDestination.Sum(d => d.BasePrice);
        public List<DestinationModel> GetDestinations() => ListDestination;
        public void SetDestinations(List<DestinationModel> list) => ListDestination = list;
    }
}
