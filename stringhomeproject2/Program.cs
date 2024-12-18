//class program
//{

//    static void main()
//    {

//        const int size = 5;
//        int[,] matrix = new int[size, size];
//        Random random = new Random();
//        Console.WriteLine("Two-Massive : ");
//        for (int i = 0; i < size; i++)
//        {
//            for (int j = 0; j < size; j++)
//            {
//                matrix[i, j] = random.Next(-100, 101);
//                Console.WriteLine($"{matrix[i,j],5}");
//            }
//            Console.WriteLine();
//        }
//    }
//}
class program2
{
    static void main()
    {
        const int size = 5;
        int[,] matrix = new int[size, size];
        Random random = new Random();
        Console.WriteLine("Massive : ");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(-100, 101);
                Console.WriteLine($"{matrix[i, j],5}");
            }
            Console.WriteLine();
        }

        int[] arr = new int[size * size];
        int index = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                arr[index++] = matrix[i, j];
            }
        }

        int min = 0;
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
            if (arr[i] > max)
                max = arr[i];
        }
        int start = Math.Min(min, max);
        int end = Math.Max(min, max);
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"Min element : {arr[min]}");
        Console.WriteLine($"Max element : {arr[max]}");
        Console.WriteLine($"Sum with elemenrs {sum}");
    }
}

class Matrix
{

    static void matrixbynumber()
    {
        Console.WriteLine("Enter length of matrix : ");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        /*  int[,] matrix = /*InputMatrix*/
    }




}



