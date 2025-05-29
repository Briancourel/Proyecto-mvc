using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL.Views;
using PARCIAL.Models;

namespace PARCIAL.Controllers
{
    class DestinationController
    {
        public List<DestinationModel> LoadDestinationList() => DestinationViews.CreateDestination();
        public void ShowDestinationList(List<DestinationModel> destinations) => DestinationViews.ShowDestination(destinations);
    }
}
