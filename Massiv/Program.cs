Random Rnd = new Random(); // Генератор псевдослучайных чисел
int[,] mas = new int[5, 10]; // Массив на 5 строк и 10 столбцов
double[,] mas1 = new double[5,10]; // Массив на 5 строк и 10 столбцов
HashSet<int> set = new HashSet<int>(); // Создания хеш сет для хранения уникальных значений
Console.Write("Массив со случайными значениями:");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        int rnd = Rnd.Next(-100, 100); // Инициализация переменной с рандомным значением от -100 до 100
        while (set.Contains(rnd)) // Если значение переменной rnd уже есть в хеш сет, генерируем её заново до тех пор пока её значение не станет уникальным
        {
            rnd = Rnd.Next(-100, 100);
        }
        set.Add(rnd); // Добавляем хеш сет переменную
        mas[i, j] = rnd; // добавляем переменную в массив
        if (j % 10 == 0) Console.WriteLine(""); 
        Console.Write($"{mas[i, j]} ");
    }
}
// Копируем int массив в массив double
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        mas1[i, j] = mas[i, j];
    }
}
// Поиск наибольшего числа
int Max = -101;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (Max < mas[i, j])
        {
            Max = mas[i, j];
        }
    }
}
Console.Write($"\n\nНаибольшее число: {Max}\n");
for (int i = -10; i < 11; i++)
{
    Console.Write($"При {i} | sin: {Math.Round(Math.Sin(i * Max), 2)} | "); // Находим синус и округляем до двух знаков после запятой
    Console.Write($"cos: {Math.Round(Math.Cos(i * Max), 2)} | "); // Находим косинус и округляем до двух знаков после запятой
    Console.Write($"tan: {Math.Round(Math.Tan(i * Max), 2)}\n"); // Находим тангенс и округляем до двух знаков после запятой
}
// Поиск наименьшего числа
int Min = 101;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (Min > mas[i, j])
        {
            Min = mas[i, j];
        }
    }
}
Console.Write($"\nНаименьшее число: {Min}\n");
for (int i = -10; i < 11; i++)
{
    Console.Write($"При {i} | sin: {Math.Round(Math.Sin(i * Min), 2)} | "); // Находим синус и округляем до двух знаков после запятой
    Console.Write($"cos: {Math.Round(Math.Cos(i * Min), 2)} | "); // Находим косинус и округляем до двух знаков после запятой
    Console.Write($"tan: {Math.Round(Math.Tan(i * Min), 2)}\n"); // Находим тангенс и округляем до двух знаков после запятой
}

Console.WriteLine("\nСреднее арифметическое для каждой строки:");
// Суммирование всех элементов строки и деления их на 10
double sred1 = ((Math.Abs(mas1[0, 0]) + Math.Abs(mas1[0, 1]) + Math.Abs(mas1[0, 2]) + Math.Abs(mas1[0, 3]) + Math.Abs(mas1[0, 4]) + Math.Abs(mas1[0, 5]) + Math.Abs(mas1[0, 6]) + Math.Abs(mas1[0, 7]) + Math.Abs(mas1[0, 8]) + Math.Abs(mas1[0, 9])) / 10);
Console.WriteLine(sred1);
double sred2 = ((Math.Abs(mas1[1, 0]) + Math.Abs(mas1[1, 1]) + Math.Abs(mas1[1, 2]) + Math.Abs(mas1[1, 3]) + Math.Abs(mas1[1, 4]) + Math.Abs(mas1[1, 5]) + Math.Abs(mas1[1, 6]) + Math.Abs(mas1[1, 7]) + Math.Abs(mas1[1, 8]) + Math.Abs(mas1[1, 9])) / 10);
Console.WriteLine(sred2);
double sred3 = ((Math.Abs(mas1[2, 0]) + Math.Abs(mas1[2, 1]) + Math.Abs(mas1[2, 2]) + Math.Abs(mas1[2, 3]) + Math.Abs(mas1[2, 4]) + Math.Abs(mas1[2, 5]) + Math.Abs(mas1[2, 6]) + Math.Abs(mas1[2, 7]) + Math.Abs(mas1[2, 8]) + Math.Abs(mas1[2, 9])) / 10);
Console.WriteLine(sred3);
double sred4 = ((Math.Abs(mas1[3, 0]) + Math.Abs(mas1[3, 1]) + Math.Abs(mas1[3, 2]) + Math.Abs(mas1[3, 3]) + Math.Abs(mas1[3, 4]) + Math.Abs(mas1[3, 5]) + Math.Abs(mas1[3, 6]) + Math.Abs(mas1[3, 7]) + Math.Abs(mas1[3, 8]) + Math.Abs(mas1[3, 9])) / 10);
Console.WriteLine(sred4);
double sred5 = ((Math.Abs(mas1[4, 0]) + Math.Abs(mas1[4, 1]) + Math.Abs(mas1[4, 2]) + Math.Abs(mas1[4, 3]) + Math.Abs(mas1[4, 4]) + Math.Abs(mas1[4, 5]) + Math.Abs(mas1[4, 6]) + Math.Abs(mas1[4, 7]) + Math.Abs(mas1[4, 8]) + Math.Abs(mas1[4, 9])) / 10);
Console.WriteLine(sred5);

