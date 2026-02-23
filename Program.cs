//Задано n троек целых чисел (ai,bi,ci).Определить, сколько троек может быть использовано для построения треугольника со сторонами a_i, b_i, c_i.

Console.WriteLine("Hello, World!");
string n_str = Console.ReadLine();
int n = Convert.ToInt32(n_str);


int count = 0;

for (int i = 0; i < n; i++)
{
    string a_str = Console.ReadLine();
    int a = Convert.ToInt32(a_str);
    string b_str = Console.ReadLine();
    int b = Convert.ToInt32(b_str);
    string c_str = Console.ReadLine();
    int c = Convert.ToInt32(c_str);

    if (a+b>c) || (a+c>b) || (b + c > a){
        count++;
    }
}

Console.WriteLine(count);

