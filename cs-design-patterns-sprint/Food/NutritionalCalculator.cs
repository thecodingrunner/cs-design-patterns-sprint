using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public class NutritionalCalculator : INutritionalCalculator
    {

        private Food Food { get; set; }
        private string name { get; set; }
        private double calories { get; set; }
        public NutritionalCalculator(Food food)
        {

            name = food.Name;
            calories = food.Calories;

        }

        public double CalculateProtein()
        {

            double proteinConversionFactor = 0.1;
            double baseProteinContent = 5.0;
            double protein = calories / 100.0 * proteinConversionFactor + baseProteinContent;


            return protein;

        }
        public Vitamins CalculateVitamins()
        {
            
            int vitaminA = (int)(calories / 10);
            int vitaminC = (int)(calories / 20);
            Vitamins returnVit = new Vitamins(vitaminA, vitaminC);
            return returnVit;
        }
    }
}
