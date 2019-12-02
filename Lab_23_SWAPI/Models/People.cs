using System;
using System.Collections.Generic;

namespace Lab_23_SWAPI.Models
{
    public class PeopleRoot
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Person> results { get; set; }
    }
}
