using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class EmployeeModel
    {
        
        public string NCin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Poste { get; set; }
        public string Matricule { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public double Salaire { get; set; }
        public string UserId { get; set; }

    }
}
