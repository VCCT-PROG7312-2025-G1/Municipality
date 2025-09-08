using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Tools
{
    internal class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }

            Count++;
        }

        public void RemoveLast()
        {
            if (Tail == null)
                return;

            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }

            Count--;
        }

        public void RemoveFirst()
        {
            if (Head == null)
                return;

            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }

            Count--;
        }

        public void Remove(T value)
        {
            if (Head == null)
                return;

            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    if (currentNode.Previous != null)
                        currentNode.Previous.Next = currentNode.Next;
                    else
                        Head = currentNode.Next;

                    if (currentNode.Next != null)
                        currentNode.Next.Previous = currentNode.Previous;
                    else
                        Tail = currentNode.Previous;

                    Count--;
                    return;
                }
                currentNode = currentNode.Next;
            }
        }

        public Node<T> GetNodeAt(int index)
        {
            if (index < 0 || index >= Count)
                return null;

            Node<T> currentNode = Head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.Next;

            return currentNode;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
