using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace implementarlista_itens_obstáculos
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;

        SpriteBatch spriteBatch;
        Hains Personagem = new Hains();
        Inimigos Peixe = new Inimigos();
        BackGround Recepção = new BackGround();
        Rectangle Armario, Escada;
        Texture2D TexturaArmario, TexturaEscada;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here


            Armario = new Rectangle(160, 320, 335, 352);
            Escada = new Rectangle(120, 200, 250, 633);









            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.

            ///////////////////////////////////--------------------------- Chamando as Texturas ------------------------------------------------------------------- /////////////////////////////////

            spriteBatch = new SpriteBatch(GraphicsDevice);
            TexturaArmario = Content.Load<Texture2D>("Armario");
            TexturaEscada = Content.Load<Texture2D>("Escada");
            Recepção.Texturafundo = Content.Load<Texture2D>("BackGround");
            Personagem.HainsTextura = Content.Load<Texture2D>("Hains");
            Peixe.TexturaInimigo = Content.Load<Texture2D>("Inimigo");
            Peixe.TexturaVisao = Content.Load<Texture2D>("Visao");



            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            ///////////////////////////////////--------------------------- Movimentação do Personagem ------------------------------------------------------------------- /////////////////////////////////







            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {



                if (Recepção.fundore.X < 0)
                {
                    Recepção.fundore.X = Recepção.fundore.X + Recepção.velocidade;
                    Peixe.InimigoRe.X = Peixe.InimigoRe.X + Recepção.velocidade;
                    Peixe.Visao.X = Peixe.Visao.X + Recepção.velocidade;
                    
                }

            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {


                if (Recepção.fundore.X > -2200)
                {
                    Recepção.fundore.X = Recepção.fundore.X - Recepção.velocidade;
                    Peixe.InimigoRe.X = Peixe.InimigoRe.X - Recepção.velocidade;
                    Peixe.Visao.X = Peixe.Visao.X - Recepção.velocidade;
                    
                }

            }

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Recepção.mover(10);
                Console.WriteLine("Y=" + Recepção.fundore.Y);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Recepção.mover(-10);
                Console.WriteLine("Y=" + Recepção.fundore.Y);
            }

            Recepção.moverAndar();



            
            if (Personagem.HainsR.Intersects(Peixe.Visao) && Personagem.HainsR.X <= Peixe.InimigoRe.X)
            
            {

                Peixe.VisaoInimigo();

            }
            if (Personagem.HainsR.Intersects(Peixe.Visao) && Personagem.HainsR.X >= Peixe.InimigoRe.X)
            {
                Peixe.VisaoInimigo();

            }







            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(Recepção.Texturafundo, Recepção.fundore, Color.White);
            // spriteBatch.Draw(TexturaArmario, Armario, Color.White);
            //spriteBatch.Draw(TexturaEscada, Escada, Color.White);
            spriteBatch.Draw(Personagem.HainsTextura, Personagem.HainsR, Color.White);
            spriteBatch.Draw(Peixe.TexturaInimigo, Peixe.InimigoRe, Color.White);
            spriteBatch.Draw(Peixe.TexturaVisao, Peixe.Visao, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here


            base.Draw(gameTime);
        }


    }
}