using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tinder_For_Food.Model;

namespace Tinder_For_Food.Controller
{
    public class AppController
    {
        private List<Meal> meals;
        private int currentIndex = 0;
        public List<Meal> LikedMeals { get; private set; }


        public AppController()
        {
            meals = new List<Meal>
            {
                new Meal
                {
                    Name = "Greek Yogurt Parfait",
                    ImagePath = "Assets/greek_yoggie_parfait.jpg",
                    Calories = 370, 
                    Protein = 27, 
                    Carbohydrates = 48 , 
                    Fats = 6,
                    Ingredients =  "1 cup nonfat Greek yogurt, 1/2 cup granola, 1/2 cup mixed berries, 1 tbsp honey"
                    },
                new Meal
                {
                    Name = "Grilled Chicken Salad",
                    ImagePath = "Assets/grilled_chicken_salad.jpg",
                    Calories = 360,
                    Protein = 35, 
                    Carbohydrates = 10,
                    Fats = 18,
                    Ingredients = "4 oz grilled chicken breast, mixed greens, cucumber, tomato, olive oil & balsamic dressing, 1/4 avocado" 
                },
                new Meal
                {
                    Name = "Baked Salmon with Sweet Potato & Asparagus",
                    ImagePath = "Assets/salmon_potato_asparagus.jpg",
                    Calories = 480, 
                    Protein = 36, 
                    Carbohydrates = 32, 
                    Fats = 20,
                    Ingredients = "5 oz baked salmon, 1 small sweet potato, asparagus (1 cup), olive oil drizzle" 
                },
                new Meal
                {
                    Name = "Veggie Omelet with Avocado Toast",
                    ImagePath = "Assets/veggie_omelet_avocado_toast.jpg",
                    Calories = 410,
                    Protein = 29,
                    Carbohydrates = 22,
                    Fats = 23,
                    Ingredients =  "2 whole eggs, 2 egg whites, spinach, tomato, onion, 1/4 avocado, 1 slice whole grain bread"
                },
                new Meal
                {
                    Name = "Protein Oatmeal Bowl",
                    ImagePath = "Assets/oatmeal_bowl.jpg",
                    Calories = 420,
                    Protein = 30,
                    Carbohydrates = 42,
                    Fats = 13,
                    Ingredients =  "1/2 cup oats, 1 scoop protein powder, 1 tbsp peanut butter, 1/2 banana"
                    },
                new Meal
                {
                    Name = "Turkey & Quinoa Bowl",
                    ImagePath = "Assets/turkey_quinoa.jpg",
                    Calories = 450, 
                    Protein = 34, 
                    Carbohydrates = 35, 
                    Fats = 15,
                    Ingredients = "4 oz ground turkey, 1/2 cup cooked quinoa, roasted veggies (sweet potato, broccoli,zucchini" 
                },
                new Meal
                {
                    Name = "Tuna Wrap",
                    ImagePath = "Assets/tuna_wrap.jpg",
                    Calories = 370, 
                    Protein = 38, 
                    Carbohydrates = 28, Fats = 10,
                    Ingredients = "1 whole wheat tortilla, 4 oz canned tuna (in water), Greek yogurt (1 tbsp), spinach & tomota slices" 
                },
                new Meal
                {
                    Name = "Stir-Fried Tofu & Veggies with Brown Rice",
                    ImagePath = "Assets/tofu_veggies_rice.jpg",
                    Calories = 420, 
                    Protein = 23, 
                    Carbohydrates = 45, 
                    Fats = 14,
                    Ingredients = "1/2 block firm tofu, 1 cup mixed stir-fry vegetables, 1/2 cup cooked brown rice, soy sauce" 
                },
                new Meal
                {
                    Name = "Chicken Burrito Bowl",
                    ImagePath = "Assets/chicken_burrito_bowl.jpg",
                    Calories = 470, 
                    Protein = 38, 
                    Carbohydrates = 45, 
                    Fats = 12,
                    Ingredients =  "4oz grilled chicken, 1/2 cup brown rice, 1/2 cup black beans, 1 tbsp chhese, corn & salsa" 
                },
                new Meal
                {
                    Name = "Shrimp Zoodle Pasta",
                    ImagePath = "Assets/shrimp_zoodle_pasta.jpg",
                    Calories = 370, 
                    Protein = 33, 
                    Carbohydrates = 16, 
                    Fats = 14,
                    Ingredients = "5 oz shrimp, 2 cups zucchini noodles, olive oil (1 tsp), garlic, tomato sauce" 
                }
            };

            LikedMeals = new List<Meal>();
        }

        public Meal GetCurrentMeal() => meals[currentIndex];

        public void LikeCurrentMeal()
        {
            LikedMeals.Add(GetCurrentMeal());
            DataStorage.SaveLikes(LikedMeals);
            NextMeal();
        }

        public void DislikeCurrentMeal() => NextMeal();

        private void NextMeal()
        {
            currentIndex = (currentIndex + 1) % meals.Count;
        }
    }
}
