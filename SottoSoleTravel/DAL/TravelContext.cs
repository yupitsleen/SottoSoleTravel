using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SottoSoleTravel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SottoSoleTravel.DAL
{
    public class TravelContext : DbContext
    {
        public TravelContext() : base("TravelContext") //cn string in Web.config passed here
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}