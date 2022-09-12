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
        public virtual Responsable_Entreprise User { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual Employe Employe { get; set; }
       
        public ICollection<Tâche>tâches;

        
    }
}
