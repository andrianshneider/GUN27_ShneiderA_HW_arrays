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
        var s = "";
        foreach (var n in array1)
            s = s + "[" + Convert.ToString(n) + "]";
        Console.WriteLine(s);
        
        //create and display an array of month names using a loop
        string[] array2 = new string[12];
        for (var i = 0; i<array2.Length; i++)
        {
            array2[i] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i+1);
        }

        Console.WriteLine("");
        Console.WriteLine("Arrray2:");
        Console.WriteLine("--------------");

        s = "";
        foreach (var n in array2)
            s = s + "[" + n + "]";
        Console.WriteLine(s);

        //create and display an array of numbers
        double[,] array3 = new double[3, 3];

        Console.WriteLine("");
        Console.WriteLine("Arrray3:");
        Console.WriteLine("--------------");

        for (var i = 0; i < array3.GetLength(0); i++)
        {
            for (var j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = Math.Pow(i+2,j+1);
            }
        }

        for (var i=0; i< array3.GetLength(0); i++)
        {
            s = "";
            for (var j = 0; j < array3.GetLength(1); j++)
            {
                s = s + "[" + Convert.ToString(array3[j, i]) + "]";
            }
            Console.WriteLine(s);
        }

        // create and display jagged array
        double[][] array4 = new double[3][]
        {
            new double [] { 1, 2, 3, 4, 5 },
            new double [] { Math.E, Math.PI },
            new double [] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
        };

        Console.WriteLine("");
        Console.WriteLine("Arrray4:");
        Console.WriteLine("--------------");

        for (var i=0; i< array4.GetLength(0); i++)
        {
            s = "";
            foreach (var n in array4[i])
                s = s + "[" + n + "]";
            Console.WriteLine(s);
        }

        //create, copy, resize and display two arrays

        //create
        int[] array5 = { 1, 2, 3, 4, 5 };
        int[] array6 = { 7, 8, 9, 10, 11, 12, 13 };

        //display arrays before operations
        Console.WriteLine("");
        Console.WriteLine("Arrray5 and Array6 (before):");
        Console.WriteLine("--------------");

        s = "";
        foreach (var n in array5)
            s = s + "[" + n + "]";
        Console.WriteLine(s);

        s = "";
        foreach (var n in array6)
            s = s + "[" + n + "]";
        Console.WriteLine(s);

        //copy
        Array.Copy(array5, array6, 3);

        //resize
        Array.Resize(ref array5, array5.GetLength(0) * 2);


        //display result
        Console.WriteLine("");
        Console.WriteLine("Arrray5 and Array6 (after):");
        Console.WriteLine("--------------");

        s = "";
        foreach (var n in array5)
            s = s + "[" + n + "]";
        Console.WriteLine(s);

        s = "";
        foreach (var n in array6)
            s = s + "[" + n + "]";
        Console.WriteLine(s);
    }
}