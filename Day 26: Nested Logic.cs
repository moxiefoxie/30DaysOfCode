using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int getMonthsDifference(DateTime date1, DateTime date2) {
        return ((date1.Year - date2.Year) * 12) + date1.Month - date2.Month;
    }
    static int calculateFine(List<string> returnedDate, List<string> dueDate){
        int fine = 0;
        int retDay = Int32.Parse(returnedDate[0]);
        int retMonth = Int32.Parse(returnedDate[1]);
        int retYear = Int32.Parse(returnedDate[2]);
        DateTime returnDt = new DateTime(retYear, retMonth, retDay);
        
        int dueDay = Int32.Parse(dueDate[0]);
        int dueMonth = Int32.Parse(dueDate[1]);
        int dueYear = Int32.Parse(dueDate[2]);
        DateTime dueDt = new DateTime(dueYear, dueMonth, dueDay);
        
        if(returnDt <= dueDt)
            return fine;
        if(returnDt.Month == dueDt.Month && returnDt.Year == dueDt.Year)
            fine = 15 * (int)(returnDt - dueDt).TotalDays;
        else if(returnDt.Year == dueDt.Year)
            fine = (int)500 * getMonthsDifference(returnDt, dueDt);
        else
            fine = 10000;
        
        return fine;
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<string> returnedDate = Console.ReadLine().Split(' ').ToList();
        List<string> dueDate = Console.ReadLine().Split(' ').ToList();
        Console.WriteLine(calculateFine(returnedDate, dueDate));
    }
}
