using System;

namespace Shape
{
  public class Square :Rectangle, Resizeable
  {
     
  private double side = 1.0;

    public Square()
    {
    }

    public Square(double width):base(width) 
    {
      
    } 
  

    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
    }

    public double getSide()
    {
      return getWidth();
    }

    public void setSide(double side)
    {
      base.setWidth(side);
      base.setLength(side);
    }
    public override void setWidth(double width)
    {
      setSide(width);
    }

    public override void setLength(double length)
    {
      setSide(length);
    }

    public override string ToString()
    {
      return "A Square with side="
              + getSide()
              + ", which is a subclass of "
              + base.ToString();
    }
  }
}