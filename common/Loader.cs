public static class Loader
{
    public static List<int> PuzzleInt = new List<int>();
    public static List<char> PuzzleChar = new List<char>();

    public static void Load(int year, int day, bool isTest, bool isDebug)
    {
        string filePath = CreateFilePath(year, day, isTest, isDebug);

        Loader.LoadToIntList(filePath, isDebug);

        if (isDebug)
        {
            DebugLoadReport();
        }
    }

    public static void DebugLoadReport()
    {
        System.Console.WriteLine("Debug writer of Integer Puzzle Input:");
        foreach (var item in Loader.PuzzleInt)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");

        System.Console.WriteLine("Debug writer of Char Puzzle Input:");
        foreach (var item in Loader.PuzzleChar)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
    }

    public static string CreateFilePath(int year, int day, bool isTest, bool isDebug)
    {
        var filePath = string.Empty;
        var fileName = string.Empty;
        if (isTest)
        {
            fileName = "test.txt";
        }
        else
        {
            fileName = "puzzle.txt";
        }

        filePath = System.IO.Path.Combine(Environment.CurrentDirectory, year.ToString(), string.Format("{0:00}", day), @"input", fileName);

        if (isDebug) System.Console.WriteLine($"Fullpath is : {filePath}");
        return filePath;
    }

    private static void LoadToIntList(string filePath, bool isDebug = false)
    {
        //int numberOfLine = File.ReadAllLines(filePath).Length;

        PuzzleInt.Clear();

        foreach (string line in File.ReadLines(filePath))
        {
            if (isDebug) System.Console.WriteLine($"Line read: N{line}N");
            if (line == string.Empty)
            {
                PuzzleInt.Add(0);
            }
            else
            {
                PuzzleInt.Add(int.Parse(line));
            }
        }

        System.Console.WriteLine("Puzzle input loaded.");
        
    }

    public static void LoadToCharList(int year, int day, bool isTest, bool isDebug = false)
    {
        string filePath = CreateFilePath(year, day, isTest, isDebug);

        PuzzleChar.Clear();

        foreach (string line in File.ReadLines(filePath))
        {
            if (isDebug) System.Console.WriteLine($"Line read: N{line}N");
            if (line == string.Empty)
            {
                PuzzleChar.Add('\0');
            }
            else
            {
                
                PuzzleChar.AddRange(line.ToCharArray());
            }
        }

        System.Console.WriteLine("Puzzle input loaded.");

        if (isDebug)
        {
            DebugLoadReport();
        }

        
    }
}