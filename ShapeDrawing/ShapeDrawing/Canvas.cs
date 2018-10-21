using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    /// <summary>
    /// The C# canvas for drawing shapes
    /// </summary>
    class Canvas : Visualization
    {
        /// <summary>
        /// Graphic object to paint to
        /// </summary>
        public Graphics graphics
        {
            get;
            private set;
        }

        public Canvas(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public override void DrawEllipse(Pen pen, int x, int y, int size, int size2)
        {
            graphics.DrawEllipse(pen, x, y, size, size2);
        }

        public override void DrawLine(Pen pen, int x, int y, int x2, int y2)
        {
            graphics.DrawLine(pen, x, y, x2, y2);
        }
    }
}
