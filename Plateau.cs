using System;

namespace MarsRover
{
   public class Plateau
    {
       public Plateau(int x, int y)
       {
           this.bottomCoordinate = new Coordinates(0, 0);
           this.upperCoordinate = new Coordinates(x,y);
       }
       Coordinates bottomCoordinate;
       Coordinates upperCoordinate;

    }
}