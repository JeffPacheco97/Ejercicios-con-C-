using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{


    public class SchoolEngine
    {
        public School School { get; set; }


        public SchoolEngine(){
            

        }

        public void Initialize(string name, int foundationAge, SchoolType classroomType, string country)
        {

                School = new School(name, foundationAge, classroomType, country: "");

                //Instatiate and initialize a list
                School.ListCourses = new List<Course>
                {
                //course constructor instantiation and  initialization
                new Course() { name = "C# with Mr. Gatito from List", shift =  ShiftTypes.Morning},
                new Course() { name = "C# with Ms. Gatita from List", shift =  ShiftTypes.Morning},
                new Course() { name = "C# with Lord bigotitos from List", shift =  ShiftTypes.Evening},
                new Course() { name = "C# with Lady patitas", shift =  ShiftTypes.Afternoon},
                new Course() { name = "C# wit don penaut", shift =  ShiftTypes.Evening},
                };
        }
    }   



}


