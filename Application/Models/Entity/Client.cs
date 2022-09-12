using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Entity
{
    public class Client
    {
        public Guid Id { get; set; }
        public string NCin { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
    }
}
