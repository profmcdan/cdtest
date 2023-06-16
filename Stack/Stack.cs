using System.Text;
using AlgoReview.List;

namespace AlgoReview.Stack;

public class Stack<T>
{
    private Node<T>? Head { get; set; }
    
    public void Push(T value)
    {
        var node = new Node<T> { Value = value, Next = null };
        if (Head == null)
        {
            Head = node;
            return;
        }
        node.Next = Head;
        Head = node;
    }

    public T Pop()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        var value = Head.Value;
        Head = Head.Next;
        return value;
    }
    
    public T Peek()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Stack is empty");
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
    }

    public int EvaluatePostfixExpression(string exp)
    {
        Stack<int> stack = new Stack<int>();
        char character;
        int x, y;
        //1.Scan expression character by character,
        //2.If character is a number push it in stack
        //3.If character is operator then pop two elements from stack
        //perform the operation and put the result back in stack
        //At the end, Stack will contain result of whole expression.
        for (var i = 0; i < exp.Length; i++)
        {

            character = exp[i];

            if (!Char.IsDigit(character))
            {
                x = stack.Pop();
                y = stack.Pop();
                switch (character)
                {
                    case '+':
                        stack.Push(y + x);
                        break;
                    case '-':
                        stack.Push(y - x);
                        break;
                    case '*':
                        stack.Push(y * x);
                        break;
                    case '/':
                        stack.Push(y / x);
                        break;
                }
            }
            else
                stack.Push(character - '0');

        }
        return stack.Pop();
    }
    
    public bool IsBalanced(string exp)
    {
        Stack<char> stack = new Stack<char>();
        char character;
        for (var i = 0; i < exp.Length; i++)
        {
            character = exp[i];
            if (character == '(' || character == '{' || character == '[')
            {
                stack.Push(character);
            }
            else if (character == ')' || character == '}' || character == ']')
            {
                if (stack.IsEmpty())
                {
                    return false;
                }
                var top = stack.Pop();
                if (character == ')' && top != '(')
                {
                    return false;
                }
                if (character == '}' && top != '{')
                {
                    return false;
                }
                if (character == ']' && top != '[')
                {
                    return false;
                }
            }
        }
        return stack.IsEmpty();
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