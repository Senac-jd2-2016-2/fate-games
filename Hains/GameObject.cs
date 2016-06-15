using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    public class GameObject
    {

        public Rectangle rectangle;

        public Texture2D texture;

        public ContentManager content;

        public CenarioModel cenarioModel;

        public TypeBlock typeBlock;

        public string image;



        public virtual void update(GameTime gameTime) { }

        public virtual void start(string FaseAtual) { }

    }
    public enum TypeBlock
    {
        PASSAVEL,
        NAO_PASSAVEL,
        PORTA

    }
}
