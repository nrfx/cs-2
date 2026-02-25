//Задано n троек целых чисел (ai,bi,ci).Определить, сколько троек может быть использовано для построения треугольника со сторонами a_i, b_i, c_i.

Console.WriteLine("введи переменную n (количество троек чисел) ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("введите три числа через enter: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());

    if ((a+b>c) && (a+c>b) && (b + c > a)){
        count++;
    }
}

string outMessage = $"Количество троек из которых можно сделать треугольник: {count}";
Console.WriteLine(outMessage);

