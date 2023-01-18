// из четверти декартовой системы определяет какой знак имеют х и у
/*
void GetDiapozon(int quadrant)
{
    if (quadrant==1) Console.WriteLine("x>0 and y>0");
    else if (quadrant==2) Console.WriteLine("x<0 and y>0");
    else if (quadrant==3) Console.WriteLine("x<0 and y<0");
    else if (quadrant==4) Console.WriteLine("x>0 and y<0");
    else Console.WriteLine("wrong input");
}
Console.Write("input a number of quater");
int quadNum=Convert.ToInt32(Console.ReadLine());
GetDiapozon(quadNum);
*/
// из коридинат точки выдаюет четверть где она находится
/*int func(int xpos,int ypos)
{
if (xpos>0 && ypos>0) return 1;
else if(xpos<0 && ypos>0) return 2;
else if(xpos<0 && ypos<0) return 3;
else if(xpos>0 && ypos<0) return 4;
else return 0;
}
Console.Write("input a x");
int x=Convert.ToInt32(Console.ReadLine());

Console.Write("input a y");
int y=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(func(x,y));
if (func(x,y)==1) Console.WriteLine("первая четветь");
    else if (func(x,y)==2) Console.WriteLine("вторая четветь");
    else if (func(x,y)==3) Console.WriteLine("третья четветь");
    else if (func(x,y)==4) Console.WriteLine("четвертая четветь");
    else Console.WriteLine("wrong input");
    */

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*void func(int N)
{
  int count=1;
while (count<=N)
{
  int z=count*count;
    Console.WriteLine(z);
    count=count+1;
  }
}
Console.Write("Введите пожалуйста число N");
int N=Convert.ToInt32(Console.ReadLine());
func(N);
*/

/*using System;

class MainClass {
  public static void Main (string[] args) {
    int n;
    Console.WriteLine("Enter a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++) {
      Console.WriteLine(i + " * " + i + " = " + i*i);
    }
  }
}
*/

// кординаты двух точек и определяет расстояние между ними
double funciya(double x1, double y1,double x2, double y2)
{
  return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}
Console.Write("input a x1");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("input a x2");
double x2=Convert.ToDouble(Console.ReadLine());

Console.Write("input a y1");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("input a y2");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write($"растояние между ними равно {funciya(x1,y1,x2,y2)}");

