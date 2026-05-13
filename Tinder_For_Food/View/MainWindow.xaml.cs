using System;
using System.IO;
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

            // Ingredients: split by comma for the ItemsControl
            var ingredients = meal.Ingredients
                                  .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(i => i.Trim())
                                  .ToList();
            IngredientsList.ItemsSource = ingredients;

            // Load the image
            if (File.Exists(meal.ImagePath))
            {
                MealImage.Source = new BitmapImage(new Uri(Path.GetFullPath(meal.ImagePath)));
            }
            else
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
