namespace Generics
{
    public class CustomArray<TItem>
    {
        private TItem[] items;

        public CustomArray(int size)
        {
            items = new TItem[size];
        }

        public void Add(TItem item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (EqualityComparer<TItem>.Default.Equals(items[i], default(TItem)))
                {
                    items[i] = item;
                    return;
                }
            }
            throw new IndexOutOfRangeException("Массив переполнен");
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException("Индекс вне массива");
            }
            items[index] = default(TItem);
        }

        public TItem FindFirst(Func<TItem, bool> filter)
        {
            foreach (TItem item in items)
            {
                if (filter(item))
                {
                    return item;
                }
            }
            return default(TItem);
        }

        public void Print()
        {
            foreach (TItem item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= items.Length || index2 < 0 || index2 >= items.Length)
            {
                throw new IndexOutOfRangeException("Индекс вне массива");
            }
            TItem temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }

}
