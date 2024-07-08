using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BallCatcher
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        int speed;
        Platform platform1;
        Platform platform2;
        public Ball ball;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            speed = 9; // Initialize speed before creating platform instances

            ball = new Ball(Content.Load<Texture2D>("Untitled"), Color.Red, new Rectangle(200, 200, 50, 50),
                5, 5, Window.ClientBounds.Width, Window.ClientBounds.Height, true, true);

            platform1 = new Platform(Content.Load<Texture2D>("player1"),
                new Rectangle(0, 0, 50, 150), Color.Red, 0, Window.ClientBounds.Height, speed);

            platform2 = new Platform(Content.Load<Texture2D>("player2"),
                new Rectangle(Window.ClientBounds.Width - 50, Window.ClientBounds.Height - 150, 50, 150),
                Color.Blue, 0, Window.ClientBounds.Height, speed);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            ball.ballMovement();

            // Check collision with platforms
            ball.ballcollision(platform1.PlatRec);
            ball.ballcollision(platform2.PlatRec);


            KeyboardState state = Keyboard.GetState();

            platform2.platformMovement(Keys.Up, Keys.Down);
            platform1.platformMovement(Keys.W, Keys.S);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(platform1.PlatText, platform1.PlatRec, platform1.PlatColor);
            _spriteBatch.Draw(platform2.PlatText, platform2.PlatRec, platform2.PlatColor);
            _spriteBatch.Draw(ball.BallTexture, ball.BallRec, ball.BallColor);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}