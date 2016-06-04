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

        string faseAtual;
        int num = 0;

        public List<GameObject> objetos = new List<GameObject>();

        public Cenario()
        {
            cenarioModel = CenarioModel.load("sala-" + num + ".json");
            cenarioModel = new CenarioModel();
            construtor = new Construtor(64, cenarioModel.cenario.faseAtual);

        }


        public void addGameObject(GameObject obj)
        {
            objetos.Add(obj);
            obj.texture = content.Load<Texture2D>(obj.image);
            obj.start(cenarioModel.cenario.faseAtual);
        }
    }
}
