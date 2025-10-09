using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tinder_For_Food.Controller;


namespace Tinder_For_Food
{
    
public partial class MainWindow : Window
    {
        private AppController controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new AppController();
            ShowCurrentMeal();
        }
        private void ShowCurrentMeal()
        {
            var meal = controller.GetCurrentMeal();

            
            try
            {
                MealImage.Source = new BitmapImage(new Uri($"pack://application:,,,/{meal.ImagePath}", UriKind.Absolute));
            }
            catch
            {
                
                MealImage.Source = null;
            }

            
            MealName.Text = meal.Name;
            CaloriesText.Text = $"Calories: {meal.Calories}";
            ProteinText.Text = $"Protein: {meal.Protein}g";
            CarbohydratesText.Text = $"Carbs: {meal.Carbohydrates}g";
            FatsText.Text = $"Fats: {meal.Fats}g";

            
            IngredientsList.ItemsSource = meal.Ingredients.Split(',').Select(i => i.Trim()).ToList();
        }

        private void LikeButton_Click(object sender, RoutedEventArgs e)
        {
            controller.LikeCurrentMeal();
            ShowCurrentMeal();
        }

        private void DislikeButton_Click(object sender, RoutedEventArgs e)
        { controller.DislikeCurrentMeal();
            ShowCurrentMeal();
        }
    }
}