//First task
/*int[] array = { 1, 2, 3, 2, 5, 6, 7, 8, 9 };

Console.WriteLine("Enter a number to check");

int number = int.Parse(Console.ReadLine());
bool check = false;

for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        check = true;
        break;

    }

}

if (check)
{
    Console.WriteLine($"The number {number} is included in array");

}
else
{
    Console.WriteLine($"The number {number} is not included in array");
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
/*Console.WriteLine("Inter size of array");

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

Console.WriteLine($"Max: {max}, Min: {min}, Average number: {average}");
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));*/

//Fourth task
/*int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 6, 7, 8, 9, 10 };

Console.Write("First array  ");
Console.WriteLine(string.Join(" , ", array1));

Console.Write("Second array ");
Console.WriteLine(string.Join(" , ", array2));

double average1 = 0;

foreach (int item in array1)
{

    average1 += item;
}

double average2 = 0;

foreach (int item in array2)
{

    average2 += item;
}

if (average1 > average2)
{
    Console.WriteLine($"The average number of firs array is higher");
}

else if (average1 < average2)
{
    Console.WriteLine($"The averege number of second array is higher");
}

else if (average1 == average2)
{
    Console.WriteLine("Average numbers is equals");
}*/


//Additional tasks
//Fourth task 

/*bool check = true;
Console.WriteLine("Enter size of array. When size > 5 and size <= 10");

while (check)
{

    int size = int.Parse(Console.ReadLine());

    if (size > 5 & size <= 10)
    {
        int[] array1 = new int[size];
        Random rnd = new Random();
        int counter1 = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = rnd.Next(1, 10);
            if (array1[i] % 2 == 0)
            {
                counter1++;
            }
        }

        Console.WriteLine();
        Console.Write("Initial array ");
        Console.WriteLine(string.Join(",", array1));
        Console.WriteLine();

        switch (counter1)
        {
            case 0:
                {
                    Console.WriteLine($"There are no even numbers in the array");
                    break;
                }

            default:
                {
                    int[] array2 = new int[counter1];
                    int counter2 = 0;

                    foreach (int item in array1)
                    {

                        if (item % 2 == 0)
                        {
                            array2[counter2] = item;
                            counter2++;
                        }
                    }

                    
                    Console.WriteLine("An array of even numbers");
                    Console.WriteLine(string.Join(",", array2));
                }
                break;
        }

                check = false;

    }
    else
    {
        Console.WriteLine("Try again");
    }


}*/

//Additional tasks
//Fifth task

/*Console.WriteLine("Enter size of array");

int size = int.Parse(Console.ReadLine());
int[] array1 = new int[size];
Random rnd = new Random();


for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rnd.Next(1, 10);
}

int[] array2 = new int[size];

for (int i = 0; i < array1.Length; i++)
{
    if(i % 2 == 0)
    {
        array2[i] = array1[i];
    }
    else if (i % 2 != 0)
    {
        array2[i] = 0;
    }
}

Console.Write("Initial array       ");
Console.WriteLine(string.Join(" , ", array1));
Console.Write("Array after changed ");
Console.WriteLine(string.Join(" , ", array2));*/


//Additional tasks
//Sixth task
/*
string[] array = { "Matvey", "Anton", "Vladimir", "Vitaly", "Arnold", "motvey" };

string temp = "";

for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)

    {
        int result = string.Compare(array[i], array[j], StringComparison.CurrentCultureIgnoreCase);

        if (result > 0)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

Console.WriteLine(string.Join(" , ", array));*/


//Additional tasks
//Seventh task
//Bubble sorting is implemented in task 6





