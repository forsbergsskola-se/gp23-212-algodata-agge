namespace TurboCollections;

public class TurboBinarySearchTree<T> where T:IComparable<T>
{
    class Node
    {
        private T value;
        private Node left;
        private Node right;
        
        public Node(T value)
        {
            this.value = value;
        }

        public void Insert(T val)
        {
            Node sideNode = val.CompareTo(left.value) < 1? left : right;

            if (sideNode == null)
                sideNode = new Node(val);
            else
            {
                sideNode.left.Insert(val);
            }
        }
        
    }
    
    
    
    

}