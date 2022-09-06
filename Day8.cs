using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfLines = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string lineCon;
        while ((lineCon = Console.ReadLine()) != null && lineCon != "") 
        {
            var lineContent = lineCon.Trim().Split(' ');
            if(lineContent.Length >1)
                phonebook[lineContent[0].ToString()] = lineContent[1].ToString();
            else
            {
                string number = ""; 
                if(phonebook.TryGetValue(lineContent[0], out number))
                    Console.WriteLine(lineContent[0] + "=" + number);
                else    
                    Console.WriteLine("Not found");
            }
        }
    }
}
