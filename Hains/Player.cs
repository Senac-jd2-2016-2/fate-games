using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace implementarlista_itens_obstáculos
{
    public class Player : GameObject
    {
        public override void start(string faseAtual)
        {
            cenarioModel = CenarioModel.load(faseAtual);
            image = "Player.png";
            position = new Vector2(cenarioModel.player.position.X, cenarioModel.player.position.Y);
            rectangle = new Rectangle((int)position.X, (int)position.Y, cenarioModel.player.rectangle.Width, cenarioModel.player.rectangle.Height);

        }

        public override void update(GameTime gameTime)
        {
            Keys[] keys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys k in keys)
            {
                if (k.Equals(Keys.Up))
                {
                    position.Y += 2;
                }
                if (k.Equals(Keys.Down))
                {
                    position.Y -= 2;
                }
                if (k.Equals(Keys.Right))
                {
                    position.X += 2;
                }
                if (k.Equals(Keys.Left))
                {
                    position.X -= 2;
                }
            }
        }
    }
}
