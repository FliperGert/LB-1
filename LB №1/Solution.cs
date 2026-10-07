using System;

internal class Solution
{
    private static readonly Random _random = new Random();

    public int[] generationArr(int begin, int end, int length)
    {
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = _random.Next(begin, end + 1);
        }

        return arr;
    }

    public int sumLastNums(int x)
    {
        return x % 10 + x % 100 / 10;
    }

    public bool isPositive(int x)
    {
        return x >= 0;
    }

    public bool isUpperCase(char x)
    {
        return char.IsUpper(x);
    }

    public bool isDivisor(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return false;
        }

        return a % b == 0 || b % a == 0;
    }

    public int lastNumSum(int a, int b)
    {
        return a % 10 + b % 10;
    }

    public double safeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }

        return (double)x / y;
    }

    public string makeDecision(int x, int y)
    {
        if (x < y)
        {
            return $"{x}<{y}";
        }

        if (x > y)
        {
            return $"{x}>{y}";
        }

        return $"{x}=={y}";
    }

    public bool sum3(int x, int y, int z)
    {
        return x + y == z || x + z == y || y + z == x;
    }

    public string age(int x)
    {
        if (x % 10 == 1 && x != 11)
        {
            return $"{x} год";
        }

        if ((x % 10 == 2 && x != 12) ||
            (x % 10 == 3 && x != 13) ||
            (x % 10 == 4 && x != 14))
        {
            return $"{x} года";
        }

        return $"{x} лет";
    }

    public void printDays(string x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;

            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;

            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;

            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;

            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;

            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;

            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;

            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }

    public string reverseListNums(int x)
    {
        string result = "";

        for (int i = 0; i <= x; i++)
        {
            result = " " + i + result;
        }

        return result;
    }

    public int pow(int x, int y)
    {
        int result = 1;

        for (int i = 0; i < y; i++)
        {
            result *= x;
        }

        return result;
    }

    public bool equalNum(int x)
    {
        int original = x;
        int reversed = 0;

        while (x > 0)
        {
            int lastDigit = x % 10;
            reversed = reversed * 10 + lastDigit;
            x /= 10;
        }

        return original == reversed;
    }

    public void leftTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public void guessGame()
    {
        int answer = _random.Next(10);
        int userAnswer;
        int counter = 0;

        Console.WriteLine("Введите число от 0 до 9:");
        do
        {
            userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer != answer)
            {
                Console.WriteLine("Вы не угадали, введите число от 0 до 9");
            }
            else
            {
                Console.WriteLine("Вы угадали");
            }

            counter++;
        }
        while (answer != userAnswer);

        Console.WriteLine("Вы угадали число за " + counter + " попытки");
    }

    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] newArr = new int[arr.Length + 1];

        int i = 0;
        int k = 0;
        bool isInserted = false;

        while (i < arr.Length)
        {
            if (k == pos)
            {
                newArr[k] = x;
                isInserted = true;
            }
            else
            {
                newArr[k] = arr[i];
                i++;
            }

            k++;
        }

        if (!isInserted)
        {
            newArr[k] = x;
        }

        return newArr;
    }

    public void reverse(int[] arr)
    {
        int buffer;

        for (int i = 0; i < arr.Length / 2; i++)
        {
            buffer = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = buffer;
        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] newArr = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            newArr[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            newArr[arr1.Length + i] = arr2[i];
        }

        return newArr;
    }

    public int[] deleteNegative(int[] arr)
    {
        int[] newArr = new int[arr.Length];

        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                newArr[k] = arr[i];
                k++;
            }
        }

        Array.Resize(ref newArr, k);

        return newArr;
    }
}