internal class Game
{
    public UFO alienCraft = new UFO();

    private readonly string symbolsNumbersAndSpace = "`~!@#$%^&*()-_=+,.<>/?;:'\"[]{}\\| 0123456789";
    private readonly string alphasNumbersAndSpace = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz 0123456789";
    private readonly string symbolsAndNumbers = "`~!@#$%^&*()-_=+,.<>/?;:'\"[]{}\\|0123456789";
    private readonly string symbolsAndSpace = "`~!@#$%^&*()-_=+,.< >/?;:'\"[]{}\\|";
    private readonly string symbols = "`~!@#$%^&*()-_=+,.<>/?;:'\"[]{}\\|";
    private readonly string alphas = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
    private readonly string numbers = "0123456789";
    private readonly string[] codewordOptions = {
            "apocalypse", "scream", "tiger", "millennial", "espionage", "extravagant",
            "apathy", "generous", "rose", "fascination", "revolution", "artificial",
            "strife", "discrepancy", "ordinary", "rage", "devotion", "imagination",
            "delirious", "excruciating", "grateful", "capacity", "marathon", "volcano",
            "trend", "domination", "dramatic", "peaceful", "organic", "page", "hope",
            "duck", "pope", "rope", "graceful", "divine", "elementary", "basic", "genius",
            "iconic", "reservation", "planetary", "momentary", "sacrament", "viral",
            "lame", "game", "digress", "duress", "instinct", "devolution", "panic", "pain",
            "gain", "strain", "domain", "remain", "cage", "rock", "luck", "train", "drain",
            "trash", "stash", "smash", "dose", "pose", "lose", "hose", "most", "dock",
            "amphibian", "stream", "resilient", "egregious", "fragrance", "romance",
            "observe", "deserve", "obscure", "tape", "extreme", "rain", "grape", "cape",
            "dart", "cart", "fair", "rude", "nice", "cruel", "love", "fade", "fast", "cast",
            "past", "last", "pass", "mass", "fake", "rake", "lake", "rows", "toes", "foes",
            "fog", "dog", "log", "hog", "lazy", "hazy", "ironic", "moronic", "magic",
            "logic", "logos", "foggy", "fun", "pun", "fur", "gun", "run", "rug", "tug",
            "life", "stress", "mess", "mind", "find", "freak", "leak", "race", "lace", "face",
            "fact", "pact", "gaze", "maze", "lean", "cream", "dream", "steam", "information",
            "cry", "shy", "try", "why", "toys", "boy", "goat", "way", "mean", "fry", "tale",
            "spider", "emotion", "intense", "danger", "defense", "offense", "stranger", "sky",
            "ranger", "static", "stain",  "stormy", "polite", "police", "glare", "delegation",
            "stage", "bubonic", "crate", "cake", "case", "pace", "late", "fate", "mash",
            "date", "night", "gate", "mate", "cat", "rat", "fat", "mat", "map", "rest",
            "pest", "nest", "best", "test", "pear", "tear", "gear", "fear", "near", "rear",
            "dear", "beer", "bean", "bash", "star", "stay", "day", "ray", "cringe", "fringe",
            "prince", "quince", "robot", "cobra", "snake", "stake", "stand", "grand",
            "brand", "land", "band", "bear", "rare", "dare", "war", "wild", "waste", "taste",
            "paste", "grave", "wax", "fax", "boat", "water", "rated", "year", "cash", "crash",
            "fox", "box", "mop", "man", "tan", "fan", "gin", "girl", "live", "dive", "sting",
            "smear", "ride", "trade", "maid", "hide", "fellow", "glide", "fountain", "steer",
            "mountain", "money", "honey", "mad", "fad", "glad", "sad", "bad", "lad", "bid",
            "bin", "bat", "hat", "win", "wit", "bit", "sit", "lit", "hit", "chance", "stance",
            "glance", "lord", "word", "loan", "wand", "sand", "wait", "slope", "hate", "fly",
            "roar", "beat", "feet", "legit", "heat", "neat", "seat", "follow", "need", "seed",
            "mellow", "beet", "deer", "bent", "rent", "tent", "went", "instigate", "distorted",
            "feed", "weep", "when", "treat", "seal", "hollow", "cheat", "device", "lizard",
            "mice", "mug", "house", "ram", "jam", "rice", "dice", "regress", "impress",
            "repress", "brain", "grain", "splash", "main", "rap", "gut", "hut", "nap", "hug",
            "bug", "sage", "mage", "wizard", "mouse", "say", "may", "hay", "lay", "fantastic",
            "bombastic", "drape", "propagation", "desecration", "superstition", "fungus",
            "emancipation", "obfuscate", "denigrate", "fame", "dame", "lam", "ham", "join",
            "coin", "meme", "vain", "vase", "baby", "wary", "many", "dent", "send", "farm",
            "harm", "warm", "cold", "fold", "bold", "sold", "mold", "moan", "foam", "drone",
            "long", "gong", "bong", "bone", "lone", "wall", "pearl", "base", "leap", "leaf",
            "blow", "flow", "glow", "slow", "slot", "hot", "bot", "got", "not", "lot", "mic",
            "prank", "frank", "crank", "lice", "pic", "trick", "lungs", "humus", "rip", "dip",
            "nip", "sip", "lip", "reformation", "restitution", "infiltrate", "oration",
            "illustrate", "erosion", "negation", "nut", "rot", "sun", "sin", "son", "bow",
            "moon", "soon", "loon", "foot", "loop", "goon", "swirl", "swift", "stiff", "fuck",
            "lock", "mock", "suck", "buck", "funk", "sunk", "rank", "bank", "trans", "sniff",
            "phone", "stone", "tall", "hall", "gall", "ball", "balm", "palm", "fixation",
            "rotation", "clash", "brash", "sports", "shorts", "monument", "document", "sight",
            "passion", "regiment", "sentient", "cow", "west", "loin", "steep", "deep", "sweep",
            "reef", "beef", "low", "sow", "how", "tow", "row", "elation", "mansion", "now",
            "pension", "meek", "spank", "thick", "tone", "zone", "lime", "like", "line",
            "light", "fight", "might", "right", "strength", "hold", "gold", "flat", "pale",
            "seek", "reek", "seen", "weed", "geek", "leek", "work", "warp", "wane", "mile",
            "tension", "nose", "vow", "fit", "slang", "rust", "dust", "must", "lust", "bust",
            "trunk", "trump", "trust", "truck", "leverage", "beverage", "book", "hook",
            "rook", "took", "look", "nook", "gook", "cook", "lend", "bend", "tend", "mend",
            "lens", "zen", "hen", "den", "dot", "yen", "cost", "lost", "host", "deal",
            "feel", "reel", "stuck", "steel", "will", "wheel", "whiff", "flash", "formal",
            "knife", "white", "black", "crack", "stack", "smack", "shack", "slack", "sale",
            "harsh", "marsh", "first", "burst", "nurse", "curse", "purse", "feral", "hail",
            "normal", "nordic", "gnostic", "crane", "radiation", "humiliation", "slave",
            "trace", "blaze", "flame", "crave", "grade", "grass", "brass", "brave",
            "mine", "mike", "mist", "gist", "list", "food", "mood", "hood", "good", "doom",
            "root", "loot", "loom", "zoom", "hoot", "boot", "boom", "bowl", "howl", "soul",
            "amazon", "just", "avalon", "rate", "bait", "reed", "space", "teen", "kill",
            "fill", "bill", "mill", "hill", "nail", "rail", "wail", "sail", "bail", "dean",
            "deaf", "quit", "spit", "slit", "slip", "slap", "keen", "peek", "peak", "sick",
            "wick", "lick", "beak", "queen", "queer", "seem", "seam", "zest", "part", "mart",
            "hard", "pot", "cot", "spear", "shear", "swear", "surge", "purge", "merge",
            "forge", "heal", "smart", "spring", "farce", "large", "lair", "liar", "tail",
            "gait", "fire", "wire", "pire", "tire", "tier", "least", "beast", "lease",
            "feast", "east", "next", "peel", "real", "pill", "verge", "blame", "blast",
            "bloom", "groom", "shirt", "flirt", "sneer", "clear", "sheer", "swim",
            "suit", "pool", "tool", "gust", "swing", "blare", "blade", "clean", "slide",
            "pride", "tribe", "pipe", "pine", "pint", "wine", "dine", "fine", "hint", "hind",
            "side", "wind", "dire", "high", "nigh", "sigh", "tint", "drop", "crop", "stop",
            "flop", "crow", "grow", "spot", "shot", "prop", "coat", "goal", "grip", "flip",
            "ship", "ruin", "skip", "drip", "neon", "lion", "crime", "spine", "shine",
            "swine", "slime", "poor", "gone", "done", "lane", "bane", "cane", "mane", "pane",
            "door", "sane", "pick", "sock", "hock", "node", "code", "load", "road", "toad",
            "soap", "soar", "soak", "soil", "boil", "coil", "jail", "pail", "toil", "foil",
            "toll", "mall", "fall", "call", "doll", "told", "wood", "wool", "fool", "cool",
            "sway", "pray", "flay", "shape", "vape", "gape", "slay", "tray", "play", "clay",
            "fest", "jest", "less", "crest", "press", "dress", "quest", "guest", "seer", "peal",
            "week", "force", "chess", "weal", "monk", "dunk", "junk" };

