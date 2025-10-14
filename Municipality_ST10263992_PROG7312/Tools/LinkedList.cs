using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Tools
{
    /// <summary>
    /// Generic doubly-linked list implementation
    /// </summary>
    internal class LinkedList<T> : IEnumerable<T>
    {
        // Reference to the first node in the list
        public Node<T> First { get; set; }
        // Reference to the last node in the list
        public Node<T> Last { get; set; }
        // Number of elements in the list
        public int Count { get; private set; }

        /// <summary>
        /// Constructor initializes an empty linked list
        /// </summary>
        public LinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        /// <summary>
        /// Adds a new node with the specified value at the end of the list
        /// </summary>
        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            if (First == null) // If list is empty
            {
                First = newNode;
                Last = newNode;
            }
            else // Add to the end and update references
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
            }

            Count++;
        }

        /// <summary>
        /// Removes the last node from the list
        /// </summary>
        public void RemoveLast()
        {
            if (Last == null)
                return;

            if (Last.Previous != null) // More than one node
            {
                Last = Last.Previous;
                Last.Next = null;
            }
            else // Only one node
            {
                First = null;
                Last = null;
            }

            Count--;
        }

        /// <summary>
        /// Removes the first node from the list
        /// </summary>
        public void RemoveFirst()
        {
            if (First == null)
                return;

            if (First.Next != null) // More than one node
            {
                First = First.Next;
                First.Previous = null;
            }
            else // Only one node
            {
                First = null;
                Last = null;
            }

            Count--;
        }

        /// <summary>
        /// Removes the first occurrence of a specific value from the list
        /// </summary>
        public void Remove(T value)
        {
            if (First == null)
                return;

            Node<T> currentNode = First;
            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    // Update previous node's next reference
                    if (currentNode.Previous != null)
                        currentNode.Previous.Next = currentNode.Next;
                    else
                        First = currentNode.Next;

                    // Update next node's previous reference
                    if (currentNode.Next != null)
                        currentNode.Next.Previous = currentNode.Previous;
                    else
                        Last = currentNode.Previous;

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

            Node<T> currentNode = First;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.Next;

            return currentNode;
        }

        /// <summary>
        /// Removes all nodes from the list
        /// </summary>
        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = First;
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
}//GitHub Copilot(2023) Linked Lists Available at: github.com / features / copilot(Accessed: [10/09/2025]).
