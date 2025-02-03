<<<<<<< HEAD
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
    public class MouseController : IController
    {
        private Texture2D texture;
        private List<Rectangle> nonMovingAnimatedFrames;
        private List<Rectangle> movingAnimatedFrames;

        public MouseController(Texture2D texture, List<Rectangle> nonMovingAnimatedFrames, List<Rectangle> movingAnimatedFrames)
        {
            this.texture = texture;
            this.nonMovingAnimatedFrames = nonMovingAnimatedFrames;
            this.movingAnimatedFrames = movingAnimatedFrames;
        }

        public void HandleInput(ref ISprite currentSprite)
        {
            MouseState mouseState = Mouse.GetState();

            if (mouseState.RightButton == ButtonState.Pressed)
            {
                // Quit the game
                System.Environment.Exit(0);
            }
            else if (mouseState.LeftButton == ButtonState.Pressed)
            {
                if (mouseState.X < 400 && mouseState.Y < 300)
                {
                    // Display a non-moving, non-animated sprite
                    currentSprite = new NonMovingNonAnimatedSprite(texture, 0, 0, 16, 16);
                }
                else if (mouseState.X >= 400 && mouseState.Y < 300)
                {
                    // Display a non-moving, animated sprite
                    currentSprite = new NonMovingAnimatedSprite(texture, nonMovingAnimatedFrames, 200);
                }
                else if (mouseState.X < 400 && mouseState.Y >= 300)
                {
                    // Display a moving, non-animated sprite
                    currentSprite = new MovingNonAnimatedSprite(texture, 16, 0, 16, 16);
                }
                else if (mouseState.X >= 400 && mouseState.Y >= 300)
                {
                    // Display a moving, animated sprite
                    currentSprite = new MovingAnimatedSprite(texture, movingAnimatedFrames, 200, 2f);
                }
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Controllers
{
    internal class MouseController
    {
    }
}
>>>>>>> eebefdd5cd3b1259d16ca47fcff95c206be8c88f
