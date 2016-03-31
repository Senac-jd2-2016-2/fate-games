using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    class BackGround
    {

        public int velocidade = 10, subir = 0;
        public Texture2D Texturafundo;
        public Rectangle fundore = new Rectangle(0, -2160, 3000, 2650);
        public int andar = 0;
        public int alturaAndar;
        bool andarMovendo;
        bool subindo;

        public void mover(int qtd)
        {
            if (!andarMovendo)
            {
                fundore.Y += qtd;
                alturaAndar += qtd;
               

                
                if (alturaAndar > 260)
                {
                    andarMovendo = true;
                    andar++;
                    subindo = true;
                }
                if (alturaAndar < 0)
                {
                    andarMovendo = true;
                    andar--;
                    subindo = false;
                }
            }

            if (andar < 0)
            {
                andar = 0;
            }

            if (andar > 2)
            {
                andar = 2;
            }

        }

        public void moverAndar()
        {
            if (andarMovendo)
            {
                int qtdMover;
                if (subindo)
                {
                    qtdMover = 10;
                }
                else
                {
                    qtdMover = -10;
                }
                fundore.Y += qtdMover;

                if ((fundore.Y - 2090) % 850 == 0)
                {
                    andarMovendo = false;
                    alturaAndar = 0;
                }
                
            }
        }

    }
}