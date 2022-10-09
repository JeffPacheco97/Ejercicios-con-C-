

namespace CoreSchool.Entities
{

    public class School
    {
        
        //Constructor method is used when the variable is private → which is a good practice
        public string Name { get; set; }
        //A faster way to get and set this variable with the user input
        public int FoundationAge {get; set;}
        //The shortcout to write this property is "prop" and TAB
        public string City { get; set; }
        public string Country {get; set;}
        public SchoolType ClassroomType { get; set; }
        public List<Course> ListCourses { get; set; }


       //Create a new constructor method with params. This one must be called as classname
        public School (string name){
            Name = name;

        }
        

        //Create a new constructor method with params in a shortly way. First comes the class, then the variable.
        public School (string name, int foundationAge, SchoolType classroomType){
             Name = name;
             FoundationAge = foundationAge;
             ClassroomType = classroomType;
        }


        public School (string name, int foundationAge){ 

            (Name, FoundationAge)  = (name,foundationAge);
        }
        //Constructor with optional params
        public School (string name, int foundationAge, SchoolType classroomType, string city = "", string country = ""){
             (Name, FoundationAge, ClassroomType,  City, Country)  = (name, foundationAge, classroomType, city, country);
    
        }

        //Allow us to transform the whole class to string in order to print it
        public override string ToString()
        {
            return $"Name: {Name} Foundation age: {FoundationAge} Classroom Type: {ClassroomType}";
        }
    }
}