// Joshua Gregory; June 2024
// Connect Four game logic class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourApp
{
    internal class ConnectFour
    {
        // Instance Fields (set via gameplay methods)
        private char[,] grid = new char[6, 7];  // 6r x 7c matrix
        private string player;                   // Red or Yellow
        private char token;                      // R or Y

        // Non-Param Constructor & Getters
        public ConnectFour()
        {
            // Instantiates obj with "empty" grid
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    // set ith row & jth col to empty char
                    this.grid[i, j] = ' ';
                }
            }
            // red goes first
            this.player = "Red";
            this.token = 'R';
        }
        public string getPlayer() { return this.player; }
        public char getToken() { return this.token; }

        public string playerPrompt()
        {
            // Prompt input for Red and Yellow players
            if (this.player == "Red")
            {
                Console.WriteLine("Red Player: Enter a column number (0 - 6) to drop a red token (7 to save game, 8 to load game, 9 to exit):");
                return Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yellow Player: Enter a column number (0 - 6) to drop a yellow token (7 to save game, 8 to load game, or 9 to exit):");
                return Console.ReadLine();
            }
        }

        public void nextTurn()
        {
            // Switches player & token (Red, R to/from Yellow, Y)
            if (this.player == "Red")
            {
                this.player = "Yellow";
                this.token = 'Y';
            }           
            else if (this.player == "Yellow")
            {
                this.player = "Red";
                this.token = 'R';
            }
        }

        public int nextAvailablePosition(int col)
        {
            // Searches nth col, from last to 0th row, for open position
            for(int row = 5; row >= 0; row--)
            {
                if (this.grid[row, col] == ' ')
                {
                    return row;  // ' ' = open position
                }
            }
            return -1;  //  all rows are full
        }

        public void dropPiece(int c, char currToken)
        {
            // Changes rth row x cth column from ' ' to 'R' or 'Y'
            int r = nextAvailablePosition(c);

            if(r != -1)
            {
                this.grid[r,c] = currToken;
            }
            else
            {
                throw new ColumnFull($"Column number {c} is full.");
            }              
        }

        public void saveGame()
        {
            // Stores values in game grid to a new file
            Console.WriteLine("To save game to text file, enter a filename (eg, game1.txt):");
            string f = Console.ReadLine();

            do
            {
                // validate user input filename
                if(f == null || f.Length < 1)
                {
                    Console.WriteLine("File name is too short, must be 1+ characters:");
                    f = Console.ReadLine();
                }
                else if (!f.Contains(".txt"))
                {
                    f += ".txt";
                    break;
                }
                else
                {
                    break;
                }
            } while (true);

            try
            {
                // write grid values to a new file
                StreamWriter sw = new StreamWriter(f);

                // add comma between values
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if(j < 6)
                        {
                            sw.Write(this.grid[i, j] + ",");
                        }
                        else
                        {
                            sw.Write(this.grid[i, j]);
                        }
                    }
                }
                sw.Close();  // close stream
            }
            catch(IOException e)
            {
                Console.WriteLine("Error saving game to file: " + e);
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine("File type not supported: " + e);
            }
        }

        public void loadGame()
        {
            // Prompts for filename, reads file to set grid values
            Console.WriteLine("Enter the filename (with path) of the saved game:");
            string f = Console.ReadLine();

            do
            {
                // validate user input filename
                if (f == null || f.Length < 1)
                {
                    Console.WriteLine("File name is too short, must be 1+ characters:");
                    f = Console.ReadLine();
                }
                else if (!f.Contains(".txt"))
                {
                    f += ".txt";
                    break;
                }
                else
                {
                    break;
                }
            } while (true);

            try
            {
                // read lines and split using comma 
                StreamReader sr = new StreamReader(f);
                string line = sr.ReadLine();
                string[] data = line.Split(",");

                // iterate thru grid, set cell to converted arr values
                int idx = 0;
                while (idx < data.Length)  // len = 42
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            // [0,0] = data[0], [0,1] = data[1]...
                            if (data[idx] == " ")
                            {
                                grid[i, j] = ' ';
                                idx++;
                            }
                            else
                            {
                                grid[i, j] = char.Parse(data[idx]);
                                idx++;
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error loading game file: " + e);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("File type not supported: " + e);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("You don't have access to that file: " + e);
            }
        }

        public override string ToString()
        {
            // Provided by KSU CSE1322L 
            string toReturn = " 0 1 2 3 4 5 6";
            for (int i = 0; i < 6; i++)
            {
                toReturn += "\n-----------------------------\n";
                toReturn += "| ";
                for (int j = 0; j < 7; j++)
                {
                    toReturn += grid[i, j] + " | ";
                }
            }
            toReturn += "\n-----------------------------\n";
            return toReturn;
        }
    }
}
