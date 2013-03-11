using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class clsNPC
    {
        public clsSprite Sprite { get; set; }      //  sprite texture, read-only property
        public SpriteFont Font { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Unlocker { get; set; }
        public int UnlockedNom { get; set; }
        public bool Visible { get; set; }
        public bool OverWriteVisible { get; set; }

        public clsNPC(clsSprite _sprite, string _text, string _name, string _unlocker, int _unlocknos)
        {
            Unlocker = _unlocker;
            UnlockedNom = _unlocknos;

            Sprite = _sprite;
            Text = _text;
            Name = _name;
            OverWriteVisible = false;
        }

        public void SetUnlock(int _iIn, string _sIn)
        {
            Unlocker = _sIn;
            UnlockedNom = _iIn;
        }

        public int GetLockNom()
        {
            return UnlockedNom;
        }

        public string GetUnlockText()
        {
            return Unlocker;
        }

        public void SetName(string _in)
        {
            Name = _in;
        }

        public void SetSpeech(string _in)
        {
            Text = _in;
        }

        public void SetPosition(float x, float y)
        {
           Sprite.position = new Vector2(x, y);
        }

        public void Hide()
        {
            Visible = false;
        }

        public void OverWriteVisibility()
        {
            OverWriteVisible = true;
        }

        public void Show()
        {
            if (!OverWriteVisible)
            Visible = true;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (Visible)
            Sprite.Draw(spriteBatch, 1f, SpriteEffects.None);
        }
    }
}