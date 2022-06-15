using System;

namespace CSE210_Greed.Game.Casting
{
   class Gem : Actor
   {
      public Gem()
      {
         SetText("*");
         SetColor(Constants.RED);
         Reset();
      }

   }
}