using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSchool.Entities
{
    public class Assessment
    {
        //Set name and get a name
        public string Name { get; set; }
        //Set and get an unique Id
        public string uniqueId { get; private set; }
         //Set and get the student to assess
        public Student Student{ get; set; }
        //Set and get the student to assess
        public Subject Subject{ get; set; }
        //Set and get the student Note
        public float Note {get; set;}


         //Assessment constructor, generates a random ID with a build-in method 
        public Assessment() => uniqueId = Guid.NewGuid().ToString();

        public override string ToString()
        {
                return $"{Note}, {Student.Name}, {Subject.Name}";
        }
    }
}