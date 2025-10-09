using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Tinder_For_Food.Model
{
    internal class DataStorage
    {
        private const string FilePath = "likedMeals.json";

        public static void SaveLikes(List<Meal> likedMeals)
        {
            string json = JsonSerializer.Serialize(likedMeals, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static List<Meal> LoadLikes()
        {
            if (!File.Exists(FilePath))
                return new List<Meal>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Meal>>(json) ?? new List<Meal>();
        }
    }
}
