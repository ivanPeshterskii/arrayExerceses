int n = int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];


for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);

    if (i % 2 == 0)
    {
        firstArray[i] = n1;
        secondArray[i] = n2;
    }
    else
    {
        secondArray[i] = n1;
        firstArray[i] = n2; 
    }
}

Console.WriteLine(string.Join(" ",firstArray));
Console.WriteLine(string.Join(" ", secondArray));

