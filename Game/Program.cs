internal class Program
{
    /*Invaders from outer space have arrived and are abducting 
     * humans using tractor beams. Players must crack the codeword 
     * to stop the abduction!*/
    static void Main(string[] _)
    {
        Console.CancelKeyPress += new ConsoleCancelEventHandler(ExitApp);

        Random rand = new();

        bool StayOn;

        Game.Intro();

        do
        {
            Game g = new(rand.Next(808));

            while (!g.DidWin() && !g.DidLose())
            {
                g.Display();
                g.Start();
            }

            g.Display();

        exit:

            if (Console.ForegroundColor != ConsoleColor.Blue)
                Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write(" PLAY AGAIN? (y/n): ");

            Console.ForegroundColor = ConsoleColor.DarkRed;

            string answer = Console.ReadLine() ?? "possible null assignment";
            if (!String.IsNullOrEmpty(answer))
            {
                if (answer == answer.ToUpper())
                    answer = answer.ToLower();

                if (answer == "n")
                    StayOn = false;
                else if (answer == "y")
                    StayOn = true;
                else
                {
                    g.Display();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" need Y or N ~*~");
                    goto exit;
                }
            }
            else
            {
                g.Display();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" NEED y OR n ~*~");
                goto exit;
            }

        } while (StayOn);

        Console.ResetColor();
    }

    static void ExitApp(object? sender, ConsoleCancelEventArgs c)
    {
        Console.ResetColor();
        c.Cancel = true;
        Console.WriteLine("exiting application...");
        Environment.Exit(0);
    }
}