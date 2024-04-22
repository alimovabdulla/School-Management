using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class AddLIstOperations:InformationsBase
    {




         

        public static void AddTeacher()
        {

            try
            {

                Console.WriteLine("                                Adiniz:");
                string name = Console.ReadLine();
                Console.WriteLine("                              Soyadiniz:");
                string surname = Console.ReadLine();
                Console.WriteLine("                               Yasiniz:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("                                Sinif:");
                string sinf = Console.ReadLine();





                if (yas < 22)
                {
                    Console.WriteLine("Zehmet olmasa Dogru Melumat qeyd Edin!");
                }
                else if (yas > 75)
                {
                    Console.WriteLine("Zehmet olmasa Dogru Melumat qeyd Edin!");

                }
                else { teachers.Add(new Teacher { Name = name, Surname = surname, Age = yas, Cname = sinf}); }


            }
            catch { Console.WriteLine("Yalnis Emeliyyat!!!"); }


        }
        
        
        
        public static void ListTeachers()
        {


            foreach (var teacher in teachers)
            {
                Console.WriteLine("                                Muellim:                            ");
                Console.WriteLine("                                                                    ");
                Console.WriteLine($"            Soyadi: {teacher.Surname}   Adi:{teacher.Name}    Yasi:{teacher.Age}  Sinif:{teacher.Cname}    ");

            }

        }
              /////////////////////////////////////////////////////////////////////////////////////////////////////////

        

        public static void AddStudent()
        {



           try
           {

                Console.WriteLine("                                Adiniz:");
                string name = Console.ReadLine();
                Console.WriteLine("                              Soyadiniz:");
                string surname = Console.ReadLine();
                Console.WriteLine("                               Yasiniz:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("                                Sinif:");
                string sinf = Console.ReadLine();
                if (yas >= 20)
                {
                    Console.WriteLine("Zehmet olmasa Dogru Melumat qeyd Edin!");
                }
                else if(yas<8)
                {
                    Console.WriteLine("Zehmet olmasa Dogru Melumat qeyd Edin!");
                }
                else
                { students.Add(new Student { Name = name, Surname = surname, Age = yas, Cname = sinf }); Console.WriteLine("Melumat Qeyd Edildi!"); } 
                   


           }
           catch { Console.WriteLine("Yalnis Emeliyyat!!!"); }





            
          
        }
        public static void ListStudent()
        {

            foreach (var student in students)
            {
                
                Console.WriteLine("                                Sagird:                            ");
                Console.WriteLine("                                                                    ");
                Console.WriteLine($"            Soyadi: {student.Surname}   Adi:{ student.Name}    Yasi:{student.Age}  Sinif:{student.Cname}    ");
            }

        }

    }
}
