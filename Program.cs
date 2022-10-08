// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{


    class Program
    {
        public static void Main(String[] args)
        {

            //Welcome users and request name
            WriteLine("Welcome to Booky, your favorite virtual classroom creator.\nPlease, enter your classroom name: ");
            var name =ReadLine();

            //Request foundation age
            WriteLine($"Now, please enter the foundation age of {name}:");
            int foundationAge = Convert.ToInt32(ReadLine());

            //Request type of room
            WriteLine("What type of room do you want?\n 1- Personal\n 2- Two\n 3- Group ");
            int classType = Convert.ToInt32(ReadLine());
            SchoolType classroomType = (SchoolType)classType;

            //school constructor instantiation (with optional params: "")
            var school = new School(name, foundationAge, classroomType, country: "");

            //print the whole class school
            WriteLine(school);


            // //Instatiate and initialize an array
            // school.arrayCourses = new Course[]
            // {
            //     //course constructor instantiation and  initialization
            //     new Course() { name = "C# with Mr. Gatito from array" },
            //     new Course() { name = "C# with Ms. Gatita from array" },
            //     new Course() { name = "C# with Lord bigotitos from array" },
            // };

            //Instatiate and initialize a list
            school.ListCourses = new List<Course>(){
                //course constructor instantiation and  initialization
                new Course() { name = "C# with Mr. Gatito from List", shift =  ShiftTypes.Morning, },
                new Course() { name = "C# with Ms. Gatita from List", shift =  ShiftTypes.Morning, },
                new Course() { name = "C# with Lord bigotitos from List", shift =  ShiftTypes.Evening, },
            };

            //Instatiate and initialize another list
            var anotherList = new List<Course>(){
                new Course() { name = "C# with pancakes from List", shift =  ShiftTypes.Morning, },
                new Course() { name = "C# with Miss manchas from List", shift =  ShiftTypes.Morning, },
                new Course() { name = $"C# with {name} from List", shift =  ShiftTypes.Evening, },

            };


            //Add a course to the list
            school.ListCourses.Add(new Course{name = "C# with Lady patitas", shift =  ShiftTypes.Afternoon,});
            school.ListCourses.Add(new Course{name = "C# with don penaut", shift =  ShiftTypes.Evening,});

            //Add a List to a List (Or range of objects)
            school.ListCourses.AddRange(anotherList);

           /* //Remove all elements within the selected List  or array
            anotherList.Clear();

            //remove just the elements we want to erase
            Course tmp = new Course{name = "C# with you", shift = ShiftTypes.Afternoon};
            school.ListCourses.Add(tmp);
            school.ListCourses.Remove(tmp);

            //Remove elements with Delegates
            Predicate<Course> myDelegate =  Predicate;
            school.ListCourses.RemoveAll(myDelegate);

            //Remove elements with  A faster way using Delegates
            school.ListCourses.RemoveAll(delegate(Course memberToErase){return memberToErase.name == "C# with Lady patitas";});
            */
            //Remove elements in a faster way using Delegates and lambda expressions
            school.ListCourses.RemoveAll((Course memberToErase2) => memberToErase2.name == "C# with don penaut");
            school.ListCourses.RemoveAll((Course memberToErase2) => memberToErase2.name == "C# with Ms. Gatita from List" && memberToErase2.shift == ShiftTypes.Morning);

            //Call PrintCoursesSchool method with school object as param
            PrintCoursesSchool(school);
        }

        private static bool Predicate(Course curobj)
        {
            return curobj.name == "C# with don penaut";
        }

        private static void PrintCoursesSchool(School school)
        {
            WriteLine($"================CURSOS DE LA ESCUELA DE {school.Name.ToUpper()}=====================");
            foreach (var course in school.ListCourses)
            {
                WriteLine($"Name: {course.name}, Id: {course.uniqueId} ");

            }
           
        }

        //Invoque all PrintCourses methods
            // WriteLine("================WHILE PRINT=====================");
            // PrintCoursesWhile(school.arrayCourses);
            // WriteLine("==============DO WHILE PRINT====================");
            // PrintCoursesDoWhile(schoolarrayCourses);
            // Console.WriteLine("================FOR PRINT=======================");
            // PrintCoursesFor(school.arrayCourses);
            // Console.WriteLine("==============FOREACH PRINT======================");
            // PrintCoursesForEach(school.arrayCourses);




        //Create PrintCourses method to print arrays value
        private static void PrintCoursesWhile(Course[] arrayCourses)
        {
            //create a counter to handle the while cycle
            int counter = 0;

            //Counter always have to be lower than our arrayCourses
            while (counter < arrayCourses.Length)
            {
                //If so, print the array name and uniqueId having in count the number of the counter cycle
                WriteLine($"Name: {arrayCourses[counter].name}, Id: {arrayCourses[counter].uniqueId} ");
                //Increase the counter to avoid a infinite loop
                counter++;
            }
        }

        //Create PrintCoursesDoWhile method to print arrays value
        private static void PrintCoursesDoWhile(Course[] arrayCourses)
        {
            //create a counter to handle the Do while cycle
            int counter = 0;
            //Counter always have to be lower than our arrayCourses
            do
            {
                //If so, print the array name and uniqueId having in count the number of the counter cycle
                WriteLine($"Name: {arrayCourses[counter].name}, Id: {arrayCourses[counter].uniqueId} ");
                //Increase the counter to avoid a infinite loop
                counter++;
            } while (counter < arrayCourses.Length);
        }

        //Create PrintCoursesFor method to print arrays value
        private static void PrintCoursesFor(Course[] arrayCourses)
        {
            //Use For cycle to iterate the array Length, then add 1 and reset the cycle 
            for(int i = 0; i < arrayCourses.Length; i++)
            {
                WriteLine($"Name: {arrayCourses[i].name}, Id: {arrayCourses[i].uniqueId} ");
            }
        }

        //Create PrintCoursesFor method to print arrays value
        private static void PrintCoursesForEach(Course[] arrayCourses)
        {
            //Use Foreach cycle to iterate the array in a simpler way
             foreach (var course in arrayCourses)
            {
                 WriteLine($"Name: {course.name}, Id: {course.uniqueId} ");
            }
        }
    }
}