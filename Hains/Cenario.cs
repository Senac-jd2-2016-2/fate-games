using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace implementarlista_itens_obstáculos
{
    public class Cenario
    {
        public List<Tile> list;
        public Texture2D background;
        int lineList, columList;

        StreamReader sr;
        public void Initialize(string source)
        {
            list = new List<Tile>();

            //leitura de arquivos
            sr = new StreamReader(source);
            string line;
            Tile novo;
            lineList = 0;
            while ((line = sr.ReadLine()) != null)
            {
                columList = 0;
                foreach (char item in line)
                {
                    novo = new Tile();
                    switch (item)
                    {
                        case '0':
                            novo.type = TypeTile.PASSABLE;
                            break;
                        case '1':
                            novo.type = TypeTile.NOT_PASSABLE;
                            break;
                    }
                    novo.position = new Rectangle(columList * 64, lineList * 64, 64, 64);
                    columList++;
                    list.Add(novo);
                }
                lineList++;
            }
        }
        public void LoadContent(ContentManager Content, string[] values)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].type == TypeTile.PASSABLE)
                {
                    list[i].img = Content.Load<Texture2D>(values[0]);
                }
                else
                {
                    list[i].img = Content.Load<Texture2D>(values[1]);
                }
            }
            background = Content.Load<Texture2D>(values[2]);
        }
        public void Draw(SpriteBatch spriteBacth)
        {
            spriteBacth.Draw(background, new Vector2(0, 0), Color.White);
            for (int i = 0; i < list.Count; i++)
            {
                spriteBacth.Draw(list[i].img, list[i].position, Color.White);
            }
        }
    }
}
