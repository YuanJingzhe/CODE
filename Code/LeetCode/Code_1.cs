﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //给定一个整数数组和一个目标值，找出数组中和为目标值的两个数。

    //你可以假设每个输入只对应一种答案，且同样的元素不能被重复利用。

    //示例:

    //给定 nums = [2, 7, 11, 15], target = 9

    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回[0, 1]
    class Code_1
    {
        public static void Run() {
            Console.WriteLine("请输入数组长度：");
            int n = int.Parse(Console.ReadLine());
          int[]  nums = new int[n];
            Console.WriteLine("请输入数组元素：");
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("请输入目标和");
            int target = int.Parse(Console.ReadLine());

           var result= TwoSum(nums, target);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static  int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
