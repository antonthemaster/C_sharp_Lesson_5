int arr_length = new Random().Next(5, 15);
int [] arr_num = new int[arr_length];
int result = 0;
for (int i = 0; i < arr_length; i++)
{
    int new_int = new Random().Next(100);
    if(i % 2 != 0)
    {
        result += new_int;
    }
    arr_num[i] = new_int;
}

Console.WriteLine(String.Join(", ", arr_num));
Console.WriteLine(result);

