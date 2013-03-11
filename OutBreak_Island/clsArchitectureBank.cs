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
    class clsArchitectureBank
    {

        public clsArchitecture[] Buildings, Mudhuts, Trees;
        public clsArchitecture Tower;

        public clsArchitectureBank(ContentManager Content, ref clsSpriteBank Sprites)
        {
            Buildings = new clsArchitecture[10];
            Mudhuts = new clsArchitecture[10];
            Trees = new clsArchitecture[10];

            Tower = new clsArchitecture(Sprites.sprTowerPiece[3], Sprites.sprTowerPiece[4]);

            for (int i = 0; i < Buildings.Length; i++)
                Buildings[i] = new clsArchitecture(Sprites.sprARC_Body[i], Sprites.sprARC_Head[i]);

            for (int i = 0; i < Mudhuts.Length; i++)
                Mudhuts[i] = new clsArchitecture(Sprites.sprARC_Body[10+i], Sprites.sprARC_Head[10+i]);

            for (int i = 0; i < Trees.Length; i++)
                Trees[i] = new clsArchitecture(Sprites.sprTree_Body[i], Sprites.sprTree_Head[i]);
        }


        public void HideAll()
        {
            for (int i = 0; i < Buildings.Length; i++)
                Buildings[i].Hide();

            for (int i = 0; i < Mudhuts.Length; i++)
                Mudhuts[i].Hide();


            for (int i = 0; i < Trees.Length; i++)
                Trees[i].Hide();

            Tower.Hide();
        }

        public void SetMap(int Map)
        {
            switch (Map)
            {
                case 1:
                    Trees[0].SetPosition(300, 340);
                    Trees[1].SetPosition(310, 390);
                    Trees[2].SetPosition(350, 440);
                    Trees[3].SetPosition(600, 200);
                    Trees[4].SetPosition(750, 100);
                    Trees[5].SetPosition(760, 120);
                    Buildings[0].SetPosition(750, 320);
                    Buildings[1].SetPosition(660, 340);
                    Buildings[2].SetPosition(710, 420);

                    Trees[0].Show(); Trees[1].Show(); Trees[2].Show(); Trees[3].Show(); Trees[4].Show(); Trees[5].Show();
                    Buildings[0].Show(); Buildings[1].Show(); Buildings[2].Show();
                    break;

                case 2:
                    Trees[0].SetPosition(10, 100);
                    Trees[1].SetPosition(50, 110);
                    Trees[2].SetPosition(100, 130);
                    Trees[3].SetPosition(20, 120);
                    Trees[4].SetPosition(150, 150);
                    Trees[5].SetPosition(250, 180);
                    Trees[6].SetPosition(200, 190);
                    Trees[7].SetPosition(750, 400);
                    Trees[8].SetPosition(760, 450);
                    Buildings[0].SetPosition(-40, 320);
                    Buildings[1].SetPosition(30, 400);
                    Buildings[2].SetPosition(40, 320);
                    Buildings[3].SetPosition(175, 400);


                    Trees[0].Show(); Trees[1].Show(); Trees[2].Show(); Trees[3].Show(); Trees[4].Show(); Trees[5].Show();
                    Trees[6].Show(); Trees[7].Show(); Trees[8].Show();
                    Buildings[0].Show(); Buildings[1].Show(); Buildings[2].Show(); Buildings[3].Show();
                    break;

                case 3:
                    Trees[0].SetPosition(10, 400);
                    Trees[1].SetPosition(30, 430);
                    Trees[2].SetPosition(90, 450);
                    Trees[3].SetPosition(0, 450);
                    Trees[4].SetPosition(120, 500);
                    Trees[5].SetPosition(160, 550);

                    Trees[0].Show(); Trees[1].Show(); Trees[2].Show(); Trees[3].Show(); Trees[4].Show(); Trees[5].Show();
                    break;

                case 4: 
                    Trees[0].SetPosition(500, 175);
                    Trees[1].SetPosition(575, 200);
                    Trees[2].SetPosition(650, 175);
                    Trees[3].SetPosition(550, 250);
                    Trees[4].SetPosition(650, 265);
                    Trees[5].SetPosition(600, 300);

                    Trees[0].Show(); Trees[1].Show(); Trees[2].Show(); Trees[3].Show(); Trees[4].Show(); Trees[5].Show();
                   break;

                case 5:
                    Trees[0].SetPosition(750, 300);
                    Trees[1].SetPosition(745, 350);
                    Trees[5].SetPosition(760, 550);
                    Buildings[0].SetPosition(275, 175);
                    Buildings[1].SetPosition(320, 250);
                    Buildings[2].SetPosition(280, 290);
                    Buildings[3].SetPosition(530, 250);
                    Buildings[4].SetPosition(570, 300);
                    Buildings[5].SetPosition(500, 320);
                    Buildings[6].SetPosition(300, 350);

                    Trees[0].Show(); Trees[1].Show(); Trees[5].Show();
                    Buildings[0].Show(); Buildings[1].Show(); Buildings[2].Show(); Buildings[3].Show();
                    Buildings[4].Show(); Buildings[5].Show(); Buildings[6].Show();
                    break;

                case 6:
                   
                    Trees[6].SetPosition(100, 300);
                    Trees[7].SetPosition(100, 350);
                    Buildings[0].SetPosition(700, 275);
                    Buildings[1].SetPosition(630, 325);
                    Buildings[2].SetPosition(740, 350);
                    Buildings[3].SetPosition(620, 400);
                    Buildings[4].SetPosition(700, 430);
                    Buildings[5].SetPosition(650, 500);

                    Trees[6].Show(); Trees[7].Show();
                    Buildings[0].Show(); Buildings[1].Show(); Buildings[2].Show(); Buildings[3].Show();
                    Buildings[4].Show(); Buildings[5].Show();
                    break;

                case 7:
                    Trees[0].SetPosition(120, 10);
                    Trees[1].SetPosition(160, 40);
                    Buildings[0].SetPosition(20, 275);
                    Buildings[1].SetPosition(-10, 350);
                    Buildings[2].SetPosition(50, 380);

                    Trees[0].Show(); Trees[1].Show();
                    Buildings[0].Show(); Buildings[1].Show(); Buildings[2].Show();
                    break;

                case 8:
                    Trees[0].SetPosition(550, 100);
                    Trees[0].Show();
                    break;

                case 9:
                    Trees[0].SetPosition(740, 30);
                    Trees[1].SetPosition(500, 265);
                    Trees[2].SetPosition(570, 250);
                    Trees[3].SetPosition(670, 185);
                    Trees[4].SetPosition(750, -5);
                    Tower.SetPosition(150, 225);

                    Trees[0].Show(); Trees[1].Show(); Trees[2].Show(); Trees[3].Show(); Trees[4].Show(); Tower.Show();
                    break;

                case 21:
                    Mudhuts[0].SetPosition(20,50);
                    Mudhuts[1].SetPosition(-30, 250);
                    Mudhuts[2].SetPosition(60, 600);
                    Mudhuts[3].SetPosition(600, 100);
                    Mudhuts[4].SetPosition(350, 150);
                    Mudhuts[5].SetPosition(500, 300);
                    Mudhuts[6].SetPosition(770, 400);
                    Mudhuts[7].SetPosition(550, 150);
                    Mudhuts[8].SetPosition(650, 300);
                    Mudhuts[9].SetPosition(70, 400);

                    Mudhuts[0].Show(); Mudhuts[1].Show(); Mudhuts[2].Show();
                    Mudhuts[3].Show(); Mudhuts[4].Show(); Mudhuts[5].Show();
                    Mudhuts[6].Show(); Mudhuts[7].Show(); Mudhuts[8].Show();
                    Mudhuts[9].Show();
                    break;

                case 22:
                    Mudhuts[0].SetPosition(100, 0);
                    Mudhuts[1].SetPosition(60,150);
                    Mudhuts[2].SetPosition(240, 450);
                    Mudhuts[3].SetPosition(600, 10);
                    Mudhuts[4].SetPosition(350, 150);
                    Mudhuts[5].SetPosition(400, 270);
                    Mudhuts[6].SetPosition(790, 400);
                    Mudhuts[7].SetPosition(550, 150);
                    Mudhuts[8].SetPosition(650, 354);
                    Mudhuts[9].SetPosition(70, 400);

                    Mudhuts[0].Show(); Mudhuts[1].Show(); Mudhuts[2].Show();
                    Mudhuts[3].Show(); Mudhuts[4].Show(); Mudhuts[5].Show();
                    Mudhuts[6].Show(); Mudhuts[7].Show(); Mudhuts[8].Show();
                    Mudhuts[9].Show();
                    break;

                case 23:
                    Mudhuts[0].SetPosition(10, 10);
                    Mudhuts[1].SetPosition(10, 210);
                    Mudhuts[2].SetPosition(500, -10);
                    Mudhuts[3].SetPosition(600, 160);
                    Mudhuts[4].SetPosition(240, 400);
                    Mudhuts[4].SetPosition(350, 150);
                    Mudhuts[5].SetPosition(400, 270);
                    Mudhuts[6].SetPosition(189, 112);
                    Mudhuts[7].SetPosition(550, 225);
                    Mudhuts[8].SetPosition(650, 354);
                    Mudhuts[9].SetPosition(70, 400);

                    Mudhuts[0].Show(); Mudhuts[1].Show(); Mudhuts[2].Show();
                    Mudhuts[3].Show(); Mudhuts[4].Show(); Mudhuts[5].Show();
                    Mudhuts[6].Show(); Mudhuts[7].Show(); Mudhuts[8].Show();
                    Mudhuts[9].Show();
                    break;
            }
        }

        public bool Collisions(ref clsHUDBank Hud, ref clsChatBoxBank TextMenus, ref clsPlayer Player, int Map, ref clsArchitecture Collider, ref clsBlockingBank Blocks, ref clsNPCBank NPC, ref clsController Controller, ref clsKeyboard KBoard)
        {
            HideAll();
            SetMap(Map);

            for (int i = 0; i < Trees.Length; i++)
            {
                
                if (Trees[i].Collide(Player))
                {
                    if (Trees[i].Visible)
                    {
                        Collider = Trees[i];
                    return true;
                    }
                }
            }
            for (int i = 0; i < Buildings.Length; i++)
            {
                if (Player.Sprite.Collides(Buildings[i].Body))
                {
                    if (Buildings[i].Visible)
                    {
                        Collider = Buildings[i];
                        return true;
                    }
                }
            }

            for (int i = 0; i < Mudhuts.Length; i++)
            {
                if (Player.Sprite.Collides(Mudhuts[i].Body))
                {
                    if (Mudhuts[i].Visible)
                    {
                        Collider = Mudhuts[i];
                        return true;
                    }
                }
            }

            if (Player.Sprite.Collides(Tower.Body))
            {
                if (Tower.Visible)
                {
                    Collider = Tower;

                    if (Controller.A || KBoard.ACCESS)
                    {
                        if (Player.GetQuest()==0)
                        {
                            if (Player.IsCollected(3))
                            {
                                {
                                    Tower.Body.frame = new Vector2(0, 0);
                                    Tower.Head.frame = new Vector2(0, 0);
                                    Player.ManipulateScore(150);
                                    Player.Collectables = 0;
                                    Player.StartQuest(1);
                                    TextMenus.RadioMessage.SetText("Great work Jim! Now we can\nfinally get started. First, you\nneed to go to a village just\nnorth of your current location.\nThere is a distinct lack of\neducation in correct water\nsanitation, we have to sort\nthat out.\n\nAdditionally, collect as many\nresources as you can. You\ncan't take on challenges if\nyou don't have resources.\nYou can build resources by\nhelping out the local island\npeople.");
                                    Hud.DataBank.SetText(2, "Clean Water in 1st World");
                                    TextMenus.Collectables.Closed();
                                    TextMenus.Databank.ShowIndicator();
                                    Blocks.hVillageblock[0].MakeHidden(); Blocks.hVillageblock[1].MakeHidden();
                                }
                            }
                        }

                    TextMenus.RadioMessage.ShowIndicator();
                    }

                    if (!Controller.A && !KBoard.ACCESS)
                    {
                        TextMenus.A.Open();
                    }

                    return true;
                }
            }
                 
            return false;

        }

        public void Draw(SpriteBatch spriteBatch, int Map)
        {
            for (int i = 0; i < Trees.Length; i++)
                Trees[i].Draw(spriteBatch);
            for (int i = 0; i < Buildings.Length; i++)
                Buildings[i].Draw(spriteBatch);
            for (int i = 0; i < Mudhuts.Length; i++)
                Mudhuts[i].Draw(spriteBatch);


            Tower.Draw(spriteBatch);
        }
    }
}
