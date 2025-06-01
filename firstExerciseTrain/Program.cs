int input = int.Parse(Console.ReadLine());
int[] passangers = new int[input];
int total = default;
for (int i = 0; i < input; i++)
{
    passangers[i] = int.Parse(Console.ReadLine());
    total += passangers[i]; 

}
Console.WriteLine(string.Join($" ",passangers));
Console.WriteLine(total);