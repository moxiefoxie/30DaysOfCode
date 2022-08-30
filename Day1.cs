using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int i2;
        double d2;
        string s2;
        
        // Read and save an integer, double, and String to your variables.
        i2 = Convert.ToInt32(Console.ReadLine().Trim());
        d2 = Convert.ToDouble(Console.ReadLine().Trim());
        s2 = Console.ReadLine().Trim();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i2);
        
        // Print the sum of the double variables on a new line.
        var dSum = String.Format("{0:0.0}", (d+d2));
        Console.WriteLine(dSum);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine($"{s}{s2}");

    }
}
