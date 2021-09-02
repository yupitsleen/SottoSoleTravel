using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SottoSoleTravel.Models;

namespace SottoSoleTravel.DAL
{
    public class TravelInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<TravelContext>
    {
        // The default behavior is to create a database only if it doesn't exist (and throw an exception if the model has changed and the database already exists). In this section, you'll specify that the database should be dropped and re-created whenever the model changes.Dropping the database causes the loss of all your data.This is generally okay during development, because the Seed method will run when the database is re-created and will re-create your test data. But in production you generally don't want to lose all your data every time you need to change the database schema. Later you'll see how to handle model changes by using Code First Migrations to change the database schema instead of dropping and re-creating the database.
        //The Seed method takes the database context object as an input parameter, and the code in the method uses that object to add new entities to the database. For each entity type, the code creates a collection of new entities, adds them to the appropriate DbSet property, and then saves the changes to the database. It isn't necessary to call the SaveChanges method after each group of entities, as is done here, but doing that helps you locate the source of a problem if an exception occurs while the code is writing to the database.
        protected override void Seed(TravelContext context)
        {
            var cities = new List<City>
           {
               new City{ID="Rome",Region="Lazio",Country="Italy",DateFounded=DateTime.Parse("0753-04-21")},
               new City{ID="Florence",Region="Tuscany",Country="Italy",DateFounded=DateTime.Parse("1115-01-01")},
               new City{ID="Venice",Region="Veneto",Country="Italy",DateFounded=DateTime.Parse("0697-01-01")}
           };

            cities.ForEach(c => context.Cities.Add(c));
            context.SaveChanges();

            var attractions = new List<Attraction>
            {
                new Attraction{AttractionID=1,Name="Vatican",TimeEstimate=4},
                new Attraction{AttractionID=2,Name="Uffizi",TimeEstimate=3},
                new Attraction{AttractionID=3,Name="San Marco",TimeEstimate=1}
            };
            attractions.ForEach(a => context.Attractions.Add(a));
            context.SaveChanges();

            var visits = new List<Visit>
            {
                new Visit{AttractionID=1,CityID="Rome",AttractionType=AttractionType.Church},
                new Visit{AttractionID=2,CityID="Florence",AttractionType=AttractionType.Museum},
                new Visit{AttractionID=3,CityID="Venice",AttractionType=AttractionType.Piazza}
            };
            visits.ForEach(v => context.Visits.Add(v));
            context.SaveChanges();
        }
    }
}