using System;
public class Rectangle{
    private int _length;
    private int _width;
	public int Length{
		set{
			_length=value;
		}
		get{
			return _length;
		}
	}
	public int Width{
		set{
			_width=value;

		}
		get{
			return _width;
		}
	}
    public Rectangle(){}
	public Rectangle(int _length, int _width){
		this._length=_length;
		this._width=_width;


	}
	
	//Fill your code here
	
	public int Area() {
		
		return _length*_width;
	}
	
	public void Display() {
		Console.WriteLine("Rectangle Dimension");
		Console.WriteLine("Length:"+_length);
		Console.WriteLine("Width:"+_width);
		Console.WriteLine("Area of the Rectangle:"+Area());

		

		//Fill your code here
	}
	
	public Rectangle DimensionChange(int d) {
		//Fill your code here
		
		Rectangle obj = new Rectangle();
		obj._length=_length*d;
		obj._width=_width*d;
        	return obj;
	}
}