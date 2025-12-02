public class Day01
{
    string filePath = string.Empty;

    public Day01() : this(false)
    {

    }

    public Day01(bool isTest, bool isDebug = false)
    {
        Loader.Load(2022, 1, isTest, isDebug);

        var caloriesPerElf = new List<int>();
        var totalCalories = 0;
        for (int i = 0; i < Loader.PuzzleInt.Count(); i++)
        {
            if (Loader.PuzzleInt[i] == 0)
            {
                caloriesPerElf.Add(totalCalories);
                totalCalories = 0;

            }
            else
            {
                totalCalories += Loader.PuzzleInt[i];
            }
        }
        caloriesPerElf.Add(totalCalories);

        // Check number of elfs
        for (int i = 0; i < caloriesPerElf.Count; i++)
        {
            System.Console.WriteLine($"Elf number {i + 1} with: {caloriesPerElf[i]} calories.");
        }

        var max = 0;
        var elfNumber = int.MinValue;
        // Detrmine elf with largest calories
        for (int i = 0; i < caloriesPerElf.Count; i++)
        {
            if (caloriesPerElf[i] > max)
            {
                max = caloriesPerElf[i];
                elfNumber = i + 1;
            }
        }

        System.Console.WriteLine($"Elf with the most caloties is: {elfNumber}, with {max} caloties");


        var max1 = 0;
        var max2 = 0;
        var max3 = 0;

        var elfNumber1 = int.MinValue;
        var elfNumber2 = int.MinValue;
        var elfNumber3 = int.MinValue;
        // Detrmine elf with largest calories
        for (int i = 0; i < caloriesPerElf.Count; i++)
        {
            if (caloriesPerElf[i] > max1)
            {
                max3 = max2;
                max2 = max1;
                elfNumber3 = elfNumber2;
                elfNumber2 = elfNumber1;
                
                max1 = caloriesPerElf[i];
                elfNumber1 = i + 1;
                
            }
            else if (caloriesPerElf[i] > max2)
            {
                max3 = max2;
                elfNumber3 = elfNumber2;
                
                max2 = caloriesPerElf[i];
                elfNumber2 = i + 1;
            }
            else if (caloriesPerElf[i] > max3)
            {
                max3 = caloriesPerElf[i];
                elfNumber3 = i + 1;
            }
        }
        System.Console.WriteLine($"Elf with the most caloties is: {elfNumber1}, with {max1} caloties");
        System.Console.WriteLine($"Elf with the second most caloties is: {elfNumber2}, with {max2} caloties");
        System.Console.WriteLine($"Elf with the third most caloties is: {elfNumber3}, with {max3} caloties");
        System.Console.WriteLine($"Combine calories of the top 3 elfs is: {max1 + max2 + max3}");


    }
}