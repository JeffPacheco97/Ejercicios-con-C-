

namespace CoreSchool.Entities
{

    class School
    {


       
        
        //Constructor method is used when the variable is private → which is a good practice
        public string Name { get; set; }
        //A faster way to get and set this variable with the user input
        public int FoundationAge {get; set;}
        //The shortcout to write this property is "prop" and TAB
        public SchoolType ClassroomType { get; set; }



       /*Create a new constructor method with params. This one must be called as classname
        public School (string name){
            this.name = name;

        }
        */

        //Create a new constructor method with params in a shortly way. First comes the class, then the variable.
         public School (string name) => (Name) = name;

      
       
            
      
        //Allow us to transform the whole class to string in order to print it
        public override string ToString()
        {
            return $"Name: {Name} Foundation age: {FoundationAge} Classroom Type: {ClassroomType}";
        }


    }
     
      
}