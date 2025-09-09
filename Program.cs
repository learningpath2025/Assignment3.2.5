namespace Assignment3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArray();
            int item = GetItem();
            Console.WriteLine($"Index for {item} is: {Search(arr, item)}");
        }

        public static int GetItem()
        {
            Console.Write("Enter the item to search for: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[] GetArray()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static int Search(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
