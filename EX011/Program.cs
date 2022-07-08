Console.Write("Введите число: ");  // приглашение ко вводу
int N = Convert.ToInt32(Console.ReadLine()); // вводим число N
int a = -N;
while (a < N+1)
{
    Console.Write(a); 
    a = a+1; 
}