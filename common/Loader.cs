public static class Loader
{
    public static int[]? Puzzle;

    public static int[] LoadToIntArray(string filePath)
    {
        IEnumerable<string> temp = File.ReadLines(filePath);

        Puzzle = new int[temp.Count()];

        for (int i = 0; i < Puzzle.Length; i++)
        {
            Puzzle[i] = Array.ConvertAll(temp, int.Parse)
        }
        

        
    }
}