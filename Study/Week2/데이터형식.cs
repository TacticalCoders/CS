using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class 데이터형식
    {
        static void Main(string[] args)
        {
            //소문자로 시작하는 데이터 타입 -> C#의 데이터 형식
            char c1 = 'a';
            string s1 = "aaa";
            bool b1 = true;

            //대문자로 시작하는 데이터 타입 -> 닷넷 데이터 형식
            Char C2 = 'B';
            String S2 = "BBB"; 
            Boolean B2 = false;

            Console.WriteLine("{0}  {1}  {2}", c1, s1, b1);
            Console.WriteLine("{0}  {1}  {2}", C2, S2, B2);
        }
    }
}
