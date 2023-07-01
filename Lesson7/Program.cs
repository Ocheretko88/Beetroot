
namespace Lesson7
{
    public enum SortAlgorithmType
    {
        Selection,
        Bubble,
        Insertion
    }

    public enum OrderBy
    {
        Asc,
        Desc
    }

    public class SortAlgorithms
    {
        public static void Main()
        {
            int[] array = { 5, 2, 7, 1, 9 };
            Sort(array, SortAlgorithmType.Selection, OrderBy.Asc);
            Console.WriteLine("Sorted array in ascending order:");
            PrintArray(array);

            Sort(array, SortAlgorithmType.Bubble, OrderBy.Desc);
            Console.WriteLine("Sorted array in descending order:");
            PrintArray(array);

            Sort(array, SortAlgorithmType.Insertion, OrderBy.Asc);
            Console.WriteLine("Sorted array in ascending order:");
            PrintArray(array);

            Console.ReadLine();
        }

        private static void Sort(int[] array, SortAlgorithmType algorithmType, OrderBy orderBy)
        {
            switch (algorithmType)
            {
                case SortAlgorithmType.Selection:
                    SelectionSort(array, orderBy);
                    break;
                case SortAlgorithmType.Bubble:
                    BubbleSort(array, orderBy);
                    break;
                case SortAlgorithmType.Insertion:
                    InsertionSort(array, orderBy);
                    break;
                default:
                    throw new ArgumentException("Invalid sort algorithm type.");
            }
        }

        private static void SelectionSort(int[] array, OrderBy orderBy)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (orderBy == OrderBy.Asc && array[j] < array[minIndex])
                        minIndex = j;
                    else if (orderBy == OrderBy.Desc && array[j] > array[minIndex])
                        minIndex = j;
                }

                Swap(array, i, minIndex);
            }
        }

        private static void BubbleSort(int[] array, OrderBy orderBy)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orderBy == OrderBy.Asc && array[j] > array[j + 1])
                        Swap(array, j, j + 1);
                    else if (orderBy == OrderBy.Desc && array[j] < array[j + 1])
                        Swap(array, j, j + 1);
                }
            }
        }

        private static void InsertionSort(int[] array, OrderBy orderBy)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                if (orderBy == OrderBy.Asc)
                {
                    while (j >= 0 && array[j] > key)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                }
                else if (orderBy == OrderBy.Desc)
                {
                    while (j >= 0 && array[j] < key)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                }

                array[j + 1] = key;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}