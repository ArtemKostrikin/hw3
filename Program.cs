using static System.Console;
Clear();
Write("Введите число: ");
int Number = Convert.ToInt32(ReadLine());
int count = 1;
while(count <= Number)
{
Write($"{Math.Pow(count,3)} ");
count++;
}
