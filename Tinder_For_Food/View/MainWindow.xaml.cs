using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using Tinder_For_Food.Controller;
using Tinder_For_Food.Model;

namespace Tinder_For_Food
{
    public partial class MainWindow : Window
    {
        private readonly AppController _controller;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new AppController();
            DisplayCurrentMeal();
        }

        private void DisplayCurrentMeal()
        {
            var meal = _controller.GetCurrentMeal();

            MealName.Text = meal.Name;
            CaloriesText.Text = $"Calories: {meal.Calories}";
            ProteinText.Text = $"Protein: {meal.Protein}g";
            CarbohydratesText.Text = $"Carbohydrates: {meal.Carbohydrates}g";
            FatsText.Text = $"Fats: {meal.Fats}g";

            // Ingredients
            var ingredients = meal.Ingredients
                                  .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(i => i.Trim())
                                  .ToList();

            IngredientsList.ItemsSource = ingredients;

            // Load image
            try
            {
                MealImage.Source = new BitmapImage(
                    new Uri($"pack://application:,,,/{meal.ImagePath}")
                );
            }
            catch
            {
                MealImage.Source = null;
            }
        }

        private void LikeButton_Click(object sender, RoutedEventArgs e)
        {
            _controller.LikeCurrentMeal();
            DisplayCurrentMeal();
        }

        private void DislikeButton_Click(object sender, RoutedEventArgs e)
        {
            _controller.DislikeCurrentMeal();
            DisplayCurrentMeal();
        }
    }
}