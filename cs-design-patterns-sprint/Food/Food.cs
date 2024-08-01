using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public class Food
    {
        public string Name { get; private set; }
        public double Calories { get; private set; }

        public Food(string name, double calories)
        {
            this.Name = name;
            this.Calories = calories;
        }
      
    }
}