    public Game(int x)
    {
        this.MaxNumberOfGuesses = 5;
        this.CurrentWrongGuesses = 0;
        this.CurrentRightGuesses = 0;

        this.Codeword = codewordOptions[x];
        int y = (this.Codeword.Length * 2) - 1;
        char[] emptyWordWithSpaces = new char[y];

        for (int z = 0; z < y; z++)
        {
            if (z % 2 == 0)
                emptyWordWithSpaces[z] = '_';
            else
                emptyWordWithSpaces[z] = ' ';
        }

        this.CurrentWord = new string(emptyWordWithSpaces);
        this.CodewordAsArray = new char[this.CurrentWord.Length];

        int superIndex = 0;
        for (int i = 0; i < this.CurrentWord.Length; i++)
        {
            if (i % 2 == 0)
            {
                this.CodewordAsArray[i] = this.Codeword[superIndex];
                ++superIndex;
            }
            else
            {
                this.CodewordAsArray[i] = ' ';
            }
        }
        this.CodewordWithSpaces = new string(this.CodewordAsArray);

        this.InputAsChar = ' ';
        this.ErrorAsString = string.Empty;
        this.LttrsAlreadyUsed = [];

        this.WasWrong = false;
        this.ThereWasAnError = false;
        this.ItWasHitOrMiss = false;
    }
    public int MaxNumberOfGuesses { get; private set; }
    public int CurrentWrongGuesses { get; private set; }
    public int CurrentRightGuesses { get; private set; }
    public char InputAsChar { get; set; }
    public string Codeword { get; }
    public string CurrentWord { get; private set; }
    public string CodewordWithSpaces { get; }
    public string ErrorAsString { get; set; }
    public char[] CodewordAsArray { get; }
    public List<char> LttrsAlreadyUsed { get; set; }
    public bool WasWrong { get; set; }
    public bool ThereWasAnError { get; set; }
    public bool ItWasHitOrMiss { get; set; }

