namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0) return 0;
            double sum = 0;
            foreach (int x in vector)
                sum += x * x;
            length = Math.Sqrt(sum);
            // end

            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0) return 0;
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            foreach (int x in array)
                if (x > min && x < max)
                    count++;
            // end

            return count;
        }

        public void Task3(int[] array)
        {
            
            // code here
            if (array == null || array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIndex]) maxIndex = i;

            if (maxIndex == array.Length - 1) return;

            int minAfterIndex = maxIndex + 1;
            for (int i = maxIndex + 1; i < array.Length; i++)
                if (array[i] < array[minAfterIndex]) minAfterIndex = i;

            if (array[minAfterIndex] == array[maxIndex]) return;

            int temp = array[maxIndex];
            array[maxIndex] = array[minAfterIndex];
            array[minAfterIndex] = temp;
            // end

        }

        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxIndex = -1;
            int maxVal = int.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIndex = i;
                }
            }
            if (maxIndex != -1)
                array[maxIndex] = maxIndex;
            // end

        }

        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0) return -1;
            index = Array.IndexOf(array, P);
            // end

            return index;
        }

        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIndex]) maxIndex = i;

            if (maxIndex == 0) return;

            for (int i = 0; i + 1 < maxIndex; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end

        }

        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            answer = array.Where(x => x >= 0).ToArray();
            // end

            return answer;
        }

        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;
            Array.Sort(array);
            Array.Reverse(array);
            // end

        }

        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;
            Array.Reverse(array);
            // end
            
        }

        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null) return null;
            if (A == null || A.Length == 0) return (int[])B.Clone();
            if (B == null || B.Length == 0) return (int[])A.Clone();

            int len = A.Length + B.Length;
            C = new int[len];
            int i = 0, j = 0, k = 0;

            while (i < A.Length && j < B.Length)
            {
                C[k++] = A[i++];
                C[k++] = B[j++];
            }
            while (i < A.Length) C[k++] = A[i++];
            while (j < B.Length) C[k++] = B[j++];
            // end

            return C;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0) return null;
            if (a == b && n == 1)
            {
                array = new double[] { a };
                return array;
            }
            if (a == b || n < 2) return null;

            array = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
                array[i] = a + i * step;
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3) return null;
            if (raw.All(x => x == -1)) return (double[])raw.Clone();

            restored = (double[])raw.Clone();
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    double left = (i > 0) ? raw[i - 1] : -1;
                    double right = (i < raw.Length - 1) ? raw[i + 1] : -1;

                    if (left != -1 && right != -1)
                        restored[i] = (left + right) / 2;
                    else if (left != -1 && right == -1)
                        restored[i] = left;
                    else if (left == -1 && right != -1)
                        restored[i] = right;
                }
            }
            // end

            return restored;
        }
    }
}
