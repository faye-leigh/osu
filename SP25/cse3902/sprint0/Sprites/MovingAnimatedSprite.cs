using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.Sprites
{
    public class MovingAnimatedSprite(Texture2D texture, List<Rectangle> frames, double millisecondsPerFrame, float speed) : ISprite
    {
        public Texture2D Texture { get; set; } = texture;
        private readonly List<Rectangle> frames = frames;
        private readonly double millisecondsPerFrame = millisecondsPerFrame;
        private int currentFrame = 0;
        private double timeSinceLastFrame = 0;
        private Vector2 position = new(592, 352);
        private readonly float speed = speed;
        private int direction = 1;

        public void Update()
        {
            // Update animation frame
            timeSinceLastFrame += 16.67; // Assuming a frame rate of 60 FPS

            if (timeSinceLastFrame >= millisecondsPerFrame)
            {
                currentFrame = (currentFrame + 1) % frames.Count;
                timeSinceLastFrame = 0;
            }

            // Move left to right
            position.X += speed * direction;
            if (position.X >= 784 || position.X <= 0) // Change direction at bounds (assuming screen width is 800)
            {
                direction *= -1;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 initialPos) // TODO: implement initial position
        {
            Rectangle sourceRectangle = frames[currentFrame];
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, sourceRectangle.Width, sourceRectangle.Height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
