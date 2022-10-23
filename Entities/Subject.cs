using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entities
{
    public class Subject
    {

        //Set name and get a name
        public string Name { get; set; }
        //Set and get an unique Id
        public string uniqueId { get; private set; }

        //Student constructor method, generates a random ID with a build-in method 
        public Subject() => uniqueId = Guid.NewGuid().ToString();

        
    }
}