using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PR.Qiymet;

namespace PR
{
    internal class AddLIstOperations:InformationsBase
    {



        


        public static void AddTeacher()
        {
            int count = 1;
            Teacher teacher = new Teacher();
            try
            {

                Console.WriteLine("                                 Adi:");
                string name = Console.ReadLine();
                Console.WriteLine("                               Soyadi:");
                string surname = Console.ReadLine();
                Console.WriteLine("                                Yasi:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("                                Sinifi:");
                string sinf = Console.ReadLine();
                teachers.Add(new Teacher { Name = name, Surname = surname, Age = yas, Cname = sinf });
                 



            }
            catch
            {
                Console.WriteLine("                 ------------------------------------           ");
                Console.WriteLine("                 |      ~  Yalnis Emeliyyat!  ~     |           ");
                Console.WriteLine("                 ------------------------------------           ");
            }


        }
        
        
        
        public static void ListTeachers()
        {
            int count = 1;

            foreach (var teacher in teachers)
            {
                Console.WriteLine($"                                {count++})                           ");
                Console.WriteLine("                                                                    ");
                Console.WriteLine($"            Soyadi: {teacher.Surname}   Adi:{teacher.Name}    Yasi:{teacher.Age}  Sinif:{teacher.Cname}    ");

            }
            

        }
              /////////////////////////////////////////////////////////////////////////////////////////////////////////

        

        public static void AddStudent()
        {
            string qiy = "1 ";
        int count = 1;

            try
           {

                Console.WriteLine("                                  Adi:");
                string name = Console.ReadLine();
                Console.WriteLine("                                Soyadi:");
                string surname = Console.ReadLine();
                Console.WriteLine("                                 Yasi:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("                                Sinifi:");
                string sinf = Console.ReadLine();
                Console.WriteLine("                                Qiymeti:");
                int quymet = Convert.ToInt32(Console.ReadLine());
                 
                if (Enum.IsDefined(typeof(qiymet), quymet))
                {
                    qiymet q = (qiymet)quymet;
                    qiy = q.ToString();
                    
                }
                else if ((quymet > 6 || quymet < 2))
                {
                    Console.WriteLine("                     Yalnis Qiymet qeyd ettiniz!!! ");
                }
                else
                {

                   students.Add(new Student { Name = name, Surname = surname, Age = yas, Cname = sinf, _Qiymet = qiy });

                }
               
                 



            }
           catch
            {
                Console.WriteLine("                 ------------------------------------           ");
                Console.WriteLine("                 |      ~  Yalnis Emeliyyat!  ~     |           ");
                Console.WriteLine("                 ------------------------------------           ");


            }





            
          
        }
        public static void ListStudent()
        {int count = 1;

            foreach (var student in students)
            {

                Console.WriteLine($"                                  {count++})                           ");
                Console.WriteLine("                                                                    ");
                Console.WriteLine($"      Soyadi: {student.Surname}   Adi: { student.Name}    Yasi: {student.Age}  Sinif: {student.Cname} Qiymeti: {student._Qiymet}    ");
            }

        }

    }
}
