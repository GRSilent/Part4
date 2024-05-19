namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr = new int[row, col];

            Random r = new Random();

            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = r.Next(10);
                    Console.Write($"{arr[i, j]} ");
                    
                }
                Console.WriteLine();
            }

            int sum = 0;

            for (int s = 0; s < row; s++)
                for (int k = 0; k < col; k++)
                    sum += arr[s, k];

            Console.WriteLine("Сумма всех элементов двухмерного массива равна: {0}", sum);

        }
    }
}