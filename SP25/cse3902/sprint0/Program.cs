<<<<<<< HEAD
﻿using var game = new sprint0.Sprint0();
game.Run();
=======
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyMonoGameProject
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}
>>>>>>> eebefdd5cd3b1259d16ca47fcff95c206be8c88f
