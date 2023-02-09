Random rnd = new Random ();
int m = rnd.Next (4, 10);
int n = rnd.Next (4, 10);
int [,] matrix = new int [m,n];
double avg = 0;
double sum = 0;

void PrintArray(int [,] matr)
    {
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j< matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
  {
   for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    } 
}


void Aver (int [,] matr)
  {
   for (int j=0; j < matr.GetLength(1); j++)
    {
      for (int i=0; i < matr.GetLength(0); i++)
      {
        sum = sum + matr [i,j];
        
      }
       avg = sum / matr.GetLength(0);
       avg = Math.Round(avg, 2);
       Console.Write($"{avg} ");
       avg = 0;
    } 
}

FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray (matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
Aver(matrix);
