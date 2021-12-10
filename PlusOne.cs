using System.Collections.Generic;
using System.Linq;

namespace LeetcodePractice
{
    public class PlusOne
    {
        public int[] DoPlusOne(int[] digits)
        {
            var inputStack = new Stack<int>();
            var temp = new List<int>();
            var adder = 1;
            var carry = 0;
            foreach (var digit in digits)
            {
                inputStack.Push(digit);
            }

            var top = inputStack.Pop();
            if (top + adder >= 10)              
            {                                   
                temp.Add(0);
                carry = 1;
            }                                   
            else                                
            {                                   
                temp.Add(top + adder);          
            }                                   

        
            
            while (inputStack.TryPop(out top))
            { 
                 if (top + carry >= 10)  
                 {                   
                     temp.Add(0);
                     carry = 1;
                 }                   
                 else                
                 {                   
                     temp.Add(top + carry);
                     carry = 0;
                 }
            }

            if (carry == 1)
            {
                temp.Add(carry);
            }

            return temp.ToArray().Reverse().ToArray();

        }
        
    }
}