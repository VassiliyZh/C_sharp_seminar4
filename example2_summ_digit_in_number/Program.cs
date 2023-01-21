// Вводим число и на выходе получаем сумму цифр этого числа

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] arr = new int[num.ToString().Length];
int i = 0, s = 0; ;
while (num > 0)
{
   arr[i] = num % 10;
   num /= 10;
   s += arr[i];
   i++;
}
Console.WriteLine("Сумма цифр числа равна " + s);

