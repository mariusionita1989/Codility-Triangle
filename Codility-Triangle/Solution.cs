using System.Runtime.CompilerServices;

namespace Codility_Triangle
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                if (N < 3)
                    return 0; // Not enough elements to form a triplet
                // Sort the array in ascending order
                Array.Sort(A);
                // Iterate through the array to find a triangular triplet
                for (int i = 0; i < N - 2; i++)
                {
                    long P = A[i];
                    long Q = A[i + 1];
                    long R = A[i + 2];
                    // Check the triangular conditions
                    if (P + Q > R)
                        return 1; // Triangular triplet found
                }
            }
            return 0; // No triangular triplet found
        }
    }
}
