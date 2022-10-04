// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
namespace CoreSchool
{


    class Program
    {
        public static void Main(String[] args)
        {

            //Welcome users and request name
            Console.WriteLine("Welcome to Booky, your favorite virtual classroom creator.\nPlease, enter your classroom name: ");
            string name = Console.ReadLine() + "";

            //Request foundation age
            Console.WriteLine($"Now, please enter the foundation age of {name}:");
            int foundationAge = Convert.ToInt32(Console.ReadLine());

            //Request type of room
            Console.WriteLine("What type of room do you want?\n 1- Personal\n 2- Two\n 3- Group ");
            int classType = Convert.ToInt32(Console.ReadLine());
            SchoolType classroomType = (SchoolType)classType;

            //school constructor instantiation (with optional params: "")
            var school = new School(name, foundationAge, classroomType, country: "");

            //print the whole class school
            Console.WriteLine(school);


            //Instatiate an array
            var arrayCourses = new Course[3];
            //course constructor instantiation
            arrayCourses[0] = new Course() { name = "C# with Jeff" };
            arrayCourses[1] = new Course() { name = "C# with Misha" };
            arrayCourses[2] = new Course() { name = "C# with Misho-Mishis" };

            //Invoque all PrintCourses methods
            System.Console.WriteLine("================WHILE PRINT=====================");
            PrintCoursesWhile(arrayCourses);
            System.Console.WriteLine("==============DO WHILE PRINT====================");
            PrintCoursesDoWhile(arrayCourses);
            System.Console.WriteLine("================FOR PRINT=======================");
            PrintCoursesFor(arrayCourses);
            System.Console.WriteLine("==============FOREACH PRINT======================");
            PrintCoursesForEach(arrayCourses);

        }


        //Create PrintCourses method to print arrays value
        private static void PrintCoursesWhile(Course[] arrayCourses)
        {
            //create a counter to handle the while cycle
            int counter = 0;

            //Counter always have to be lower than our arrayCourses
            while (counter < arrayCourses.Length)
            {
                //If so, print the array name and uniqueId having in count the number of the counter cycle
                System.Console.WriteLine($"Name: {arrayCourses[counter].name}, Id: {arrayCourses[counter].uniqueId} ");
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
                System.Console.WriteLine($"Name: {arrayCourses[counter].name}, Id: {arrayCourses[counter].uniqueId} ");
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
                System.Console.WriteLine($"Name: {arrayCourses[i].name}, Id: {arrayCourses[i].uniqueId} ");
            }
        }

        //Create PrintCoursesFor method to print arrays value
        private static void PrintCoursesForEach(Course[] arrayCourses)
        {
            //Use Foreach cycle to iterate the array in a simpler way
             foreach (var course in arrayCourses)
            {
                 System.Console.WriteLine($"Name: {course.name}, Id: {course.uniqueId} ");
            }
        }
    }
}