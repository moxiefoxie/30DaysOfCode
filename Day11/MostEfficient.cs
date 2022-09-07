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
    public static int getMaxHourglassSum(List<List<int>> pattern)
    {
        int width = 3;
        int matrixwidth = pattern[0].Count;
        int matrixheight = pattern.Count;
        int max = -99;
        List<int> hourglass = new List<int>();
        List<List<int>> hourglasses = new List<List<int>>();
        
        for(int i = 0; i < (matrixwidth-(width-1)) * (matrixheight-(width-1)) ; i++)
        {
         
            // Find row and column index
            int row = i / (matrixheight-(width-1)) ;
            int col = i % (matrixwidth-(width-1)) ;
            hourglass = new List<int>();
            
            //extract top
            hourglass.AddRange(pattern[row].GetRange(col, width));
            //extract middle
            hourglass.Add(pattern[row+1][col+1]);
            //extract bottom
            hourglass.AddRange(pattern[row+2].GetRange(col, width));
            
            int sum = hourglass.Sum();
            if(sum > max)
            {
                max = sum;
            }
        }
        return max;
    }
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();
        //if this took in any number of rows, this would be O(n^3)
        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        Console.WriteLine(getMaxHourglassSum(arr));
    }
}
