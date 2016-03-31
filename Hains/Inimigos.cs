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
        
        public int vida = 10, velocidadeinimigo = 2;
        public bool perseguir = true;
        public Rectangle InimigoRe, Visao;
        public Texture2D TexturaInimigo, TexturaVisao;



       public void VisaoInimigo(int pos) 
           {
               if (perseguir == true)
               {
                  
                   if (pos > 0)
                   {
                       InimigoRe.X = InimigoRe.X + velocidadeinimigo;
                       Visao.X = Visao.X + velocidadeinimigo;
                   }
                   else if (pos < 0)
                   {
                       InimigoRe.X = InimigoRe.X - velocidadeinimigo;
                       Visao.X = Visao.X - velocidadeinimigo;

                   }
               }
            }

        
        }

    }


