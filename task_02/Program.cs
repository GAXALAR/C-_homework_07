Random rnd = new Random ();
int m = rnd.Next (3, 15);
int n = rnd.Next (3, 15);
int [,] matrix = new int [m,n];

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
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10,10);
        }
    } 
}



FillArray(matrix);
PrintArray (matrix);
Console.WriteLine();

Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 
 if ( a > m || b > n )
    Console.WriteLine("такого числа нет");
 else
    {
        int value = matrix[a,b];
        Console.WriteLine($"Искомое число = {value}");

    }