using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9_21
{


    class Student
    {
        public string Full_Name { get; set; }
        public byte Course { get; set; }
        public string Specialization { get; set; }

        public Student(string full, byte course, string specialization)
        {
            Full_Name = full;
            this.Course = course;
            Specialization = specialization;

        }

        public string Group(string specialization)
        {


            switch (Specialization)
            {

                case "09.02.07":
                    specialization = "ИС";
                    break;

                case "09.02.03":
                    specialization = "П";
                    break;

            }
            return Course + specialization;

        }

        public virtual void Display()
        {
            Console.WriteLine($"Полное имя {Full_Name}, в группе {Group(ToString())}.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Редин Никита", 2, "09.02.03");
            student.Display();



            Console.ReadKey();
        }
    }
}
