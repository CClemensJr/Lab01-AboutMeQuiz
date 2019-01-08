using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main will call the Play function to activate the came without any direct code manipulation.
            Play();

            Console.ReadLine();
        }

        // Play is the function that will call all of the other functions.
        static void Play()
        {
            Console.WriteLine("In the Play function");
            // The application must provide at least 5 different questions

            // The first question deals with my training in martial arts. Martial arts have been in important part of my life for many years.
            Console.WriteLine("Question 1. Which martial art have I not studied?");
            Console.WriteLine("\ta. Brazilian Jujitsu");
            Console.WriteLine("\tb. Aikido");
            Console.WriteLine("\tc. Tae Kwan Do");
            Console.WriteLine("\td. Jeet Kune Do");

            // Collecte user input
            string answer1 = Console.ReadLine();
            
            // Add some logic to let the user know if they were right or wrong
            if (answer1.ToUpper() == "A")
            {
                Console.WriteLine("\nThat is correct! I have trained in the arts of Aikido, Tae Kwan Do, and Jeet Kune Do but not Brazilian Jujitsu");
            }
            else
            {
                Console.WriteLine("\nI'm sorry but that is incorrect. I have trained in the arts of Aikido, Tae Kwan Do, and Jeet Kune Do but not Brazilian Jujitsu");
            }


            // Rinse and repeat for each question
            Console.WriteLine("\nQuestion 2. How many novels have I written?");
            Console.WriteLine("\t1. 3");
            Console.WriteLine("\t2. 1");
            Console.WriteLine("\t3. 5");
            Console.WriteLine("\t4. 2");

            string answer2 = Console.ReadLine();

            if (answer2 == "1")
            {
                Console.WriteLine("\nThat is correct. I have written three novels, though none of them have been published. Yet. ;)");
            }
            else
            {
                Console.WriteLine("\nThat is incorrect. I have written three novels, though none of them have been published. Yet. ;)");
            }


            Console.WriteLine("\nQuestion 3. My go to karaoke song is Bohemian Rhapsody by Queen.");
            Console.WriteLine("\ta. True");
            Console.WriteLine("\tb. False");

            string answer3 = Console.ReadLine();

            if (answer3.ToUpper() == "A")
            {
                Console.WriteLine("\nThat is correct. I love to rock out to some Bohemian Rhapsody.");
            }
            else
            {
                Console.WriteLine("\nThat is incorrect. I love to rock out to some Bohemian Rhapsody.");
            }


            Console.WriteLine("\nQuestion 4. My favorite movie is:");
            Console.WriteLine("\t1. The Notebook");
            Console.WriteLine("\t2. The Matrix");
            Console.WriteLine("\t3. The Thing");
            Console.WriteLine("\t4. The Avengers");

            string answer4 = Console.ReadLine();

            if (answer4 == "3")
            {
                Console.WriteLine("\nThat is correct. My favorite movie is The Thing. Kurt Russell at his finest.");
            }
            else
            {
                Console.WriteLine("\nThat is incorrect. My favorite movie is The Thing. Don't ask why. Well, I guess you can ask.");
            }


            Console.WriteLine("\nQuestion 5. Which ability do I covet the most?");
            Console.WriteLine("\ta. The ability to fly");
            Console.WriteLine("\tb. The ability to teleport");
            Console.WriteLine("\tc. The ability to read minds");
            Console.WriteLine("\td. The ability to swing through the air with a web made of hair");

            string answer5 = Console.ReadLine();

            Console.WriteLine($"You enterd { answer5 }");

            // The correct answer is the ability to teleport

        }


    }
}
