using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace implementarlista_itens_obstáculos
{
    public class Fase
    {
        public Cenario cenario; //lista de cenarios


        public void Initialize(string source)
        {
            cenario = new Cenario();
            cenario.Initialize(source);
        }
        public void LoadContent(ContentManager Content, string[] values)
        {
            cenario.LoadContent(Content, values);
        }
        public void Draw(SpriteBatch spriteBacth)
        {
            cenario.Draw(spriteBacth);
        }
    }
}
