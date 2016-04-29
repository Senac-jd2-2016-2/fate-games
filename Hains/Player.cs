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
    public class Player : Personagem
    {
        public StatePlayer state;


        public void Initilize(Rectangle player, int velocity, int life)
        {
            state = StatePlayer.IDLE;
            position = new Rectangle(player.X, player.Y, player.Width, player.Height);
            this.velocity = velocity;
            this.life = life;
        }
        public void LoadContent(ContentManager Content, string value)
        {
            img = Content.Load<Texture2D>(value);
        }
        //public void MovmentPlayer()
        //{

        //}
        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                state = StatePlayer.RUNLEFT;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                state = StatePlayer.RUNRIGTH;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                state = StatePlayer.RUNTOP;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                state = StatePlayer.RUNDOWN;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                state = StatePlayer.JUMP;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                state = StatePlayer.SEARCHING;
            }

            else
            {
                state = StatePlayer.IDLE;
            }
        }
        public void Draw(SpriteBatch spriteBacth)
        {
            spriteBacth.Draw(img, position, Color.White);
        }
    }
}
