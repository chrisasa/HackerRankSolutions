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
    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int rt = 0;
        List<int> sckList = ar.ToList();
        
        sckList.Sort();
        int tmpCurrent = sckList.First();
        int counter = 0;
        sckList.ForEach(Console.WriteLine);
        foreach(int sock in sckList){
            
            // Console.WriteLine(sock);
            Console.WriteLine("counter is = " + counter);
            
            if(sock == tmpCurrent){
                // Console.WriteLine(sock + "   " +tmpCurrent);
                counter++;
                if (counter == 2){
                    rt++;
                    counter=0;
                }
            
            } else {
                // int pairsN = counter / 2;
                // Console.WriteLine("===== Number of pairs = " +pairsN); 
                
                // rt += pairsN;
                
                tmpCurrent = sock;
                counter=1;
            }
            Console.WriteLine("===== Number of pairs = " +rt); 



            // if(sock == tmpCurrent){
            //     Console.WriteLine(sock + "   " +tmpCurrent);
            //     counter++;
            // } else {
            //     int pairsN = counter / 2;
            //     Console.WriteLine("===== Number of pairs = " +pairsN); 
                
            //     rt += pairsN;
            //     tmpCurrent = sock;
            //     counter=1;
            // }
        }
        // rt = cnt ^ 2;
        return rt;
    }
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
