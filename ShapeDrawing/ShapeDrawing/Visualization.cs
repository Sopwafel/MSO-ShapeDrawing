using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShapeDrawing
{
    /// <summary>
    /// Abstract implementation of ways to draw shapes
    /// </summary>
    public abstract class Visualization
    {
        public abstract void DrawLine(Pen pen, int x, int y, int x2, int y2);
        public abstract void DrawEllipse(Pen pen, int x, int y, int size, int size2);

    }
}
