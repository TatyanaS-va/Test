// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

int[] CommonDivisor(int[] numbers)
{
    List<int> result = new List<int>();
    int min = numbers[0];

    for(int i = 1;i < numbers.Length; i++)
    { 
        if (numbers[i] < min) min = numbers[i];
        
    }
    for (int i = 2; i <= min; i++)
    {
        if (min % i == 0)
        {
            result.Add(i);
        }
    }
    for (int i = 0;i<numbers.Length;i++)
    {
        for (int j = 0; j < result.Count; j++)
        {
            if (numbers[i] % result[j] != 0) result.Remove(result[j]);     
        }
        if (result.Count == 0) break;
    }

   
    return result.ToArray<int>();
}
