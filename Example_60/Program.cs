/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int [] CreateArray1(){ 
    int [] array = new int [90]; 
    for (int i = 0; i < 90; i++) 
    { 
        array[i] = 10+i;
    } 
    return array; 
} 
void PrintArray1(int [] array){ 
    int row = array.Length; 
    Console.WriteLine("Одномерный массив двузначных чисел");
    for (int i = 0; i < row; i++) 
    { 
        Console.Write($"{array [i]}({i})\t");
    }
    Console.WriteLine(); 
    Console.WriteLine();
} 
int [,,] CreateArray(int row, int col, int lon, int [] array){ 
    Random rand = new Random(); 
    int n = 0;
    int end = 90;
    int [,,] array3 = new int [row,col,lon]; 
    for (int i = 0; i < row; i++){ 
        for (int j = 0; j < col; j++){ 
            for (int k = 0; k < lon; k++){
                n = rand.Next(0,end);
                array3[i,j,k] = array[n];
                end = end - 1;
                array[n] = array[end];
                array[end] = 0;
            }
        } 
    } 
    Console.WriteLine("Одномерный массив после заполнения трехмерного массива");
    PrintArray1(array);
    return array3; 
} 

void PrintArray(int [,,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1);
    int lon = array.GetLength(2); 
    Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел");
    for (int k = 0; k < lon; k++) 
    { 
        for (int i = 0; i < row; i++) 
        { 
            for (int j = 0; j < col; j++){
                Console.Write($"{array [i,j,k]}({i},{j},{k})\t");
            }
            Console.WriteLine(); 
        } 
        Console.WriteLine(); 
    } 
} 
Console.Clear();
int row = 3; 
int col = 4;
int lon = 6;
if ((row*col*lon) <= 90)
{
    int [] array1 =  CreateArray1();
    PrintArray1(array1);
    int [,,] arrayA = CreateArray(row,col,lon,array1);
    PrintArray(arrayA); 
    Console.WriteLine();
}
else
{
    Console.WriteLine("Размер массива более 90 элементов! Основное условие задачи не выполнимо!");
}