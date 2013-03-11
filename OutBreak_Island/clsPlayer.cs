using Microsoft.Xna.Framework.Graphics;   //   for Texture2D
using Microsoft.Xna.Framework;  //  for Vect
using System;

namespace IsometricGame
{
    class clsPlayer
    {
        public clsSprite Sprite { get; set; }      //  sprite texture, read-only property
        public int Score { get; set; }
        public int Quest;
        public string[] Journal;
        public int Collectables, Correct;
        public SpriteEffects Effector;


        public clsPlayer(clsSprite _sprite, int _quests, int _journal)
        {
            Journal = new string[_journal];
            Sprite = _sprite;
            Collectables = 0;
            Correct = 0;
        }

        public void StartQuest(int _no)
        {
               Quest = _no;
        }

         public int GetQuest()
        {
            return Quest;
        }

        public void EndQuests()
        {
            Quest = -1;
        }

        public void AddCorrect()
        {
            Correct++;
        }

        public void AddCollectable()
        {
            Collectables++;
        }

        public int GetCorrect()
        {
            return Correct;
        }

        public int GetCollected()
        {
            return Collectables;
        }

        public void ClearCorrect()
        {
            Correct = 0;
        }

        public void ClearCollected()
        {
            Collectables = 0;
        }

        public void ManipulateScore(int _score)
        {
            Score += _score;
        }

        public void FlipPlayer(bool flip)
        {
                if (flip)
                {
                    Effector = SpriteEffects.None;
                }
                else
                {
                    Effector = SpriteEffects.FlipHorizontally;
                }
        }

        public void Animate(ref TimeSpan tmrAnimator, int PlayerAnimate)
        {
            if (tmrAnimator > TimeSpan.FromSeconds(0))
                Sprite.frame = new Vector2(0f, PlayerAnimate);
            if (tmrAnimator > TimeSpan.FromSeconds(0.2))
                Sprite.frame = new Vector2(1, PlayerAnimate);
            if (tmrAnimator > TimeSpan.FromSeconds(0.4))
                Sprite.frame = new Vector2(2, PlayerAnimate);
            if (tmrAnimator > TimeSpan.FromSeconds(0.6))
                Sprite.frame = new Vector2(3, PlayerAnimate);
            if (tmrAnimator > TimeSpan.FromSeconds(0.8))
                tmrAnimator = TimeSpan.Zero;
        }

        public void ResetScore()
        {
            Score = 0;
        }

        public int GetScore()
        {
            return Score;
        }

        public void JournalEntry(int _entry, string _value)
        {
            Journal[_entry] = _value;
        }

        public bool IsCollected(int _amount)
        {
            if (_amount == Collectables)
                return true;
            else
                return false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, 1f, Effector);
        }

    }
}