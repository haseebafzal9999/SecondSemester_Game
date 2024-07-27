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
    public class HorizontalPatrol:IMovement
    {
        private int Speed;
        private Point Boundary;
        private Direction direction;
        private int OffSet = 20;
        public HorizontalPatrol(int speed, Point boundary, Direction direction)
        {
            this.Speed = speed;
            this.Boundary = boundary;
            this.direction = direction;
        }

        public Point Move(Point location)
        {
            if ((location.X + OffSet+50) >= Boundary.X)
            {
                direction = Direction.Left;
            }

            else if (location.X - OffSet <= 0)
            {
                direction = Direction.Right;
            }
            if (direction == Direction.Left)
            {
                location.X -= Speed;
            }
            else if (direction == Direction.Right)
                location.X += Speed;
            return location;
        }
    }
}
