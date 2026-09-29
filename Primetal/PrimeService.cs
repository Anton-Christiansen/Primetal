namespace Primetal;

public class PrimeService
{
    public bool IsPrime(int candidate)
    {
        if (candidate < 2)
        {
            return false;
        }

        if (candidate == 2)
        {
            return true;
        }

        if (candidate % 2 == 0)
        {
            return false;
        }


        var top = (int)Math.Sqrt(candidate);

        for (int i = 3; i <= top; i += 2)
        {
            if (candidate % i == 0)
            {
                return false;
            }
        }


        return true;
    }
}