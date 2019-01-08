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
            // The application must provide at least 5 different questions
            Console.WriteLine("Question 1. Which martial art have I not studied?");
            Console.WriteLine("\ta. Brazilian Jujitsu");
            Console.WriteLine("\tb. Aikido");
            Console.WriteLine("\tc. Tae Kwan Do");
            Console.WriteLine("\td. Jeet Kune Do");

                // The correct answer is Brazilian Jujitsu

    
            // Question 2. How many novels have I written?
                // 1. 3
                // 2. 1
                // 3. 5
                // 4. 2

                // The correct answer is 3

            // Question 3. My go to karaoke song is Bohemian Rhapsody by Queen.
                // a. True
                // b. False

                // The correct answer is true

            // Question 4. My favorite movie is:
                // 1. The Notebook
                // 2. The Matrix
                // 3. The Thing
                // 4. The Avengers

                // The correct answer is The Thing

            // Question 5. Which ability do I covet the most?
                //a. The ability to fly
                //b. The ability to teleport
                //c. The ability to read minds
                //d. The ability to swing through the air with a web made of hair

            // The correct answer is the ability to teleport
                
        }


    }
}
