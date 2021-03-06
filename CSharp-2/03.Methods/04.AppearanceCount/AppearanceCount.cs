﻿using System;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = Array.ConvertAll(splitInput, int.Parse);
            int x = int.Parse(Console.ReadLine());
            int count = 0;

            XCount(nums, n, x, count);
        }

        static void XCount(int[] nums, int n, int x, int count)
        {
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == x)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
