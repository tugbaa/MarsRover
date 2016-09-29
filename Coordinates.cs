using System;

namespace MarsRover
{
   public class Coordinates
    {
      public int x;
      public int y;
       public Coordinates(int x, int y)
       {
           this.x = x;
           this.y = y;
       }
       public string ToString()
       {
           return x + " " + y;
       }
     public bool isWithinBounds(Coordinates coordinate)
       {
          return x >= coordinate.x && y >= coordinate.y;
       }
    }
}