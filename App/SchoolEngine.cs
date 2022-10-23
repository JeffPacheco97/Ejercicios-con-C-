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
                            new Subject{Name= "Maths"},
                            new Subject{Name= "English"},
                            new Subject{Name= "Sciencies"},
                            new Subject{Name= "Gym"},        
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
                                select new Student{Name = $"{n1} {n2} {l1}"};
                                
                //Return a studentList generated and ordered by his unique ID and transformed it to a list
                return studentsList.OrderBy((st) => st.uniqueId).Take(number).ToList();
        }

             //Create a method to charge the list of courses
            private void ChargeCourses()
        {
                School.ListCourses = new List<Course>
            {
                    //course constructor instantiation and  initialization
                    new Course() { name = "C# with Mr. Gatito from List", shift =  ShiftTypes.Morning},
                    new Course() { name = "C# with Ms. Gatita from List", shift =  ShiftTypes.Morning},
                    new Course() { name = "C# with Lord bigotitos from List", shift =  ShiftTypes.Evening},
                    new Course() { name = "C# with Lady patitas", shift =  ShiftTypes.Afternoon},
                    new Course() { name = "C# with don penaut", shift =  ShiftTypes.Evening},
            };

                //Iterate every course and every student on it
                foreach(var c in  School.ListCourses)
            {

                     //Call a built-in Random constructor method
                    Random rnd = new Random();
                    
                    //Declarate and initialize a random variable between 5 and 30
                    int randomNumber = rnd.Next(5,30);
                    c.Students = GenerateRandomStudents(randomNumber);
            }
        }

            //Method that generates 5 random notes for each student in each subject of each course
            private void ChargeAssessment()
        {       foreach(var course in School.ListCourses)
            {
                    foreach(var subject in course.Subjects)
                {
                        foreach(var student in course.Students)
                    {    
                            Random rnd = new Random();
                            for (int i = 0; i < 5; i++)
                        {
                                var ass = new Assessment
                            {
                                    Subject = subject,
                                    Name = $"{subject.Name} Assess# {i+1}",
                                    Note = (float)(5* rnd.NextDouble()),
                                    Student = student      
                            };
                            
                            student.Assessment.Add(ass);
                        }
                    }
                }
            }
         }
    }                
}


