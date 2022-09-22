using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Models.Entity
{
    public class Employe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string NCin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Poste { get; set; }
        public string Matricule { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public double Salaire { get; set; }
        public virtual Responsable_Entreprise User { get; set; }
        [JsonIgnore]
        public ICollection<Offre_Employe> Offre_Employes { get; set; }

    }
}


