using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Entity
{
    public class Offre_Employe
    {
       
        public double Prix_Revient { get; set; }
        public double Nbre_H_Siege { get; set; }
        public double Nbre_H_Site { get; set; }
        public double Prix_Proposition { get; set; }
        public double CoutParEmp { get; set; }
        public double Marge_Brut { get; set; }
        public double Marge_nette { get; set; }
        public double Marge_nette_PerPen { get; set; }

        public string OffreId { get; set; }
        public Offre offre { get; set; }
        public Guid EmployeId { get; set; }
        public Employe employe { get; set; }

    }
}
