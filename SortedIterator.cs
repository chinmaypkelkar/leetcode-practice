using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodePractice
{ 
    public class SortedIterator
    {
        private readonly List<int> _output = new();
        private static int _globalpointer;
        private static int _counter = 0;

        public SortedIterator(IReadOnlyCollection<List<int>> input )
        {
            _output.AddRange(input.SelectMany(x=>x));
            _output.Sort();
            _globalpointer = _output.Count;
        }
        public bool HasNext()
        {
            return _counter < _globalpointer;
        }

        public int Next()
        {
            if (HasNext())
            {
                var test =   _output[_counter++];
                return test;

            }

            return -1;
        }
    }
}