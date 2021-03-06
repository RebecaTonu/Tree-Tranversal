using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreePainter_v3_1
{
    public class BinaryTree
    {

        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        /* Given a binary tree, print its nodes in inorder*/
        void printInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.Write(node.key + " ");

            /* now recur on right child */
            printInorder(node.right);
        }

        // Wrappers over above recursive functions 
        void printInorder()
        {
            printInorder(root);
        }


    }
}
