// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
namespace CoreSchool{
    

    class Program{

        

         public static void Main(String [] args){
              
            Console.WriteLine("Welcome to Booky, your favorite virtual classroom creator.\nPlease, enter your classroom name: ");
            string name = Console.ReadLine() + "";
            Console.WriteLine($"Now, please enter the foundation age of {name}:");
            int foundationAge = int.Parse(Console.ReadLine() + "");
            var school = new School(name);
            school.FoundationAge = (foundationAge);
            Console.WriteLine("What type of room do you want?\n Personal\n Two\n Group ");
            string ClassroomType = Console.ReadLine() + "";
            

             

            //print the whole class school
            Console.WriteLine(school);

        }
    }
}