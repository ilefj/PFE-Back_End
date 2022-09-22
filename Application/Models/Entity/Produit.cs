using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Entity
{
    public class Produit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string nom_Prod { get; set; }
        public string description { get; set; }
        public double prix_Unitaire { get; set; }
        public double Quantite { get; set; }
        public int marge { get; set; }
        public int remise { get; set; }
        public double apres_Marge { get; set; }
        public double apres_Remise { get; set; }
        public double Produit_HT { get; set; }
        public double Produit_TTC { get; set; }
        public string OffreId { get; set; }
        public  Offre Offre { get; set; }


    }
}
