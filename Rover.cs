using System;

namespace MarsRover{
    public class MarsRover{
        Direction currentDirection;
        Plateau roverPlateau;
        Coordinates currentCoordinate;

         public MarsRover(Direction direction, Plateau plateau, Coordinates position)
       {
           currentCoordinate = position;
           currentDirection = direction;
           roverPlateau = plateau;
       }
    }
}