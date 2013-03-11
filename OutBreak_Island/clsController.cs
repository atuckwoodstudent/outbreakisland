using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
namespace IsometricGame
{
    class clsController
    {
        public bool A, B, X, Y, LB, RB, START, BACK, UP, DOWN, LEFT, RIGHT;
        public float LSX, LSY, RSX, RSY, LT, RT;

        public void Update()
        {
     
                A = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.A);
                B = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.B);
                X = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.X);
                Y = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Y);
                LEFT = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.DPadLeft);
                RIGHT = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.DPadRight);
                UP = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.DPadUp);
                DOWN = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.DPadDown);
                START = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Start);
                BACK = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.Back);
                LB = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.LeftShoulder);
                RB = GamePad.GetState(PlayerIndex.One).IsButtonDown(Buttons.RightShoulder);
                LSX = GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.X;
                LSY = GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.Y;
                RSX = GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.X;
                RSY = GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y;
                LT = GamePad.GetState(PlayerIndex.One).Triggers.Left;
                RT = GamePad.GetState(PlayerIndex.One).Triggers.Right;  
        }
    }
}
