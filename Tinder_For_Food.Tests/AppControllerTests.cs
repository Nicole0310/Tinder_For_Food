namespace Tinder_For_Food.Tests
{
    // Simple in-memory implementation of ILikeStorage for tests
    internal class InMemoryLikeStorage : ILikeStorage
    {
        private List<Meal> _likedMeals = new List<Meal>();

        public void SaveLikes(List<Meal> likedMeals)
        {
            _likedMeals = new List<Meal>(likedMeals);
        }

        public List<Meal> LoadLikes()
        {
            return new List<Meal>(_likedMeals);
        }
    }

    [TestClass]
    public class AppControllerTests
    {
        [TestMethod]
        public void LikeCurrentMeal_AddsCurrentMealToLikedMeals()
        {
            // Arrange
            var storage = new InMemoryLikeStorage();
            var controller = new AppController(storage);

            var firstMeal = controller.GetCurrentMeal();

            // Act
            controller.LikeCurrentMeal();

            // Assert
            Assert.AreEqual(1, controller.LikedMeals.Count);
            Assert.AreEqual(firstMeal.Name, controller.LikedMeals[0].Name);
        }

        [TestMethod]
        public void DislikeCurrentMeal_DoesNotAddToLikedMeals()
        {
            // Arrange
            var storage = new InMemoryLikeStorage();
            var controller = new AppController(storage);

            // Act
            controller.DislikeCurrentMeal();

            // Assert
            Assert.AreEqual(0, controller.LikedMeals.Count);
        }
    }
}
