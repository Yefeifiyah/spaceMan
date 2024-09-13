internal class UFO
{
    private readonly string s0 = "\n\n\n\n\n\n\n\n" +
@"            .-""^""-.
           /_....._\
       .-""`         `""-.
      (  ooo  ooo  ooo  )
       '-.,_________,.-'
           |       |     ,---------.
           |   0   |    (" + " \u00A1Auxilio! )\n" +
@"           | --|-- | ___/`---------'
           |   |   |
           |  / \  |";

    private readonly string s1 = "\n\n\n\n\n\n\n" +
@"            .-""^""-.
           /_....._\
       .-""`         `""-.
      (  ooo  ooo  ooo  )
       '-.,_________,.-'
           |   0   |     ,---------.
           | --|-- | ___(" + " \u00A1Socorro! )\n" +
@"           |   |   |     `---------'
           |  / \  |
           |       |" + "\n";

    private readonly string s2 = "\n\n\n\n\n\n\n" +
@"            .-""^""-.
           /_....._\
       .-""`         `""-.
      (  ooo  ooo  ooo  )
       '-.,_________,.-'  ,--------.
           | --|-- | ___ /" + " \u00A1R\u00E1pido  \\\n" +
@"           |   |   |     \  boludo! /
           |  / \  |      `--------'
           |       |" + "\n\n";

    private readonly string s3 = "\n\n\n\n\n\n" +
@"            .-""^""-.
           /_....._\
       .-""`         `""-.
      (  ooo  ooo  ooo  )
       '-.,_________,.-' ,---------.
           |   |   | \_ /" + " \u00A1Pi\u00E9nsala \\\n" +
"           |  / \\  |    \\  imb\u00E9cil! /\n" +
@"           |       |     `---------'" + "\n\n\n\n";

    private readonly string s4 = "\n\n\n\n\n\n" +
@"            .-""^""-.
           /_....._\
       .-""`         `""-.
      (  ooo  ooo  ooo  ) __
       '-.,_________,.-'    \
           |  / \  |   ,-----^-----.
           |       |  /" + " \u00A1Gilipollas \\\n" +
@"                      \  de mierda! /
                       `-----------'" + "\n\n\n";

    private readonly string s5 = "\n\n\n\n\n" +
@"            .-""^""-.
           /_..0.._\   ____
       .-""`         `""-.   \
      (  ooo  ooo  ooo  )   \
       '-.,_________,.-'     \
           |       |      ,---^----.
                         /" + " \u00A1Con dos \\\n" +
@"                         \ cojones! /
                          `--------'" + "\n\n\n\n";

    private readonly string s6 = "\n\n\n\n\n" +
@"            .-""^""-.
           /_....._\
       .-""`         `""-.
      (  ooo  ooo  ooo  )
       '-.,_________,.-'" + "\n\n\n\n" +
@"                             0
                           --|--
                             |
                            / \";

    private readonly string[] ufos;
    private int stage;

    public UFO() => ufos = new string[] { s0, s1, s2, s3, s4, s5, s6 };

    public void AddPart()
    {
        stage++;

        if (stage >= ufos.Length)
        {
            Console.WriteLine("staging error");
            stage = ufos.Length - 1;
            Console.ReadKey();
        }
    }

    public void SetFinal() => stage = ufos.Length - 1;
    public string Showcase() => ufos[stage];
    public override string ToString() => "I'm a UFO object...";
}