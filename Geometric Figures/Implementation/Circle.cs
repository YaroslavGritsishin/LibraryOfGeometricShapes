using Geometric_Figures.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Figures.Implementation
{
    public class Circle : ICircle
    {
        /// <summary>
        /// Значение радиуса круга
        /// </summary>
        private double Radius { get; set; } = 0;
        /// <summary>
        /// Расчитывает площадь круга, площадь круга зависит от его радиуса, значение радиуса по умолканию 0 
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        /// <summary>
        /// Устанавливает значение радиуса
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetRadius(double value)
        {
            if(value < 0)
                throw new ArgumentException(nameof(value), "Значение радиуса не может быть отрицательным");
            this.Radius = value;
        }
    }
}
