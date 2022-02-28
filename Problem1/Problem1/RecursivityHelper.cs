namespace Problem1
{
    public static class RecursivityHelper
    {
        public static int Sum(int[] array)
        {
            return Sum(array, 0);
        }

        private static int Sum(int[] array, int i)
        {
            if (array is null || 
                i < 0 ||
                i >= array.Length)
            {
                // argument invalid
                return 0;
            }

            // i == array.Length - 1 => suma = array[i]
            // otherwise,
            // sum(array[i] ... array[array.Length - 1]) = array[i] +
            //                                             sum(array[i+1] ... array[array.Length - 1])


            if (i == array.Length - 1)
            {
                return array[i];
            }

            return array[i] + Sum(array, i + 1);
        }
    }
}
