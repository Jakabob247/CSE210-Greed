using System;

namespace CSE210_Greed.Game.Casting
{
   class Actor
   {
      private Point position = new Point(0,0);
      private Point velocity = new Point(0,0);
      private Color color = new Color(255,255,255);
      private int fontSize = 15;


      /*
      summary: The constructor
      */
      public Actor()
      {
      }


      /*
      summary: Gets the object of the color
      return: (Color color) The color instance of the object
      */
      public Color GetColor()
      {
         return color;
      }


      /*
      summary: Gets the object of the position
      return: (Point position) The position instance of the object
      */
      public Point GetPosition()
      {
         return position;
      }


      /*
      summary: Gets tehe object of the velocity
      return: (Point velocity) The velocity instance of the object
      */
      public Point GetVelocity()
      {
         return velocity;
      }


      /*
      summary: Moves the actor to its next position according to its velocity. Will wrap the position from one side of the screen to the other when it reaches the maximum x and y values.
      param: (int maxX) The maximun x value
      param: (int maxY) The maximun y value
      */
      public void MoveNext(int maxX, int maxY)
      {
         int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
         int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
         position = new Point(x, y);
      }


      /*
      summary: Sets the actor's color to the given value.
      param: (Color color) The given color
      */
      public void SetColor(Color color)
      {
         if (color == null)
         {
            throw new ArgumentException("color can't be null");
         }
         this.color = color;
      }


      /*
      summary: Sets the actor's font size to the given value.
      param: (int fontSize) The given font size
      */
      public void SetFontSize(int fontSize)
      {
         if (fontSize <= 0)
         {
            throw new ArgumentException("fontSize must be greater than zero");
         }
         this.fontSize = fontSize;
      }


      /*
      summary: Sets the actor's position to the given value.
      param: (Point position) The given position
      */
      public void SetPosition(Point position)
      {
         if (position == null)
         {
               throw new ArgumentException("position can't be null");
         }
         this.position = position;
      }


      /*
      summary: Sets the actor's velocity to the given value.
      param: (Point velocity) The given velocity.
      */
      public void SetVelocity(Point velocity)
      {
         if (velocity == null)
         {
               throw new ArgumentException("velocity can't be null");
         }
         this.velocity = velocity;
      }


   }
}