

using Microsoft.AspNetCore.Identity;

namespace Application.Models.Entity
{
    public  class Responsable_Entreprise :IdentityUser   {
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Nom_Entreprise { get; set; }
        public string Activite_Entreprise { get; set; }
        public string Taille_Entreprise { get; set; }
        public string Code_Fiscale { get; set; }

    }
}
