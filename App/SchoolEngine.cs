using System.Linq;
using CoreSchool.Entities;
using static System.Console;


namespace CoreSchool
{

    public class SchoolEngine
    {
        
        public School School { get; set; }

        //SchoolEngine constructor
             public SchoolEngine(){ }

            public void Initialize(string name, int foundationAge, SchoolType classroomType, string country)
        {
            School = new School(name, foundationAge, classroomType, country: "");

            //Charge all methods implemented below
             ChargeCourses();
             ChargeSubjects();
             ChargeAssessment();
        }

            private void ChargeSubjects()
        {
                foreach (var Course in School.ListCourses)
            {
                    //Create a list with the subjects to charge
                    List<Subject> subjectsList = new List<Subject>
                {
                            new Subject{name= "Maths"},
                            new Subject{name= "English"},
                            new Subject{name= "Sciencies"},
                            new Subject{name= "Gym"},        
                }; 

            Course.Subjects = subjectsList;    
            }
        }

            private List<Student> GenerateRandomStudents(int number)
        {
                string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
                string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
                string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

                //Use LINQ to generate a random combination of names and lastnames
                var studentsList = from n1 in name1
                                from n2 in name2
                                from l1 in lastName
                                select new Student{name = $"{n1} {n2} {l1}"};
                                
                //Return a studentList generated and ordered by them unique ID and transformed to a list
                return studentsList.OrderBy((st) => st.uniqueId).Take(number).ToList();
        }

            private void ChargeAssessment()
        {
                throw new NotImplementedException();
        }

             //Create a method to charge the list
            private void ChargeCourses()
        {
                School.ListCourses = new List<Course>
            {
                    //course constructor instantiation and  initialization
                    new Course() { name = "C# with Mr. Gatito from List", shift =  ShiftTypes.Morning},
                    new Course() { name = "C# with Ms. Gatita from List", shift =  ShiftTypes.Morning},
                    new Course() { name = "C# with Lord bigotitos from List", shift =  ShiftTypes.Evening},
                    new Course() { name = "C# with Lady patitas", shift =  ShiftTypes.Afternoon},
                    new Course() { name = "C# wit don penaut", shift =  ShiftTypes.Evening},
            };

                //Iterate every course printing it and every student on it
                foreach(var c in  School.ListCourses)
            {

                     //Call a built-in Random constructor method
                    Random rdn = new Random();
                    
                    //Declarate and initialize a random variable between 5 and 30
                    int randomNumber = rdn.Next(5,30);
                    c.Students = GenerateRandomStudents(randomNumber);
            }
        }
    }   
}


