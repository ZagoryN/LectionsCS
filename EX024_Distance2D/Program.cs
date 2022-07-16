//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату первой точки x1: ");  
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату первой точки y1: ");  
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату первой точки x2: ");  
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки y2: ");  
int y2 = Convert.ToInt32(Console.ReadLine());  

int[] array1 = {x1,y1};
int[] array2 = {x2,y2};
// Math.Pow((x2-x1),2)
double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));  //distance, расстояние
Console.Write(result);
