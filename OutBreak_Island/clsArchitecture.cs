using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class clsArchitecture
    {
        public clsSprite Body{ get; set; }
        public clsSprite Head { get; set; }
        public bool Visible { get; set; }
        public bool OverWriteVisible { get; set; }

        public clsArchitecture(clsSprite _sprite, clsSprite _sprite2)
        {
            Body = _sprite;
            Head = _sprite2;
            Visible = false;
            OverWriteVisible = false;

            if (Body.size.X > Head.size.X)
                Head.position = new Vector2(Body.position.X +((Body.size.X- Head.size.X) / 2), Body.position.Y - Head.size.Y);
            else if (Body.size.X < Head.size.X)
            {
                Head.position = new Vector2(Body.position.X - ((Head.size.X - Body.size.X) / 2), Body.position.Y - Head.size.Y);
            }
            else
                Head.position = new Vector2(Body.position.X, Body.position.Y - Head.size.Y);
        }

        public bool Collide(clsPlayer Player)
        {
            if (Player.Sprite.Collides(Body))
                    return true;
            return false;
        }

        public void Hide()
        {
            Visible = false;
        }

        public void Show()
        {
            if (!OverWriteVisible)
            Visible = true;
        }

        public void SetPosition(float x, float y)
        {
            Body.position = new Vector2(x, y);

            if (Body.size.X > Head.size.X)
                Head.position = new Vector2(Body.position.X + ((Body.size.X - Head.size.X) / 2), Body.position.Y - Head.size.Y);
            else if (Body.size.X < Head.size.X)
            {
                Head.position = new Vector2(Body.position.X - ((Head.size.X - Body.size.X) / 2), Body.position.Y - Head.size.Y);
            }
            else
                Head.position = new Vector2(Body.position.X, Body.position.Y - Head.size.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Visible)
            {
                Body.Draw(spriteBatch, 1f, SpriteEffects.None);
                Head.Draw(spriteBatch, 1f, SpriteEffects.None);
            }
        }
    }
}