using System;
using System.Drawing;

public abstract class Shape
{

	public Shape()
	{
	}

    public abstract string SVGObject();

    public abstract void Draw(Graphics Canvas);
	
}