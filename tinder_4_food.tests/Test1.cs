using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tinder_4_food.tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void LikeCounter_ShouldIncrease()
        {
            int likes = 0;

            likes++;

            Assert.AreEqual(1, likes);
        }

        [TestMethod]
        public void FoodName_ShouldNotBeEmpty()
        {
            string foodName = "Pizza";

            Assert.IsFalse(string.IsNullOrEmpty(foodName));
        }
    }
}