using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main will call the Play function to activate the came without any direct code manipulation.
            Play();
        }

        // Play is the function that will call all of the other functions.
        static void Play()
        {
            Console.WriteLine("In the Play function");
        }
    }
}
