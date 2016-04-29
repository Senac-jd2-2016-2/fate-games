using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    public class Control
    {
        public Player player;
        public Fase fase;
        public List<Enemy> enemyes;
        public int qtdeEnemyes;

        void InitializePlayer(Rectangle pos, int vel, int life)
        {
            player = new Player();
            player.Initilize(pos, vel, life);
        }
        void InitializeFase(string source)
        {
            fase = new Fase();
            fase.Initialize(source);
        }
        void InitializeEnemyes(Rectangle[] positions, int[] velocity, int[] life, int qtde)
        {
            qtdeEnemyes = qtde;
            enemyes = new List<Enemy>();
            for (int i = 0; i < qtdeEnemyes; i++)
            {
                enemyes.Add(new Enemy());
                enemyes[i].Initilize(positions[i], velocity[i], life[i]);
            }
        }

        public void Initialize(Rectangle pos, int vel, int life, string source, Rectangle[] positionsE, int[] velocityE, int[] lifeE, int qtde)
        {
            InitializePlayer(pos, vel, life);
            InitializeFase(source);
            InitializeEnemyes(positionsE, velocityE, lifeE, qtde);
        }

        public void LoadContent(ContentManager Content, string sourcePlayer, string[] valuesFase, string[] valuesEnemye)
        {
            player.LoadContent(Content, sourcePlayer);
            fase.LoadContent(Content, valuesFase);
            for (int i = 0; i < enemyes.Count; i++)
            {
                enemyes[i].LoadContent(Content, valuesEnemye[i]);
            }
        }
        public void Update(GameTime gameTime)
        {
            player.Update(gameTime);
            //CONTROLE DE MOVIMENTAÇÃO DO PERSONAGEM
            bool valida;
            Console.WriteLine(player.state.ToString());
            if (player.state == StatePlayer.RUNLEFT)
            {
                valida = colider(player, fase);
                if (!valida)
                {
                    player.position.X -= player.velocity;
                }
            }
            else if (player.state == StatePlayer.RUNRIGTH)
            {
                valida = colider(player, fase);
                if (!valida)
                    player.position.X += player.velocity;
            }
        }
        public void Draw(SpriteBatch spriteBacth)
        {
            fase.Draw(spriteBacth);
            for (int i = 0; i < enemyes.Count; i++)
            {
                enemyes[i].Draw(spriteBacth);
            }
            player.Draw(spriteBacth);
        }
        //COLISÕES ENTRE PLAYER E FASE(CENARIO)
        public bool colider(Player player, Fase fase)
        {
            for (int i = 0; i < fase.cenario.list.Count; i++)
            {
                if (player.position.Intersects(fase.cenario.list[i].position) && fase.cenario.list[i].type == TypeTile.PASSABLE)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
