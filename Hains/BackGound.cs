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
        public Rectangle fundore = new Rectangle(0, -2400, 3000, 3000);
        public int andar = 0;
        public int alturaAndar;
        bool andarMovendo;

        int alturaAndarMovendo = 0;

        public void mover(int qtd)
        {
            if (!andarMovendo)
            {
                fundore.Y += qtd;
                alturaAndar = alturaAndar + qtd;
                if (alturaAndar > 260)
                {
                    andarMovendo = true;
                    andar++;
                }
                if (alturaAndar < 0)
                {
                    andarMovendo = true;
                    andar--;
                }
            }
        }

        public void moverAndar()
        {
            if (andarMovendo)
            {
                alturaAndarMovendo = alturaAndarMovendo + 15;
                fundore.Y = (andar - 1) * 750 - 2400 + alturaAndarMovendo + alturaAndar;
                if (alturaAndarMovendo > 750)
                {
                    andarMovendo = false;
                    alturaAndarMovendo = 0;
                    alturaAndar = 0;
                }
            }
        }

    }
}