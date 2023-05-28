int arr_length = new Random().Next(5, 15);
int [] arr_num = new int[arr_length];
int even_count = 0;
for (int i = 0; i < arr_length; i++)
{
    int new_int = new Random().Next(100, 1000);
    if(new_int % 2 == 0)
    {
        even_count ++;
    }
    arr_num[i] = new_int;
}

Console.WriteLine(String.Join(", ", arr_num));
Console.WriteLine(even_count);

