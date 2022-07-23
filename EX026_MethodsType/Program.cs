// Вид 1
void Method1() // в скобках нет аргументов
{
    Console.WriteLine("Автор ...");
}
// Как вызываются
//Method1(); // При вызове обязательно должны стоять скобки
//Method1; // такая команда (без скобок) вызовет ошибку


// Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("Текст сообщения"); // вызов 
//Method2(msg:"Текст сообщения"); // именованные аргументы (какому аргументу какое значение)

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//  вызов метода - написать msg "текст" count раз
//Method21 ("Текст", 5);    // вызов метода со строгим порядком, но без именования аргументов
//Method21 (msg:"Текст", count: 5); // вызов метода с явным именованием переменных
//Method21 (count: 5, msg:"Новый текст"); // при именовании не важен порядок


//Вид 3
int Method3()  //без аргументов
{ 
    return DateTime.Now.Year;  // произошла работа метода
}

int year = Method3(); // результат работы метода
Console.WriteLine(year);

//Вид4
/*string Method4(int count, string text)
{
    int i=0;
    //string result = ""; // пустая строка, но правильнее написать String.Empty
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res); */

//Вид 4 с помощью FOR

string Method4(int count, string text)
{
    
    //string result = ""; // пустая строка, но правильнее написать String.Empty
    string result = String.Empty;
    for (int i=0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res); 