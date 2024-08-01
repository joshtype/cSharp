// Joshua Gregory; June 2024
// Connect Four app driver & UI
namespace ConnectFourApp
{
    internal class Program
    {
        // Driver & UI
        static void Main(string[] args)
        {
            // create new game obj
            ConnectFour game = new ConnectFour();

            // start game
            string inp = game.playerPrompt();

            // validate input
            do
            {
                game.ToString();
                if (Int32.TryParse(inp, out int num))
                {
                    if (num >= 0 && num < 7)
                    {
                        if (game.getToken() == 'R')
                        {
                            try
                            {
                                game.dropPiece(num, 'R');
                                break;
                            }
                            catch (ColumnFull e)
                            {
                                Console.WriteLine("That column is full, try again.");
                            }
                        }
                        else
                        {
                            game.dropPiece(num, 'Y');
                        }
                    }
                    else if(num == 7)
                    {
                        game.saveGame();
                    }
                    else if(num == 8)
                    {
                        game.loadGame();
                    }
                    else if(num == 9)
                    {
                        Console.WriteLine("See you next time!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please follow the prompt.");
                    inp = game.playerPrompt();
                }
            } while (true);
        }
    }
}
