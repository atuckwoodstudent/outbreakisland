using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class clsHUD
    {
        public clsSprite Sprite;
        public SpriteFont Font { get; set; }
        public Color[] MenuCol;
        public string[] Text;
        public int Size;
        public bool Visible, OverWriteVisible;
        public int Selected;
        public Vector2 Offset;
        public Vector2 Spacer;

        public clsHUD(clsSprite _sprite, SpriteFont _font, int _size)
        {
            Sprite = _sprite;
            Font = _font;
            Size = _size;
            MenuCol = new Color[_size];
            Text = new string[Size];
            Visible = false;
            Offset = Sprite.position;
            Selected = 0;
            OverWriteVisible = false;
            Spacer = new Vector2(0f,30f);
        }

        public void ProcessTextColours()
        {
            for (int i = 0; i != Selected; i++)
                MenuCol[i] = Color.Black;

            MenuCol[Selected] = Color.Red;

            for (int i = Selected + 1; i < MenuCol.Length; i++)
                MenuCol[i] = Color.Black;
        }

        public void Show()
        {
            if(!OverWriteVisible)
            Visible = true;
        }

        public void Hide()
        {
            Visible = false;
        }

        public int GetSelected()
        {
            return Selected;
        }

        public void UpOne()
        {
            if (Selected != 0)
                Selected--;
            else
                Selected = Size-1;
            ProcessTextColours();
        }

         public void DownOne()
        {
            if (Selected < Text.Length - 1)
                Selected++;
            else
                Selected = 0;
             ProcessTextColours();
        }

        public void SetText(int i, string _text)
        {
            Text[i] = _text;
        }

        public void SetOffSet(float x, float y, Vector2 _linespace)
        {
            Spacer = _linespace;
            Offset = new Vector2(Sprite.position.X + x, Sprite.position.Y + y);
        }

        public void MakeHidden()
        {
            OverWriteVisible = true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            ProcessTextColours();

            if (Visible)
            {                   
                    Sprite.Draw(spriteBatch, 1f, SpriteEffects.None);
                    
                for (int i=0; i<Size; i++)
                    spriteBatch.DrawString(Font, Text[i], new Vector2(Offset.X+(Spacer.X*i), Offset.Y + (Spacer.Y*i)), MenuCol[i]);
            }
        }
    }
}