using System;

namespace MarsRover
{   
   public class Direction
    {
      public enum direction { E, N, W, S }

      public direction currentDirection;
       public void turnLeft()
       {
           var position = (int) currentDirection;
           position = (position + 1) % 4;
           currentDirection = (direction)position;
       }
       public void turnRight()
       {
           var position = (int)currentDirection;
           position = (position - 1) % 4;
           if (position < 0)
           {
               position = 4 + position;
           }
           currentDirection = (direction)position;
       }
    }
}