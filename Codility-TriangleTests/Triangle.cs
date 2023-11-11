using Codility_Triangle;

namespace Codility_TriangleTests
{
    public class SolutionTests
    {
        [Fact]
        public void TriangularTripletExists_Returns1()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = { 10, 2, 5, 1, 8, 20 };

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void TriangularTripletDoesNotExist_Returns0()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = { 10, 50, 5, 1 };

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void NotEnoughElements_Returns0()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = { 1, 2 };

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void EmptyArray_Returns0()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[0];

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void LargestInputRange_Returns1()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[Solution.RANGE_HIGHEST_VALUE];
            for (int i = 0; i < Solution.RANGE_HIGHEST_VALUE; i++)
                input[i] = i + 1;
            
            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(1, result);
        }
    }
}