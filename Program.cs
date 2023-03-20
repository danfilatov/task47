Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numArray = new double[m, n];
Random numRandom = new Random();

void PrintArray(double[,] matrix)
 { 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
       { 
          Console.Write($"{matrix[i, j]}; ");
       }
 Console.WriteLine();
    }
 }

void FillArray(double[,] matrix)
 { 
    for (int i = 0; i < m; i++)
    { 
      for (int j = 0; j < n; j++)
       { 
          matrix[i,j] = Convert.ToDouble(numRandom.Next(-10, 10)/10.0);
       }
    }
}
FillArray(numArray);
PrintArray(numArray);