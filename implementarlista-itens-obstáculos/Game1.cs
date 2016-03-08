using Microsoft.Xna.Framework;
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
        Rectangle Armario, Escada,BackGround;
        Texture2D TexturaArmario, TexturaEscada,TexturaBackground;

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


            Armario = new Rectangle(200, 200, 335, 352);
            Escada = new Rectangle(200, 200, 250, 633);
            BackGround = new Rectangle(0, 0, 3000, 3000);
           
           





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
            TexturaBackground = Content.Load<Texture2D>("BackGround");
            Personagem.HainsTextura = Content.Load<Texture2D>("Hains");


           
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
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Personagem.HainsR.X = Personagem.HainsR.X + Personagem.velocidade;
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
            spriteBatch.Draw(TexturaBackground, BackGround, Color.White);
            spriteBatch.Draw(TexturaArmario, Armario, Color.White);
            spriteBatch.Draw(TexturaEscada, Escada, Color.White);
            spriteBatch.Draw(Personagem.HainsTextura, Personagem.HainsR, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

           
            base.Draw(gameTime);
        }

 
    }
}
