﻿//First task
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


//Additional tasks
//Eighth task


/*int[,] array1 = new int[3, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
int[,] array2 = new int[4, 3] { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 }, { 2, 1, 0 } };

var row = array1.GetLength(0);
var collum = array2.GetLength(1);

int[,] array3 = new int[row, collum];

for (var i = 0; i < row; i++)
{
    for (var j = 0; j < collum; j++)
    {

        for (var k = 0; k < collum; k++)
        {
            array3[i, j] += array1[i, k] * array2[k, j];
        }
    }
}


for (var i = 0; i < row; i++)
{
    for (var j = 0; j < collum; j++)
    {
        Console.Write("{0} ", array3[i, j]);
    }
    Console.WriteLine();
}*/

//Ninth task

/*int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
var summ = 0;

for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        summ += array[i, j];
    }
}

Console.WriteLine(summ);*/

//Tenth task
/*
int[,] array = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 4, 0, 2, 9 }, {1, 3, 2, 7} };


for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j< array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("The main diagonal: ");
    
for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        if ( i == j)
        {
            Console.Write( array[i, j] + " ");
        }
    }
    
}

Console.WriteLine();
Console.Write("The side diagonal: ");

var size = array.GetLength(0) - 1;

for (int i = size; i >= 0; i--)
{
    Console.Write(array[i, size - i] + " ");
}*/

//Eleventh task

int[,] array = new int[4, 4] { { 2, 8, 1, 5 }, { 5, 1, 7, 2 }, { 5, 5, 2, 2 }, { 0, 1, 2, 0 } };


for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


int[] row1 = new int[array.GetLength(0)];
int[] row2 = new int[array.GetLength(0)];
int[] row3 = new int[array.GetLength(0)];
int[] row4 = new int[array.GetLength(0)];


for (var i = 0; i < array.GetLength(0); i++)
{
        row1[i] = array[0, i];
    
        row2[i] = array[1, i];
    
        row3[i] = array[2, i];
    
        row4[i] = array[3, i];
    
}

Console.Write("First row  ");
Console.Write(string.Join(" ", row1));
Console.WriteLine();

Console.Write("Second row ");
Console.Write(string.Join(" ", row2));
Console.WriteLine();

Console.Write("Third row  ");
Console.Write(string.Join(" ", row3));
Console.WriteLine();

Console.Write("Fourth row ");
Console.Write(string.Join(" ", row4));
Console.WriteLine();

var tmp1 = 0;
for (var m = 0; m < row1.Length; m++)
{
    for (var n = 0; n < row1.Length - 1; n++)
    {
        if (row1[n] > row1[n + 1] )
        {
            tmp1 = row1[n];
            row1[n] = row1[n + 1];
            row1[n + 1] = tmp1;
        }
    }
}

Console.Write("First row after sotring  ");
Console.Write(string.Join(" ", row1));
Console.WriteLine();

var tmp2 = 0;
for (var m = 0; m < row2.Length; m++)
{
    for (var n = 0; n < row2.Length - 1; n++)
    {
        if (row2[n] > row2[n + 1])
        {
            tmp2 = row2[n];
            row2[n] = row2[n + 1];
            row2[n + 1] = tmp2;
        }
    }
}

Console.Write("Second row after sotring ");
Console.Write(string.Join(" ", row2));
Console.WriteLine();

var tmp3 = 0;
for (var m = 0; m < row3.Length; m++)
{
    for (var n = 0; n < row3.Length - 1; n++)
    {
        if (row3[n] > row3[n + 1])
        {
            tmp3 = row3[n];
            row3[n] = row3[n + 1];
            row3[n + 1] = tmp3;
        }
    }
}

Console.Write("Third row after sotring  ");
Console.Write(string.Join(" ", row3));
Console.WriteLine();

var tmp4 = 0;
for (var m = 0; m < row4.Length; m++)
{
    for (var n = 0; n < row4.Length - 1; n++)
    {
        if (row4[n] > row4[n + 1])
        {
            tmp4 = row4[n];
            row4[n] = row4[n + 1];
            row4[n + 1] = tmp4;
        }
    }
}

Console.Write("Fourth row after sotring ");
Console.Write(string.Join(" ", row4));
Console.WriteLine();












