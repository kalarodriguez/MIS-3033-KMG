using System;
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

            List<Student> studs = new List<Student>();

            Student kala = new Student();
            kala.firstName = "Kala";
            kala.lastName = "Guthrie";
            kala.ID = 1;
            kala.birthdate = new DateTime(1994, 03, 30);

            studs.Add(kala);

            for (int i = 0; i < studentIDs.Length; i++)
            {
                Student s = new Student();
                s.firstName = studentFirstNames[i];
                s.lastName = studentLastNames[i];
                s.ID = studentIDs[i];

                studs.Add(s);
            }



            double allIDsSummedUp = 0;




            foreach (var student in studs)
            {
                allIDsSummedUp += student.ID;
                Console.WriteLine($"{student.lastName}, {student.firstName} ({student.ID}) - DOB: {student.birthdate.ToShortDateString()}");
                bool isUpper = true;
                string crazyFname = "";
                foreach (var letter in student.firstName)
                {
                    if (isUpper == true)
                    {
                        crazyFname += letter.ToString().ToUpper();
                        isUpper = false;
                    }

                    else
                    {
                        crazyFname += letter.ToString().ToLower();
                        isUpper = true;
                    }                    

                }

                Console.WriteLine($"Crazy first name is {crazyFname}");                

            }

            Console.WriteLine($"All IDs added together is {allIDsSummedUp}");




            Console.ReadKey();
        }
    }
}
