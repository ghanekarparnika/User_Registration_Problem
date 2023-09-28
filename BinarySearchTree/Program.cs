// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using BinarySearchTree;

public class Program
{
    public static void Main(string[] args)
    {
        /*Tree tree = new Tree();
        tree.Insert(56);
        tree.Insert(30);
        tree.Insert(70);

        Console.WriteLine("preOrder Transversal : Root-left-right");
        tree.Display(tree.ReturnRoot());
        Console.WriteLine("Post transversal : left-right-root");
        tree.Post(tree.ReturnRoot());
        Console.WriteLine("Inorder transversal : left-root-right");
        tree.InOrdet(tree.ReturnRoot());*/


        BinarySearchTree<int> bst = new BinarySearchTree<int>();
        bst.Add(56);
        bst.Add(30);
        bst.Add(70);
        bst.Add(63);

        Console.WriteLine("Binary Search Tree:");
        bst.Display();


        bool found = bst.Search(63);
        Console.WriteLine("\nKey 63 found: " + found);

    }

}