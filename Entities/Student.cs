using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entities
{
    public class Student
    {
        //Set name and get a name
        public string name { get; set; }
        //Set and get an unique Id
        public string uniqueId { get; private set; }

        //Student constructor, generates a random ID with a build-in method 
        public Student() => uniqueId = Guid.NewGuid().ToString();
        
    }
}