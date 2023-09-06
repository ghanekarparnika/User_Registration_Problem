// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Day10_PracticeProb2;

//1) Demonstrate different types of constructors.
// Default Constructor


Console.WriteLine("Q1-Contructor Types");
Constructor_Types obj1 = new Constructor_Types();
Console.WriteLine("Value after default constructor: " + obj1.Value);

// Parameterized Constructor
Constructor_Types obj2 = new Constructor_Types(42);
Console.WriteLine("Value after parameterized constructor: " + obj2.Value);

// Copy Constructor
Constructor_Types obj3 = new Constructor_Types(obj2);
Console.WriteLine("Value after copy constructor: " + obj3.Value);

// Static Constructor (automatically called before any static members are accessed)
Constructor_Types obj4 = new Constructor_Types();

// Accessing static constructor
Console.WriteLine("Static constructor has already been called.");
Console.WriteLine("==============================================");