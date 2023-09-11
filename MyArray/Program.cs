using MyArrays;

Random rand = new Random();
int size = 10;
int n;
MyArray ray = new MyArray(size);
for (int i = 0; i < size; i++)
{
    n = rand.Next(1, 10);
    ray.AddValue(n);
}
Console.WriteLine($"second largest num: {ray.Max2()}\nsum: {ray.ArraySum()}\n");
ray.PrintArray();
for (int i = 0; i < 2; i++)
{
    n = rand.Next(1, 9);
    Console.WriteLine($"{n} was counted: {ray.Count(n)} times\n" +
        $"digit {n} was counted: {ray.CountDigit(n)} times");
    ray.Remove(n);
}
Console.WriteLine();
ray.PrintArray();
n = rand.Next(1, 10);
for (int i = 0; ray.IsAvailable() >= 0 && i < n; i++)
{
    ray.AddValue(i);
}
ray.PrintArray();
Console.WriteLine(ray);
