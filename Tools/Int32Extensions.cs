namespace Tools;

public static class Int32Extensions
{
    public static bool IsPrime(this int value)
    {
        if (value < 2) 
            throw new InvalidOperationException( 
                $"La valeur {value} ne peut pas être inférieure à 2 !");

        int square = (int)Math.Sqrt(value);

        for (int divider = 2; divider <= square; divider++)
        {
            if (value % divider == 0) return false;
        }

        return true;
    }
}