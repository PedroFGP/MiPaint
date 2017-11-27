using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint.Classes
{
    public enum FigureType
    {
        Line,
        Circle,
        Point
    }

    public enum CanvasState
    {
        CreatingLine = 1,
        CreatingCircle = 2,
        Rotating = 3,
        Translating = 4,
        None = 0
    }
}
