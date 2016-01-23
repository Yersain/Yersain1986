using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab.Models
{
    public class DiseaseGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Disease> Diseases { get; set; }
        public ICollection<DiseaseGroup> DiseaseGroups { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}