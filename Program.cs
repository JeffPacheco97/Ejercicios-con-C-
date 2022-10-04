// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
namespace CoreSchool{
    

    class Program{

        

         public static void Main(String [] args){
              
            Console.WriteLine("Welcome to Booky, your favorite virtual classroom creator.\nPlease, enter your classroom name: ");
            string name = Console.ReadLine() + "";

            Console.WriteLine($"Now, please enter the foundation age of {name}:");
            int foundationAge =  Convert.ToInt32(Console.ReadLine());

            //school.FoundationAge = (foundationAge);

            
            Console.WriteLine("What type of room do you want?\n 1- Personal\n 2- Two\n 3- Group ");
            int classType = Convert.ToInt32(Console.ReadLine());
            
            SchoolType classroomType = (SchoolType)classType;
            
             //You left here param of object SchoolType has a mistake
             var school = new School(name, foundationAge, classroomType);


            //print the whole class school
            Console.WriteLine(school);

        }
    }
}