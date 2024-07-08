using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BallCatcher
{
    internal class Ball
    {
        Texture2D ballTexture;
        Color ballColor;
        Rectangle ballRec;
        int speedX, speedY;
        int boundaryX, boundaryY;

        public Ball(Texture2D ballTexture, Color ballColor, Rectangle ballRec,
            int speedX, int speedY, int boundaryX, int boundaryY)
        {
            this.ballTexture = ballTexture;
            this.ballColor = ballColor;
            this.ballRec = ballRec;
            this.speedX = speedX;
            this.speedY = speedY;
            this.boundaryX = boundaryX;
            this.boundaryY = boundaryY;
        }

        public Texture2D BallTexture { get => ballTexture; set => ballTexture = value; }
        public Rectangle BallRec { get => ballRec; set => ballRec = value; }
        public Color BallColor { get => ballColor; set => ballColor = value; }
    }
}
