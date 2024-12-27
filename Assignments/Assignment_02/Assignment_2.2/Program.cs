using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    internal class Program
    {

        static void reverseArray(Student []students)
        {
            for (int i = students.Length-1; i >=0; i--) {
                students[i].printInfo();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array of students");
            int size=Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[size];

            for (int i = 0; i < student.Length; i++) {
                student[i].acceptInfo();
            }

            for (int i = 0; i < student.Length; i++) {
                student[i].printInfo();
            }

            Console.WriteLine("After reversing the array");
            Console.WriteLine("----------------------------------------------------------");
            reverseArray(student);
        }
    }
}
