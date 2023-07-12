/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
bool ValidateArray(int [,] array1, int [,] array2){
    if (array1.GetLength(1) != array2.GetLength(0)){
        Console.WriteLine("Матрицы не совместимы, т.к. число столбцов первой матрицы НЕ равно числу строк второй матрицы");
        return false;
    }
    return true;
}
int [,] MultiplyArrays(int [,] array1, int [,] array2){ 
    int [,] array = new int [array1.GetLength(0),array2.GetLength(1)]; 
    for (int i = 0; i < array1.GetLength(0); i++) 
    { 
        for (int j = 0; j < array2.GetLength(1); j++){ 
            for (int k = 0; k < array1.GetLength(1); k++)
            array[i,j] += array1[i,k]*array2[k,j]; 
        }
    } 
    return array; 
}
Console.Clear(); 
int [,] arrayA = CreateArray(2,3,0,10);
PrintArray(arrayA); 
Console.WriteLine();
int [,] arrayB = CreateArray(3,4,0,10);
PrintArray(arrayB); 
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
if (ValidateArray(arrayA, arrayB)){
int [,] arrayC = MultiplyArrays(arrayA, arrayB);
PrintArray(arrayC); 
}