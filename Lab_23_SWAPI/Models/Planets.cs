using System;
using System.Collections.Generic;

namespace Lab_23_SWAPI.Models
{
    public class PlanetsRoot
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Planet> results { get; set; }
    }
}

