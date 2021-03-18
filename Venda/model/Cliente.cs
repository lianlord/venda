using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda.model {
    class Cliente {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Cliente(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
