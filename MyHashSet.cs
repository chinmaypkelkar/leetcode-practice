namespace LeetcodePractice
{
    public class MyHashSet
    {
        private LinkedList LinkedList;
        public MyHashSet()
        {
            LinkedList = new LinkedList();
        }
    
        public void Add(int key) {
            if (!LinkedList.Contains(key))
            {
                LinkedList.Insert(key);
            }
        }
    
        public void Remove(int key) {
            LinkedList.Remove(key);
        }
    
        public bool Contains(int key)
        {
            return LinkedList.Contains(key);
        }
        
        public void PeekSet()
        {
            LinkedList.Traverse();
        }
    }
}