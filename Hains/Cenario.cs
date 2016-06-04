using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace implementarlista_itens_obstáculos
{
    public class Cenario
    {
        public ContentManager content;

        public Construtor construtor;

        public CenarioModel cenarioModel;

        public string faseAtual;
        public int num ;

        public List<GameObject> objetos = new List<GameObject>();

        public Cenario()
        {
            faseAtual = "sala-" + num + ".json";
            cenarioModel = new CenarioModel();         
            construtor = new Construtor(64, faseAtual);
            cenarioModel = CenarioModel.load(faseAtual);

        }


        public void addGameObject(GameObject obj)
        {
            objetos.Add(obj);
            obj.texture = content.Load<Texture2D>(obj.image);
            obj.start(cenarioModel.cenario.faseAtual);
        }

        public void Update(GameTime gameTime)
        {
            num = 0;
            faseAtual = "sala-" + num + ".json";

            foreach (GameObject obj in objetos)
            {
                obj.update(gameTime);
            }        
        }

        public void draw(SpriteBatch spriteBatch)
        {            
            foreach (GameObject obj in objetos)
            {
                spriteBatch.Draw(obj.texture,obj.rectangle, Color.White);
            }
        }
    }
}
