Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i=1;

while (i<=number)
{
    int cube = (int)Math.Pow(i, 3);
    i++;
    Console.Write(cube + " ");
}
