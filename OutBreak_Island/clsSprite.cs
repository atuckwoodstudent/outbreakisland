using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vector2
using Microsoft.Xna.Framework.Media;

namespace IsometricGame
{
    class clsSprite
    {
        public Texture2D texture { get; set; }      //  sprite texture, read-only property
        public Vector2 position { get; set; }  //  sprite position on screen
        public Vector2 size { get; set; }      //  sprite size in pixels
        public Vector2 velocity { get; set; } // our velocity vector
        public Vector2 scale { get; set; }    // the scale size of the sprite
        public Vector2 screenSize { get; set; } // scale of the window
        public Rectangle sourceRect{ get; set;} // Animation Rectangle
        public Vector2 origin {get; set;} // Rotary origin
        public Vector2 frame { get; set; } // current animation frame
        public bool Collided;

  
        public clsSprite (Texture2D newTexture, Vector2 newPosition, Vector2 newSize, Vector2 newVel, Vector2 newfram)
        {
            texture = newTexture;
            position = newPosition;
            size = newSize;
            frame = newfram;
            screenSize = new Vector2(800,600);
            velocity = newVel;
            Collided = false;
        }

        public clsSprite(Texture2D newTexture, Vector2 newPosition, Vector2 newSize, Vector2 newfram)
        {
            texture = newTexture;
            position = newPosition;
            size = newSize;
            frame = newfram;
            screenSize = new Vector2(800, 600);
            velocity = new Vector2(0,0);
            Collided = false;
        }

        public clsSprite(Texture2D newTexture, Vector2 newPosition, Vector2 newSize)
        {
            texture = newTexture;
            position = newPosition;
            size = newSize;
            frame = new Vector2(0,0);
            screenSize = new Vector2(800, 600);
            velocity = new Vector2(0, 0);
            Collided = false;
        }

        public void autoMove()
        {
            if (position.X + size.X + velocity.X > screenSize.X)
                velocity = new Vector2(-velocity.X, velocity.Y);
            if (position.Y + size.Y + velocity.Y > screenSize.Y)
                velocity = new Vector2(velocity.X, -velocity.Y);
            if (position.X + velocity.X < 0)
                velocity = new Vector2(-velocity.X, velocity.Y);
            if (position.Y + velocity.Y < 0)
                velocity = new Vector2(velocity.X, -velocity.Y);
            position += velocity;
        }

        public void Move()
        {
            position += velocity;
        }

        public bool Collides(clsSprite otherSprite)
        {
            if (this.position.X + this.size.X + velocity.X> otherSprite.position.X &&
            this.position.Y + this.size.Y + velocity.Y> otherSprite.position.Y &&
            this.position.X + velocity.X < otherSprite.position.X + otherSprite.size.X &&
           this.position.Y + velocity.Y < otherSprite.position.Y + otherSprite.size.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Draw(SpriteBatch spriteBatch, float scale, SpriteEffects Effector)
        {
            sourceRect = new Rectangle((int)frame.X * (int)this.size.X, (int)frame.Y * (int)this.size.Y, (int)this.size.X, (int)this.size.Y);
            spriteBatch.Draw(texture, position, sourceRect, Color.White, 0.0f, new Vector2(0,0), scale, Effector, 0.0f);
        }   
   
    }
}
