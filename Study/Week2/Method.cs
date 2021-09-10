using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class Method
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            //int tot = a + b;
            //Console.WriteLine("a + b = {0}", tot);
            int hap = Plus.Sum(a, b);
            Console.WriteLine("a + b = {0}", hap);
        }

        //public class Plus {
        //    public static int Sum(int c, int d)
        //    {
        //        int tot = c + d;
        //        return tot;
        //    }
        //}
        //같은 클래스 내에서는 public, private 상관 없음.
        
    }
}
