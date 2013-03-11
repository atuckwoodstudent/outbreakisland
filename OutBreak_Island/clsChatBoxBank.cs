using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using System.Linq;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;

namespace IsometricGame
{
    class clsChatBoxBank
    {

        public clsChatBox Chatbox, RadioMessage, Databank, Letter, PlayerScore, Collectables, DataPopup, A;

        public clsChatBoxBank(ref clsSpriteBank Sprites, ref SpriteFont Font)
        {
            Chatbox = new clsChatBox(Sprites.sprChatBox, Sprites.sprChatBox_Closed, null, Font);
            RadioMessage = new clsChatBox(Sprites.sprRadioBox, Sprites.sprRadioBox_Closed, Sprites.sprRadioBox_Indicate, Font);
            Databank = new clsChatBox(Sprites.sprDataBox, Sprites.sprDataBox_Closed, Sprites.sprDataBox_Indicate, Font);
            Letter = new clsChatBox(Sprites.sprLetter, Sprites.sprLetter_Closed, null, Font);
            Collectables = new clsChatBox(Sprites.sprCollectables, Sprites.sprCollectable_Closed, null, Font);
            PlayerScore = new clsChatBox(Sprites.sprPlayerScore, null, null, Font);
            DataPopup = new clsChatBox(Sprites.sprDataPopup, Sprites.sprDataPopup_Closed, null, Font);
            A = new clsChatBox(Sprites.sprInteract, Sprites.sprInteract_Closed, null, Font);

            A.SetText("");

            Chatbox.SetOffSet(10, 10);
            RadioMessage.SetOffSet(5, 60);
            Databank.SetOffSet(18, 60);
            Letter.SetOffSet(30, 30);
            PlayerScore.SetOffSet(10, 10);
            Collectables.SetOffSet(10, 10);
            PlayerScore.Open();
            DataPopup.SetOffSet(10, 50);

        }
  
        public void DrawHUD(SpriteBatch spriteBatch)
        {
             Chatbox.Draw(spriteBatch);
             RadioMessage.Draw(spriteBatch);
             Databank.Draw(spriteBatch);
             DataPopup.Draw(spriteBatch);

        }

        public void DrawPlayer(SpriteBatch spriteBatch)
        {
            PlayerScore.Draw(spriteBatch);
            Collectables.Draw(spriteBatch);
            A.Draw(spriteBatch);
        }

    }
}
