using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;

namespace Solution.Tests
{
    [TestClass]
    public class Solution_aVeryBigSumShould
    {
        // private readonly Solution _solution;

        // public Solution_aVeryBigSumShould()
        // {
        //     _solution = new Solution();
        // }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            long[] input = new long[] 
            {
                1000000001, 
                1000000002, 
                1000000003, 
                1000000004, 
                1000000005
            };
            long expecting = 5000000015;

            // Act
            long result = Solution.aVeryBigSum(input);

            // Assert
            Assert.AreEqual(result, expecting);
        }
    }
}
