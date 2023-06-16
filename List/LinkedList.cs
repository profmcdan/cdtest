using System.Text;

namespace AlgoReview.List;

public class LinkedList<T>
{
    public Node<T> Root { get; private set; }
    
    public (Node<T>? previous, Node<T>? current) FindFirst(T value)
    {
        Node<T>? previous = null;
        Node<T>? current = Root;
        while (current != null)
        {
            if (current.Value != null && current.Value.Equals(value))
            {
                return (previous, current);
            }
            previous = current;
            current = current.Next;
        }
        return (null, null);
    }
    
    public Node<T> AddAfter(Node<T> node, T value)
    {
        Node<T> newNode = new Node<T> { Value = value };
        newNode.Next = node.Next;
        node.Next = newNode;
        return newNode;
    }
    
    public Node<T> Add(T value)
    {
        Node<T> newNode = new Node<T> { Value = value };
        if (Root == null)
        {
            Root = newNode;
        }
        else
        {
            Node<T> current = Root;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        return newNode;
    }
    
    public bool DeleteAfter(Node<T> node)
    {
        if (node.Next == null)
        {
            return false;
        }
        node.Next = node.Next.Next;
        return true;
    }
    
    public bool DetectLoop()
    {
        Node<T>? slow = Root;
        Node<T>? fast = Root;
        while (fast != null && fast.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;
            if (slow == fast)
            {
                return true;
            }
        }
        return false;
    }
    
    public Node<T> FindMiddleNode()
    {
        var slow = Root;
        var fast = Root;
        while (fast != null && fast.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;
        }
        return slow!;
    }
    
    public Node<T> GetNthNodeFromEnd(int n)
    {
        Node<T>? current = Root;
        Node<T>? nth = Root;
        for (int i = 0; i < n; i++)
        {
            if (current == null)
            {
                return null!;
            }
            current = current.Next;
        }
        while (current != null)
        {
            current = current.Next;
            nth = nth!.Next;
        }
        return nth!;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        Node<T>? current = Root;
        while (current != null)
        {
            sb.Append(current.Value);
            sb.Append(" -> ");
            current = current.Next;
        }
        sb.Append("null");
        return sb.ToString();
    }
}