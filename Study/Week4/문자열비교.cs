using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "kbs";
            //string s2 = "kbs"; 
            //s1==s2 -> true 


            string[] s1 = new string[] { "kbs" };
            string[] s2 = new string[] { "kbs" };
            //s1 == s2 -> false
            

            if (s1 == s2)
            {
                Console.WriteLine("s1과 s2 는 같다");
            }
            else
            {
                Console.WriteLine("s1과 s2 는 다르다");
            }
        }

    }

}
