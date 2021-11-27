using Geometric_Figures.Implementation;

namespace Geometric_Figures
{
    /// <summary>
    /// Геометрические фигуры
    /// </summary>
    public static class GeometricFigures
    {
        private static Circle _circle = null;
        private static Triangle _triangle = null;
        /// <summary>
        /// Круг
        /// </summary>
        public static Circle Circle 
        {
            get
            {
                return _circle ??= new Circle();
            }
        }
        /// <summary>
        /// Треугольник
        /// </summary>
        public static Triangle Triangle
        {
            get
            {
                return _triangle ??= new Triangle();
            }
        }
    }
}
