using Application.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Models
{
    public class UpdateOffreModel
    {
       
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string UserId { get; set; }
        public string domaineId{ get; set; }

    }
}
