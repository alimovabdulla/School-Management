using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Student:Human
    {






        public int Age
        {
            get { return Age; }
            set
            {

                if (value < 20)
                {
                    Console.WriteLine("Dogru Melumat Qey edin!");
                }
                else
                {


                    Age = value;

                }


            }
        }











    }
}
