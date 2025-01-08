using System;
using MyLibrary;

namespace reviewexercises
{
    internal class program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyMath.SecondsTo24Format(UserInteraction.UserIntputInt()));
        }
    }
}
