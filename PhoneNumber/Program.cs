using System;
using System.IO;

namespace PhoneNumber{
    class Program{
        static void Main(string[] args){
            //var phoneNumber = "45683926";
            var phoneNumber = "456";
            var solution = new Solution();
            var result = solution.Combinations(phoneNumber);
            File.WriteAllLines(@"C:\Temp\output.txt", result);
        }
    }
}