using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;  //名称空间

namespace 完数_framwork_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*===============================
             这是一个求完数的程序
            ===============================*/
            // n=6
            // n=496
            // n=8128
            // n=33550336;
            // n=8589869056; 
            Stopwatch sw = new Stopwatch();//计时用
            sw.Start();

            long s,i;
            byte k;
            const long n = 8589869056; //             n = 8589869056;
            s = 0; //求和
            k = 0; //换行计数，每6个数一行 
            i = 1; //循环累加用

            long Sec;//秒数。
            
            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    s += i;
                    k ++;
                    Console.Write("{0,12:d}",i); //用end=' '方式不换行
                    if (k % 6 == 0)
                    {
                        Console.Write("\n");        // #换行
                    }                        
                }
                i ++;
            }
               
            if (s == n)
            {
                 Console.Write("\n\n {0,12:d} 是完数\n",n);
            }
            else
            {
               Console.Write("\n\n {0,12:d} 不是完数\n",n); 
            }

            sw.Stop();
            Sec = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine("\n 计算一共花了{0}秒", Sec.ToString());
            Console.WriteLine("按任意键结束");
            Console.ReadKey();
            
        }
    }
}
