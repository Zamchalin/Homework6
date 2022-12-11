// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Сколько чисел вы хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;

for(int i = 0; i < n; i++)
{
    Console.Write("Веддите число: ");
int number = Convert.ToInt32(Console.ReadLine());
array[i] = number;
}
 Console.WriteLine($"Вот ваши числа [{string.Join(", ", array)}]");

for( int i = 0; i < n; i++)
{
 if(array[i] > 0)
 count++;

}
Console.WriteLine($"Вы ввели {count} положительных числа");