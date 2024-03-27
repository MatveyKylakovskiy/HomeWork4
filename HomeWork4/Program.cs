//First task
/*int[] array = { 1, 2, 3, 2, 5, 6, 7, 8, 9 };

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
            Console.WriteLine($"The number {number} is included in the array {counter} times");
            break;
        }
}*/

//Second task
/*int[] array = { 1, 3, 2, 3, 4, 5, 4, 3};

Console.WriteLine("Enter a number to check");

int number = int.Parse(Console.ReadLine());
int counter1 = 0;


for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        counter1++;
        
    }
    
}

switch (counter1) { 
    case 0:
        {
            Console.WriteLine($"The number {number} is not included in the array");
            break;
        }

    default:
        {
            int[] arrayNew = new int[array.Length - counter1];
            int counter2 = 0;

            foreach (int item in array)
            {

                if (number != item)
                {
                    arrayNew[counter2] = item;
                    counter2++;
                }
            }

            Console.WriteLine(string.Join(",", array));

            Console.WriteLine(string.Join(",", arrayNew));
        }
        break;

}*/

//Third task
Console.WriteLine("Inter size of array");

int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}

int max = array[0];
int min = array[0];
double avrg = array[0];

foreach (int item in array)
{

    if (item > max)
    {
        max = item;
    }

    else if (item < min)
    {
        min = item;
    }

    avrg += item;
}

double average = avrg / size;

Console.WriteLine($"Max: {max}, Min: {min}, Average: {average}");
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));