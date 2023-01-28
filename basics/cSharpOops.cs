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
            // creating object in the different namespace
            nameSpace2.Device deviceObj = new nameSpace2.Device();
            Console.WriteLine("1 st --- " + deviceObj.countNew);
            deviceObj.countNew = 10;
            Console.WriteLine("2 nd after value set --- " + deviceObj.countNew);
            deviceObj.addDevice();

            //nameSpace2.CollegeStudent collegeStudent = new nameSpace2.CollegeStudent();

            //collegeStudent.addDevice();
            //collegeStudent.votingstatus();

            //nameSpace2.Device student1 = new nameSpace2.CollegeStudent();
            //student1.addDevice();

            Console.ReadKey();
        }
    }
}


namespace nameSpace2
{
    class Device
    {
        private int count;// Field

        // Constructor should be public
        public Device() //Default Constructor
        {}
        public Device(int count_) // Parametrized Constructor
        {
            count = count_;
        }
        // int Age { get,set}
        public int countNew   // property
        {
            get { return countNew; }   // get method
            set { countNew = value; }  // set method
        }
        public static void getvalue() // Method Static
        {
            Console.WriteLine(" i am in tmperNs");
        }
        public virtual void addDevice()
        {
            Console.WriteLine("Inside virtual method" + count);
        }
    }
    class CollegeStudent : Device
    {
        public override void addDevice()
        {
            Console.WriteLine("Body mass Index inside CollegeStudent");
        }
        public void LogCheck()
        {
            Console.WriteLine("LogCheck");
        }
    }
}

