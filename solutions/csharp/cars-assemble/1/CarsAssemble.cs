static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0;
        }
        
        else if (speed >= 1 && speed <= 4)
        {
            return 1;
        }

        else if (speed >= 5 && speed <= 8)
        {
            return 0.90;
        }
        else if (speed == 9)
        {
            return 0.80;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        return 0;
        
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        double total = speed * 221 * successRate;
        return total;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int carPerHour = speed * 221;
        var exitValue = carPerHour * SuccessRate(speed);
        var carPerMinute = exitValue / 60; 
        int total = (int)carPerMinute;
        return total;
    }
}
