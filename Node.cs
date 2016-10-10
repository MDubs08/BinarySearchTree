using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node rightBranch;
        public Node leftBranch;
        public Node(int treeBranch)
        {
            data = treeBranch;
            rightBranch = null;
            leftBranch = null;
        }
        public void InsertData(int treeBranch)
        {
            if (data > treeBranch)
            {
                InsertBranchLeft(treeBranch);
            }
            else if (data < treeBranch)
            {
                InsertBranchRight(treeBranch);
            }
        }
        public void InsertBranchLeft(int treeBranch)
        {
            if (leftBranch != null)
            {
                leftBranch.InsertData(treeBranch);
            }
            else
            {
                leftBranch = new Node(treeBranch);
            }
        }
        public void InsertBranchRight(int treeBranch)
        {
            if (rightBranch != null)
            {
                rightBranch.InsertData(treeBranch);
            }
            else
            {
                rightBranch = new Node(treeBranch);
            }
        }

        public void SearchTree(int treeBranch)
        {

            if (data == treeBranch)
            {
                Console.WriteLine("Tree contains {0}", treeBranch); ;
            }
            else if (data > treeBranch)
            {
                SearchTreeBranch(leftBranch, treeBranch);
            }
            else if (data < treeBranch)
            {
                SearchTreeBranch(rightBranch, treeBranch);
            }

        }
        public void SearchTreeBranch(Node leaf, int treeBranch)
        {
            if (leaf != null)
            {
                leaf.SearchTree(treeBranch);
            }
            else
            {
                Console.WriteLine("Tree does not contain {0}", treeBranch);
            }
        }

        public void Display()
        {

            LeafDisplay(leftBranch);
            Console.Write("{0} ", data);
            LeafDisplay(rightBranch);

        }
        public void LeafDisplay(Node leaf)
        {
            if (leaf != null)
            {
                leaf.Display();
            }
            else
            {
                Console.Write("");
            }
        }
    }
}
