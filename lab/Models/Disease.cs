using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DiseaseGroup DiseaseGroup { get; set; }
        public int DiseaseGroupId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}