using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TreePainter_v3_1
{
    class Graph
    {
        LinkedList<int>[] linkedListArray;

        public Graph(int v)
        {
            linkedListArray = new LinkedList<int>[v];
        }

        public void AddEdge(int u, int v)
        {
            if (linkedListArray[u] == null)
            {
                linkedListArray[u] = new LinkedList<int>();
                linkedListArray[u].AddFirst(v);
            }
            else
            {
                var last = linkedListArray[u].Last;
                linkedListArray[u].AddAfter(last, v);
            }

            
        }

        internal void DFSHelper(int src, bool[] visited)
        {
            visited[src] = true;
            Form1._Form1.update(src + " ");
            if (linkedListArray[src] != null)
            {
                foreach (var item in linkedListArray[src])
                {
                    if (!visited[item] == true)
                    {
                        DFSHelper(item, visited);
                    }
                }
            }
        }

        internal void DFS()
        {
            //Form1._Form1.update("Depth First Search(DFS):  ");
            bool[] visited = new bool[linkedListArray.Length + 1];
            DFSHelper(1, visited);

        }

        internal void DFS_with_limit(int limit)
        {
            //Form1._Form1.update("Depth First Search(DFS):  ");
            bool[] visited = new bool[linkedListArray.Length + 1];
            DFSHelper(1, visited);

        }
    }
}
