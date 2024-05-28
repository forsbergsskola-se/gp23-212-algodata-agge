using System.Collections;

namespace TurboCollections;

public class TurboBinarySearchTree<T> : IEnumerable<T> where T:IComparable<T>
{

    public Node? root;
    
    public class Node
    {
        public T value;
        public Node left;
        public Node right;
        public Node parent;
        
        public Node(T value, Node parent)
        {
            this.value = value;
            this.parent = parent;
        }

        public bool HasChildren()
        {
            return left != null || right != null;
        }

        public bool IsLeftChild()
        {
            return parent.left == this;
        }
        
        public Node GetSingleChild()
        {
            return left != null? left : right;
        }

        public Node GetChildOfLowestValue()
        {
            if (left == null)
                return this;

            return left.GetChildOfLowestValue();
        }
        
        
        public void InsertInto(ref Node child, T val)
        {
            if (child == null)
                child = new Node(val, this);
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
       

        public Node GetNode(T val)
        {
            if (value.Equals(val))
                return this;
            
            if (left != null && val.CompareTo(value) < 1)
                    return left.GetNode(val);
            else if(right != null)
                return right.GetNode(val);

            return null;
        }
        
    }

    public void Insert(T val)
    {
        if (root != null)
            root.Insert(val);
        else
            root = new Node(val, null);
    }


    public bool Search(T val)
    {
        return root.GetNode(val) != null;
    }
    
    public bool Delete(T val)
    {
        Node node = root.GetNode(val);

        if (node == null)
            return false;

        if (node.left == null && node.right == null)
        {
            if(node.IsLeftChild())
                node.parent.left = null;
            else
                node.parent.right = null;
        }
        else if (node.left != null && node.right != null)
        {
            Node replacementNode = node.right.GetChildOfLowestValue();
            
            //if replacement node has right child, will insert it again....
            if(replacementNode.right != null)
                node.right.Insert(replacementNode.right.value);
            
            
            //Set parent for replacement node
            if (root != node)
            {
                if(node.IsLeftChild())
                    node.parent.left = replacementNode;
                else
                    node.parent.right = replacementNode;
            }
            else
            {
                root = replacementNode;
            }

            //Attach the old nodes right and left side to the replacement node
            replacementNode.left = node.left;
            if(node.right != replacementNode)
                replacementNode.right = node.right;
        }
        else
        {
            if (node.IsLeftChild())
            {
                node.parent.left = node.GetSingleChild();
            }
            else
            {
                node.parent.right = node.GetSingleChild();
            }
        }
        
        return true;

    }
    
    
    void FindMaxInChild(Node node)
    {
        
    }

    public IEnumerable<T> TraverseInOrder(Node node)
    {
        if(node == null)
            yield break;
        
        foreach (var n in TraverseInOrder(node.left))
            yield return n;

        yield return node.value;
        
        foreach (var n in TraverseInOrder(node.right))
            yield return n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return TraverseInOrder(root).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}