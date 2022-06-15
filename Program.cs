using System;
using CSE210_Greed.Game.Directing;
using CSE210_Greed.Game.Services;

namespace CSE210_Greed{
   class Program
   {
      public Program(){
      Director director = new Director();
      director.StartGame();
   }
   }
}