using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Figures.Abstract
{
    public interface ITriangle: IFigure
    {
        void SetSideA(double value);
        void SetSideB(double value);
        void SetSideC(double value);
    }
}
