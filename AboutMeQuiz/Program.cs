using System;

namespace AboutMeQuiz
{
    class Program
    {
        public static int score = 0;

        static void Main(string[] args)
        {
            // Main will call the Play function to activate the came without any direct code manipulation.
            Play();
            ShowScore();

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
                    // Add to the score if answered correctly
                    TotalScore(1);
                    // Let the user know they got it right!
                    Console.WriteLine("That is correct! I feel like we've known each other for years!");
                }
                else
                {
                    // Let user know they got it wrong
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
                    correctAnswer = "\t1. Brazilian Jujitsu\n";
                    potentialAnswer1 = "\t2. Aikido\n";
                    potentialAnswer2 = "\t3. Tae Kwan Do\n";
                    potentialAnswer3 = "\t4. Jeet Kune Do\n";

                    fullQuestion = mainQuestion + correctAnswer + potentialAnswer1 + potentialAnswer2 + potentialAnswer3;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                case 1:
                    // For the longest time I thought I wanted to be a novelist.
                    mainQuestion = "\nQuestion 2. How many novels have I written?\n";
                    correctAnswer = "\t1. Three\n";
                    potentialAnswer1 = "\t2. One\n";
                    potentialAnswer2 = "\t3. Five\n";
                    potentialAnswer3 = "\t4. Two\n";

                    fullQuestion = mainQuestion + correctAnswer + potentialAnswer1 + potentialAnswer2 + potentialAnswer3;

                    questionAndAnswers[0] = fullQuestion;
                    questionAndAnswers[1] = correctAnswer;

                    return questionAndAnswers;

                case 2:
                    // Little known fact. I can sing. Decently enough.
                    mainQuestion = "\nQuestion 3. My go to karaoke song is Bohemian Rhapsody by Queen.\n";
                    correctAnswer = "\t1. True\n";
                    potentialAnswer1 = "\t2. False\n";

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
                    potentialAnswer1 = "\t1. The ability to fly\n";
                    correctAnswer = "\t2. The ability to teleport\n";
                    potentialAnswer2 = "\t3. The ability to read minds\n";
                    potentialAnswer3 = "\t4. The ability to swing through the air with a web made of hair\n";

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

        //This function checks if the user answer is correct
        static bool CheckAnswer(string userAnswer, string correctAnswer)
        {
            return correctAnswer.Contains(userAnswer);
        }

        // This function keeps track of correct answers
        static int TotalScore(int incrementBy)
        {
            Program.score += incrementBy;

            return Program.score;
        }

        // Once the user has has completed the questionairre, show the score on the screen
        static void ShowScore()
        {
            int highScore = TotalScore(0);

            Console.WriteLine($"Congratulations! You answered { highScore } questions correctly!");
        }
    }
}
