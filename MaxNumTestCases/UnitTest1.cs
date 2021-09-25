using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberGeneric;
namespace MaxNumTestCases
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void TestMethodPrint()
        {
            int max1 = new CalculateMax<int>(34, 156, 16).Print(); //Arrange and Act
            float max2 = new CalculateMax<float>(3.8f, 1.8f, 9.4f).Print();
            string max3 = new CalculateMax<string>("Apple", "Peach", "Banana").Print();

            Assert.AreEqual(156,max1); // assert
            Assert.AreEqual(9.4f, max2);
            Assert.AreEqual("Peach", max3);
        }
    }
}
