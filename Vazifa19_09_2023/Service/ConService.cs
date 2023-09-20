using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa19_09_2023.Service
{
    public static class ConService
    {
        public static void NewTest()
        {
            Console.WriteLine("Fan nomini kiriting :");
            string subjectname = Console.ReadLine();
            Console.WriteLine("Savolni kiriting :");
            string testDescription = Console.ReadLine();
            Console.WriteLine("A variantni kiriting :");
            string a = Console.ReadLine();
            Console.WriteLine("B variantni kiriting :");
            string b = Console.ReadLine();
            Console.WriteLine("C variantni kiriting :");
            string c = Console.ReadLine();
            Console.WriteLine("D variantni kiriting :");
            string d = Console.ReadLine();
            Console.WriteLine("Tog`ri variantni kiriting (A,B,C,D):");
            string corr = Console.ReadLine();
            var test = new Test(subjectname,testDescription,a,b,c,d,corr);
        }

        public static void Generatsiya() 
        {

            Console.WriteLine("Fan  nomini kiriting :");
            string s = Console.ReadLine();

            Console.WriteLine("Talabalar sonini kiriting :");
            int  a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Testlar sonini kiriting");
            int b = Convert.ToInt32(Console.ReadLine());
            FileWriter.Generatsion(s, a, b);
        }
    }
}
