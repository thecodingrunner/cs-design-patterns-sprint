﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public interface INutritionalCalculator
    {
        double CalculateProtein();
        Vitamins CalculateVitamins();
    }
}
