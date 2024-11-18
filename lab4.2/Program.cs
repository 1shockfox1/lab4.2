



int[,] A = new int[5, 5]
        {
            {0, 0, 1, 0, 0},
            {0, 0, 1, 0, 0},
            {1, 1, 1, 1, 1},
            {0, 0, 1, 0, 0},
            {0, 0, 1, 0, 0}
        };


for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine(A);
}