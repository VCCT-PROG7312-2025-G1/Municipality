using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Tools
{
    /// <summary>
    /// Generic doubly-linked list implementation
    /// </summary>
    internal class LinkedList<T>
    {
        // Reference to the first node in the list
        public Node<T> Head { get; set; }
        // Reference to the last node in the list
        public Node<T> Tail { get; set; }
        // Number of elements in the list
        public int Count { get; private set; }

        /// <summary>
        /// Constructor initializes an empty linked list
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Adds a new node with the specified value at the end of the list
        /// </summary>
        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            if (Head == null) // If list is empty
            {
                Head = newNode;
                Tail = newNode;
            }
            else // Add to the end and update references
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }

            Count++;
        }

        /// <summary>
        /// Removes the last node from the list
        /// </summary>
        public void RemoveLast()
        {
            if (Tail == null)
                return;

            if (Tail.Previous != null) // More than one node
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else // Only one node
            {
                Head = null;
                Tail = null;
            }

            Count--;
        }

        /// <summary>
        /// Removes the first node from the list
        /// </summary>
        public void RemoveFirst()
        {
            if (Head == null)
                return;

            if (Head.Next != null) // More than one node
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else // Only one node
            {
                Head = null;
                Tail = null;
            }

            Count--;
        }

        /// <summary>
        /// Removes the first occurrence of a specific value from the list
        /// </summary>
        public void Remove(T value)
        {
            if (Head == null)
                return;

            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    // Update previous node's next reference
                    if (currentNode.Previous != null)
                        currentNode.Previous.Next = currentNode.Next;
                    else
                        Head = currentNode.Next;

                    // Update next node's previous reference
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

        /// <summary>
        /// Returns the node at the specified index
        /// </summary>
        /// <returns>Node at index or null if index is out of range</returns>
        public Node<T> GetNodeAt(int index)
        {
            if (index < 0 || index >= Count)
                return null;

            Node<T> currentNode = Head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.Next;

            return currentNode;
        }

        /// <summary>
        /// Removes all nodes from the list
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
