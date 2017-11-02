using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace LargeNumSum
{

    //大数加法
    //----------------------------------------------------------------------
    //基准时间限制：1 秒 空间限制：131072 KB 分值: 0 难度：基础题 
    //给出2个大整数A, B，计算A+B的结果。
    //----------------------------------------------------------------------
    //Input
    //第1行：大数A
    //第2行：大数B
    //(A, B的长度 <= 10000 需注意：A B有可能为负数）
    //Output
    //输出A + B
    //----------------------------------------------------------------------
    //Input示例
    //68932147586
    //468711654886
    //Output示例
    //537643802472
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            BigInteger largeA = BigInteger.Parse(a);
            BigInteger largeB = BigInteger.Parse(b);

            Console.WriteLine(largeA+largeB);
            Console.ReadLine();
        }

  
    }
}
