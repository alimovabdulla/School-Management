using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    class Teacher:Human
    {
         
        
        public int myVar;

	     public int Age
		{
			get { return myVar; }
			set
			{


				if (value > 75||value<22)
				{
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("    Emeliyyat Ugursuzdur Muellimin yasi 22 den az 75 den cox ola bilmez!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
				else { myVar = value;
                    Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                 ------------------------------------           ");
                        Console.WriteLine("                 |    ~  Melumat Qeyd Edildi!  ~    |           ");
                        Console.WriteLine("                 ------------------------------------           ");

                    Console.ForegroundColor = ConsoleColor.White;
                }


                }
            }


       

	}
}

