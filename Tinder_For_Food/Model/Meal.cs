using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tinder_For_Food.Model
{
    public class Meal
    {
        public string Name { get; set; } = "";

        public string ImagePath { get; set; } = "";

        public string Ingredients { get; set; } = "";

        public int Calories { get; set; }

        public int Protein { get; set; }

        public int Carbohydrates { get; set; }

        public int Fats { get; set; }

    }
}
