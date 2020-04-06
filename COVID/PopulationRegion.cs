using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace COVID
{
    public class PopulationRegion
    {
        [Index(0)]
        public int Year { get; set; }
        [Index(1)]
        public string Geography { get; set; }
        [Index(2)]
        public string Postcode { get; set; }
        [Index(3)]
        public string ValueType { get; set; }
        [Index(4)]
        public int HouseholdSpaces { get; set; }
        [Index(5)]
        public int OccupiedHouseholdSpaces { get; set; }
        [Index(6)]
        public int UnoccupiedHouseholdSpaces { get; set; }
          

    }
}
