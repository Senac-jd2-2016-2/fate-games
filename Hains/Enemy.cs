using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    public class Enemy : Personagem
    {
        StateEnemy state;
        int steps;
        int time;
        int factor;

        public void LoadContent(ContentManager Content, string value)
        {
            img = Content.Load<Texture2D>(value);
        }
        public void Initilize(Rectangle player, int velocity, int life)
        {
            factor = 1;
            state = StateEnemy.WATCHING;
            steps = 5;
            position = new Rectangle(player.X, player.Y, player.Width, player.Height);
            this.velocity = velocity;
            this.life = life;
        }
        public void Update(GameTime gameTime)
        {
            //movimentação automatica WHATCHING
            time += gameTime.ElapsedGameTime.Milliseconds;
            if (time > 100)
            {
                time = 0;
                steps += factor;
                if (steps < 0)
                {
                    factor = 1;
                }
                else if (steps > 5)
                {
                    factor = -1;
                }
                position.X += velocity * factor;
            }
        }
        public void Draw(SpriteBatch spriteBacth)
        {
            spriteBacth.Draw(img, position, Color.White);
        }
    }
}
