using  System;
using  System.Collections.Generic;

namespace PhoneNumber{
    public class Solution{
        public IList<string> Combinations(string digits){
            string[] dict = {
                null, null, "abc", "def", "ghi", "jkl", "mno",
                "pqrs", "suv", "wxyz"
            };
                
            var result = new List<string>();
            if (string.IsNullOrEmpty(digits)) return result;
            var q = new Queue<string>();
            q.Enqueue(string.Empty);
            while (q.Count>0 ){
                var cur = q.Dequeue();
                if (cur.Length == digits.Length) 
                    result.Add(cur);
                else
                    foreach (var c in dict[digits [cur.Length] - '0']){
                        q.Enqueue( cur + c);
                    }
            }
            return result;
        }
        
    }
}