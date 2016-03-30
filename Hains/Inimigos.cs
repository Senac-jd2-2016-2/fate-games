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
        public BackGround Teste = new BackGround();
        public int vida = 10, velocidadeinimigo = 1, x = 0, y = 190;
        public bool perseguir = false;
        public Rectangle InimigoRe = new Rectangle(1500, 120, 190, 275), Visao = new Rectangle(1200, 120, 800, 500);
        public Texture2D TexturaInimigo, TexturaVisao;



       public void VisaoInimigo() 
           {
          
                    InimigoRe.X = InimigoRe.X - velocidadeinimigo;
                    Visao.X = Visao.X - velocidadeinimigo;
                         

            }

        
        }

    }


