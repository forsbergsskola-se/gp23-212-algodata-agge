namespace TurboCollections;

public class TurboBinarySearchTree<T> where T:IComparable<T>
{

    public Node root;

    public class Node
    {
        public T value;
        private Node left;
        private Node right;
        
        public Node(T value)
        {
            this.value = value;
        }

        public void InsertInto(ref Node child, T val)
        {
            if (child == null)
                child = new Node(val);
            else
                child.Insert(val);
        }
        
        public void Insert(T val)
        {
            if (val.CompareTo(value) < 1)
                InsertInto(ref left, val);
            else
                InsertInto(ref right, val);
            
        }

        public bool CanFindValue(T val)
        {
            if (value.Equals(val))
                return true;
            
            if (val.CompareTo(value) < 1)
                return left.CanFindValue(val);
            else
            {
                return right.CanFindValue(val);
            }
        }
        
    }

    public void Insert(T val)
    {
        if (root != null)
            root.Insert(val);
        else
            root = new Node(val);
    }


    public bool Search(T val)
    {
        return root.CanFindValue(val);
    }
    

}