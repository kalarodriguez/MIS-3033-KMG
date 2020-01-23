﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_3013_Review_KMG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parallel Arrays = means each element at the same position is part of the same entity
            int[] studentIDs = new int[3];
            string[] studentFirstNames = new string[3];
            string[] studentLastNames = { "Guthrie", "Mallory", "Johnson" };
            studentIDs[0] = 1;
            studentIDs[1] = 2;
            studentIDs[2] = 3;
            studentFirstNames[0] = "Jordan";
            studentFirstNames[1] = "Harvey";
            studentFirstNames[2] = "William";

            // any time you have a collection you will have to use a loop to iterate each item in the collection

            for (int i = 0;  i < studentIDs.Length; i++)
            {
                Console.WriteLine($"{studentLastNames[i]}, {studentFirstNames[i]} ({studentIDs[i]})");
            }



            //Dictionary Example - key/value pairs

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Jordan Guthrie");
            students.Add(2, "Harvey Mallory");
            students.Add(3, "William Johnson");


            if (students.ContainsKey(1))
            {
                students[1] = "Jordan W. Guthrie";
            }

            foreach (var key in students.Keys)
            {
                Console.WriteLine($"{students[key]} ({key})");

            }



            Console.ReadKey();

        }
    }
}
