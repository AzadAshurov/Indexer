namespace NullableStructEnumIndexer
{
    internal class ListInt
    {
        private int[] array = new int[0];
        public ListInt(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public override string ToString()
        {
            return string.Join(", ", array);
        }


        public void Add(int value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }
        public void AddRange(params int[] nums)
        {
            int oldLen = array.Length;
            Array.Resize(ref array, array.Length + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                array[oldLen + i] = nums[i];
            }
        }
        public bool Contains(int num)
        {
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    found = true;
                    Console.WriteLine("NUmber found");
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Not found");
            }
            return found;
        }
        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum is {sum}");
        }
        public void Remove(int num)
        {
            int index = Array.IndexOf(array, num);
            if (index == -1) return;
            int[] newArray = new int[array.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index) continue;
                newArray[newIndex++] = array[i];
            }
            array = newArray;
        }
        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {
                Remove(num);
            }
        }

    }
}

