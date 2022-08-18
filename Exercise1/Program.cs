// Задайте двумерный массив размером m×n, заполненный случайными вещественными числам m=3 n=4;
 // 1) Задать массив
 // 2) Заполнить случайными числами

class Program
{
static void Main (string[] args)
{
int [,] massiv = new int [4, 3];
Random random = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
       {
    for (int j = 0; j < massiv.GetLength(1); j++)
         {
           massiv [i, j] = random.Next(1, 99);
         }
       }
    for (int x = 0; x < massiv.GetLength(0); x++)
       {
            for (int y = 0; y < massiv.GetLength(1); y++)
              {
                Console.Write(massiv[x , y] + "\t");
              }
             Console.WriteLine(); 
       }
}
}
