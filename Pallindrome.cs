using System.Collections.Generic;

namespace LeetcodePractice
{
    public class Pallindrome
    {
        public bool IsPallindrome(string input){ // input = null or empty; input = Race car! 
            var punctuations = new List<char>{' ', '!','@',','};
            if(string.IsNullOrEmpty(input))return true;
    
            input = input.ToLower(); // race car!
            var start = 0;
            var end = input.Length - 1;
            while(start <= end){
                if(punctuations.Contains(input[start])){
                    start++;
                    continue;
                }
                if(punctuations.Contains(input[end])){
                    end--;
                    continue;
                }
                if(input[start] != input[end]){
                    return false;
                }
                start++;
                end--;
            }
            return true;
    
        }
    }
}