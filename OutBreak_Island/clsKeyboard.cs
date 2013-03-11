using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
namespace IsometricGame
{
    class clsKeyboard
    {
        public bool ACCESS, BACK, UP, DOWN, LEFT, RIGHT, START, LEFTBAR, RIGHTBAR;

        public void Update()
        {
            ACCESS = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Z);
            BACK = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.X);
            LEFT = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left);
            RIGHT = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right);
            UP = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up);
            DOWN = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down);
            START = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Enter);
            LEFTBAR = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Q);
            RIGHTBAR = Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.E);
        }
    }
}
