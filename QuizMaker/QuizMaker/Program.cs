// (L3) Quiz Maker & Editor console app
// @author      Joshua Gregory
// @version     1.0 (June 2024)
namespace QuizMaker
{
    internal class Program
    {
        // DRIVER + UI
        static void Main(string[] args)
        {
            // create new Quiz obj via default constructor
            Quiz quiz1 = new Quiz();

            // user menu
            string choices = ("\n|  1. Add a question to the quiz.       |\n|  2. Remove a question from the quiz.  |\n|  3. Modify a question in the quiz.    |\n" +
                "|  4. Take the quiz.                    |\n|  5. Quit                              |\n");
            string dashes = (" --------------------------------------- ");
            string title = ("\n|          Welcome to QuizBot!          |\n");
            string menu = (dashes + title + dashes + choices + dashes);

            do
            {
                Console.WriteLine("\n" + menu);
                Console.WriteLine("Enter the number of your choice:");
                string userInp = Console.ReadLine();

                // OPTION 1: ADD QUESTION
                if (userInp == "1")
                {
                    quiz1.addQuestion();
                }

                // OPTION 2: REMOVE QUESTION
                else if (userInp == "2")
                {
                    quiz1.removeQuestion();
                }

                // OPTION 3: MODIFY QUESTION
                else if (userInp == "3")
                {
                    quiz1.modifyQuestion();
                }

                // OPTION 4: TAKE QUIZ
                else if (userInp == "4")
                {
                    quiz1.giveQuiz();
                }

                // OPTION 5: QUIT
                else if (userInp == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // INVALID INPUT
                else
                {
                    Console.WriteLine("Invalid input. Enter an integer from 1 to 5 please:");
                    userInp = Console.ReadLine();
                }
            } while (true);
        }
    }
}