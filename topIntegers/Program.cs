string[] inputArray = Console.ReadLine().Split();

int[] number = new int[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++)
{
    number[i] = int.Parse(inputArray[i]); 
}

for (int i = 0; i < number.Length; i++)
{
    bool isTop = true;
    for (int j = i+1; j < number.Length; j++)
    {
        if (number[i] <= number[j])
        {
            isTop = false;
            break; 
        }
    }

    if (isTop)
    {
        Console.Write($"{number[i]} ");
    }
}