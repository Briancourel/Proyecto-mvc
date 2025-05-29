using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL.Models
{
    class DestinationModel
    {
        public string Name { get; set; }
        public double BasePrice { get; set; }
        public string Country { get; set; }
        public DestinationModel() { }
        public DestinationModel(string name, double basePrice, string
        country)
        {
            Name = name;
            BasePrice = basePrice;
            Country = country;
        }
        public double PrecioConImpuesto()
        {
            return BasePrice * 1.15; // 15% impuesto turístico
        }
    }
}
