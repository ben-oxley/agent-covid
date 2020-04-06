using System;
using System.Collections.Generic;
using System.Text;

namespace COVID
{
    public class Person
    {
        public Person[] Family { get; }
        public bool Infected { get; set; }
        public DateTime TimeInfected { get; set; }
        public bool IsIsolating { get; set; }
        public Location CurrentLocation { get; set; }
        public Location HomeLocation { get; set; }
        public Location WorkLocation { get; set; }
        public double Age { get; set; }
        public bool Vunerable { get; set; }

    }

}
