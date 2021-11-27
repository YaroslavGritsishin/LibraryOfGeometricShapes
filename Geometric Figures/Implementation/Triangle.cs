using Geometric_Figures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometric_Figures.Implementation
{
    public class Triangle : ITriangle
    {
        /// <summary>
        /// Значение стороны А
        /// </summary>
        private double SideA { get; set; } = 0;
        /// <summary>
        /// Значение стороны B
        /// </summary>
        private double SideB { get; set; } = 0;
        /// <summary>
        /// Значение стороны С
        /// </summary>
        private double SideC { get; set; } = 0;
        /// <summary>
        /// Расчетывает площадь треугольника по трем сторонам, по умолчанию все стороны равны 0
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            var triangleParties = new List<double>()
            {
                SideA, SideB, SideC
            };
            double semiPerimeter = triangleParties.Sum() / 2;
            return Math.Sqrt(triangleParties.Select(sideValue => semiPerimeter - sideValue)
                 .Aggregate(semiPerimeter, (accamulate, sourceItem) => sourceItem * accamulate));
        }
        /// <summary>
        /// Устанавливает значение стороны А 
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetSideA(double value)
        {
            if (value < 0)
                throw new ArgumentException(nameof(SideA), "Значение стороны треугольника не может быть отрицательным");
            this.SideA = value;
        }
        /// <summary>
        /// Устанавливает значение стороны B
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetSideB(double value)
        {
            if (value < 0)
                throw new ArgumentException(nameof(SideB), "Значение стороны треугольника не может быть отрицательным");
            this.SideB = value;
        }
        /// <summary>
        /// Устанавливает значение стороны C
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetSideC(double value)
        {
            if (value < 0)
                throw new ArgumentException(nameof(SideC), "Значение стороны треугольника не может быть отрицательным");
            this.SideC = value;
        }
    }
}
