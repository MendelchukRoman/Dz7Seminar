// Задайте двумерный массив размером m×n, заполненный случайными вещественными числам; (с поворотом матрицы)
 

class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите размер матрицы по вертикали: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер матрицы по горизонтали: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int[,] mas = new int[x, y];
            for (int i = 0; i < (mas.GetUpperBound(0) + 1); i++)
            {
                for (int j = 0; j < (mas.Length) / (mas.GetUpperBound(0) + 1); j++)
                {
                    mas[i, j] = random.Next(0, 9);
                }
            }
            for (int i = 0; i < (mas.GetUpperBound(0) + 1); i++)
            {
                for(int j=0;j< (mas.Length) / (mas.GetUpperBound(0) + 1); j++)
                {
                   Console.Write($"{mas[i, j]} ");
                }
               Console.WriteLine("");
            }
           Console.WriteLine("");
            for (int i = (mas.GetUpperBound(0) + 1); i > 0; i--)
            {
                for (int j = 0; j < (mas.Length) / (mas.GetUpperBound(0) + 1); j++)
                {
 
                    Console.Write($"{mas[j, i-1]} ");
                }
                Console.WriteLine("");
            }
        }
     }
