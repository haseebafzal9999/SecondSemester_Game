﻿using EZInput;
using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Movement
{
    public class KeyBoardMovement:IMovement
    {
        private int Speed;
        private System.Drawing.Point Boundary;
        private int OffSet = 20;

        public KeyBoardMovement(int speed, System.Drawing.Point boundary)
        {
            this.Speed = speed;
            this.Boundary = boundary;
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if ((location.Y + OffSet) <= Boundary.Y && Keyboard.IsKeyPressed(Key.DownArrow))
            {
                location.Y += Speed;
            }

            else if (location.Y - OffSet >= 0 && Keyboard.IsKeyPressed(Key.UpArrow))
            {
                location.Y -= Speed;
            }
            else if (location.X - OffSet >= 0 && Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                location.X -= Speed;
            }
            if ((location.X + OffSet) <= Boundary.X && Keyboard.IsKeyPressed(Key.RightArrow))
            {
                location.X += Speed;
            }
            return location;
        }
    }
}
