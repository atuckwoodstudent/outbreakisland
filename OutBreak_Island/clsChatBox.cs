using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class clsChatBox
    {
        public clsSprite ActiveSprite, OpenSprite, CloseSprite, IndicatorSprite;
        public SpriteFont Font { get; set; }
        public string Text { get; set; }
        public bool ShowConvo { get; set; }
        public bool Indicator { get; set; }
        public string Name { get; set; }
        public Vector2 Offset { get; set; }

        public clsChatBox(clsSprite _opensprite, clsSprite _closedsprite, clsSprite _indicatorsprite, SpriteFont fontin)
        {
            OpenSprite = _opensprite;
            CloseSprite = _closedsprite;
            ActiveSprite = _closedsprite;
            IndicatorSprite = _indicatorsprite;
            Font = fontin;
        }

        public void SetText(string _text)
        { Text = _text; }

        public void SetName(string _name)
        { Name = _name; }

        public void SetOffSet(float x, float y)
        {
            Offset = new Vector2(OpenSprite.position.X + x, OpenSprite.position.Y + y);
        }

        public void ShowIndicator()
        {
            Indicator = true;
        }

        public void Open()
        {
            Indicator = false;
            ShowConvo = true;
            ActiveSprite = OpenSprite;
        }

        public void Closed()
        {
            ShowConvo = false;
            ActiveSprite = CloseSprite;
        }

        public bool GetActive()
        {
            if (ActiveSprite == OpenSprite)
                return true;
            else
                return false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            ActiveSprite.Draw(spriteBatch, 1f, SpriteEffects.None);

            if (Indicator)
            {
            IndicatorSprite.Draw(spriteBatch, 1f, SpriteEffects.None);
            }


            if (ShowConvo)
            {
                if (Name != null)
                    spriteBatch.DrawString(Font, Name + " Says: " + Text, Offset, Color.Black);
                else
                    spriteBatch.DrawString(Font, Text, Offset, Color.Black);
            }

        }
    }
}
