using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void platformMovement(Keys controls, int player)
        {
            if (player == 1)
            {
                if (controls == Keys.Up && platRec.X > boundTop)
                { platRec.Y -= speed; }
                if (controls == Keys.Down && platRec.Y > boundBottom)
                { platRec.Y += speed; }
            }
            if (player == 2)
            {
                if (controls == Keys.W && platRec.X > boundTop)
                { platRec.Y -= speed; }
                if (controls == Keys.S && platRec.Y > boundBottom)
                { platRec.Y += speed; }
            }

        }

        public int speedSet { get => speed;set => this.speed = value; }
    }
}
