using System;

namespace ConsoleApp
{
    // class name have to start with CAPS
    class Program
    {
        string myCode = "C#";

        static void getvalue(int a, int b)
        {
            int z = a + b;
            Console.WriteLine(" i am in getvalue static method -----" + z);
        }
        void getValue1()
        {
            Console.WriteLine(" i am in getValue1 non static method ");
        }

        // Main will call at first
        static void Main(string[] args)
        {

            // creating object for Program class
            Program programObj = new Program();
            Console.WriteLine("output from Program class - " + programObj.myCode);
            // with static don't wont to create object
            Program.getvalue(5, 8);
            // no static so Have to create object
            programObj.getValue1();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            // creating object in the different namespace with Constructor int value
            nameSpace2.Device deviceObj = new nameSpace2.Device(5);
            Console.WriteLine("Constructor update Public --- " + deviceObj.countPublic);
            // Using get, set
            Console.WriteLine(" 1.Access Private value in Device class  --- " + deviceObj.countNew);
            deviceObj.countNew = 10;
            Console.WriteLine(" 2.Update Private value in Device class --- " + deviceObj.countNew);
            deviceObj.getTotal();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Inheritance 
            nameSpace2.Mobile MobileObj = new nameSpace2.Mobile(7);
            MobileObj.addDevice();
            MobileObj.LogCheck();
            // Polymorphism (Overriding method)
            nameSpace2.Device MobileObj1 = new nameSpace2.Mobile(10);
            MobileObj1.addDevice();
            MobileObj1.LogCheck();

            nameSpace2.Device MobileObj2 = new nameSpace2.Device(10);
            MobileObj2.addDevice();
            MobileObj2.LogCheck();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Abstraction (Inherit with other class to use it)
            // nameSpace3.Laptop LaptopObj = new nameSpace3.Laptop(); // It will Give error Laptop is abstract class
            nameSpace3.LaptopColor LaptopColorObj = new nameSpace3.LaptopColor();
            LaptopColorObj.getLaptopColor();
            LaptopColorObj.getLaptop();

            Console.ReadKey();
        }
    }
}


namespace nameSpace2
{
    class Device
    {
        public int countPublic; // Field
        private int countPrivate; // Field

        // Constructor should be public
        // public Device() // Default Constructor
        // { }
        public Device(int count_) // Parametrized Constructor
        {
            countPublic = count_;
        }
        public int countNew   // property - To update and get value from private method
        {
            get { return countPrivate; }  // get method
            set { countPrivate = value; }  // set method
        }
        public void getTotal()
        {
            int total = countPublic + countPrivate;
            Console.WriteLine("getTotal --- " + total);
        }
        public virtual void addDevice()
        {
            Console.WriteLine("addDevice (virtual)method from Device Class --- " + countPrivate);
        }
        public void LogCheck()
        {
            Console.WriteLine(" --LogCheck method Device Class-- ");
        }

    }
    class Mobile : Device // Mobile - derived Class(child), Device - base Class(parent) 
    {
        public Mobile(int count_) : base(count_) // Constructor for Mobile
        {
        }

        // public void addDevice()
        public override void addDevice()
        {
            Console.WriteLine("addDevice (override)method from Mobile Class");
        }
        public new void LogCheck()
        {
            Console.WriteLine(" --LogCheck method Mobile Class-- ");
        }
    }
}

namespace nameSpace3
{
    abstract class Laptop // Abstract class
    {
        public abstract void getLaptopColor();
        public void getLaptop()
        {
            Console.WriteLine("getLaptop in (abstract class Laptop)");
        }
    }
    class LaptopColor : Laptop
    {
        public override void getLaptopColor()
        {
            Console.WriteLine("getLaptopColor in (class LaptopColor : Laptop)");
        }
    }
}