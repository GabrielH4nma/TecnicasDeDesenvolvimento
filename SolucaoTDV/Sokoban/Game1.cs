using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sokoban
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont font;

        private int nrLinhas = 0;
        private int nrColunas = 0;
        private char[,] level;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            LoadLevel("level1.txt");
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("File");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.CornflowerBlue);

            string text = "Ola, mundo!";
            Vector2 textPosition = Vector2.Zero;
            Vector2 textSize = font.MeasureString(text);
            textPosition.X = (GraphicsDevice.Viewport.Width - textSize.X) / 2;
            textPosition.Y = (GraphicsDevice.Viewport.Height - textSize.Y) / 2;

            _spriteBatch.Begin();
            _spriteBatch.DrawString(font, text, textPosition, Color.White, 0f, Vector2.Zero, new Vector2(1f), SpriteEffects.None, 0f, false);
            _spriteBatch.End();

            base.Draw(gameTime)
        }
        void LoadLevel(string levelFile)
        {
            string[] linhas = File.ReadAllLines(levelFile);
        }
    }
}