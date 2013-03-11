using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class HUD
    {
        public clsSprite sprStartMenu, sprMainMenu, sprOptions;
        public SpriteFont Font { get; set; }
        public Color[] MenuCol;

        public HUD(Texture2D _tex1, Texture2D _tex2, Texture2D _tex3, SpriteFont _font)
        {
            sprStartMenu = new clsSprite(_tex1, new Vector2(160f, 150f),
               new Vector2(456, 281));
            sprMainMenu = new clsSprite(_tex2, new Vector2(150f, 100f),
                          new Vector2(325f, 352f));

            sprOptions = new clsSprite(_tex3, new Vector2(150f, 100f),
                                         new Vector2(325f, 352f));
            Font = _font;
            MenuCol = new Color[6]; 
        }

        public void ProcessTextColours(int MenuSelector)
        {
            switch (MenuSelector)
            {
                case 0: MenuCol[0] = Color.Yellow;
                    MenuCol[1] = Color.Black;
                    MenuCol[2] = Color.Black;
                    MenuCol[3] = Color.Black;
                    MenuCol[4] = Color.Black;
                    MenuCol[5] = Color.Black;
                    break;
                case 1: MenuCol[0] = Color.Black;
                    MenuCol[1] = Color.Yellow;
                    MenuCol[2] = Color.Black;
                    MenuCol[3] = Color.Black;
                    MenuCol[4] = Color.Black;
                    MenuCol[5] = Color.Black;
                    break;
                case 2: MenuCol[0] = Color.Black;
                    MenuCol[1] = Color.Black;
                    MenuCol[2] = Color.Yellow;
                    MenuCol[3] = Color.Black;
                    MenuCol[4] = Color.Black;
                    MenuCol[5] = Color.Black;
                    break;
                case 3: MenuCol[0] = Color.Black;
                    MenuCol[1] = Color.Black;
                    MenuCol[2] = Color.Black;
                    MenuCol[3] = Color.Yellow;
                    MenuCol[4] = Color.Black;
                    MenuCol[5] = Color.Black;
                    break;
                case 4: MenuCol[0] = Color.Black;
                    MenuCol[1] = Color.Black;
                    MenuCol[2] = Color.Black;
                    MenuCol[3] = Color.Black;
                    MenuCol[4] = Color.Yellow;
                    MenuCol[5] = Color.Black;
                    break;
                case 5: MenuCol[0] = Color.Black;
                    MenuCol[1] = Color.Black;
                    MenuCol[2] = Color.Black;
                    MenuCol[3] = Color.Black;
                    MenuCol[4] = Color.Black;
                    MenuCol[5] = Color.Yellow;
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch, bool DrawStart, bool DrawMain, bool DrawOptions)
        {
            if (DrawStart)
            {
                    sprStartMenu.Draw(spriteBatch, 1f, SpriteEffects.None);
                    spriteBatch.DrawString(Font, "Continue", new Vector2(200, 200), MenuCol[0]);
                    spriteBatch.DrawString(Font, "Quit", new Vector2(200, 230), MenuCol[1]);
             }

            if (DrawOptions)
            {
                sprOptions.Draw(spriteBatch, 1f, SpriteEffects.None);
                spriteBatch.DrawString(Font, "Turn On Sound", new Vector2(180, 200), MenuCol[0]);
                spriteBatch.DrawString(Font, "Option 2", new Vector2(180, 220), MenuCol[1]);
                spriteBatch.DrawString(Font, "Option 3:", new Vector2(180, 240), MenuCol[2]);
                spriteBatch.DrawString(Font, "Option 4", new Vector2(180, 260), MenuCol[3]);
                spriteBatch.DrawString(Font, "Option 5", new Vector2(180, 280), MenuCol[4]);
                spriteBatch.DrawString(Font, "Back", new Vector2(180, 300), MenuCol[5]);
            }


            if (DrawMain)
            {
                sprMainMenu.Draw(spriteBatch, 1f, SpriteEffects.None);
                spriteBatch.DrawString(Font, "Start Game", new Vector2(180, 200), MenuCol[0]);
                spriteBatch.DrawString(Font, "Options", new Vector2(180, 220), MenuCol[1]);
                spriteBatch.DrawString(Font, "Quit:", new Vector2(180, 240), MenuCol[2]);
            }
        }
    }
}