
void PrintArray(double [,] matr)
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

void FillArray(double [,] matr)
{
   for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToDouble(new Random().Next(-10,10)) / 10;
        }
    } 
}

double [,] matrix = new double [5,5];
FillArray(matrix);
PrintArray (matrix);
