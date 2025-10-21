using System;
using System.Collections.Generic;

namespace Municipality_ST10263992_PROG7312.Tools
{
    public class AdjNode
    {
        public int Vertex;
        public int Weight; // distance / cost
        public AdjNode Next;
        public AdjNode(int vertex, int weight) { Vertex = vertex; Weight = weight; Next = null; }
    }

    public class Graph
    {
        private AdjNode[] adjacency;
        private int vCount;

        public Graph(int vertices)
        {
            vCount = vertices;
            adjacency = new AdjNode[vertices];
            for (int i = 0; i < vertices; i++) adjacency[i] = null;
        }

        public void AddEdge(int src, int dest, int weight = 1, bool undirected = true)
        {
            var node = new AdjNode(dest, weight) { Next = adjacency[src] };
            adjacency[src] = node;
            if (undirected)
            {
                var rev = new AdjNode(src, weight) { Next = adjacency[dest] };
                adjacency[dest] = rev;
            }
        }

        public void BFS(int start, Action<int> action)
        {
            bool[] visited = new bool[vCount];
            var queue = new SimpleQueueInt(vCount);
            visited[start] = true;
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int u = queue.Dequeue();
                action(u);
                AdjNode n = adjacency[u];
                while (n != null)
                {
                    if (!visited[n.Vertex])
                    {
                        visited[n.Vertex] = true;
                        queue.Enqueue(n.Vertex);
                    }
                    n = n.Next;
                }
            }
        }

        public void DFS(int start, Action<int> action)
        {
            bool[] visited = new bool[vCount];
            DFSRec(start, visited, action);
        }

        private void DFSRec(int u, bool[] visited, Action<int> action)
        {
            visited[u] = true;
            action(u);
            AdjNode n = adjacency[u];
            while (n != null)
            {
                if (!visited[n.Vertex]) DFSRec(n.Vertex, visited, action);
                n = n.Next;
            }
        }

        public (int totalWeight, List<(int u, int v, int w)> edges) PrimMST()
        {
            int V = vCount;
            if (V == 0) return (0, new List<(int u, int v, int w)>());

            int[] key = new int[V];
            bool[] inMST = new bool[V];
            int[] parent = new int[V];
            for (int i = 0; i < V; i++) { key[i] = int.MaxValue; inMST[i] = false; parent[i] = -1; }
            
            key[0] = 0;
            
            for (int count = 0; count < V - 1; count++)
            {
                int u = -1;
                int min = int.MaxValue;
                for (int v = 0; v < V; v++)
                {
                    if (!inMST[v] && key[v] < min)
                    {
                        min = key[v];
                        u = v;
                    }
                }
                
                if (u == -1) break;
                
                inMST[u] = true;
                
                AdjNode n = adjacency[u];
                while (n != null)
                {
                    int v = n.Vertex;
                    if (!inMST[v] && n.Weight < key[v])
                    {
                        key[v] = n.Weight;
                        parent[v] = u;
                    }
                    n = n.Next;
                }
            }

            int total = 0;
            var edgeList = new List<(int u, int v, int w)>();
            for (int i = 1; i < V; i++)
            {
                if (parent[i] != -1)
                {
                    int w = 0;
                    AdjNode n = adjacency[i];
                    while (n != null)
                    {
                        if (n.Vertex == parent[i])
                        {
                            w = n.Weight;
                            break;
                        }
                        n = n.Next;
                    }
                    total += w;
                    edgeList.Add((parent[i], i, w));
                }
            }
            return (total, edgeList);
        }
    }

    public class SimpleQueueInt
    {
        private int[] arr;
        private int front = 0, rear = 0, count = 0;
        public SimpleQueueInt(int capacity = 64) { arr = new int[capacity]; }
        public void Enqueue(int x) { if (count == arr.Length) Resize(); arr[rear++] = x; if (rear == arr.Length) rear = 0; count++; }
        public int Dequeue() { if (count == 0) throw new InvalidOperationException("Queue is empty."); int val = arr[front++]; if (front == arr.Length) front = 0; count--; return val; }
        public int Count => count;
        private void Resize()
        {
            var newArr = new int[arr.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newArr[i] = arr[(front + i) % arr.Length];
            }
            arr = newArr;
            front = 0; rear = count;
        }
    }
}
