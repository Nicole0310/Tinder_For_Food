using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Tinder_For_Food.Model
{
    // Abstraction for how liked meals are stored (for SOLID + testability)
    public interface ILikeStorage
    {
        void SaveLikes(List<Meal> likedMeals);
        List<Meal> LoadLikes();
    }

    // Concrete implementation using a JSON file
    public class JsonFileLikeStorage : ILikeStorage
    {
        private const string FilePath = "likedMeals.json";

        public void SaveLikes(List<Meal> likedMeals)
        {
            if (likedMeals == null) throw new ArgumentNullException(nameof(likedMeals));

            string json = JsonSerializer.Serialize(
                likedMeals,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(FilePath, json);
        }

        public List<Meal> LoadLikes()
        {
            if (!File.Exists(FilePath))
                return new List<Meal>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Meal>>(json) ?? new List<Meal>();
        }
    }
}
