# TInder 4 Food 🍔🍕🍣

## Project Overview 
Tinder 4 Food is a simple WPF desktop app that lets users swipe through healthy meals, view their macros, and ingredients. 
Users can "like" or "dislike" meals using swipe-style buttons, similar to Tinder.
User likes are saved locally for future reference.

### Features
- User- friendly interface with swipe-style buttons for liking or disliking meals.
- Displays macros and ingredients for each meal.
- Stores liked meals locally for easy access later.
- Organized MVC-style structure.

### File Structure 
|-- Tinder_For_Food
	|-- Assets
		|-- Images
	|-- Controllers
		|-- MealController.cs
	|--Model
		|-- DataStorage.cs
		|-- Meal.cs
	|-- View
		|--MainWindow.xaml
			|-- MainWindow.xaml.cs
	|-- App.xaml
	|-- App.xaml.cs
	|-- Tinder_For_Food.csproj
	|-- README.md

### Installation Instructions 
1. Open the git repository in Visual Studio.
2. Download 


### How Data is Stored
User input (liked meals) is stored in a local JSON file using the DataStorage class. 

### Known Issues / Limitations
- THe meal list is hardacoded and limited. Future versions could integrate with a meal API for more variety.
- Swipe functionality is simulated with buttons. Future versions could implement actual swipe gestures.

### Debugging Summary 
- Checked for null references when loading meals.
- Ensured JSON file is created and accessed correctly for storing liked meals.
- Tested UI responsiveness and button functionality.
- Verified meal data is displayed correctly.

### Credits and Acknowledgements
- Developed by Nicole Soto for Software Engineering 1 at Newman University.
- Used WPF framework for the desktop application.
- Used Google for Meal Images.
- Inspired by Tinder's swipe interface for a fun user experience.
- Used ChatGPT for code optimization, meal ideas, and macro calculations.