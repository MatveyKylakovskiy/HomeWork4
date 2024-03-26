//First task
int[] array = { 1, 2, 3, 2, 5, 6, 7, 8, 9 };

Console.WriteLine("Enter a number to check");

int number = int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        counter++;
    }
}

switch (counter)
{
    case 0:
        {
            Console.WriteLine($"The number {number} is not included in the array");
            break;
        }

    default:
        {
            Console.WriteLine($"The number {number} is included in the array");
            break;
        }
}