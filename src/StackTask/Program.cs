using System;

namespace StackTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new STACK<char>();
            stack.Push('r');
            stack.Push('b');
            stack.Push('q');
            stack.Pop();
            stack.Push('h');
            // stack.Clear();
            stack.Print();
        }
    }
}

public class STACK<T> 
{
    public class Node<T>
    {
        public Node<T> next = null;
        public T data;
    }

    private Node<T> root = null;

    public bool Any()
    {
        return root != null;
    }

    public Node<T> Peek
    {
        get
        {
            return root;
        }
    }

    public void Push(T value)
    {
        var node = new Node<T>();
        node.data = value;
        node.next = this.root;
        this.root = node;
    }

    public Node<T> Pop()
    {
        var peek = this.root;

        if (this.root != null) this.root = this.root.next;

        return peek;
    }

    public void Clear()
    {
        this.root = null;
    }

    public void Print()
    {
        if (!this.Any()) return;

        var node = this.root;
        while (node != null)
        {
            Console.Write(node.data + " ");
            node = node.next;
        }
        
    }
}