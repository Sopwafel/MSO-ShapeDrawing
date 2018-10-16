using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{

    private int x;
	private int y;
	private int size;

    public Circle(int x, int y, int size)
    {
		this.x = x;
		this.y = y;
		this.size = size;
    }

    public override void Draw(Graphics Canvas)
    {
		Pen pen = new Pen(Color.Black);
        Canvas.DrawEllipse(pen, this.x, this.y, this.size, this.size);
    }

    public override string SVGObject()
    {
        int xnew, ynew, newsize;
        newsize = size / 2;
        xnew = x + (newsize);
        ynew = y + (newsize);
        string svg = String.Format("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke-width=\"1\" fill=\"none\" stroke=\"black\" />", xnew, ynew, newsize);
        return svg;
    }

}
