int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

bool isfound = false;

for (int i = 0; i < number.Length; i++)
{
    int leftSum = number.Take(i).Sum();
    int rightSum = number.Skip(i + 1).Sum();

    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        isfound = true;
        break; 
    }
}
if (!isfound)
{
    Console.WriteLine("no");
}