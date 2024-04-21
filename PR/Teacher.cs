using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    class Teacher:Human
    {

		public int Age
		{
			get { return Age; }
			set
			{

				if (value <= 22) { Console.WriteLine("Dogru Melumat Qey edin!"); }

				else {Age = value;}



            }
		}





	}
}

