using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SottoSoleTravel.Models
{
    public enum AttractionType
    {
        Museum, Piazza, Restaurant, Park, Church, Other
    }
    public class Visit //can only hold a single Attraction, AttractionType
    {
        public int VisitID { get; set; } //PK
        public int AttractionID { get; set; }
        public string CityID { get; set; } 
        public AttractionType? AttractionType { get; set; }

        public virtual Attraction Attraction { get; set; }
        public virtual City City { get; set; }
    }
}