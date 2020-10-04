using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        /*
         * Write your code here.
         */
        int totalPages = n;
        int pageToOpen = p;
        int result = 0;
        var whichHalf = 0;
        if ( (totalPages/2) < pageToOpen) {
            
            whichHalf = 1;
            
            if(totalPages % 2 == 0 ){ totalPages++;}
            result = (totalPages - pageToOpen) /2;
        } else {
            result = pageToOpen/2;
        }
        Console.WriteLine("total pages  =  " + totalPages);
        Console.WriteLine("page  =  " + pageToOpen);
        Console.WriteLine("result =  " + result);
        return result;
    }
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = pageCount(n, p);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
