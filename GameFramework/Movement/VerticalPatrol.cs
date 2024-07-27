using GameFramework.Enum;
using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class VerticalPatrol:IMovement
    {
        private int Speed;
        private Point Boundary;
        private Direction direction;
        private int OffSet = 20;
        public VerticalPatrol(int speed, Point boundary, Direction direction)
        {
            this.Speed = speed;
            this.Boundary = boundary;
            this.direction = direction;
        }

        public Point Move(Point location)
        {
            if ((location.Y + OffSet+50) >= Boundary.Y)
            {
                direction = Direction.Up;
            }

            else if (location.Y - OffSet <= 0)
            {
                direction = Direction.Down;
            }
            if (direction == Direction.Up)
            {
                location.Y -= Speed;
            }
            else if (direction == Direction.Down)
            {
                location.Y += Speed;
            }
            return location;
        }
    }
}
