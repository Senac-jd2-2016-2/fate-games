using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    public class Fase1
    {
        public bool ativa;
        public Control fase;

        int qtd = 4;

        public void Initialize()
        {
            fase = new Control();
            //INICIAR PLAYER
            Rectangle pos = new Rectangle(100, 100, 65, 65);
            int vel = 5;
            int life = 2;

            //INICIAR CENÁRIO
            string source = "fase1.txt";
            qtd = 4;
            Rectangle[] positionsE = new Rectangle[qtd];
            positionsE[0] = new Rectangle(10, 10, 65, 65);
            positionsE[1] = new Rectangle(90, 10, 65, 65);
            positionsE[2] = new Rectangle(150, 10, 65, 65);
            positionsE[3] = new Rectangle(250, 10, 65, 65);

            int[] velocityE = new int[qtd];
            velocityE[0] = 4;
            velocityE[1] = 3;
            velocityE[2] = 5;
            velocityE[3] = 7;

            int[] lifeE = new int[qtd];
            for (int i = 0; i < lifeE.Length; i++)
            {
                lifeE[i] = 2;
            }
            //INICIAR INIMIGOS
            fase.Initialize(pos, vel, life, source, positionsE, velocityE, lifeE, qtd);
        }
        public void Load(ContentManager Content)
        {
            /*
             * (ContentManager Content, string sourcePlayer, string[] valuesFase, string[] valuesEnemye)
             * */
            //LOAD PLAYER
            string sourcePlayer = "Hains";

            //LOAD CENARIO
            string[] valuesFase = new string[3];
            valuesFase[0] = "Visao";
            valuesFase[1] = "Armario";
            valuesFase[2] = "BackGround";

            string[] valuesEnemyes = new string[qtd];
            for (int i = 0; i < valuesEnemyes.Length; i++)
            {
                valuesEnemyes[i] = "Inimigo";
            }
            fase.LoadContent(Content, sourcePlayer, valuesFase, valuesEnemyes);
        }
        public void Update(GameTime gameTime)
        {
            fase.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBacth)
        {
            fase.Draw(spriteBacth);
        }
    }   
}
