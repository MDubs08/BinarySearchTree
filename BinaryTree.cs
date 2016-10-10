using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node root;

        public void RootInsert(int treeBranch)
        {
            if (root != null)
            {
                root.InsertData(treeBranch);
            }
            else
            {
                root = new Node(treeBranch);
            }
        }

        public void Search(int treeBranch)
        {
            root.SearchTree(treeBranch);
        }
        public void Display()
        {
            if (root != null)
            {
                root.Display();
            }
            else
            {
                Console.WriteLine("Tree is empty");
            }
        }
    }
}
