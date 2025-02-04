using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0.Controllers;
using sprint0.Sprites;
using System.Collections.Generic;

namespace sprint0
{
    public class Sprint0 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D cat;
        private SpriteFont font;
        private ISprite currentSprite;
        private IController keyboardController;
        private IController mouseController;
        private ISprite textSprite;

        public Sprint0()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            cat = Content.Load<Texture2D>("CatSpriteSheet");

            List<Rectangle> nonMovingAnimatedFrames = new List<Rectangle>
            {
                new Rectangle(0, 16, 16, 16),
                new Rectangle(16, 16, 16, 16),
                new Rectangle(32, 16, 16, 16),
                new Rectangle(48, 16, 16, 16)
            };

            List<Rectangle> movingAnimatedFrames = new List<Rectangle>
            {
                new Rectangle(0, 32, 16, 16),
                new Rectangle(16, 32, 16, 16),
                new Rectangle(32, 32, 16, 16),
                new Rectangle(48, 32, 16, 16)
            };

            currentSprite = new NonMovingNonAnimatedSprite(cat, 0, 0, 16, 16); // Initial sprite
            keyboardController = new KeyboardController(cat, nonMovingAnimatedFrames, movingAnimatedFrames);
            mouseController = new MouseController(cat, nonMovingAnimatedFrames, movingAnimatedFrames);

            font = Content.Load<SpriteFont>("File");
            textSprite = new TextSprite(font, "Credits\nProgram Made By: Faye Leigh\nSprites from:\"https://elthen.itch.io/2d-pixel-art-cat-sprites\"");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Handle input
            keyboardController.HandleInput(ref currentSprite);
            mouseController.HandleInput(ref currentSprite);

            // Update the current sprite
            currentSprite.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Draw the current sprite
            currentSprite.Draw(_spriteBatch, new Vector2(392, 232));
            textSprite.Draw(_spriteBatch, new Vector2(200, 400));

            base.Draw(gameTime);
        }
    }
}
