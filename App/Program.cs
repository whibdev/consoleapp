using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've been hacked!");
            var chester = new Chester();
            Console.WriteLine(chester.Dob.ToString("yy-MMM-dd"));
        }
    }
}
