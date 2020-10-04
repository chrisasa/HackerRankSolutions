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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static int pickingNumbers(List<int> a)
    {
        int result = 0; 
        a.Sort();
        List<int> d = a.Distinct().ToList();
        a.ForEach(x => Console.Write(" - " + x));
        d.ForEach(x => Console.WriteLine("DST->" + x));
        int lgn = 0; 
        
        if(d.Count == 1){
            return a.Count;
        }

        foreach(int t in d){
            int cnt = a.Count(str => (str == t) );
            if(cnt>lgn){lgn=cnt;}
        }


        for(int i=0; i < d.Count; i++) {
            int tmp = d.ElementAt(i);
            int tmpNext = d.ElementAtOrDefault(i+1);
            // int tmpNext = d.ElementAtOrDefault(101);
            int tmpAbs = Math.Abs(tmp-tmpNext);
            if(tmpAbs<=1){
                int tmpCount = a.Count(str => (str == tmp) );
                int tmpNxtCount = a.Count(str => (str == tmpNext) );
                int tmpSum = tmpCount + tmpNxtCount;
                
                Console.WriteLine("> " + tmp);
                Console.WriteLine("> " + tmpNext);
                Console.WriteLine(">>> " + tmpSum);
                if(lgn < tmpSum) {
                    lgn = tmpSum;
                }
                Console.WriteLine("==============>>> " + lgn);
            }


        }
        result = lgn;



        return result; 
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int result = Result.pickingNumbers(a);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
