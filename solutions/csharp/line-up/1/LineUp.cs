public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastNumber = number % 10;
        int twoLastNumbers = number % 100;

        if (twoLastNumbers == 11 || twoLastNumbers == 12 || twoLastNumbers == 13)
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }

        else if (lastNumber == 1)
        {
            return $"{name}, you are the {number}st customer we serve today. Thank you!";
        }
        
        else if (lastNumber == 2)
        {
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        }
        
        else if (lastNumber == 3)
        {
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        }
        else
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
    }
}
