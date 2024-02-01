int n = 10;
//int[] arr = new int[10]{2,6,5,3,4,8,9,8,3,10};
int[] array = {2,6,5,3,4,8,9,8,3,10};

int i = 0;

while (i<n) //(i < arr.Lenght)
{
    if (array[i] % 2 == 0)
    {
       System.Console.Write($"{array[i]} "); 
    }
    
    i = i + 1;
}