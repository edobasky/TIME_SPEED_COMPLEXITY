
namespace SORTING
{
    public class BubbleSort
    {
        /*
         Here 3 things are kept track off,
        1. the i iterator, 2. the j(i + 1) iterator and then the wall
          which separates unsorted from sorted, as every sort it left
        on the other side of the wall........for the inner loop
        i and i+1 is checked withing the boundaries of the current wall and swapped if i is 
        greater than (i + 1)....
         */
        public int[] sortImp(int[] array)
        {
            for (int a = array.Length - 1; a > 0; a--)
            {
                for (int i = 0; i < a; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
            return array;
        }

        private void Swap(int[] arr, int i, int y)
        {
            if (i == y) return;

            int temp = arr[i];
            arr[i] = arr[y];
            arr[y] = temp;
        }

        #region Increasing order udemy Assessment
        public int[] sortDecreasingOrder(int[] array)
        {
            for(int w = array.Length - 1 ; w < array.Length;w--)
            {
                for (int i = 0; i < w; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        Swap(array,i, i + 1);
                    }
                }
            }
            return array;
        }

        #endregion
    }

}
