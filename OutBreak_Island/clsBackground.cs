using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2

namespace IsometricGame
{
    class clsBackground
    {
        public clsSprite Sprite { get; set; }      //  sprite texture, read-only property
        public int Map;

        public clsBackground(clsSprite _sprite)
        {
            Sprite = _sprite;
            Map = -1;
        }

        public void SwitchMap(ref clsPlayer Player)
        {
            if (Player.Sprite.position.X + Player.Sprite.size.X > 810)
            {
                Sprite.frame = new Vector2(Sprite.frame.X + 1, Sprite.frame.Y);
                Player.Sprite.position = new Vector2(0, Player.Sprite.position.Y);
            }

            if (Player.Sprite.position.X < -10)
            {
                Sprite.frame = new Vector2(Sprite.frame.X - 1, Sprite.frame.Y);
                Player.Sprite.position = new Vector2(770, Player.Sprite.position.Y);
            }

            if (Player.Sprite.position.Y + Player.Sprite.size.Y > 610)
            {
                Sprite.frame = new Vector2(Sprite.frame.X, Sprite.frame.Y + 1);
                Player.Sprite.position = new Vector2(Player.Sprite.position.X, 0);
            }

            if (Player.Sprite.position.Y < -10)
            {
                Sprite.frame = new Vector2(Sprite.frame.X, Sprite.frame.Y - 1);
                Player.Sprite.position = new Vector2(Player.Sprite.position.X, 550);
            }
        }

        public void SetMap(int _map)
        {
            Map = _map;
            switch (Map)
            {
                case 0:
                    Sprite.frame = new Vector2(0, 0);
                    break;
                case 1:
                    Sprite.frame = new Vector2(1, 0);
                    break;
                case 2:
                    Sprite.frame = new Vector2(2, 0);
                    break;
                case 3:
                    Sprite.frame = new Vector2(3, 0);
                    break;
                case 4:
                    Sprite.frame = new Vector2(0, 1);
                    break;
                case 5:
                    Sprite.frame = new Vector2(1, 1);
                    break;
                case 6:
                    Sprite.frame = new Vector2(2, 1);
                    break;
                case 7:
                    Sprite.frame = new Vector2(3, 1);
                    break;
                case 8:
                    Sprite.frame = new Vector2(0, 2);
                    break;
                case 9:
                    Sprite.frame = new Vector2(1, 2);
                    break;
                case 10:
                    Sprite.frame = new Vector2(2, 2);
                    break;
                case 11:
                    Sprite.frame = new Vector2(3, 2);
                    break;

                case 20:
                    Sprite.frame = new Vector2(0, 3);
                    break;


                case 21:
                    Sprite.frame = new Vector2(1, 3);
                    break;


                case 22:
                    Sprite.frame = new Vector2(2, 3);
                    break;


                case 23:
                    Sprite.frame = new Vector2(3, 3);
                    break;

                case 24:
                    Sprite.frame = new Vector2(1, 4);
                    break;

                case 25:
                    Sprite.frame = new Vector2(2, 4);
                    break;

                case -1:
                    Sprite.frame = new Vector2(0, 4);
                    break;
            }
        }

        public int GetMap()
        {
                if (Sprite.frame == new Vector2(0, 0))
                    Map = 0;
                if (Sprite.frame == new Vector2(1, 0))
                    Map = 1;
                if (Sprite.frame == new Vector2(2, 0))
                    Map = 2;
                if (Sprite.frame == new Vector2(3, 0))
                    Map = 3;
                if (Sprite.frame == new Vector2(0, 1))
                    Map = 4;
                if (Sprite.frame == new Vector2(1, 1))
                    Map = 5;
                if (Sprite.frame == new Vector2(2, 1))
                    Map = 6;
                if (Sprite.frame == new Vector2(3, 1))
                    Map = 7;
                if (Sprite.frame == new Vector2(0, 2))
                    Map = 8;
                if (Sprite.frame == new Vector2(1, 2))
                    Map = 9;
                if (Sprite.frame == new Vector2(2, 2))
                    Map = 10;
                if (Sprite.frame == new Vector2(3, 2))
                    Map = 11;
                if (Sprite.frame == new Vector2(0, 3))
                    Map = 20;
                if (Sprite.frame == new Vector2(1, 3))
                    Map = 21;
                if (Sprite.frame == new Vector2(2, 3))
                    Map = 22;
                if (Sprite.frame == new Vector2(3, 3))
                    Map = 23;
                if (Sprite.frame == new Vector2(1, 4))
                    Map = 24;
                if (Sprite.frame == new Vector2(2, 4))
                    Map = 25;
                if (Sprite.frame == new Vector2(0, 4))
                    Map = -1;
     
            return Map;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, 1f, SpriteEffects.None);
        }
    }
}