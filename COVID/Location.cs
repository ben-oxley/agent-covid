using System;
using System.Collections.Generic;
using System.Text;

namespace COVID
{
    public abstract class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public LocationType Type { get; set; }
        public Person[] Visitors { get; set; }
        public Person[] Inhabitants { get; set; }
        public Person[] Staff { get; set; }
    }

    public enum LocationType
    {
        [Probability(p=0.0001)]
        Work,
        [Probability(p = 0.0001)]
        Shop,
        [Probability(p = 0.001)]
        Home,
        [Probability(p = 0.00001)]
        Hospital,
        [Probability(p = 0.0001)]
        Transport
    }
}
