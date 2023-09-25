// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using BinarySearchTree;

public class Program
{
    public static void Main(string[] args)
    {
        Tree tree = new Tree();
        tree.Insert(56);
        tree.Insert(30);
        tree.Insert(70);

        Console.WriteLine("preOrder Transversal : Root-left-right");
        tree.Display(tree.ReturnRoot());
        Console.WriteLine("Post transversal : left-right-root");
        tree.Post(tree.ReturnRoot());
        Console.WriteLine("Inorder transversal : left-root-right");
        tree.InOrdet(tree.ReturnRoot());
    }

}