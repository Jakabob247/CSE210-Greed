using Raylib_cs;
namespace CSE210_Greed;

public class Color
{
	private Raylib.Color myColor;

	public Color(int r, int g, int b, int a)
	{
		myColor.r = r;
		myColor.g = g;
		myColor.b = b;
		myColor.a = a;
	}

	public Color(Raylib.Color color)
    {
		this.myColor = color;
    }

	public Raylib.Color GetColor()
    {
		return myColor;
    }

	public void SetColor(int r, int g, int b, int a)
	{
		myColor.r = r;
		myColor.g = g;
		myColor.b = b;
		myColor.a = a;
	}

	public void SetColor(Raylib.Color color)
    {
		this.myColor = color;
    }

	
}