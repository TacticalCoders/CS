using System;
using System.Collections; //자료구조 관련 클래스
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 스택
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push("첫 번째 오브젝트");
            Console.WriteLine("push()");
            st.Push("두 번째 오브젝트");
            Console.WriteLine("push()");
            st.Push("세 번째 오브젝트");
            Console.WriteLine("push()");

            Console.WriteLine(st.Pop()); ; // 세 번째 출력
            Console.WriteLine(st.Pop()); ; // 두 번째 출력
            Console.WriteLine(st.Pop()); ; // 첫 번째 출력
            Console.WriteLine(st.Pop()); ; // 에러 발생

        }
    }
}
