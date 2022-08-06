public class Methods
{

    //methods are in line with assignment prompts 1-10
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Average(int num1, int num2, int num3, int num4, int num5)
    {
        return num1 + num2 + num3 + num4 + num5 / 5;
    }

    public static int SumRandom()
    {
        //genterating randome numbers
        Random random1 = new Random();
        Random random2 = new Random();
        int num1 = random1.Next(0, 100);
        int num2 = random2.Next(0, 100);

        return num1 + num2;
    }

    public static bool DivideByThree(int num1, int num2, int num3)
    {
        if(num1 + num2 + num3 % 3 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string SmallString(string string1, string string2)
    {
        int letterCount = string1.Length;
        int letterCount2 = string2.Length;

        if(letterCount > letterCount2)
        {
            return string2;
        }
        else
        {
            return string1;
        }
    }
    public static double LargestIndex(double[] doubles)
    {
        double[] value = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        value = doubles;
        double i;
        double max = doubles[0];

        for(i = 0; i < doubles.Length; i++)
        {
            if (doubles[(int)i] > max)
            {
                max = doubles[(int)i];
            }
            
        }
        return max;
    }

    public static int[] ArrayOfInts(int X)
    {
        int[] ints = Enumerable.Range(0, X).ToArray();
        return ints;
    }

    public static bool VariableBool(bool x, bool y)
    {
        //x or operation
        return !(x ^ y);
    }

    public static int Product(int x, double y)
    {
         return (int)(x * y);
    }

    public static int ArrayAverage(int[,] result)
    {
        
        int counter = 0;
        int sum = 0;
        

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                sum = sum + result[i, j];
                counter++;
            }
        }
        return sum / counter;
    }
    public static void Main(String[] args)
    {
        //Array of doubles created to test methods
        double[] value = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        
        //variable created to test method
        int X = 50;

        //boolean variables to test boolean method
        //changing these values will change the output due to x or operation
        bool x = true;
        bool y = false;
        
        //createing two dimentional Array for testing
        int[,] result = new int[5,2];
        result[0, 0] = 1;
        result[0, 1] = 2;
        result[1, 0] = 3;
        result[1, 1] = 4;
        result[2, 0] = 5;
        result[2, 1] = 6;
        result[3, 0] = 7;
        result[3, 1] = 8;
        result[4, 0] = 9;
        result[4, 1] = 10;


        //Calling all methods and providing input where needed
        Console.WriteLine(Sum(1,2)) ;
        Console.WriteLine(Average(1, 2, 3, 4, 5));
        Console.WriteLine(SumRandom());
        Console.WriteLine(DivideByThree(1, 2, 3));
        Console.WriteLine(SmallString("Hello", "You"));
        Console.WriteLine(LargestIndex(value));
        //to get the array to pirnt
        int[] ints = ArrayOfInts(X);
        string intsString = "";
        foreach(int i in ints)
        {
            intsString += "[" + i + "]";
        }
        Console.WriteLine(intsString);
        Console.WriteLine(VariableBool(x, y));
        Console.WriteLine(Product(1, 2.0));
        Console.WriteLine(ArrayAverage(result));

    }
}
