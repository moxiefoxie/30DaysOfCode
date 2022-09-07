using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    //extract the hourglasses
    public static List<List<int>> getHourglasses(List<List<int>> pattern)
    {
        int width = 3;
        int height = 3;
        List<int> hourglass = new List<int>();
        List<List<int>> hourglasses = new List<List<int>>();
        for(int i = 0; i<pattern.Count - 2; i++)
        {
            for(int j = 0; j<pattern[i].Count - 2;j++)
            {
                hourglass = new List<int>();
                //extract top
                hourglass.AddRange(pattern[i].GetRange(j, width));
                //extract middle
                hourglass.Add(pattern[i+1][j+1]);
                //extract bottom
                hourglass.AddRange(pattern[i+2].GetRange(j, width));
                hourglasses.Add(hourglass);
            }
        }
        return hourglasses;
    }
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int max = 0;
        var hourglasses = getHourglasses(arr);
            foreach(var hourglass in hourglasses)
            {
                string digits = "";
                foreach(var digit in hourglass)
                {
                    digits += digit;
                }
                int result = digits.ToString().Sum(c => c - '0');
                if(result > max)
                    max = result;
            }
            Console.WriteLine(max);
    }
}
