using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class 조건연산자
    {
       

        static void Main(string[] args)
        {
            int[] n = new int[3];
            for (int i=0; i< n.Length; i++)
            {
                Console.Write("{0} 하나의 수 입력 : ",i);
                String temp = Console.ReadLine();
                n[i] = int.Parse(temp);
            }

            int max = 0;
            int min = n[0];
            //조건연산자(삼항연산자)
            for(int k = 0; k < n.Length; k++)
            {
                if(n[k] >= max)
                {
                    max = n[k];
                }
                if (n[k] <= min)
                {
                    min = n[k];
                }
            }

            Console.WriteLine("The Max = {0}    The Min = {1}",max,min);
        }
    }
}
