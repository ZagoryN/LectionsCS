// Цикл в цикле - вывод таблицы умножения

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); // отделили строкой умножение на каждое число
}