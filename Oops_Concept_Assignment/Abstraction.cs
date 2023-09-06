using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Assignment
{
    internal class Abstraction
    {
    }

    abstract class Account 
    {
        private int accNo;
        public string name;
        public string accType;
        public int age;

     
        public int AccNo
        {
            get { return accNo; }
            set {  accNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string AccType
        {
            get { return accType; }
            set { accType = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public abstract void minimumBalance();
        public void print()
        {
            Console.WriteLine("Account no: " + accNo + "\nName: " + name + "\n Age: " + age + "\nAccount Type: " + accType);
        }
    }


    class Saving : Account
    {

       

        public override void minimumBalance()
        {
            Console.WriteLine("You should Maintain minimum balance above 1000");
        }
    }

    class Current : Account 
    {
        public override void minimumBalance()
        {
            Console.WriteLine("You should Maintain minimum balance above 10,000");
        }
    }
}
