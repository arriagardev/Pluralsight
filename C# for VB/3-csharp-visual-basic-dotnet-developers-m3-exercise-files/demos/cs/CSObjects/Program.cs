using System;

namespace CSObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Message msg = new Message();

            msg.Concatenate(" ", "Hello", "Mr.", "Console!");

            Console.WriteLine(msg.Text);

            Console.ReadLine();
        }
    }
}