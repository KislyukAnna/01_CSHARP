int n = 5;
//int[] arr = new int[10]{2,6,5,3,4,8,9,8,3,10};
int[] array = { 10, 4, 7, 3, 9 };

int i = 0;
int max = array[0];

while (i < n) //(i < arr.Lenght)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    i = i + 1;
}
Console.Write($"{max}");

max = array[0];
for (int j=0; j<n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.Write($"{max}");

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Write($"{max}");