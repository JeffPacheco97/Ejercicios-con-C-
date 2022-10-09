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
        

        public static void DrawLine(int size)
        {
            WriteLine("".PadLeft(size, '='));
        }
        public static void DrawTitle(string name1, int size = 10){

            WriteLine($"{"".PadLeft(size, '=')} CURSOS DE LA ESCUELA DE {name1.ToUpper()} {"".PadRight(size, '=')}");
        }

    }    
}