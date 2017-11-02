using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011
{
    //1011 最大公约数GCD
    //--------------------------------------------------------------
    //基准时间限制：1 秒 空间限制：131072 KB 分值: 0 难度：基础题 
    //输入2个正整数A，B，求A与B的最大公约数。
    //--------------------------------------------------------------
    //Input
    //2个数A,B，中间用空格隔开。(1<= A,B <= 10^9)
    //Output
    //输出A与B的最大公约数。
    //--------------------------------------------------------------
    //Input示例
    //30 105
    //Output示例
    //15

    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int numOne = int.Parse(inputNum.Split(' ')[0]);
            int numTwo = int.Parse(inputNum.Split(' ')[1]);

            Console.WriteLine(func(numOne,numTwo));
            Console.ReadLine();
        }
        private static int  func(int numOne,int numTwo) {
            int temp = Math.Max(numOne, numTwo);
            numTwo = Math.Min(numOne, numTwo);
            numOne = temp;
            while (numTwo != 0) {
               //numOne = numOne > numTwo ? numOne : numTwo;
                int m = numOne % numTwo;
                numOne = numTwo;
                numTwo = m;
            }
            return numOne;
        }
    }
}
