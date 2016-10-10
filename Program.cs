using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.RootInsert(13);
            tree.RootInsert(80);
            tree.RootInsert(101);
            tree.RootInsert(1);
            tree.RootInsert(55);
            tree.RootInsert(23);
            tree.RootInsert(72);

            tree.Search(101);
            tree.Search(5);

            tree.Display();

            Console.ReadLine();
        }
    }
}
