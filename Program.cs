using System;
using System.Collections.Generic;

namespace LeetcodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var input = new []{4,2,6,1,3};
            var bTree = new BinaryTree();
            foreach (var i in input)
            {
                bTree.Insert(i);
            }
            Console.WriteLine(bTree.Root);
            var test = new BinaryTreePaths().GetBinaryTreePaths(bTree.Root);*/
            //var getDifference = new GetMinimumDifference().GetMinimum(bTree.Root);

            /*var input = new[] {9,8,9};
            var output = (new PlusOne()).DoPlusOne(input);*/

            /*var linkedList = new LinkedList();
            linkedList.Insert(2);
            linkedList.Insert(3);
            linkedList.Insert(4);
            linkedList.Traverse();*/

            /*
            var myHashSet = new MyHashSet();
            myHashSet.Add(1);
            myHashSet.Add(2);
            myHashSet.Add(2);
            myHashSet.Add(3);
            myHashSet.Remove(3);
            myHashSet.PeekSet();
            */

            /*var n = 3;
            var edges = new[]
            {
                new[] {0, 1},
                new[] {1, 2},
                new[] {2, 0}
            };
            var isValidPath = new ValidPath();
            isValidPath.FindValidPath(n, edges, 0, 2);*/

            //var test = new RepeatedSubstring().RepeatedSubstringPattern("abab");

            //var test = new Pallindrome().IsPallindrome("ab!");

            // var input = new List<List<int>>()
            // {
            //     new() {0, 2, 8}
            // };
            // var test = new SortedIterator(input);
            // Console.WriteLine(test.next());
            // Console.WriteLine(test.next());
            // Console.WriteLine(test.next());
            // Console.WriteLine(test.next());

            var s = "";
            var test = new ValidParentheses().IsValid(s);



        }
    }
}