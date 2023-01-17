// Вводим 2 числа А и В, на выходе получаем результат возведения числа А в степень В

int GetNumberFromConsole (string message) //<= отвечает за ввод данных и пишет что вводить
    {
        System.Console.Write(message);
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }
int ExponentiationNumber(int A, int B) //<= данная функция делает расчет
    {
        int result = Convert.ToInt32(Math.Pow(A,B));
        return result;
    }
int A = GetNumberFromConsole("A = ");
int B = GetNumberFromConsole("B = ");

System.Console.WriteLine(ExponentiationNumber(A,B));