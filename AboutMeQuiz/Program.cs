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
            int totalQuestions = 5;
            string question, correctAnswer, userAnswer;

            // Ask questions and ask for an answer from the user after each question
            for (int i = 0; i < totalQuestions; i++)
            {
                question = AskQuestion(i)[0];
         
                Console.WriteLine(question);

                userAnswer = Console.ReadLine();
                correctAnswer = AskQuestion(i)[1];

                // Check to see if the user's answer matches the correct answer
                if (CheckAnswer(userAnswer, correctAnswer))
                {
                    Console.WriteLine("That is correct!");
                }
                else
                {
                    Console.WriteLine("That is incorrect. You don't know me at all, do you? :(");
                }
            }
        }

        static string[] AskQuestion(int questionNumber)
        {
            string fullQuestion, mainQuestion, potentialAnswer1, potentialAnswer2, potentialAnswer3, correctAnswer;

            string[] questionAndAnswers = new string[2];

            switch (questionNumber)
            {
                case 0: 
                    // The first question deals with my training in martial arts. Martial arts have been in important part of my life for many years.
                    mainQuestion = "\nQuestion 1. Which martial art have I not studied?\n";
                    correctAnswer = "\ta. Brazilian Jujitsu\n";
                    potentialAnswer1 = "\tb. Aikido\n";
                    potentialAnswer2 = "\tc. Tae Kwan Do\n";
                    potentialAnswer3 = "\td. Jeet Kune Do\n";

                    fullQuestion = mainQuestion + correctAnswer + potentialAnswer1 + potentialAnswer2 + potentialAnswer3;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                case 1:
                    // For the longest time I thought I wanted to be a novelist.
                    mainQuestion = "\nQuestion 2. How many novels have I written?\n";
                    correctAnswer = "\t1. 3\n";
                    potentialAnswer1 = "\t2. 1\n";
                    potentialAnswer2 = "\t3. 5\n";
                    potentialAnswer3 = "\t4. 2\n";

                    fullQuestion = mainQuestion + correctAnswer + potentialAnswer1 + potentialAnswer2 + potentialAnswer3;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                case 2:
                    // Little known fact. I can sing. Decently enough.
                    mainQuestion = "\nQuestion 3. My go to karaoke song is Bohemian Rhapsody by Queen.\n";
                    correctAnswer = "\ta. True\n";
                    potentialAnswer1 = "\tb. False\n";

                    fullQuestion = mainQuestion + correctAnswer + potentialAnswer1;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                case 3:
                    // I don't know why but I have a fascination with horror movies, especially The Thing
                    mainQuestion = "\nQuestion 4. My favorite movie is:\n";
                    potentialAnswer1 = "\t1. The Notebook\n";
                    potentialAnswer2 = "\t2. The Matrix\n";
                    correctAnswer = "\t3. The Thing\n";
                    potentialAnswer3 = "\t4. The Avengers\n";

                    fullQuestion = mainQuestion + potentialAnswer1 + potentialAnswer2 + correctAnswer + potentialAnswer3;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                case 4:
                    // Superpowers are all the rage but noone thinks about practicality! I would save so much time if I could just teleport everywhere.
                    mainQuestion = "\nQuestion 5. Which ability do I covet the most?\n";
                    potentialAnswer1 = "\ta. The ability to fly\n";
                    correctAnswer = "\tb. The ability to teleport\n";
                    potentialAnswer2 = "\tc. The ability to read minds\n";
                    potentialAnswer3 = "\td. The ability to swing through the air with a web made of hair\n";

                    fullQuestion = mainQuestion + potentialAnswer1 + correctAnswer + potentialAnswer2 + potentialAnswer3;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                default:
                    questionAndAnswers[0] = "Please enter a valid selection.";
                    questionAndAnswers[1] = "Please enter a valid selection.";

                    return questionAndAnswers;
            }
        }

        static bool CheckAnswer(string userAnswer, string correctAnswer)
        {
            return true;
        }
    }
}
