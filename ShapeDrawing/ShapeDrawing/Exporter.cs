using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    abstract class Exporter : Visualization
    {
        protected StringBuilder ExportString;
        public abstract string Export();
    }
}
