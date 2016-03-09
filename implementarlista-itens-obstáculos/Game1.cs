﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
        Inimigos Peixe;
        BackGround Recepção;
        Rectangle Armario, Escada,BackGround,Visao;
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


            Armario = new Rectangle(200, 130, 335, 352);
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
            Recepção.TexturaBackGround = Content.Load<Texture2D>("BackGround");
            Personagem.HainsTextura = Content.Load<Texture2D>("Hains");
            Peixe.TexturaInimigo = Content.Load<Texture2D>("Inimigo");
            

           
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

                Personagem.HainsR.X = Personagem.HainsR.X - Personagem.velocidade;


                if (BackGround.X < 0 && Personagem.HainsR.X <=  Window.ClientBounds.Left + 100)
                {
                    Recepção.fundore.X = Recepção.fundore.X - 10;
                }
                
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Personagem.HainsR.X = Personagem.HainsR.X + Personagem.velocidade;

                if (BackGround.X > -2200 && Personagem.HainsR.X >= Window.ClientBounds.Width - 200)
                {
                    Recepção.fundore.X = Recepção.fundore.X + 10;
                }

            }

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Personagem.HainsR.Y = Personagem.HainsR.Y - Personagem.velocidade;

                if (Personagem.HainsR.Y <= Window.ClientBounds.Top)
                {

                    Recepção.subir += gameTime.ElapsedGameTime.Milliseconds;
                    
                    if (BackGround.Y < 0)
                    {
                        BackGround.Y = BackGround.Y + 5;
                        
                        if (Recepção.subir <= 3000) 
                        {
                            BackGround.Y = BackGround.Y + 3000;
                        
                        }

                    }
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {

                if (BackGround.Y > -2400)
                {
                    Recepção.fundore.Y = Recepção.fundore.Y - 10;
                }

            }


            if (Personagem.HainsR.Intersects(Visao)) 
            {

                Peixe.perseguir = true;

                if (Peixe.perseguir == true)
                {
                    if (Personagem.HainsR.X < Peixe.InimigoRe.X)
                    {
                        Peixe.InimigoRe.X = Peixe.InimigoRe.X - 2;
                        Visao.X = Peixe.InimigoRe.X;
                    }
                    else if (Personagem.HainsR.X > Peixe.InimigoRe.X)
                    {
                        Peixe.InimigoRe.X = Peixe.InimigoRe.X + 2;
                        Visao.X = Peixe.InimigoRe.X;
                    }
                }
            } 
            

            /*if (Personagem.HainsR.Intersects(Armario) && Keyboard.GetState().IsKeyDown(Keys.E)) 
            {

                perseguir = false;

            }*/
            

           
       
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
            spriteBatch.Draw(Recepção.TexturaBackGround, Receção.fundore, Color.White);
            //spriteBatch.Draw(TexturaArmario, Armario, Color.White);
            //spriteBatch.Draw(TexturaEscada, Escada, Color.White);
            spriteBatch.Draw(Personagem.HainsTextura, Personagem.HainsR, Color.White);
            spriteBatch.Draw(Peixe.TexturaInimigo, Peixe.InimigoRe, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

           
            base.Draw(gameTime);
        }

 
    }
}
