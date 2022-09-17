using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class AddUpdateOffreEmploye
    {
        public double Prix_Revient { get; set; }
        public double Nbre_H_Siege { get; set; }
        public double Nbre_H_Site { get; set; }

        public string OffreId { get; set; }

        public string EmployeId { get; set; }
    }
}