    public static void Intro()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("          CRACK THE CODEWORD");
        Console.WriteLine("        AND STOP THE ABDUCTION!");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("           -----------------");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("    maximize panel for full graphics");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("         press Ctrl+C to exit");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("      press <Enter> to continue -> ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadLine();
    }

    public void Inform()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        if (DidLose())
            Console.WriteLine("       ~~*~*~  STUFF HAPPENS! ~*~*~~");
        else if (DidWin())
            Console.WriteLine("         ~~*~*~  RUN HOME!  ~*~*~~");
        else if (WasWrong && CurrentWrongGuesses > 0)
            Console.WriteLine("      ~~*~*~  SWING & A MISS!  ~*~*~~");
        else if (!WasWrong && CurrentRightGuesses > 0)
            Console.WriteLine("         ~~*~*~  BASE HIT!  ~*~*~~");
        else
            Console.WriteLine("          ~~*~*~ BATTER UP! ~*~*~~");
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\n" + alienCraft.Showcase());
        Inform();
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        if (!DidWin() && !DidLose())
        {
            int guessesRemaining = MaxNumberOfGuesses - CurrentWrongGuesses;
            if (ThereWasAnError)
            {
                Console.WriteLine(ErrorAsString);
                ThereWasAnError = false;
            }
            else
            {
                switch (guessesRemaining)
                {
                    case 1:
                        Console.WriteLine("    ~~*~ you're allowed hits only! ~*~~");
                        break;
                    case 2:
                        Console.WriteLine("     ~~*~ you can miss once more! ~*~~");
                        break;
                    case 5:
                        if (CurrentRightGuesses == 0)
                            Console.WriteLine("   ~~*~ you're allowed 4 misses max ~*~~");
                        else Console.WriteLine("      ~~*~  you can miss 4 times ~*~~");
                        break;
                    default:
                        Console.WriteLine("    ~~*~ you can miss "
                                        + (guessesRemaining - 1) + " more times ~*~~");
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("      codeword: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(CurrentWord);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("      HIT");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("miss");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(": ");

            var ordered = LttrsAlreadyUsed.OrderBy(l => l);

            foreach (char k in ordered)
            {
                if (CurrentWord.Contains(k))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(Convert.ToString(k).ToUpper() + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(k + " ");
                }
            }

            Console.WriteLine("\n");
        }
        else if (!DidWin())
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\n the codeword was: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Codeword + "\n");
        }
        else
        {
            Console.WriteLine("\n\n\n\n");
        }
    }

