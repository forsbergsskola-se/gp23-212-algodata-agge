namespace TurboCollections;

public class TurboBinarySearchTree<T> where T:IComparable<T>
{
    class Node
    {
        public int value;
        private Node left;
        private Node right;
        
        public Node(int value)
        {
            this.value = value;
        }

        public bool HasEmptyChild()
        {
            return (left == null || right == null);
        }

        public void AddChild(int val)
        {
            if (left != null && left.value < val)
                right.value = left.value;
            
            left = new Node(val);
        }
        
    }
    
    

}