using FindMaximumNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1,2,3,3)]
        [DataRow(1,4,2,4)]
        [DataRow(5,2,1,5)]
        public void MaximumIntegerNumber_PassThreeNumbers_ReturnMaximumNumber(int a, int b, int c, int max)
        {
            int result = MaximumNumberCheck.MaximumIntegerNumber(a, b, c);
            Assert.AreEqual(result, max);
        }
    }
}
