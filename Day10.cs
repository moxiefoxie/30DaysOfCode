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
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string binary = Convert.ToString(n, 2);
        char lastchar = '0';
        int maxcount = 0;
        int currentcount = 0;
        foreach(char x in binary)
        {
            if (x == lastchar)
            {
                if(x == '1')
                    currentcount++;
            }
            else
            {
                lastchar = x; 
                if(lastchar == '1')
                    currentcount = 1;   
            }
            if(maxcount < currentcount)
                maxcount = currentcount;
        }
        Console.WriteLine(maxcount);
    }
}
