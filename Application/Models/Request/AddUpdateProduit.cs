using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class AddUpdateProduit
    {
        public string nom_Prod { get; set; }
        public string description { get; set; }
        public double prix_Unitaire { get; set; }
        public double Quantite { get; set; }
        public int marge { get; set; }
        public int remise { get; set; }
    }
}
