using System.Text;
using AlgoReview.List;

namespace AlgoReview.Queue;

public class Queue<T>
{
    protected Node<T>? Head { get; set; }
    protected Node<T>? Tail { get; set; }
    
    public void Enqueue(T value)
    {
        var node = new Node<T> { Value = value, Next = null };
        if (Head == null)
        {
            Head = node;
            Tail = node;
            return;
        }
        Tail!.Next = node;
        Tail = node;
    }
    
    public T Dequeue()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var value = Head.Value;
        Head = Head.Next;
        return value;
    }
    
    public T Peek()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return Head.Value;
    }
    
    public bool IsEmpty()
    {
        return Head == null;
    }
    
    public void Clear()
    {
        Head = null;
        Tail = null;
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("[");
        var node = Head;
        while (node != null)
        {
            sb.Append(node.Value);
            node = node.Next;
            if (node != null)
            {
                sb.Append(", ");
            }
        }
        sb.Append("]");
        return sb.ToString();
    }
}