using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static bool isPrime(int input, int currentDivisor){
        // corner cases
        if (input == 0 || input == 1) {
            return false;
        }
 
        // Checking Prime
        if (input == currentDivisor)
            return true;
 
        // base cases
        if (input % currentDivisor == 0) {
            return false;
        }
        currentDivisor++;
        return isPrime(input, currentDivisor);
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfLines = Int32.Parse(Console.ReadLine());
        for(int i = 0; i< numberOfLines; i++)
        {
            int input = Int32.Parse(Console.ReadLine());
            if(isPrime(input,2)==true)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
    }
}
