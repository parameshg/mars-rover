namespace MarsRover.Server.Tools
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public Node(T item)
        {
            Value = item;
        }
    }

    public class CircularLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public Node<T> Current { get; set; }

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = new Node<T>(item);
                Tail = Head;
                Head.Next = Tail;
                Head.Previous = Tail;
                Current = Head;
            }
            else
            {
                var node = new Node<T>(item);
                Tail.Next = node;
                node.Next = Head;
                node.Previous = Tail;
                Tail = node;
                Head.Previous = Tail;
            }
        }

        public void Next()
        {
            Current = Current.Next;
        }

        public void Previous()
        {
            Current = Current.Previous;
        }

        public void GoTo(T item)
        {
            if (!Current.Value.Equals(item))
            {
                var end = Current.Previous;

                while (Current != end)
                {
                    if (Current.Value.Equals(item))
                        break;
                    else
                        Next();

                }
            }
        }
    }
}