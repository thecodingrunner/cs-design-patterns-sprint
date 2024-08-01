using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public class Vitamins
    {
        public int VitaminA { get; private set; }
        public int VitaminC { get; private set; }

        public Vitamins(int vitaminA, int vitaminC)
        {
            this.VitaminA = vitaminA;
            this.VitaminC = vitaminC;
        }       
    }
}
