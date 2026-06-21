using NUnit.Framework;
using NUnit.Framework.Legacy;
using SORTING;

namespace TIME_SPEED_COMPLEXITY.ALGO_TEST
{
    [TestFixture]
    public class SortingTest
    {

        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] {2,1 };
            samples[2] = new[] {2,1,3};
            samples[3] = new[] {2,3,-1,3,4};
            samples[4] = new[] {4,-5,3,3};
            samples[5] = new[] { 5, 6, 0, 7, 4, 7 };
            samples[6] = new[] { 6, 7, 0,-2, 3, -8,  -4, 6, 7, 3, 5 };
            samples[7] = new[] { 0,-5,3,0};
            samples[8] = new[] { -6, -4, 0, 6, 9, 3 };
            return samples;
          
        }

        private void RunTestForSortAlgorithms(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }

        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("------------TRACE-----------\n");
            foreach (var el in array)
            {
                TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n-----------------------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestForSortAlgorithms(BubbleSort.sortImp);
        }
    }
}
