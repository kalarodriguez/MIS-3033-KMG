using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_3013_Review_KMG
{
    class Student
    {
        // + stands for public in class UML
        // - stands for private in class UML

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthdate { get; set; }
        private int luckyNumber;

        public Student()
        {
            ID = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            birthdate = DateTime.Now;
            luckyNumber = 0;
        }

        public Student(int id, int luckynumber)
        {
            ID = id;
            firstName = string.Empty;
            lastName = string.Empty;
            birthdate = DateTime.Now;
            luckyNumber = luckyNumber;
        }

        public string BirthDateDayOfWeek()
        {
            return "";
        }

    }
}
