using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    class Inimigos
    {
        public int vida = 10, velocidadeinimigo = 1, x = 0, y = 190;
        public  bool perseguir = true;
        public Rectangle InimigoRe  = new Rectangle(0, 190, 190, 275), Visao = new Rectangle(0,190, 300, 300);
        public Texture2D TexturaInimigo;
        
        

        
        
    }
}
