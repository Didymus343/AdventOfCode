public class Day02
{
    string filePath = string.Empty;
    char lose = 'X';
    char draw = 'Y';
    char win = 'Z';
    char opRock = 'A';
    char opPaper = 'B';
    char opScissors = 'C';

    public Day02() : this(false)
    {

    }

    public Day02(bool isTest, bool isDebug = false)
    {
        Loader.LoadToCharList(2022, 2, isTest, isDebug);
        var totalScore = 0;
        for (int i = 0; i < Loader.PuzzleChar.Count; i+=3)
        {
            var you = Loader.PuzzleChar[i+2];
            var op = Loader.PuzzleChar[i];
            totalScore += CheckRound(you, op, isDebug);
        }

        System.Console.WriteLine($"Total score is: {totalScore}");

    }

    private int CheckRound(char desiredResult, char opponent, bool isDebug)
    {
        if(isDebug)System.Console.WriteLine($"Input, desired result:: {desiredResult} opponent: {opponent}"); 
        var score = 0;
        
        if(desiredResult == lose)
        {
            score += 0;      
            if(isDebug)System.Console.WriteLine("You should lose");      
        }
        else if(desiredResult == draw)
        {
            score += 3;  
            if(isDebug)System.Console.WriteLine("You should draw");           
        }
        else if(desiredResult == win)
        {
            score += 6;  
            if(isDebug)System.Console.WriteLine("You should win");           
        }

        score += DetermineTypeScore(desiredResult, opponent);
        return score;

    }

    private int DetermineTypeScore(char result, char opponent)
    {
        if(result == lose)
        {
            if(opponent == opRock)
            {
                return 3;
            }
            else if(opponent == opPaper)
            {
                return 1;
            }
            else if(opponent == opScissors)
            {
                return 2;
            }
        }
        else if(result == draw)
        {
            if(opponent == opRock)
            {
                return 1;
            }
            else if(opponent == opPaper)
            {
                return 2;
            }
            else if(opponent == opScissors)
            {
                return 3;
            }
        }
        else if(result == win)
        {
            if(opponent == opRock)
            {
                return 2;
            }
            else if(opponent == opPaper)
            {
                return 3;
            }
            else if(opponent == opScissors)
            {
                return 1;
            }
        }
        return 0;
    }

    private int CheckWin(char you, char opponent)
    {
        var result = 0;
        if(you == lose)
        {
            if (opponent == opRock)
            {
                result = 3;
            }
            else if( opponent == opPaper)
            {
                result = 0;
            }
            else if( opponent == opScissors)
            {
                result = 6;
            }
        }
        else if(you == draw)
        {
            if (opponent == opRock)
            {
                result = 6;   
            }
            else if( opponent == opPaper)
            {
                result = 3;
            }
            else if( opponent == opScissors)
            {
                result = 0;
            }
        }
        else if(you == win)
        {
            if (opponent == opRock)
            {
                result = 0;
            }
            else if( opponent == opPaper)
            {
                result = 6;
            }
            else if( opponent == opScissors)
            {
                result = 3;
            }
        }

        return result;
    }

    
}