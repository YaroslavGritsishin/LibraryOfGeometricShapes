using Geometric_Figures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometric_Figures.Implementation
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Значение стороны А
        /// </summary>
        public double SideA { get; set; } = 0;
        /// <summary>
        /// Значение стороны B
        /// </summary>
        public double SideB { get; set; } = 0;
        /// <summary>
        /// Значение стороны С
        /// </summary>
        public double SideC { get; set; } = 0;
        /// <summary>
        /// Расчет площади треугольника по трем сторонам, по умолкчанию все стороны равны 0
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            var triangleParties = new List<double>() 
            {
                SideA, SideB, SideC
            };
            double semiPerimeter = triangleParties.Sum() / 2;
            return Math.Sqrt(triangleParties.Select(sideValue => semiPerimeter - sideValue)
                 .Aggregate(semiPerimeter, (accamulate, sourceItem) => sourceItem * accamulate));
        }
    }
}
