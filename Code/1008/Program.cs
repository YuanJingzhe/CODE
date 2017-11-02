using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _1008
{
    //1008 N的阶乘 mod P
    //-------------------------------------------------------------
    //基准时间限制：1 秒 空间限制：131072 KB 分值: 0 难度：基础题 
    //输入N和P（P为质数），求N! Mod P = ? (Mod 就是求模 %)
    //-------------------------------------------------------------
    //例如：n = 10， P = 11，10! = 3628800
    //3628800 % 11 = 10
    //Input
    //两个数N, P，中间用空格隔开。(N< 10000, P< 10^9)
    //Output
    // 输出N! mod P的结果。
    //-------------------------------------------------------------
    //Input示例
    //10 11
    //Output示例
    //10
    class Program
    {
        static void Main(string[] args)
        {
            string twoNum = Console.ReadLine();
            int numOne = int.Parse((twoNum.Split(' '))[0]);
            BigInteger numTwo = BigInteger.Parse((twoNum.Split(' '))[1]);
            BigInteger temp = func(numOne);
            BigInteger a = temp % numTwo;
            Console.WriteLine(a);
            Console.ReadLine();
        }
        private static BigInteger func(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * func(num - 1);
            }
        }
    }
}
