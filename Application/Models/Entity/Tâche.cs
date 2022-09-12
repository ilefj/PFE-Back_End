using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Tâche
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description   { get; set; }
        public Offre offre { get; set; }
       public TypeTâche typeTâche { get; set; }
    }
}
