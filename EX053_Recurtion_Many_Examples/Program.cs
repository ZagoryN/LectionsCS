//Решение задач рекурсией

//1 задача. Собрать строку с числами от a до b, a ≤ b
/*string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
} */
//Используя рекурсию 
/*string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty; //условие выхода в строке else
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10
*/

//2 задача. Сумма чисел от 1 до n
//Решение без рекурсии
/*int SumFor(int n)
{
 int result = 0;
 for (int i = 1; i <= n; i++) result += i;
 return result;
}*/

//Испольуя рекурсию
/*int SumRec(int n)
{
 if (n == 0) return 0; //n==0 - условие выхода. Если прописать n == 1, return 1, рекурсия будет на 1 цикл меньше
 else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55 */

//3 задача. Факториал числа - произведение чисел от 1 до N
/*//простой итеративный способ
int FactorialFor(int n)
{
 int result = 1;
 for (int i = 1; i <= n; i++) result *= i;
 return result;
}*/

// Используя рекурсию
/*int FactorialRec(int n)
{
 if (n == 1) return 1;
 else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800
*/

//4 задача. Вычислить а в степени n
/*int PowerFor(int a, int n)
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}

//Используя рекурсию
int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // тернарный оператор - запись по другому, в одну строчку
 if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a;
} */

//улучшенный вызов, используя математические формулы (сложение степеней, перемножение степеней)
/*int PowerRecMath(int a, int n)
{
 if (n == 0) return 1;
 else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
 else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024 */



//5 задача. Перебор слов
//В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова,
//состоящие из T букв, которые можно построить из букв этого алфавита.
/*
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)   // перебор для однобуквенных слов
    {
        for (int k = 0; k < count; k++) // перебор для двухбуквенный слов
        {
            for (int l = 0; l < count; l++) // перебор для трехбуквенных слов
            {
                for (int m = 0; m < count; m++) // для четрыхбуквенный слов
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}
*/

//Общее решение - решение, которое не привязано к количеству циклов
/*int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);
*/
// 6 задача. Просмотр директории
//класс DirectoryINfo() - мы должны указать путь к той папке, свойства которой хотим посмотреть
// Не работает
/*string path = @"./LectionCS/Examples/EX040_Theorem_Triangle";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
void CatalogInfo(string path, string indent = "") //рекурсивный метод
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
//string path = @"./LectionCS/Examples/EX040_Theorem_Triangle";
CatalogInfo(path);
*/

//Задача 7. Игра в пирамидки

/*void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
//1 - шпиль, откуда мы переставляем блин, 3 - где должны оказаться блины, 2 - промежуточный блин, т.к. их всего 3
//int count = 3 - это количество блинов
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();*/

//Задача 8. Бинарное дерево
//Обойти дерево - значит, получить все значения узлов, которые в нем находятся

/*string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; // Массив, представляющий дерево
//                   0  1   2       3   4     5    6    7   8    9    10    11

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length) // позиция меньше либо равно кол-ву узлов в нашем дереве
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal(); */

//Задача 9. Числа Фибоначчи
/*decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}
decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

//# 1 2 3 4 5
//V 1 1 2 3 5
Console.ReadLine();
//DateTime dt = DateTime.Now;

for (int n = 10; n <= 15; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
    fIte = 0;
}
//System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
//dt = DateTime.Now;

for (int n = 10; n <= 15; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
Console.ReadLine();

//System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
*/



//StackOverFlow

void Rec()
{
    Rec();
}

Rec();


//Задача 10. Закрашивание области

int[,] pic = new int[1000, 1000];
for (int i = 0; i < 1000; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 999] = 1;
    pic[999, i] = 1;
}