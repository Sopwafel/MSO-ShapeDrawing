using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    /// <summary>
    /// Concrete implementation that can generate an SVG string from DrawLine and DrawEllipse commands
    /// </summary>
    class SVG : Visualization
    {
        /// <summary>
        /// Current SVGString
        /// </summary>
        StringBuilder SVGString;
        public SVG()
        {
            SVGString = new StringBuilder("<?xml version=\"1.0\" standalone=\"no\"?> <!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 1.1//EN\" \"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\"> <svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\"> ");
        }
        /// <summary>
        /// Draws an Ellipse to the SVG string
        /// </summary>
        /// <param name="pen"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="size"></param>
        /// <param name="size2"></param>
        public override void DrawEllipse(Pen pen, int x, int y, int size, int size2)
        {
            int xnew, ynew, newsize;
            newsize = size / 2;
            xnew = x + (newsize);
            ynew = y + (newsize);
            string svg = String.Format("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke-width=\"1\" fill=\"none\" stroke=\"black\" />", xnew, ynew, newsize);
            SVGString.Append(svg);
        }

        // Draws a Line to the SVG string
        public override void DrawLine(Pen pen, int x, int y, int x2, int y2)
        {
            SVGString.Append(String.Format("<line x1=\"{0}\" y1=\"{1}\" x2=\"{2}\" y2=\"{3}\" style=\"fill:none; stroke:black; stroke - width:1\" />", x, y, x2, y2));
        }

        /// <summary>
        /// Builds the SVGString and returns it
        /// </summary>
        /// <returns></returns>
        public string export()
        {
            SVGString.Append("</svg>");
            return SVGString.ToString();
        }

    }
}
