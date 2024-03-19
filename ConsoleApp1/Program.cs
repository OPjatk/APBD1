// See https://aka.ms/new-console-template for more information
class Calc
{
    public static double GetAverage(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;
 
        double sum = 0;
        foreach (var coolNameMaster in numbers)
        {
            sum += coolNameMaster;
        }
        return sum / numbers.Length;
    }
    public static double GetMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}