using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;

namespace Municipality_ST10263992_PROG7312.Tools
{
    public class MinHeap
    {
        private ServiceRequest[] heap;
        private int size;
        private int capacity;

        public MinHeap(int initialCapacity = 16)
        {
            capacity = initialCapacity;
            heap = new ServiceRequest[capacity];
            size = 0;
        }

        public int Count => size;

        private void EnsureCapacity()
        {
            if (size < capacity) return;
            
            capacity *= 2;
            ServiceRequest[] newArr = new ServiceRequest[capacity];
            Array.Copy(heap, newArr, size);
            heap = newArr;
        }

        private void Swap(int i, int j)
        {
            var tmp = heap[i];
            heap[i] = heap[j];
            heap[j] = tmp;
        }

        public void Insert(ServiceRequest req)
        {
            EnsureCapacity();
            heap[size] = req;
            int currentIndex = size;
            size++;
            
            // Bubble up to maintain heap property
            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex - 1) / 2;
                if (heap[parentIndex].Priority <= heap[currentIndex].Priority) break;
                Swap(parentIndex, currentIndex);
                currentIndex = parentIndex;
            }
        }

        public ServiceRequest ExtractMin()
        {
            if (size == 0) return null;

            var min = heap[0];
            heap[0] = heap[size - 1];
            heap[size - 1] = null; // Clear the last element
            size--;

            if (size > 0)
            {
                HeapifyDown(0);
            }
            
            return min;
        }

        public void Remove(ServiceRequest requestToRemove)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (heap[i].Id == requestToRemove.Id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1) return; // Item not found

            // Swap with the last element
            heap[index] = heap[size - 1];
            heap[size - 1] = null;
            size--;

            if (index < size)
            {
                // The swapped element might need to be moved up or down
                int parentIndex = (index - 1) / 2;
                if (index > 0 && heap[index].Priority < heap[parentIndex].Priority)
                {
                    HeapifyUp(index);
                }
                else
                {
                    HeapifyDown(index);
                }
            }
        }

        private void HeapifyDown(int index)
        {
            int smallest = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (leftChild < size && heap[leftChild].Priority < heap[smallest].Priority)
                smallest = leftChild;

            if (rightChild < size && heap[rightChild].Priority < heap[smallest].Priority)
                smallest = rightChild;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void HeapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;
            while (index > 0 && heap[index].Priority < heap[parentIndex].Priority)
            {
                Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }
    }
}
