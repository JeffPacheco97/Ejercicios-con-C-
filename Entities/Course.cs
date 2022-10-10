using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entities
{
    public class Course
    {
        //Set name and get a name
        public string name { get; set; }
        //Set name and get a unique Id
        public string uniqueId { get; private set; }
        //Set name and get a shift
        public ShiftTypes shift { get; set; }

        //Create a list where to put the subject to learn
        public List<Subject> Subjects { get; set; }
        
        //Create a list where to put the studens learning
        public List<Student> Students { get; set; }


        //Course constructor, generates a random ID with a build-in method 
        public Course() => uniqueId = Guid.NewGuid().ToString();

        
    
    }
}