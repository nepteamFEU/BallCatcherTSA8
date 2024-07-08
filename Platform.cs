using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BallCatcher
{
    internal class Platform
    {
        Texture2D platText;
        Rectangle platRec;
        Color platColor;
        int boundTop, boundBottom;
        int speed;

        public Platform(Texture2D platText, Rectangle platRec, Color platColor, int boundTop, int boundBottom, int speed)
        {
            this.platText = platText;
            this.platRec = platRec;
            this.platColor = platColor;
            this.boundTop = boundTop;
            this.boundBottom = boundBottom;
            this.speed = speed;
        }

        public Texture2D PlatText { get => platText; set => this.platText = value; }
        public Rectangle PlatRec { get => platRec; set => this.platRec = value; }
        public Color PlatColor { get => platColor; set => this.platColor = value; }

        public void platformMovement(Keys upKey, Keys downKey)
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(upKey) && platRec.Y > boundTop)
            {
                platRec.Y -= speed;
            }
            if (state.IsKeyDown(downKey) && (platRec.Y + platRec.Height) < boundBottom)
            {
                platRec.Y += speed;
            }
        }

        public int speedSet { get => speed; set => this.speed = value; }
    }
}
