using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTO
{
    public class  Offre_EmployeDTO
    {
        public double Prix_Revient { get; set; }
        public double Nbre_H_Siege { get; set; }
        public double Nbre_H_Site { get; set; }
        public string Offreid { get; set; }

        public string EmployeId { get; set; }

        public Offre_EmployeDTO(double prix_Revient, double nbre_H_Siege, double nbre_H_Site, string offreid, string employeId)
        {
            Prix_Revient = prix_Revient;
            Nbre_H_Siege = nbre_H_Siege;
            Nbre_H_Site = nbre_H_Site;
            Offreid = offreid;
            EmployeId = employeId;
        }
    }
}
