﻿// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
using CoreSchool.Util;
using static System.Console;

namespace CoreSchool
{


    class Program
    {
        public static void Main(String[] args)
        {

           Printer.Beep(3, 1000);
           Printer.DrawLine("WELCOME TO BOOKY");

            //Welcome users and request name
            WriteLine("Welcome to Booky, your favorite virtual classroom creator.\nPlease, enter your classroom name: ");
            var name = "abc";


            //Request foundation age
            WriteLine($"Now, please enter the foundation age of {name}:");
            int foundationAge = Convert.ToInt32("22");


            //Request type of room
            WriteLine("What type of room do you want?\n 1- Personal\n 2- Two\n 3- Group ");
            int classType = Convert.ToInt32("3");
            SchoolType classroomType = (SchoolType)classType;

          
            //Declare the engine constructor
            var engine = new SchoolEngine();
            //Initialize the engine constructor
            engine.Initialize(name,foundationAge,classroomType, country: "");

            //Call PrintCoursesSchool method
            PrintCoursesSchool(engine.School, name);
        }
        public static void PrintCoursesSchool(School school,string name)
        {   

            //Draw a line with the DrawLine method from the static Printer class
            Printer.DrawTitle(name, 30);

            //Print every course in ListCourses
            foreach (var course in school.ListCourses){
                WriteLine($"Name: {course.name}, Id: {course.uniqueId} ");
            }

            
        }

            
    }
}   