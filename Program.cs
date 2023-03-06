

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
// int[] L = new int[100]; 
while(current <= num)
{
    // L.Append[Math.Pow(current, 2)];
    Console.WriteLine(Math.Pow(current, 2));
    // Console.WriteLine(L);
    current ++;
}