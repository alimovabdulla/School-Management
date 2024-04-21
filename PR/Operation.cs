using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Operation
    {
        
        static public void OpTeacher(int secim)
        {
            Start();
            void Again()
            {




                Start();
            }

           void Start()
           {
                

            if (secim == 1)
            {

                    Console.WriteLine("********************************************************************");
                    Console.WriteLine("*                                                                  *");
                    Console.WriteLine("*                  Melumat Elave Etmek ucun 1                      *");
                    Console.WriteLine("*                                                                  *");
                    Console.WriteLine("*                  Melumatlari Gormek ucun 2                       *");
                    Console.WriteLine("*                                                                  *");
                    Console.WriteLine("*                     Duymesini  secin                             *");

                int msecim = Convert.ToInt32(Console.ReadLine());
                switch (msecim)
                {
                    case 1:
                        School.AddTeacher(); break;

                    case 2:
                        School.ListTeachers(); break;

                            
                }
                 Again();

                 

            }

           }

        }

        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      

        static public void OpStudent(int secim)
        {
            Start();
            void Again()
            {

                Start();
            }

            void Start()
            {

                if (secim == 2)
                {

                    Console.WriteLine("********************************************************************");
                    Console.WriteLine("*                                                                  *");
                    Console.WriteLine("*                  Melumat Elave Etmek ucun 1                      *");
                    Console.WriteLine("*                                                                  *");
                    Console.WriteLine("*                  Melumatlari Gormek ucun 2                       *");
                    Console.WriteLine("*                                                                  *");
                    Console.WriteLine("*                     Duymesini  secin                             *");
                    int msecim = Convert.ToInt32(Console.ReadLine());
                    switch (msecim)
                    {
                        case 1:
                            School.AddStudent();
                            break;




                        case 2:
                            School.ListStudent(); break;


                    }

                }


                Again();



            }


        }

    }
}

