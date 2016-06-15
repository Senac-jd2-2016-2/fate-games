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
            image = "Hains.png";
            rectangle = new Rectangle(100, 100, 65, 65);

        }

        public override void update(GameTime gameTime)
        {
            Keys[] keys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys k in keys)
            {
                if (k.Equals(Keys.Up))
                {
                    rectangle.Y += 2;
                }
                if (k.Equals(Keys.Down))
                {
                    rectangle.Y -= 2;
                }
                if (k.Equals(Keys.Right))
                {
                    rectangle.X += 2;
                }
                if (k.Equals(Keys.Left))
                {
                    rectangle.X -= 2;
                }
            }
        }
    }
}
