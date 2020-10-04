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
    // Complete the encryption function below.
    static string encryption(string s) {
        string rt = "";
        var strWithoutWhiteSpaces = s.Trim();
        bool floorExpandedFlag = false;
        double L = strWithoutWhiteSpaces.Length;
        
        var sqr = Math.Sqrt(L);
        int floor = Convert.ToInt16(Math.Floor(sqr));
        int ceil = Convert.ToInt16(Math.Ceiling(sqr));
        int area = floor * ceil;
        if(!(area>=L)){
            floor++;
            floorExpandedFlag = true;
        }
        int rows = floor; 
        int columns = ceil; 
        string[,] encArr = new string[rows,columns];
        int k = 0;
        char[] tmpStrArr = strWithoutWhiteSpaces.ToArray();
        for(int i =0; i< rows; i++){
            for(int j =0; j< columns; j++){
                
                string st = "";
                if(k<tmpStrArr.Length){
                    st = tmpStrArr.ElementAt(k).ToString(); 
                }
                
                encArr[i,j] = st;
                
                k++;
            }   
        }
        for(int j =0; j< columns; j++) {
            
            string tmp = "";
            for(int i =0; i< rows; i++) {
                
                string tt = encArr[i,j];
                if(!string.IsNullOrEmpty(tt) ) {
                    
                    tmp += tt;
                }
            }
            rt += tmp.Trim() + " ";
        }

        rt = rt.TrimEnd();
        return rt;
    }
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string s = Console.ReadLine();
        string result = encryption(s);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
