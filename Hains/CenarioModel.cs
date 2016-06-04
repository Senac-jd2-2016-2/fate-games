using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace implementarlista_itens_obstáculos
{
    public class CenarioModel
    {
        public Player player;
        public Cenario cenario;
        public List<Porta> portas;
        public List<String> matriz;


        public static CenarioModel load(String source)
        {
            StreamReader reader = new StreamReader(source);
            string dados = reader.ReadToEnd();
            CenarioModel m = JsonConvert.DeserializeObject<CenarioModel>(dados);
            return m;
        }

        public static void save(CenarioModel cenario, String source)
        {
            string json = JsonConvert.SerializeObject(cenario);
            StreamWriter writer = new StreamWriter(source);
            writer.Write(json);
            writer.Close();
        }


    }
}
