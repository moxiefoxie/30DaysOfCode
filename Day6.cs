using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            string s =Console.In.ReadLine();
            string evens = "";
            string odds = "";
            int x = 0;
            foreach(var letter in s)
            {
                if(x%2 == 0)
                    evens+=letter;
                else
                    odds+=letter;
                x++;
            }
            Console.WriteLine($"{evens} {odds}");
        }
    }
}