    public void AssignValues(out IEnumerable<char> c1, out IEnumerable<char> c2,
        out IEnumerable<char> c3, out IEnumerable<char> c4, out IEnumerable<char> c5,
        out IEnumerable<char> c6, out IEnumerable<char> c7, string s)
    {
        c1 = s.Where(a => symbolsNumbersAndSpace.Contains(a));
        c2 = s.Where(b => symbolsAndNumbers.Contains(b));
        c3 = s.Where(c => alphas.Contains(c));
        c4 = s.Where(d => numbers.Contains(d));
        c5 = s.Where(e => symbols.Contains(e));
        c6 = s.Where(f => symbolsAndSpace.Contains(f));
        c7 = s.Where(g => alphasNumbersAndSpace.Contains(g));
    }

    public void Start()
    {
    beginning:
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        if (ItWasHitOrMiss)
        {
            Console.Write("   try another: ");
            ItWasHitOrMiss = false;
        }
        else
        {
            Console.Write("  try a letter: ");
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;

        string input = Console.ReadLine() ?? "possible null assignment";

        IEnumerable<char> symNumSpa, symNum, alph, numb, symb, symSpa, alpNumSpa;
        AssignValues(out symNumSpa, out symNum, out alph, out numb, out symb, out symSpa, out alpNumSpa, input);

        if (!String.IsNullOrEmpty(input))
        {
            bool isANumber = int.TryParse(input, out _);

            if (isANumber)
            {
                if (!symSpa.Any())
                    ErrorAsString = "        ~~*~ ERROR: no numbers ~*~~";
                else
                    ErrorAsString = "   ~~*~ ERROR: no spaces & numbers  ~*~~";

                ThereWasAnError = true;
                Display();
                goto beginning;
            }
            else if (symNumSpa.Any())
            {
                if (!symNum.Any() && !alph.Any())
                    ErrorAsString = "        ~~*~ ERROR: no spaces  ~*~~";
                else if (!alpNumSpa.Any())
                    ErrorAsString = "        ~~*~ ERROR: no symbols ~*~~";
                else if (!alph.Any() && !numb.Any())
                    ErrorAsString = "   ~~*~ ERROR: no spaces & symbols  ~*~~";
                else if (alph.Any())
                    if (!symb.Any() && !numb.Any())
                        ErrorAsString = "     ~~*~ ERROR: no extra spaces  ~*~~";
                    else if (numb.Any())
                        ErrorAsString = "     ~~*~ ERROR: no extra numbers ~*~~";
                    else
                        ErrorAsString = "     ~~*~ ERROR: no extra symbols ~*~~";
                else
                    ErrorAsString = "   ~~*~ ERROR: no numbers & symbols ~*~~";

                ThereWasAnError = true;
                Display();
                goto beginning;
            }
            else if (input.Length != 1)
            {
                ErrorAsString = "    ~~*~ ERROR: more than 1 letter ~*~~";
                ThereWasAnError = true;
                Display();
                goto beginning;
            }
            else
            {
                if (input == input.ToUpper())
                    input = input.ToLower();

                if (WasARepeat(input))
                    goto beginning;
                else if (Codeword.Contains(input))
                    UpdateCurrentWord();
                else
                    NextBadScene();

                ItWasHitOrMiss = true;
            }
        }
        else
        {
            ErrorAsString = "   ~~*~ ERROR: nothing was entered  ~*~~";
            ThereWasAnError = true;
            Display();
            goto beginning;
        }
    }

    public void UpdateCurrentWord()
    {
        WasWrong = false;
        CurrentRightGuesses++;
        char[] newTry = CurrentWord.ToCharArray();

        for (int idx = 0; idx < CurrentWord.Length; idx++)
        {
            if (CodewordAsArray[idx] == InputAsChar)
                newTry[idx] = InputAsChar;
        }

        LttrsAlreadyUsed.Add(InputAsChar);
        CurrentWord = new string(newTry);
        if (DidWin())
            alienCraft.SetFinal();
    }

    public void NextBadScene()
    {
        WasWrong = true;
        CurrentWrongGuesses++;
        LttrsAlreadyUsed.Add(InputAsChar);
        alienCraft.AddPart();
    }

    public bool WasARepeat(string x)
    {
        InputAsChar = Convert.ToChar(x);

        if (LttrsAlreadyUsed.Contains(InputAsChar))
        {
            ErrorAsString = "      ~~*~ ERROR: already in use  ~*~";
            ThereWasAnError = true;
            Display();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool DidLose() => (CurrentWrongGuesses == MaxNumberOfGuesses);
    public bool DidWin() => (CurrentWord == CodewordWithSpaces);
}