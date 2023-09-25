// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HashTableDemo;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hash Table Demo");
        /* MyMapNode<String,string> hash= new MyMapNode<string,string>(5);
         hash.Add("0", "To");
         hash.Add("1", "be");
         hash.Add("2", "or");
         hash.Add("3", "not");
         hash.Add("4", "To");
         hash.Add("5", "be");
         string hash5 = hash.Get("5");
         Console.WriteLine("5th index value is : " + hash5);*/
        string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

        string[] words = paragraph.Split(' ');

        MyHashTable<string, int> obj = new MyHashTable<string, int>(10);

        foreach (string word in words)
        {
            string cleanedWord = word.Trim().ToLower(); // Clean and convert to lowercase
            int frequency = obj.Get(cleanedWord);
            obj.Add(cleanedWord, frequency + 1);
        }

        // Print word frequencies
        foreach (var item in obj)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        // Remove the word "avoidable"
        obj.Remove("avoidable");

        Console.WriteLine("\nAfter removing 'avoidable':");
        foreach (var item in obj)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}