using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class 성적입력1단계s
    {
        static void Main(string[] args)
        {
            Console.Write("학번 입력:");
            int hakbun = int.Parse(Console.ReadLine());
            Console.Write("이름 입력:");
            String name = Console.ReadLine();
            Console.Write("국어 입력:");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("영어 입력:");
            int eng = int.Parse(Console.ReadLine());
            Console.Write("수학 입력:");
            int mat = int.Parse(Console.ReadLine());

            int tot = kor + eng + mat;
            double aver = tot / 3;

            Console.WriteLine("{0} {1}  {2} {3}  {4}  {5} {6:F2} ", hakbun, name, kor, eng, mat, tot, aver);

        }
    }
}
