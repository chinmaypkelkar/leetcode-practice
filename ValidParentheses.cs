using System.Collections.Generic;

namespace LeetcodePractice
{
    public class ValidParentheses
    {
        public bool IsValid(string s) {
            var endParentheses = ")}]";
            var stack = new Stack<char>();
            var dictionary = new Dictionary<char, char>()
            {
                {'{','}'},
                {'[',']'},
                {'(',')'},
            };
            foreach (var ch in s)
            {
                if (!endParentheses.Contains(ch))
                {
                    stack.Push(ch);
                    continue;
                }

                if (stack.Count == 0  || stack.Count > 0 && dictionary[stack.Pop()] != ch)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        
        }
    }
}