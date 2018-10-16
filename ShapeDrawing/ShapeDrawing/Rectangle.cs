using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

    private int x;
	private int y;
	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }

    public override string SVGObject()
    {
        int x2, y2;
        x2 = x + width;
        y2 = y + height;
        string svg = String.Format("<polyline points=\"{0},{1} {2},{3} {4},{5} {6},{7} {8},{9}\" style=\"fill:none;stroke:black;stroke-width:1\" />", x, y,   x2, y,    x2, y2,   x, y2,   x,y );
        return svg;
    }

    public override void Draw(Graphics Canvas)
    {
		Pen pen = new Pen(Color.Black);
		Canvas.DrawLine(pen,x,y,x + width,y);
		Canvas.DrawLine(pen,x+width,y,x+width,y+height);
		Canvas.DrawLine(pen,x+width,y+height,x,y+height);
		Canvas.DrawLine(pen,x,y+height,x,y);
    }
}

