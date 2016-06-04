using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace implementarlista_itens_obstáculos
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Cenario cenario;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            cenario = new Cenario();
            Player player = new Player();
            cenario.addGameObject(player);


            base.Initialize();
        }

        protected override void LoadContent()
        {
          
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

   
        protected override void UnloadContent()
        {
            
        }

  
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            cenario.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            cenario.draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
