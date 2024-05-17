using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TurboCollections;

public class TurboLinkedList<T> : IEnumerable<T> 
{
    class Node {
        public T Value;
        public Node? Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node? first;

    public void Add(T value)
    {
        if (first == null)
        {
            first = new Node(value);
            return;
        }
        var current = first;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node(value);
    }

    public void Remove(T value)
    {
        var current = first;

        if (current!.Value!.Equals(value))
        {
            first = current.Next;
            return;
        }
        
        while (current!.Next != null)
        {
            if (current.Next.Value!.Equals(value))
            {
                current.Next = current.Next.Next;
                return;
            }
            
            current = current.Next;
        }
    }

    public void RemoveAt(int index)
    {
        var current = first!;
        int currentIndex = 0;
        
        if(Count < index)
            return;

        if (currentIndex == index)
        {
            first = current.Next;
            return;
        }
        
        while (current != null)
        {
            currentIndex++;
            
            if (currentIndex == index)
                current.Next = current.Next!.Next;
            
            current = current.Next;
        }
    }

    public void Clear()
    {
        first = null;
    }

    public int Count
    {
        get
        {
            var current = first;
            int count = 0;
            
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }

    public T Peek()
    {
        if (first == null)
            throw new EmptyListException();
        
        return first!.Value;
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        var current = first;
        
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class EmptyListException : Exception
{
    public override string Message => "Error: List is empty";
}