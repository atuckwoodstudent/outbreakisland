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
    class clsNPCBank
    {

        public clsNPC[] NPCS;

        public clsNPCBank(ContentManager Content, ref clsSpriteBank Sprites)
        {
            NPCS = new clsNPC[13];

            for (int i = 0; i < NPCS.Length; i++)
                NPCS[i] = new clsNPC(Sprites.sprNPC[i],"","","",0);

            NPCS[0].SetName("Katie Stib");
            NPCS[0].SetSpeech("I dont see why everyone is getting worked up. I feel fine!");
            NPCS[0].SetUnlock(15,"Not Showing Signs");
            NPCS[1].SetName("Lee Gul");
            NPCS[1].SetSpeech("My job is to make sure nobody gets into this village because of the disease.\n What's that? A relief worker? Until I can talk to your boss on the radio, you can't come in.");
            NPCS[1].SetUnlock(8,"Infection by Numbers");
            NPCS[2].SetName("Alan Doob");
            NPCS[2].SetSpeech("Fix the tower you say? It looks pretty demolished if you ask me...");
            NPCS[2].SetUnlock(1,"Building Up");
            NPCS[3].SetName("Ben Jab");
            NPCS[3].SetSpeech("I'm so thirsty...");
            NPCS[3].SetUnlock(13, "Rehydrate Me!");
            NPCS[4].SetName("Claire Aaby");
            NPCS[4].SetSpeech("Ohhhh my tummy hurts... I never drink dirty water though.");
            NPCS[4].SetUnlock(5,"Transmitting");
            NPCS[5].SetName("Josh Bosh");
            NPCS[5].SetSpeech("Maybe I should have cooked my steak before I ate it...");
            NPCS[5].SetUnlock(9,"Raw Meats");
            NPCS[6].SetName("Elliot Bea");
            NPCS[6].SetSpeech("I just enjoyed a nice salad, now I feel terrible.");
            NPCS[6].SetUnlock(3,"Green Vegetables");
            NPCS[7].SetName("Amelia Tuck");
            NPCS[7].SetSpeech("We have to stop this thing from spreading!.");
            NPCS[7].SetUnlock(10, "Stubborn");
            NPCS[8].SetName("Emma Tee");
            NPCS[8].SetSpeech("I cant find my brother anywhere! His name is Alan!.");
            NPCS[8].SetUnlock(11, "Family Ties");
            NPCS[9].SetName("Sarah Roze");
            NPCS[9].SetSpeech("How are we supposed to stay clean after taking a dump?.");
            NPCS[9].SetUnlock(7, "Prevent and Destroy");
            NPCS[10].SetName("Adman Bannister");
            NPCS[10].SetSpeech("I hate you guys, coming in here thinking you know how to save the world...");
            NPCS[10].SetUnlock(6, "Define: Relief Work");
            NPCS[11].SetName("Jimmy Booth");
            NPCS[11].SetSpeech("Everyone else was eating the same food. They are all fine.");
            NPCS[11].SetUnlock(12, "Sharing the Wealth");
            NPCS[12].SetName("Alex Jawn");
            NPCS[12].SetSpeech("I only came here on a trip! I've been here three days!");
            NPCS[12].SetUnlock(14, "Travellers Beware");
        }

        public void Hide()
        {
            for (int i = 0; i < NPCS.Length; i++)
                NPCS[i].Hide();
        }


        public void Show(int Map)
        {
            Hide();

            switch (Map)
            {
                case 0:
                    NPCS[3].Show();

                    NPCS[3].SetPosition(600, 450);
                    break;
                case 1:
                    NPCS[6].Show();
                    NPCS[9].Show();
                    NPCS[11].Show();

                    NPCS[6].SetPosition(600, 300);
                    NPCS[9].SetPosition(100, 400);
                    NPCS[11].SetPosition(600, 500);
                    break;
                case 2:
                    NPCS[5].Show();
                    NPCS[10].Show();
                    NPCS[5].SetPosition(550, 200);
                    NPCS[10].SetPosition(100, 150);
                    break;
                case 3:
                    NPCS[8].Show();
                    NPCS[8].SetPosition(70, 470);
                    break;
                 case 4:
                    NPCS[4].SetPosition(500, 440);
               
                    NPCS[4].Show();
                    break;

                case 5: 
                    NPCS[1].SetPosition(330, 350);

                    NPCS[1].Show();
                    break;

                case 6:
                    NPCS[7].SetPosition(700, 100);

                    NPCS[7].Show();
                    break;

                case 8:
                    NPCS[0].SetPosition(600, 100);

                    NPCS[0].Show();
                    break;

                case 9:
                    NPCS[2].SetPosition(500,100);

                    NPCS[2].Show();
                    break;

                case 10:
                    NPCS[12].SetPosition(200, 200);

                    NPCS[12].Show();
                    break;
            }

        }


        public bool Collisions(clsPlayer Player, int Map, ref clsNPC Collider, ref clsHUDBank Hud, ref clsChatBox Databank, ref int HudNum, ref string HudText)
        {
            Show(Map);

            if (Player.GetQuest() > 0)
            {
               NPCS[2].SetSpeech("Nice work. You must have done this kind of thing before.");
               NPCS[1].SetSpeech("Let's hope you are as good as your boss says you are. We can't let\nthis kind of thing spread.");
            }

            for (int i = 0; i < NPCS.Length; i++)
            {
                if (NPCS[i].Visible)
                {
                    if (Player.Sprite.Collides(NPCS[i].Sprite))
                    {
                        Collider = NPCS[i];
                        HudText = NPCS[i].GetUnlockText();
                        HudNum = NPCS[i].GetLockNom();
                        return true;
                    }
                }
            }

            return false;

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < NPCS.Length; i++)
            {
                if (NPCS[i].Visible)
                    NPCS[i].Draw(spriteBatch);
            }
               
        }
    }
}
