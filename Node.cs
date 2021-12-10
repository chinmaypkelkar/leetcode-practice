namespace LeetcodePractice
{
    public class Node
    {
        public Node(int data)
        {
            Value = data;
            Left = null;
            Right = null;
        }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}