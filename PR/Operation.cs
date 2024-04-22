using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Operation
    {
        
        static public void OpTeacher(int secim)
        {
            

           bool _stop=true;
           
                

            if (secim == 1)
            {


                while (_stop)
                {


                    Console.WriteLine("-                                                                            *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Melumat Elave Etmek ucun 1                            *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Melumatlari Gormek ucun 2                             *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Ana Menuya Qayitmaq  Ucun 3                           *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Emeliyyati Bitirmek ucun 0                            *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                          Duymesini  secin                                  *");

                    int msecim = Convert.ToInt32(Console.ReadLine());
                  switch (msecim)
                  {
                    case 1:
                        AddLIstOperations.AddTeacher(); break;

                    case 2:
                            AddLIstOperations.ListTeachers(); break;

                        case 0:
                            _stop = false;
                            break;

                            case 3:
                            Start.PStart();
                            break;
                  }






                }
                





              Console.WriteLine("------------------------------------------------------------------------------");
              Console.WriteLine("|                                                                             |");
              Console.WriteLine("|                     Emeliyyat Ugurla Sona Catdi!                            |");
              Console.WriteLine("|                                                                             |");
              Console.WriteLine("------------------------------------------------------------------------------");





            }

            


        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        static public void OpStudent(int secim)
        {
            
            
            bool _stop = true;

                if (secim == 2)
                {    

                  while (_stop)
                  {


                    Console.WriteLine("-                                                                            *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Melumat Elave Etmek ucun 1                            *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Melumatlari Gormek ucun 2                             *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Ana Menuya Qayitmaq  Ucun 3                           *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                      Emeliyyati Bitirmek ucun 0                            *");
                    Console.WriteLine("*                                                                            *");
                    Console.WriteLine("*                          Duymesini  secin                                  *");
                    int msecim = Convert.ToInt32(Console.ReadLine());
                    switch (msecim)
                    {
                        case 1:
                            AddLIstOperations.AddStudent();
                            break;

                        case 2:
                            AddLIstOperations.ListStudent(); break;
                        case 0:
                            _stop = false;
                            break;
                        case 3:
                           Start.PStart();
                            break;

                    
                    }
                    
                    





                  }
                






                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("|                     Emeliyyat Ugurla Sona Catdi!                            |");
                    Console.WriteLine("|                                                                             |");
                    Console.WriteLine("------------------------------------------------------------------------------");


                }



           








        }




        



    }
}

