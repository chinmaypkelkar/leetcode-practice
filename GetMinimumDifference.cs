using System;
using System.Collections.Generic;

namespace LeetcodePractice
{
    public class GetMinimumDifference
    {
        public List<int> TreeValues = new List<int>();
        public int minValue = int.MaxValue;
        public int GetMinimum(Node root) {
            Inorder(root);
            for(var i = 0; i < TreeValues.Count; i++){
                minValue = Math.Min(minValue, TreeValues[i+1] - TreeValues[i]);
            }
            return minValue;
        }
    
        private void Inorder(Node root){
            if(root == null)return;
            Inorder(root.Left);
            TreeValues.Add(root.Value);
            Inorder(root.Right);
        }
        
    }
}