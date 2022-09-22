using Application.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Offre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string Titre { get; set; }
        public DateTime DateCreation  { get; set; }
        public string Description { get; set; } 
        public string Reference { get; set; }
        public double Total_Prix_Revient { get; set; }
        public double Total_Prix_Proposition { get; set; }
        public double Qte_H_Siege_Site { get; set; }
        public double Total_Cout_Offre { get; set; }
        public double Total_Marge_Brut { get; set; }
        public double Total_Marge_Nette { get; set; }
        public double Total_Marge_Nette_Par_Pen { get; set; }
        public double Total_Revient_Prod { get; set; }
        public double Total_HT_Prod { get; set; }
        public double Total_TTC_Prod { get; set; }
        public double Total_Marge_Nette_Prod { get; set; }

        public virtual Responsable_Entreprise User { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }

        public ICollection<Offre_Employe> Offre_Employes { get; set; }
        public ICollection<Tâche>tâches;

        
    }
}
