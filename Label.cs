using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallCatcher
{
    internal class Label
    {
        int score;
        string text, score1;
        Vector2 position;
        SpriteFont font;
        Color color;

        public Label(int score,string text,string score1, Vector2 position, SpriteFont font, Color color)
        {
            this.score = score;
            this.score1 = score1;  
            this.text = text;
            this.position = position;
            this.font = font;
            this.color = color;
        }

        public int Score
        { get => score; set => score = value; }
        public string Text
        {get => text; set => text = value;}
        public string Score1
        { get=> score1; set => score1 = value;}

        public SpriteFont Font
        {get => font;set => font = value;}

        public Color Color
        {get => color;set => color = value;}

        public Vector2 Position
        {get => position;set => position = value;}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, text, position, color);
        }

        public void parseintString()
        {
            this.score1 = Convert.ToString(Score);
        }

    }
}
