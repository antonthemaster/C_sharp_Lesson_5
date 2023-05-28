int arr_length = new Random().Next(5, 15);
double [] arr_num = new double[arr_length];
double result = 0;
double minValue = -10;
double maxValue = 10;
for (int i = 0; i < arr_length; i++)
{
    double new_double = new Random().NextDouble() * (maxValue - minValue) + minValue;
    arr_num[i] = Math.Round(new_double);
}
result = arr_num.Max() - arr_num.Min();
Console.WriteLine(String.Join(", ", arr_num));
Console.WriteLine(result);


