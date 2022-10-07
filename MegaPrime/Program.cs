static void Main()
{

}

public static class MegaPrime
{
    /// <summary>
    /// function to get all mega prime numbers from 1 to max number
    /// </summary>
    /// <param name="max">number up to which to get megaprimes (inclusive)</param>
    /// <returns>a list of the megaprime numbers</returns>
    public static List<uint> getMegaPrimes(uint max)
    {
        List<uint> mPrimes = new List<uint>();
        for (uint i = 1; i <= max; i++)
        {
            if (isMegaPrime(i))
                mPrimes.Add(i);
        }
        return mPrimes;
    }

    /// <summary>
    /// function to determine if a number is a megaprime or not
    /// </summary>
    /// <param name="num">number to check</param>
    /// <returns>true if num is a megaprime or false if not</returns>
    public static bool isMegaPrime(uint num)
    {
        // num must be prime to be megaprime
        if (isPrime(num) == false)
        {
            return false;
        }

        // check if is mega prime
        string numStr = num.ToString();
        uint curDigit;
        foreach (char c in numStr)
        {
            curDigit = (uint)c - 48; // convert char to ascii code int value (-48 to get digit value)
            if (isPrime(curDigit) == false)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// function to determine if a number is prime or not
    /// </summary>
    /// <param name="num">number to check</param>
    /// <returns>true if num is a prime number or false if it is not</returns>
    public static bool isPrime(uint num)
    {
        if (num < 2)
            return false;

        // check if divisible by any number not 1 or itself
        for (uint i = 2; i < num; i++)
            if (num % i == 0)
                return false;

        return true;
    }

    /// <summary>
    /// function to determine if a number is a megaprime or not
    /// different approach, without using string conversion, to mega prime problem
    /// </summary>
    /// <param name="num">number to check</param>
    /// <returns>true if num is a megaprime or false if not</returns>
    public static bool isMegaPrime_WithoutStrConversion(uint num)
    {
        // num must be prime to be megaprime
        if (isPrime(num) == false)
        {
            return false;
        }

        // Check if is mega prime
        uint currentDigit = num % 10;
        uint digitsToLeft = num / 10;
        while (digitsToLeft > 0)
        {
            if (isPrime(currentDigit))
            {
                currentDigit = digitsToLeft % 10;   // get next digit
                digitsToLeft = (digitsToLeft / 10); // update remaining digits
            }
            else
            {
                return false;
            }
        }
        return isPrime(currentDigit);   // perform check on final digit
    }
}
