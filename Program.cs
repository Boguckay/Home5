// Домашняя работа. Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// Console.WriteLine("Введите длину массива:  "); 
//  int size = Convert.ToInt32(Console.ReadLine()); 
//  int[] numbers = new int[size]; 
//  RandonNumbers(numbers); 
//  Console.WriteLine("В этом массиве: "); 
//  PrintArray(numbers);

//  void RandonNumbers(int[] numbers) 
//  { 
//      for(int i = 0; i < size; i++) 
//      { 
//          numbers[i] = new Random().Next(100,1000); 
//      } 
//  } 
 
//  int count = 0; 
//  for (int x = 0; x < numbers.Length; x++) 
//  { 
//  if (numbers[x] % 2 == 0) 
//  count++; 
//  } 
//  Console.WriteLine($"из {numbers.Length} чисел, {count} четных"); 
 
//  void PrintArray(int[] numbers) 
//  { 
//      Console.Write("[ "); 
//      for(int i = 0; i < numbers.Length; i++) 
//      { 
//          Console.Write(numbers[i] + " "); 
//      } 
//      Console.Write("]"); 
//      Console.WriteLine(); 
//  } 



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}