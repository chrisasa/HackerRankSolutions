using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
class Result
{
    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */
    public static int countingValleys(int steps, string path)
    {
        int result = 0; 
        int mountains = 0;
        int valleys = 0; 
        int alt = 0; 
        bool seaLevelFlag = true;
        List<int> stepsIntList = new List<int>();
        foreach(char step in path) {
            if (step == 'U') {
                stepsIntList.Add(1);
            } else {
                stepsIntList.Add(-1);
            }
        }
        foreach(int stNm in stepsIntList){
            
            alt += stNm;
            if(alt > 0 && seaLevelFlag) {
                    
                mountains++;
                
                seaLevelFlag = false;
            } else if (alt<0 && seaLevelFlag) {
                
                valleys++;
                
                seaLevelFlag = false;
            } 
            
            if(alt == 0 ) {
                seaLevelFlag=true;
            }
        }
        result = valleys;
        return result;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int steps = Convert.ToInt32(Console.ReadLine().Trim());
        string path = Console.ReadLine();
        int result = Result.countingValleys(steps, path);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
