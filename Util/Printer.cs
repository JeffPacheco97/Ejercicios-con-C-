using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        
        //Draw a title between equal signs 
        public static void DrawLine(string title, int size = 30)
        {

            WriteLine("".PadLeft(size, '=') + title + "".PadRight(size, '='));
        }
         //Draw a title between equal signs as well, but with the generic message within

        public static void DrawTitle(string name1, int size = 30){
            string firstPartPhrase = "CURSOS DE LA ESCUELA DE ";
            WriteLine($"{"".PadLeft(size = 25, '=')} {firstPartPhrase} {name1.ToUpper()} {"".PadRight(size = 25, '=')}");
        }

        public static void Beep (int number, int hz = 2000, int time = 500)
        {
            while(number-->0)
            {
                Console.Beep(hz, time);
            }
        }
       

    }    
}