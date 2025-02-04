using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.Sprites
{
    public class NonMovingAnimatedSprite(Texture2D texture, List<Rectangle> frames, double millisecondsPerFrame) : ISprite
    {
        private Texture2D Texture { get; set; } = texture;
        private readonly List<Rectangle> frames = frames;
        private int currentFrame = 0;
        private double timeSinceLastFrame = 0;
        private readonly double millisecondsPerFrame = millisecondsPerFrame;

        public void Update()
        {
            timeSinceLastFrame += 16.67; // Assuming a frame rate of 60 FPS

            if (timeSinceLastFrame >= millisecondsPerFrame)
            {
                currentFrame = (currentFrame + 1) % frames.Count;
                timeSinceLastFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = frames[currentFrame];
            Rectangle destinationRectangle = new((int)location.X, (int)location.Y, sourceRectangle.Width, sourceRectangle.Height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
