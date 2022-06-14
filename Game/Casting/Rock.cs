using System;

namespace CSE210_Greed.Game.Casting
{
   class Rock : Actor
   {
      private char shape = 'O';

      public char GetShape()
      {
         return shape;
      }
   }
}