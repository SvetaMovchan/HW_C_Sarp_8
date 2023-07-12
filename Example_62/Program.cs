/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int [,] CreateArray(int row, int col){ 
    int [,] array = new int [row,col]; 
    int k = 0;
    int n = 0;
    int i = 0;
    int j = 0;
    array[0,0] = 1;
    int count = row*col;
    while ((k < col/2) || (n < row/2))
    {   
        for (j = j + 1; j < col-k; j++) {
            array[i,j] = array[i,j-1] + 1;
            if (array[i,j]==count) return array;
        }
        j=j-1;
        for (i = n + 1; i < row-n; i++) {
            array[i,j] = array[i-1,j] + 1;
            if (array[i,j]==count) return array;
        }
        i=i-1;
        for (j = j - 1; j > k-1; j--) {
            array[i,j] = array[i,j+1] + 1;
            if (array[i,j]==count) return array;
        }
        j=j+1;
         for (i = i - 1; i > n; i--) {
            array[i,j] = array[i+1,j] + 1;
            if (array[i,j]==count) return array;
        }
        i = i + 1;
        n = n + 1; 
        k = k + 1;

    }
    return array; 
} 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 
Console.Clear(); 
int [,] arrayA = CreateArray(6,5);
PrintArray(arrayA); 
Console.WriteLine();