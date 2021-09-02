using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SottoSoleTravel.Models
{
    public class Attraction //can be related to any number of Visit entities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //lets you specify the PK
        public int AttractionID { get; set; }
        public string Name { get; set; }
        public int TimeEstimate { get; set; }

        public virtual ICollection<Visit> Visits { get; set; } //navigation property
    }
}