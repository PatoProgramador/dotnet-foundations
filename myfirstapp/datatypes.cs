using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace netfoundations
{
    internal class Program
    {
        static void Main(string[] args)
        {   // simple data types
            // Number types
            // 1 byte
            byte number = 255;
            sbyte number2 = 127; // reduces the range of numbers
            // 2 bytes 
            short number1 = 10;
            // 4 bytes
            int number3 = 58; 
            uint number4 = 20; // only positive numbers
            float number7 = 182.4f;
            // 8 bytes
            long number5 = 1000; // very long integers
            ulong number6 = 1000000; // only long positives
            double number8 = 144778.5d;
            // 16 bytes
            decimal number9 = 11445.2m;
            // Strings
            // 2 bytes
            char string1 = 'A';
            // Bool
            bool YON = true;
            // complex data types
            string string2 = "JEJEJEJEJ";
            DateTime date = DateTime.Now; // not native
            // Default value example
            int numberDefault = new int();
            Console.WriteLine(numberDefault.ToString());
            // Nullable variable example
            int? numberDefault1 = null;
            // The use of var
            var name = "Pato";
            // Basic use of anonymous objects
            var persona = new {
                name= "Pato",
                lastname="Patoso",
            };
            Console.WriteLine(persona.name);
        }
    }
}