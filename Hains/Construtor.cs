using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    public class Construtor
    {
        public List<GameObject> ListTile;

        public CenarioModel cenarioModel;

        public Construtor(int size, string faseAtual)
        {
            cenarioModel = CenarioModel.load(faseAtual);
            ListTile = new List<GameObject>();
            int numLinha = 0;

            foreach (string line in cenarioModel.matriz)
            {
                int numColuna = 0;
                foreach (char item in line)
                {
                    GameObject tile = new GameObject();
                    ListTile.Add(tile);

                    switch (item)
                    {
                        case '0':
                            tile.typeBlock = TypeBlock.PASSAVEL;
                            break;
                        case '1':
                            tile.typeBlock = TypeBlock.NAO_PASSAVEL;
                            break;

                    }
                    tile.rectangle = new Rectangle(numColuna * size, numLinha * size, size, size);
                    numColuna++;
                }
                numLinha++;
            }
            foreach (Porta porta in cenarioModel.portas)
            {
                ListTile.Add(porta);
                porta.typeBlock = TypeBlock.PORTA;
                porta.rectangle = new Rectangle(porta.coluna * size, porta.linha * size, size, size);
            }

        }

        public void LoadContent(ContentManager Content)
        {
            for (int i = 0; i < ListTile.Count; i++)
            {
                if (ListTile[i].typeBlock == TypeBlock.PASSAVEL)
                {
                    ListTile[i].texture = Content.Load<Texture2D>("Visao.png");
                }
                if (ListTile[i].typeBlock == TypeBlock.NAO_PASSAVEL)
                {
                    ListTile[i].texture = Content.Load<Texture2D>("Armario.png");
                }
                if (ListTile[i].typeBlock == TypeBlock.PORTA)
                {
                    ListTile[i].texture = Content.Load<Texture2D>("Porta.png");
                }

            }
        }

        public void Draw(SpriteBatch SpriteBatch)
        {

            for (int i = 0; i < ListTile.Count; i++)
            {
                SpriteBatch.Draw(ListTile[i].texture, ListTile[i].rectangle, Color.White);
            }
        }
    }
}
