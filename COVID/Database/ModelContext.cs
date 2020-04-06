using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace COVID.Database
{
    public class ModelContext : DbContext
    {
        

        public DbSet<Person> People { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PopulationRegion> PopulationByRegion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");

        public static async Task loadData(ModelContext context)
        {
            using (TextReader textReader = new StreamReader("./postcode-population.csv"))
            {
                using (CsvReader csvReader = new CsvReader(textReader, CultureInfo.InvariantCulture))
                {

                    await context.PopulationByRegion.AddRangeAsync(csvReader.GetRecords<PopulationRegion>());
                }
            }

        }
    }

   


   


}
