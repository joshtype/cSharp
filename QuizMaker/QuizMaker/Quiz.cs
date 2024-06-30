// Defines Quiz obj
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace QuizMaker
{
    internal class Quiz
    {
        // class attributes (List of Question objs)
        private static List<Question> qList = new List<Question>();

        // METHOD: constructs & adds Question object to List. 
        public void addQuestion()
        {
            // Question text (prompt, validate nonempty)
            Console.WriteLine("\nQuestion text:");
            string newText = Console.ReadLine();
            do
            {
                if(newText == null || newText.Length <= 0)
                {
                    Console.WriteLine("No text entered. Please try again:");
                    newText = Console.ReadLine();
                }
                else
                {
                    break;
                }
            } while (true);

            // Question answer (prompt, validate nonempty)
            Console.WriteLine("Question answer:");
            string newAnsr = Console.ReadLine();
            do
            {
                if (newAnsr == null || newAnsr.Length <= 0)
                {
                    Console.WriteLine("No text entered. Please try again:");
                    newAnsr = Console.ReadLine();
                }
                else
                {
                    break;
                }
            } while (true);

            // Difficulty level (prompt, validate, convert to int)
            Console.WriteLine("Difficulty level (enter '1' for easy, '2' for medium, or '3' for hard):");
            string inpDiff = Console.ReadLine();
            do
            {
                if(!Int32.TryParse(inpDiff, out int diff))
                {
                    Console.WriteLine("Invalid input. Please enter only '1', '2', or '3':");
                    inpDiff = Console.ReadLine();
                }
                else
                {
                    // construct new Question obj from user input, add to List
                    Question newQuestion = new Question(newText, newAnsr, diff);
                    qList.Add(newQuestion);
                    break;
                }

            } while (true);           
        }

        // METHOD: removes user-selected question from List
        public void removeQuestion()
        {
            Console.WriteLine("\nYou selected to remove a question from the quiz.");
            // prompt user for question to remove
            if (qList.Count <= 0)
            {
                // no questions in List
                Console.WriteLine("Your quiz is already empty!");
            }
            else
            {
                // display text for each question
                Console.WriteLine("Your quiz contains the following questions:");
                for (int i = 0; i < qList.Count; i++)
                {
                    // traverse List, print each question's text
                    Console.WriteLine($"\n#{i + 1}: {qList[i].getText()}\n");
                }

                // prompt user for question number to remove, validate/convert to int
                Console.WriteLine("Enter the number of the question to remove:");
                string inpNum = Console.ReadLine();
                do
                {
                    // validate conversion and withinbounds
                    if ((!Int32.TryParse(inpNum, out int n)) || (n - 1 > qList.Count))
                    {
                        Console.WriteLine("Invalid input. Please enter only the number of the question (eg: '1'):");
                        inpNum = Console.ReadLine();
                    }
                    else
                    {
                        qList.RemoveAt(n-1);
                    }

                } while (true);
            }
        }

        // METHOD: modifies a user-selected question in List
        public void modifyQuestion()
        {
            Console.WriteLine("\nYou selected to modify a question in the quiz.");
            // prompt user for question to remove
            if (qList.Count <= 0)
            {
                // no questions in List
                Console.WriteLine("Your quiz is empty!");
            }
            else
            {
                // display each question's text for user selection
                Console.WriteLine("Your quiz currently contains the following questions:");
                for (int i = 0; i < qList.Count; i++)
                {
                    // traverse List, print each question's text
                    Console.WriteLine($"\n#{i + 1}: {qList[i].getText()}\n");
                }
                // get number of question to modify (validate, convert)
                Console.WriteLine("Enter just the number of the question to modify:");
                string inpNum = Console.ReadLine();
                do
                {
                    if ((!Int32.TryParse(inpNum, out int n)) || (n - 1 > qList.Count))
                    {
                        Console.WriteLine("Invalid input. Please enter only the number of the question (eg: '1'):");
                        inpNum = Console.ReadLine();
                    }
                    else
                    {
                        // Get new text (validate nonempty)
                        Console.WriteLine("Enter the new text:");
                        string newText = Console.ReadLine();
                        do
                        {
                            if (newText == null || newText.Length <= 0)
                            {
                                Console.WriteLine("Input was empty. Please enter text for the new question:");
                                newText = Console.ReadLine();
                            }
                            else
                            {
                                qList[n - 1].setText(newText);
                                break;
                            }
                        } while (true);
                        
                        // Get new answer (validate nonempty)
                        Console.WriteLine("Enter the new answer:");
                        string newAnsr = Console.ReadLine();
                        do
                        {
                            if (newAnsr == null || newAnsr.Length <= 0)
                            {
                                Console.WriteLine("Input was empty. Please enter text for the new question:");
                                newAnsr = Console.ReadLine();
                            }
                            else
                            {
                                qList[n - 1].setAnsr(newAnsr);
                                break;
                            }
                        } while (true);

                        // get, validate, convert to int new difficulty level
                        Console.WriteLine("Enter the new difficulty level for the question:");
                        string newDiff = Console.ReadLine();
                        do
                        {
                            // validate input = 1, 2, or 3 
                            if (!Int32.TryParse(newDiff, out int diff))
                            {
                                Console.WriteLine("Invalid input. Please enter '1', '2', or '3':");
                                newDiff = Console.ReadLine();
                            }
                            else
                            {
                                if(diff > 0 && diff < 4)
                                {
                                    qList[n - 1].setDiff(diff);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter '1', '2', or '3':");
                                    newDiff = Console.ReadLine();
                                }
                            }
                        } while (true);
                    }
                } while (true);
            }
        }

        // Allows user to take quiz
        public void giveQuiz()
        {
            Console.WriteLine("\nYou selected to take the quiz. Note: answers must match to score points, including punctuation!");
            int score = 0;  // track number of matching answer strings

            // traverse List, display question text, prompt user for answer
            for (int i = 0; i < qList.Count; i++)
            {
                // display each question text, read in user answer
                Console.WriteLine("Question " + (i + 1) + ": " + qList[i].getText());
                Console.WriteLine("Enter your answer:");
                string userAnsr = Console.ReadLine();

                // compare user answer to question answer
                if (userAnsr.Equals(qList[i].getAnsr()))
                {
                    // correct answer, increment score
                    score++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    // incorrect answer
                    Console.WriteLine("Incorrect. The correct answer is: " + qList[i].getAnsr() + "\n");
                }
            }
            // display score
            Console.WriteLine("You scored " + score + " out of " + qList.Count + " points.");
        }
    }
}
