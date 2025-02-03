<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint0.Sprites
{
    public class TextSprite : ISprite
    {
        public SpriteFont Font { get; set; }
        public String Text { get; set; }
        public TextSprite(SpriteFont font, String text)
        {
            Font = font;
            Text = text;
        }
        public void Update()
        {
            // Update not needed
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(Font, Text, new Vector2(location.X, location.Y), Color.Black);
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
    internal class TextSprite
    {
    }
}
>>>>>>> eebefdd5cd3b1259d16ca47fcff95c206be8c88f
