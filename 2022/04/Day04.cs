public class Day04
{
    List<String> Puzzle = new List<string>();
    public Day04() : this(false)
    {

    }

    public Day04(bool isTest, bool isDebug = false)
    {
        Load(2022, 3, isTest, isDebug);

    }


    public void Load(int year, int day, bool isTest, bool isDebug)
    {
        string filePath = CreateFilePath(year, day, isTest, isDebug);

        LoadToStringList(filePath, isDebug);

        if (isDebug)
        {
            DebugLoadReport();
        }
    }

    public void DebugLoadReport()
    {
        System.Console.WriteLine("Debug writer of Puzzle Input:");
        foreach (var item in Puzzle)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");


    }

    public string CreateFilePath(int year, int day, bool isTest, bool isDebug)
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

    public void LoadToStringList(string filePath, bool isDebug = false)
    {
        //int numberOfLine = File.ReadAllLines(filePath).Length;

        Puzzle.Clear();

        foreach (string line in File.ReadLines(filePath))
        {
            if (isDebug) System.Console.WriteLine($"Line read: -{line}-");
            if (line == string.Empty)
            {
                Puzzle.Add(string.Empty);
            }
            else
            {
                Puzzle.Add(line);
            }
        }

        System.Console.WriteLine("Puzzle input loaded.");

    }


}