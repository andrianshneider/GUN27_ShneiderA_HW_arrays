using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Arrays Project");
        Console.WriteLine("--------------");
        Console.WriteLine("");

        //create and display an array of fibonacci numbers
        int[] array1 = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
        Console.WriteLine("Arrray1:");
        Console.WriteLine("--------------");
        foreach (var n in array1)
            Console.WriteLine(n);

        //create and display an array of month names using a loop
        string[] array2 = new string[12];
        for (var i = 0; i<array2.Length; i++)
        {
            array2[i] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i+1);
        }

        Console.WriteLine("");
        Console.WriteLine("Arrray2:");
        Console.WriteLine("--------------");

        foreach (var n in array2)
            Console.WriteLine(n);

        //create and display an array of numbers
        double[,] array3 = new double[3, 3];

        Console.WriteLine("");
        Console.WriteLine("Arrray3:");
        Console.WriteLine("--------------");

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                array3[i, j] = Math.Pow(i+2,j+1);
            }
        }

        for (var i=0; i<3; i++)
        {
            var s = "";
            for (var j = 0; j < 3; j++)
            {
                s = s + "[" + Convert.ToString(array3[j, i]) + "]";
            }
            Console.WriteLine(s);
        }
       

        //int[] array1 = new int[5] {1,2,3,4,5};

        //array1[1] = 5;
        //Console.WriteLine(array1[1]);

        //int[][] array2 = new int[3][] { new[] { 1, 2, 3, 56 }, new[] { 4, 5, 6, 78, 90 }, new[] { 7, 8, 9 } };

        //Console.WriteLine(array2[0]);

        //var array3 = Array.CreateInstance(typeof(int), 10);

        //int[] testarray = new[] { 3, 2, 1 };
        //Array.Sort(testarray, 0, 3);
        //Array.Reverse(testarray);

        //Console.WriteLine(testarray[0]);
        //Console.WriteLine(testarray[1]);
        //Console.WriteLine(testarray[2]);

        //int[] array1 = new[] { 32, 111, 25, 17 };
        //float[] array2 = new[] { 12.22f, 13f, 15.87f, 25.44f };

        //var results = Array.CreateInstance(typeof(float),4);
        //results.SetValue(array1[0] * array2[0], 0);
        //results.SetValue(array1[0] / array2[0], 1);

        //Console.WriteLine(results.GetValue(0));
        //Console.WriteLine(results.GetValue(1));

        //Array.Sort(array2);
        //Console.WriteLine(array2[0]);
        //Console.WriteLine(array2.Max());
        //Console.WriteLine(array2.Min());
    }
}