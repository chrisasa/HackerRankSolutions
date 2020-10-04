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
class Solution {
    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        // int indexOfExcluded = 0;
        int arrLg = arr.Length;
        List<long> allSum = new List<long>();
        for(int indexOfExcluded=0 ; indexOfExcluded<arrLg ; indexOfExcluded++) {
            
            long tmpSum = 0;
            for(int i=0;i<arrLg;i++){
                tmpSum += arr[i];
            }
            long finalSum = tmpSum - arr[indexOfExcluded];
            allSum.Add(finalSum);
        }
        allSum.Sort();
        Console.WriteLine(allSum.First() + " " + allSum.Last());
    }
    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
