using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.Sprites
{
    public class NonMovingNonAnimatedSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int SrcX { get; set; }
        private int SrcY { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }

        public NonMovingNonAnimatedSprite(Texture2D texture, int srcX, int srcY, int width, int height)
        {
            Texture = texture;
            SrcX = srcX;
            SrcY = srcY;
            Width = width;
            Height = height;
        }

        public void Update()
        {
            // Update not needed
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new(SrcX, SrcY, Width, Height);
            Rectangle destinationRectangle = new((int)location.X, (int)location.Y, Width, Height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
