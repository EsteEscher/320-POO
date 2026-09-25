
namespace test_my_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestThatSumOfTenAndTenIsTwenty()
        {
            //arrange
            int x = 10;
            int y = 10;
            int z = -15;

            //act
            int res = MyMath.Somme(x, y);
            int res2 = MyMath.Somme(x, z);

            //assert
            Assert.AreEqual(20, res);
            Assert.AreEqual(-5, res2);

        }
    }
}
