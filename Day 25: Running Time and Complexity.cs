using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static bool isPrime(int n){
         if (n <= 1)
            return false;
 
        // Check from 2 to sqrt(n)... no need to check past sqrt
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
 
        return true;
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfLines = Int32.Parse(Console.ReadLine());
        for(int i = 0; i< numberOfLines; i++)
        {
            int input = Int32.Parse(Console.ReadLine());
            if(isPrime(input)==true)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
    }
}
