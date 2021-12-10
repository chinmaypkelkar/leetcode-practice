using System;

namespace LeetcodePractice
{
    public class BinaryTree
    {
        public  Node Root { get; set; }
        
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return;
            }

            InsertNode(Root, data);
        }

        private void InsertNode(Node root, int data)
        {
            if (data <= root.Value)
            {
                if (root.Left == null)
                {
                    var newNode = new Node(data);
                    root.Left = newNode;
                }
                else
                {
                    InsertNode(root.Left, data);
                }
              

            } else if (data > root.Value)
            {
                if (root.Right == null)
                {
                    var newNode = new Node(data);
                    root.Right = newNode;
                }
                else
                {
                    InsertNode(root.Right, data);
                }
            }
            
        }

        
    }
}