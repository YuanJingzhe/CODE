using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    class Program
    {

        //最长公共子序列Lcs
        //-------------------------------------------------------------------------
        //基准时间限制：1 秒 空间限制：131072 KB 分值: 0 难度：基础题 
        //给出两个字符串A B，求A与B的最长公共子序列（子序列不要求是连续的）。
        //比如两个串为：
        //abcicba
        //abdkscab
        //ab是两个串的子序列，abc也是，abca也是，其中abca是这两个字符串最长的子序列。
        //-------------------------------------------------------------------------
        //Input
        //第1行：字符串A
        //第2行：字符串B
        //(A, B的长度 <= 1000)
        //Output
        //输出最长的子序列，如果有多个，随意输出1个。
        //-------------------------------------------------------------------------
        //Input示例
        //abcicba
        //abdkscab
        //Output示例
        //abca
        static string str1;
        static string str2;
        static int[,] charArray;
        static string[,] flag;
        static string lcsString;
        static string finalString;
        static void Main(string[] args)
        {
             str1 = Console.ReadLine();
             str2 = Console.ReadLine();

            charArray=new int[str1.Length+1,str2.Length+1];
            flag = new string[str1.Length + 1, str2.Length + 1];
            LCS(str1, str2);
            SubSequence(str1.Length, str2.Length);
            for (int i = lcsString.Length-1; i >= 0; i--)
            {
                finalString += lcsString[i];
            }
            Console.WriteLine(finalString);
            Console.ReadLine();

        }
        private static void LCS(string str1,string str2) {
            for (int i = 0; i <= str1.Length; i++)
            {
                charArray[i, 0] = 0;
            }

            for (int j = 0; j <= str2.Length; j++)
            {
                charArray[0,j] = 0;
            }

            for (int i = 1; i <=str1.Length; i++)
            {
                for (int j=1;j<=str2.Length;j++)
                {
                    if (str1[i-1] == str2[j-1])
                    {
                        charArray[i, j] = charArray[i - 1, j - 1] + 1;
                        flag[i, j] = "left_up";
                    }
                    else {
                        if (charArray[i - 1, j] >= charArray[i, j - 1])
                        {
                            charArray[i, j] = charArray[i - 1, j];
                            flag[i, j] = "left";

                        }
                        else {
                            charArray[i, j] = charArray[i, j - 1];
                            flag[i, j] = "up";

                        }
                    }
                }
            }
        }

        static void SubSequence(int i, int j)
         {
             if (i == 0 || j == 0)
                 return;
 
             if (flag[i, j] == "left_up")
             {
               
                //把子序列存入一个string中
                lcsString += str2[j - 1];
                 //左前方
                 SubSequence(i - 1, j - 1);
             }
             else
             {
                 if (flag[i, j] == "up")
                 {
                     SubSequence(i, j - 1);
                 }
                 else
                 {
                     SubSequence(i - 1, j);
                 }
             }
         }
    }
}
