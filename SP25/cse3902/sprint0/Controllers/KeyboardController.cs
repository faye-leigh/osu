using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using sprint0.Sprites;

namespace sprint0.Controllers
{
    public class KeyboardController : IController
    {
        private Texture2D texture;
        private List<Rectangle> nonMovingAnimatedFrames;
        private List<Rectangle> movingAnimatedFrames;

        public KeyboardController(Texture2D texture, List<Rectangle> nonMovingAnimatedFrames, List<Rectangle> movingAnimatedFrames)
        {
            this.texture = texture;
            this.nonMovingAnimatedFrames = nonMovingAnimatedFrames;
            this.movingAnimatedFrames = movingAnimatedFrames;
        }

        public void HandleInput(ref ISprite currentSprite)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D0))
            {
                // Quit the game
                System.Environment.Exit(0);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                // Display a non-moving, non-animated sprite
                currentSprite = new NonMovingNonAnimatedSprite(texture, 0, 0, 16, 16);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D2))
            {
                // Display a non-moving, animated sprite
                currentSprite = new NonMovingAnimatedSprite(texture, nonMovingAnimatedFrames, 200);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D3))
            {
                // Display a moving, non-animated sprite
                currentSprite = new MovingNonAnimatedSprite(texture, 16, 0, 16, 16);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D4))
            {
                // Display a moving, animated sprite
                currentSprite = new MovingAnimatedSprite(texture, movingAnimatedFrames, 200, 2f);
            }
        }
    }
}