using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
        DateTime tm = DateTime.Parse(s);
        // string t = String.Format("{0}:{1}:{2}", tm.Hour,tm.Minute,tm.Minute);
        string rt = tm.ToString("HH:mm:ss");
        
        return rt;
    }
    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string s = Console.ReadLine();
        string result = timeConversion(s);
        tw.WriteLine(result);
        tw.Flush();
        tw.Close();
    }
}
