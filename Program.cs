//Задано n троек целых чисел (ai,bi,ci).Определить, сколько троек может быть использовано для построения треугольника со сторонами a_i, b_i, c_i.

//взаимодействие с юзеоом
Console.WriteLine("введи переменную n (количество троек чисел) ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];
int[] b = new int[n];
int[] c = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("введите три числа через enter: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    b[i] = Convert.ToInt32(Console.ReadLine());
    c[i] = Convert.ToInt32(Console.ReadLine());
}
// логика тут
int count = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] + b[i] > c[i] && a[i] + c[i] > b[i] && b[i] + c[i] > a[i])
    {
        count++;
    }
}

//вывод
string outMessage = $"Количество троек из которых можно сделать треугольник: {count}";
Console.WriteLine(outMessage);

