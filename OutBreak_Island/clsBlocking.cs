using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class clsBlocking
    {
        public clsSprite Sprite { get; set; }      //  sprite texture, read-only property
        public bool Visible { get; set; }
        public bool OverWriteVisible { get; set; }

        public clsBlocking(clsSprite _sprite)
        {
            Sprite = _sprite;
            Visible = false;
            OverWriteVisible = false;
        }

        public void SetSize(float x, float y)
        {
            Sprite.size = new Vector2(x, y);
        }


        public void SetPosition(float x, float y)
        {
            Sprite.position = new Vector2(x, y);
        }

        public void MakeHidden()
        {
            OverWriteVisible = true ;
        }

        public void Hide()
        {
            Visible = false;
        }

        public void Show()
        {
            if(!OverWriteVisible)
            Visible = true;
        }

        public bool Collide(clsPlayer Player)
        {
            if (Player.Sprite.Collides(Sprite))
                return true;

            return false;
        }

        public void Move()
        {
            Sprite.autoMove();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Visible)
            {
                Sprite.Draw(spriteBatch, 1f, SpriteEffects.None);
            }
        }
    }
}