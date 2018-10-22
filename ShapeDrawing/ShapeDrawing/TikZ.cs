using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class TikZ : Exporter
    {
        /// <summary>
        /// LateX wants smaller shapes
        /// </summary>
        private float scalefactor = 22;
        public TikZ()
        {
            // This piece of code was taken from https://stackoverflow.com/questions/9160059/set-up-dot-instead-of-comma-in-numeric-values
            // Because LateX wants dots instead of commas
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            ExportString = new StringBuilder("\\documentclass{article}\n\\usepackage{tikz}\n\\begin{document}\n\\begin{tikzpicture}");
        }
        public override void DrawEllipse(Pen pen, int x, int y, int size, int size2)
        {
            // These numbers are an approximation because LateX uses different scales
            // The circle is slightly misaligned but fixing that would be a lot of trial and error and doesn't have anything to do with the subject matter.
            ExportString.Append(String.Format("\n\\draw ({0},{1}) circle ({2}cm);", 1.45*x/(scalefactor),1.45*-y/(scalefactor),size/(scalefactor*2)));
        }

        public override void DrawLine(Pen pen, int x, int y, int x2, int y2)
        {
            ExportString.Append(String.Format("\n\\draw ({0},{1}) -- ({2},{3});", x/scalefactor, -y/scalefactor, x2/ scalefactor, -y2/ scalefactor));
        }

        public override string Export()
        {
            ExportString.Append("\n\\end{tikzpicture}\n\\end{document}");
            return ExportString.ToString();
        }
    }
}
