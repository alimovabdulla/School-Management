﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Start
    {
        public static void PStart()

        {
            Console.WindowWidth = 79;
            Console.WindowHeight = 40;

            try
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ----------------------------------------------------------------------------");
            Console.WriteLine("|                          School Management                                 |");
            Console.WriteLine(" ----------------------------------------------------------------------------");
            Console.WriteLine("*                           Emeliyyati Secin                                 *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                           1 Muellimler ucun                                *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                           2 Sagirdler ucun                                 *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("**                                                                          **");
            Console.WriteLine("* *                                                                        * *");
            Console.WriteLine("*  *                                                                      *  *");
            Console.WriteLine("*   *                                                                    *   *");
            Console.WriteLine("*    *                                                                  *    *");
            Console.WriteLine("* </> *                                                                * </> *");
            Console.WriteLine("********|                                                            |********");
            int secim = Convert.ToInt32(Console.ReadLine());
            Operation.OpTeacher(secim);
            Operation.OpStudent(secim);

           }
           catch
           {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                    ------------------------------------           ");
                Console.WriteLine("                    |      ~  Yalnis Emeliyyat!  ~     |           ");
                Console.WriteLine("                    ------------------------------------           ");
                PStart();

           }
            



        }

    }
}
