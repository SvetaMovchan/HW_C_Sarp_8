/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
            array[i,j] = rand.Next(min,max+1); 
    } 
    return array; 
} 
 
int [,] PermuteElArray(int [,] array){ 
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1)-1; j++) 
        { 
            for (int k = j+1; k < array.GetLength(1); k++){
                if(array[i,j]<array[i,k]){ 
                    temp = array[i,j];
                    array[i,j] = array[i,k]; 
                    array[i,k] = temp;
                }
            }     
        } 
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
int [,] array = CreateArray(3,4,0,10); 
PrintArray(array); 
Console.WriteLine(); 
array = PermuteElArray(array); 
PrintArray(array);