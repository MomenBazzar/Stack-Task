namespace StackTask
{
    public class Stack<T> 
    {
        public class Node<T>
        {
            public Node<T> Next = null;
            public T Data;
        }

        private Node<T> _root = null;

        public bool Any()
        {
            return _root != null;
        }

        public Node<T> Peek
        {
            get
            {
                return _root;
            }
        }

        public void Push(T value)
        {
            var node = new Node<T>();
            node.Data = value;
            node.Next = this._root;
            this._root = node;
        }

        public Node<T> Pop()
        {
            var peek = this._root;

            if (this._root != null) this._root = this._root.Next;

            return peek;
        }

        public void Clear()
        {
            this._root = null;
        }

        public void Print()
        {
            if (!this.Any()) return;

            var node = this._root;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
        }
    }
}