using Geometric_Figures.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Figures.Implementation
{
    public class Circle : Figure
    {
        /// <summary>
        /// Значение радиуса круга
        /// </summary>
        public double Radius { get; set; } = 0;
        /// <summary>
        /// Расчёт площади круга, площадь круга зависит от его радиуса, значение радиуса по умолканию 0 
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
