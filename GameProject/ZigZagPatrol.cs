﻿
using GameFramework.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFramework;
using GameFramework.Interface;

namespace GameProject
{
    internal class ZigZagPatrol:IMovement
    {
        private int speed;
        private Point boundry;
        private Direction direction;
        private int count;
        private int offset = 20;
        public ZigZagPatrol(int speed, Point boundry, Direction direction)
        {
            this.speed = speed;
            this.boundry = boundry;
            this.direction = Direction.Right;
            count = 0;
        }

        public Point Move(Point currentLocation)
        {
            if (direction == Direction.Right)
            {
                if (count < 5)
                {
                    currentLocation.X += speed;
                    currentLocation.Y -= speed;
                }
                else if (count >= 5 && count < 10)
                {
                    currentLocation.X += speed;
                    currentLocation.Y += speed;
                }
            }
            else if (direction == Direction.Left)
            {
                if (count < 5)
                {
                    currentLocation.X -= speed;
                    currentLocation.Y += speed;
                }
                else if (count >= 5 && count < 10)
                {
                    currentLocation.X -= speed;
                    currentLocation.Y -= speed;
                }
            }
            if ((currentLocation.X + offset+50) >= boundry.X)
            {
                direction = Direction.Left;

            }
            else if ((currentLocation.X + speed) <= 0)
            {
                direction = Direction.Right;

            }
            if (count == 10)
            {
                count = 0;
            }
            count++;
            return currentLocation;
        }
    }
}
