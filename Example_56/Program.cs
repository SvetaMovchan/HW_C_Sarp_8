/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
void FindRowMinSum(int [,] array){ 
    int sum;
    int minSumRow = 0;
    int indMinSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        sum = 0; 
        for (int j = 0; j < array.GetLength(1); j++){
            sum=sum+array[i,j]; 
        }
        Console.WriteLine($"сумма {i+1} строки = {sum}");
        if (i == 0) minSumRow = sum;
        if(sum<minSumRow){
            minSumRow = sum; 
            indMinSumRow = i;
        }
    }
    Console.WriteLine(); 
    Console.WriteLine($"Минимальная сумма {minSumRow}: строка => {indMinSumRow+1}"); 
}    
Console.Clear(); 
int [,] array = CreateArray(6,5,0,10);
PrintArray(array); 
Console.WriteLine();
FindRowMinSum(array);