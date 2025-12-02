using System.Text;

public class Day03
{
    List<String> Puzzle = new List<string>();
    public Day03() : this(false)
    {

    }

    public Day03(bool isTest, bool isDebug = false)
    {
        Load(2022, 3, isTest, isDebug);

        // var result = 0;
        // foreach (var line in Puzzle)
        // {
        //     var compartmentSize = line.Length / 2;
        //     var firstCompartment = line[..compartmentSize];
        //     var secondCompartment = line.Substring(compartmentSize);

        //     var both = firstCompartment.Intersect<char>(secondCompartment);
        //     if (isDebug)
        //     {
        //         System.Console.WriteLine($"Compartment size: {compartmentSize}");
        //         System.Console.WriteLine($"First compartment: {firstCompartment}");
        //         System.Console.WriteLine($"Second compartment: {secondCompartment}");
        //         foreach (var item in both)
        //         {
        //             System.Console.WriteLine($"Present in both: {item}");
        //             System.Console.WriteLine($"Number: {(int)item}");
        //         }

        //     }
        //     foreach (var item in both)
        //     {
        //         var number = (int)item;
        //         if (number >= 97)
        //         {
        //             result += number - 96;
        //         }
        //         else
        //         {
        //             result += number - 38;
        //         }
        //     }
        // }

        // System.Console.WriteLine($"Total priorities is: {result}");

        var secondResult = 0;
        for (int i = 0; i < Puzzle.Count; i += 3)
        {
            var firstRucksack = Puzzle[i];
            var secondRucksack = Puzzle[i +1];
            var thirdRucksack = Puzzle[i + 2];

            var badge = firstRucksack.Intersect<char>(secondRucksack).Intersect<char>(thirdRucksack);

            foreach (var item in badge)
            {
                if(isDebug)System.Console.WriteLine($"Present in all: {item}");                

                var number = (int)item;
                if (number >= 97)
                {
                    secondResult += number - 96;
                }
                else
                {
                    secondResult += number - 38;
                }
            }
        }
        System.Console.WriteLine($"Second result of total: {secondResult}");

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



