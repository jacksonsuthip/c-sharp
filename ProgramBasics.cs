// using System means that we can use classes from the System namespace
using System;

namespace ProgramBasics
{
    class ProgramBasics
    {
        static void _Main(string[] args)
        {
            // int number = 5;
            // double numberDouble = 5.99D;
            char oneLetter = 'J';
            // bool boolean = true;
            const string stringLetters = "Anto"; // const cant modify value

            // multiple varibals
            int x = 5, y = 6, z = 4;
            Console.WriteLine("--" + x + y + z);
            ///////////////////////////////////////////////////////////////////////////////////////////////
            // to print
            Console.WriteLine(stringLetters + " " + oneLetter);
            Console.WriteLine(3 + 3);
            /////////////////////////////////////////////////////////////////////////////////////////////
            int myInt = 10;
            // convert int to string
            Console.WriteLine("type casting - " + Convert.ToString(myInt));
            /////////////////////////////////////////////////////////////////////////////////////////////////
            // get input using cmd using ReadLine()
            Console.WriteLine("Enter username:");
            string userName = "aj";
            // userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            ///////////////////////////////////////////////////////////////////////////////////////////////
            // operators   +=	x += 3	x = x + 3
            //////////////////////////////////////////////////////////////////////////////////////////////
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            //////////////////////////////////////////////////////////////////////////////////////////////
            // interpolation
            string firstName = "John";
            string lastName = "jack";
            string name = $"Hellow : {firstName} - {lastName}";
            Console.WriteLine(name);
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            ///////////////////////////////////////////////////
            // if else
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Hiii");
            }
            else
            {
                Console.WriteLine("biiii");
            }
            //////////////////////////////////////////////////////////////////////////////////////////
            // while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("while loop - " + i);
                i += 1; // or i++ or i = i + 1
            }
            /////////////////////////////////////////////////////////////////////////////////////////
            // for loop
            for (int j = 0; j <= 10; j = j + 2)
            {
                Console.WriteLine("for loop - " + j);
            }
            /////////////////////////////////////////////////////////////////////////////////////////
            // foreach loop
            string[] device = { "Hp", "Dell", "Lenovo" };
            foreach (string deviceName in device)
            {
                Console.WriteLine("foreach loop - " + deviceName);
            }
            ////////////////////////////////////////////////////////////////////////////////////////
            // Array in c#
            int[] myNum = { 10, 20, 30, 40 };
            string[] carsArray = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int k = 0; k < carsArray.Length; k++)
            {
                Console.WriteLine("array for loop - " + carsArray[k]);
            }
            // Create an array of four elements, and add values later
            string[] cars = new string[4];
            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
        }
    }
}