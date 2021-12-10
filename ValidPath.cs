using System.Collections;
using System.Collections.Generic;

namespace LeetcodePractice
{
    public class ValidPath
    {
        public bool FindValidPath(int n, int[][] edges, int start, int end)
        {
            var input = new bool[n, n];
            var queue = new Queue<int>();
            var visited = new bool[n];
            foreach (var edge in edges)
            {
                input[edge[0], edge[1]] = true;
                input[edge[1], edge[0]] = true;
            }
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                var vertex = queue.Dequeue();
                visited[vertex] = true;
                for (var i = 0; i < n; i++)
                {
                    if (input[vertex, i] && !visited[i])
                    {
                        if (i == end)
                        {
                            return true;
                        }
                        queue.Enqueue(i);
                    }
                }
            }

            return false;
        }
    }
}