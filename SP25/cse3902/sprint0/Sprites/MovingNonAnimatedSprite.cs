<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.Sprites
{
    public class MovingNonAnimatedSprite(Texture2D texture, int srcX, int srcY, int width, int height) : ISprite
    {
        private Texture2D Texture { get; set; } = texture;
        private int SrcX { get; set; } = srcX;
        private int SrcY { get; set; } = srcY;
        private int Width { get; set; } = width;
        private int Height { get; set; } = height;
        private Vector2 position = new(192, 352); // Initial position
        private float speed = 2f;
        private int direction = 1;

        public void Update()
        {
            // Move up and down
            position.Y += speed * direction;
            if (position.Y >= 464 || position.Y <= 240) // Change direction at bounds
            {
                direction *= -1;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 initialPos) // TODO: implement initial position
        {
            Rectangle sourceRectangle = new(SrcX, SrcY, Width, Height);
            Rectangle destinationRectangle = new((int)position.X, (int)position.Y, Width, Height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Sprites
{
    internal class MovingNonAnimatedSprite
    {
    }
}
>>>>>>> eebefdd5cd3b1259d16ca47fcff95c206be8c88f
