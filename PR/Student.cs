using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Student:Human
    {




        public string _Qiymet { get; set; }
        public int myVar;

        public int Age
        {
            get { return myVar; }
            set
            {


                if (value > 20 || value < 6)
                {
                    Console.WriteLine("    Emeliyyat Ugursuzdur Sagirdin yasi 20 den cox 6 dan az ola bilmez!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    myVar = value;
                    Console.WriteLine("                 ------------------------------------           ");
                    Console.WriteLine("                 |    ~  Melumat Qeyd Edildi!  ~    |           ");
                    Console.WriteLine("                 ------------------------------------           ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }




    }
}
