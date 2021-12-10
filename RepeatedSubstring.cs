using System.Collections.Generic;

namespace LeetcodePractice
{
    public class RepeatedSubstring
    {
        public bool RepeatedSubstringPattern(string s)
        {
            var length = s.Length;
            for(var i = length/2;i>=1;i--){
                if(length % i != 0) continue;
                var m = length / i;
                var substring = s.Substring(0,i);
                var j = 1;
                while(j<m){
                    if(!string.Equals(substring, s.Substring(i*j, i))){
                        break;
                    }  
                    j++;
                }
           
            
                if(j == m){
                    return true;
                }
            
            }
        
            return false;
        }
        
        

    }
}