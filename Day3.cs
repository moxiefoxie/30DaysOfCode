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
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        if(N%2 != 0 || (Enumerable.Range(6,15).Contains(N))) Console.WriteLine("Weird");
        else if (Enumerable.Range(2,4).Contains(N) || (N > 20) ) Console.WriteLine("Not Weird");

    }
}