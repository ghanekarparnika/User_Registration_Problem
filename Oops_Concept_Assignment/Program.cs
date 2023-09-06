// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1) Create a program with object and class concept with example.
//creating object here
using Oops_Concept_Assignment;

Console.WriteLine("Que-1-Class object");
Class_Object_Concept a=new Class_Object_Concept();
a.disp();

Console.WriteLine("===================================================");

//2) Create a program with Inheritance concept with example.

//here we are creating child class object which are inheriting properties from parent class

Console.WriteLine("Que-2-Inheritance");

Car car=new Car();
car.start();
car.travel();
car.stop();

Console.WriteLine("===================================================");

//3) Create a program with Polymorphism concept along with types of polymorphism.
Console.WriteLine("Que-3-Plymorphism");
Tiger tiger=new Tiger();
tiger.makeSound();
string str = "hunt",str1="water";
tiger.consume(str);
tiger.consume(str,str1);
Dog dog=new Dog();
dog.makeSound();
Animal animal=new Animal();
animal.makeSound();


Console.WriteLine("===================================================");

//4) Create a program with Encapsulation concept with example.
Console.WriteLine("Que-4-Encapsulation");

Person person =new Person();
Console.WriteLine("Name: "+person.name+"\nAge: "+person.age+"\nAddress: "+person.address+"\nPhoneNo: "+person.phoneNo);

//person.personalId;//we cant access this instance member due to its protection level ie. it is private hence security

Console.WriteLine("===================================================");

//5) Create a program with Abstraction concept.
Console.WriteLine("Que-5-Abstarction");
Saving a1=new Saving();
a1.AccNo = 1;
a1.Name = "Parnika Ghanekar";
a1.Age = 23;
a1.AccType = "Saving";
a1.print();
a1.minimumBalance();



