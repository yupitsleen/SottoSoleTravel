using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SottoSoleTravel.Models
{
    public class City
    {
        public string ID { get; set; } //primary key in the db table. ID here means name of the city, bc EF automatically makes 'ID' props the PK
        public string Country { get; set; }
        public string Region { get; set; }
        public DateTime DateFounded { get; set; }

        public virtual ICollection<Visit> Visits { get; set; } //Visits is a navigation property, 'virtual' for lazy loading
    }
}