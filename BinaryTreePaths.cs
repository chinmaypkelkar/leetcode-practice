using System.Collections.Generic;
using System.Text;

namespace LeetcodePractice
{
    public class BinaryTreePaths
    {
        public IList<string> GetBinaryTreePaths(Node root) {
            return GetBinaryTreePaths(root, new List<string>(), new StringBuilder());
        }
        
        private IList<string> GetBinaryTreePaths(Node root, IList<string> outputList, StringBuilder output)    {
            if (root is null)
            {
                return outputList;
            }
            if(root.Left is null && root.Right is null){
                output.Append(root.Value);
                outputList.Add(output.ToString());
                return outputList;
            }
            output.Append(root.Value);
            outputList = GetBinaryTreePaths(root.Left,outputList, output);
            outputList = GetBinaryTreePaths(root.Right, outputList, output);
            return outputList;
        
        }

    }
}