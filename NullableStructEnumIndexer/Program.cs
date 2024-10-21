namespace NullableStructEnumIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt arr = new ListInt(1);
            arr[0] = 13;
            arr.Add(1);
            arr.AddRange(1, 3, 534, 465, 465, 47, 47, 47545, 74);
            Console.WriteLine(arr);
            arr.AddRange(1, 2, 3, 4);
            Console.WriteLine(arr);
            arr.RemoveRange(3, 4, 46);
            arr.Sum();
            Console.WriteLine(arr);




        }
    }
}
