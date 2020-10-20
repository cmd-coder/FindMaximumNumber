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

        [TestMethod]
        [DataRow(1.1f, 2.2f, 3.3f, 3.3f)]
        [DataRow(1.1f, 4.4f, 2.2f, 4.4f)]
        [DataRow(5.5f, 2.2f, 1.1f, 5.5f)]
        public void MaximumFloatNumber_PassThreeNumbers_ReturnMaximumNumber(float a, float b, float c, float max)
        {
            float result = MaximumNumberCheck.MaximumFloatNumber(a, b, c);
            Assert.AreEqual(result, max);
        }

        [TestMethod]
        [DataRow("1", "2", "3", "3")]
        [DataRow("1", "4", "2", "4")]
        [DataRow("5", "2", "1", "5")]
        public void MaximumStringNumber_PassThreeNumbers_ReturnMaximumNumber(string a, string b, string c, string max)
        {
            string result = MaximumNumberCheck.MaximumStringNumber(a, b, c);
            Assert.AreEqual(result, max);
        }
    }
}
