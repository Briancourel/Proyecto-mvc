using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL.Models
{
    class ClientModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int id { get; set; }
        public string Email { get; set; }

        public ClientModel() { }

        public ClientModel(string Name, string LastName, int id, string Email)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.id = id;
            this.Email = Email;
        }

    }
}
