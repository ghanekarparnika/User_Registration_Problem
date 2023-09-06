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

//2) Perform interface concept with examples.
Console.WriteLine("Q2-Interface");
Shape s1= new Circle();
s1.Area();
Shape s2 = new Rectangle();
s2.Area();
Shape s3 = new Triangle();
s3.Area();
Console.WriteLine("==============================================");

//3) Perform access modifiers concepts with examples.
Console.WriteLine("Q3-Access Modifier");

AccessModifiers a1 = new AccessModifiers();
a1.disp();
Child c=new Child();
c.disp1();
Myaclass m=new Myaclass();
m.disp3();
