int[] PrimeNum(int min,int max)
{
    bool isPrime;
    List<int> result = new List<int>();
    for (int i = min; i <= max; i++)
    {
        isPrime = true;
        for (int j = 2; j < min; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime) result.Add(i);       
    }
    foreach (int i in result)
    {
        Console.WriteLine(i);
    }
    return result.ToArray<int>();

}
