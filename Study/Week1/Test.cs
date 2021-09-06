using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자열을 입력하세요 :");
            string s = Console.ReadLine(); //입력 매서드
            Console.WriteLine(s);
            Console.WriteLine(); //엔터 기능
            Console.Write("정수 입력 :"); //Write는 줄바꿈이 안됨.
            int n = Console.Read(); //하나의 문자만을 입력받음. 헤당 문자의 아스키코드 값이 반환,
            Console.WriteLine(n); 
            Console.WriteLine();
        }

    }
}