double[] mas2 = new double[5] { sred1, sred2, sred3, sred4, sred5 }; // Создаём массив для средних значений

// Поиск наибольшего числа
double Max1 = -101;
for (int i = 0; i < 5; i++)
{
    if (Max1 < mas2[i])
    {
        Max1 = mas2[i];
    }
}
Console.Write($"\nНаибольшее число: {Max1}\n");
for (int i = -10; i < 11; i++)
{
    Console.Write($"При {i} | sin: {Math.Round(Math.Sin(i * Max1), 2)} | "); // Находим синус и округляем до двух знаков после запятой
    Console.Write($"cos: {Math.Round(Math.Cos(i * Max1), 2)} | "); // Находим косинус и округляем до двух знаков после запятой
    Console.Write($"tan: {Math.Round(Math.Tan(i * Max1), 2)}\n"); // Находим тангенс и округляем до двух знаков после запятой
}
// Поиск наименьшего числа
double Min1 = 101;
for (int i = 0; i < 5; i++)
{
    if (Min1 > mas2[i])
    {
        Min1 = mas2[i];
    }
}
Console.Write($"\nНаименьшее число: {Min1}\n");
for (int i = -10; i < 11; i++)
{
    Console.Write($"При {i} | sin: {Math.Round(Math.Sin(i * Min1), 2)} | "); // Находим синус и округляем до двух знаков после запятой
    Console.Write($"cos: {Math.Round(Math.Cos(i * Min1), 2)} | "); // Находим косинус и округляем до двух знаков после запятой
    Console.Write($"tan: {Math.Round(Math.Tan(i * Min1), 2)}\n"); // Находим тангенс и округляем до двух знаков после запятой
}

string Path = @"C:\Users\lijokufgh\Desktop\222.txt"; //Прописываем путь до текстового файлика
using (StreamWriter wr = new StreamWriter(Path, false)) // Подключаем возможность взаимодействовать с файлом
{
    wr.WriteLine("sin cos tan");
    for (int i = -10; i < 11; i++) // Записываем значения в текстовый файл
    {
        wr.Write($"{Math.Round(Math.Sin(i * Max1), 2)} ");
        wr.Write($"{Math.Round(Math.Cos(i * Max1), 2)} ");
        wr.Write($"{Math.Round(Math.Tan(i * Max1), 2)}\n");
    }
    wr.WriteLine("0 0 0");
    wr.WriteLine("0 0 0");
    wr.WriteLine("0 0 0");
    wr.WriteLine("sin cos tan");
    for (int i = -10; i < 11; i++) // Записываем значения в текстовый файл
    {
        wr.Write($"{Math.Round(Math.Sin(i * Min1), 2)} ");
        wr.Write($"{Math.Round(Math.Cos(i * Min1), 2)} ");
        wr.Write($"{Math.Round(Math.Tan(i * Min1), 2)}\n");
    }
}