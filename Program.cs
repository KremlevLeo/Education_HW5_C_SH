namespace HT6;

class Program
{
    static void Main(string[] args)
    {
        MainManu();
    }
    private static bool MainManu()
    {
        Console.Clear();
        Console.WriteLine("1) Count >0");
        Console.WriteLine("2) Intersection of points;");
        Console.WriteLine("3) Exit.");
        Console.Write("\nSelect: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Enter how many numbers you want: ");
                int resCount = 0;
                int userCout = int.Parse(Console.ReadLine());
                int[] resArr = new int[userCout];
                for (int i = 0; i < resArr.Length; i++)
                {
                    Console.Write($"Enter {i + 1} number: ");
                    resArr[i] = int.Parse(Console.ReadLine());
                    if (resArr[i] > 0) resCount++;
                }
                ArrPrint(resArr, resCount);
                return true;
            case "2":
                Console.Write("Enter Line 1 ");
                double[] lineA = GetCoordinates();
                Console.Write("Enter Line 2 ");
                double[] lineB = GetCoordinates();

                double x = -(lineA[1] - lineB[1]) / (lineA[0] - lineB[0]);
                double y = lineB[0] * x + lineB[1];
                Console.WriteLine($"b1 = {lineA[0]}, k1 = {lineA[1]}, b2 = {lineB[0]}, k2 = {lineB[1]} -> ({x};{y})");
                return true;
            case "3":
                return false;
            default:
                return false;
        }
    }
    private static void ArrPrint(int[] a, int b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (i > 0 && i < a.Length)
            {
                Console.Write(", ");
            }
            Console.Write($"{a[i]}");
        }
        Console.Write($" -> {b}");
    }
    private static double[] GetCoordinates()
    {
        double coordinCount = 0;
        Console.Write("b, k separated by spaces: ");
        string[] input = Console.ReadLine().Split();
        double[] coordinatуs = new double[input.Length];
        for (int i = 0; i < coordinatуs.Length; i++)
        {
            coordinatуs[i] = Convert.ToDouble(input[i]);
        }
        return coordinatуs;
    }
}