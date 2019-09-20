using System;
using System.Collections.Generic;

namespace CharRestructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            CharTool charTool = new CharTool();
            List<string> testStrList = new List<string> { "aab","aaabbcc","aaabb","aaaaabbbcc","aaaaabbc","aaab"};
            Console.WriteLine("Before      After");
            foreach (var testStr in testStrList)
            {
                string afterStr= charTool.ReorganizeString(testStr);
                if (!string.IsNullOrEmpty(afterStr))
                {
                   Console.WriteLine($"{testStr}        {afterStr}");
                }
                else
                {
                    Console.WriteLine($"{testStr}        {afterStr}");
                }
            }            
            Console.WriteLine("Finished!");

            Console.ReadKey();
        }
    }
}
