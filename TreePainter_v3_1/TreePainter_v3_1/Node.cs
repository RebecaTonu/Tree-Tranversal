using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreePainter_v3_1
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
}
