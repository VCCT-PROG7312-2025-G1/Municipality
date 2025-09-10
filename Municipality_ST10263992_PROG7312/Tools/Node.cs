using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_ST10263992_PROG7312.Tools
{

    /// <summary>
    /// Represents a node in a doubly linked list data structure.
    /// Each node contains a value and references to the next and previous node, within linked list.
    /// </summary>
    /// <typeparam name="T">The type of value stored in the node</typeparam>
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }

        public Node(T value, Node<T> next, Node<T> previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }

}
