using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class School
    {


        public static List<Teacher> teachers = new List<Teacher>();

        public static void AddTeacher()
        {



            Console.WriteLine("Adiniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadiniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Yasiniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            // Yeni bir teacher listi yarat vee Dabavit ele
            teachers.Add(new Teacher { Name = name, Surname = surname, Age=yas });
        }
        public static void ListTeachers()
        {
            
            
            foreach (var teacher in teachers)
            {
                Console.WriteLine("                              Muellim:                            ");
                Console.WriteLine("                                                                   ");
                Console.WriteLine($"      Soyadi: {teacher.Surname}   Adi:{teacher.Name}    Yasi:{teacher.Age}      ");

            }

        }

        public static List<Student> students = new List<Student>();

        public static void AddStudent()
        {



            Console.WriteLine("Adiniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadiniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Yasiniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            students.Add(new Student { Name = name, Surname = surname });
        }
        public static void ListStudent()
        {
           
            foreach (var student in students)
            {   Console.WriteLine("                              Sagird:                            ");
                Console.WriteLine("                                                                   ");
                Console.WriteLine($"   Soyadi: {student.Surname}      Adi:{student.Name}  Yasi:{student.Age}        ");
            }

        }


























    }
}