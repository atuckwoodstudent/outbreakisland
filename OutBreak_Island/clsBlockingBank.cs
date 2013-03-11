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
    class clsBlockingBank
    {

        public clsBlocking[] Blank, hVillageblock, TowerPieces, Bacteria, WarpPoints, RockBlock;
        public clsBlocking Boat, School;

        public clsBlockingBank(ContentManager Content, ref clsSpriteBank Sprites)
        {
            Blank = new clsBlocking[25];
            hVillageblock = new clsBlocking[2];
            RockBlock = new clsBlocking[18];
            TowerPieces = new clsBlocking[3];
            Bacteria = new clsBlocking[15];
            WarpPoints = new clsBlocking[9];

            Boat = new clsBlocking(Sprites.sprBoat);

            School = new clsBlocking(Sprites.sprSchool);

            hVillageblock[0] = new clsBlocking(Sprites.sprBarrier[0]);
            hVillageblock[1] = new clsBlocking(Sprites.sprBarrier[1]);

            for (int i = 0; i < RockBlock.Length; i++)
            {
                RockBlock[i] = new clsBlocking(Sprites.sprRockBlock[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                TowerPieces[i] = new clsBlocking(Sprites.sprTowerPiece[i]);
            }

            for (int i = 0; i < Blank.Length; i++)
            {
                Blank[i] = new clsBlocking(Sprites.sprBlocked[i]);
            }

            for (int i = 0; i < Bacteria.Length; i++)
            {
               Bacteria[i] = new clsBlocking(Sprites.sprBacteria[i]);
            }

            for (int i = 0; i < WarpPoints.Length; i++)
            {
                WarpPoints[i] = new clsBlocking(Sprites.sprTownMarker[i]);
            }

        }

        public void HideAll()
        {
            hVillageblock[0].Hide();
            hVillageblock[1].Hide();

            School.Hide();
            for (int i = 0; i < 3; i++)
            {
                TowerPieces[i].Hide();
            }

            for (int i = 0; i < Blank.Length; i++)
            {
                Blank[i].Hide();
            }

            for (int i = 0; i < Bacteria.Length; i++)
            {
                Bacteria[i].Hide();
            }

            for (int i = 0; i < WarpPoints.Length; i++)
            {
                WarpPoints[i].Hide();
            }

            for (int i = 0; i < RockBlock.Length; i++)
            {
                RockBlock[i].Hide();
            }

            Boat.Hide();
        }

        public void SetMap(int Map)
        {
            switch (Map)
            {
                case 0:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(470, 600);
                    Blank[1].SetPosition(0, 0); Blank[1].SetSize(600, 440);
                    Blank[2].SetPosition(0, 0); Blank[2].SetSize(670, 380);
                    Blank[3].SetPosition(0, 0); Blank[3].SetSize(810, 300);
                    

                    break;
                case 1:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                    Blank[7].Show();
                    Blank[8].Show();
                    Blank[9].Show();
                    Blank[10].Show();
                    RockBlock[0].Show();
                    RockBlock[1].Show();
                    RockBlock[2].Show();
                    RockBlock[3].Show();
                    RockBlock[4].Show();
                    RockBlock[5].Show();
                   
                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(800, 60);
                    Blank[1].SetPosition(0, 0); Blank[1].SetSize(20, 300);
                    Blank[2].SetPosition(50, 0); Blank[2].SetSize(10, 280);
                    Blank[3].SetPosition(90, 250); Blank[3].SetSize(150, 20);
                    Blank[4].SetPosition(110, 300); Blank[4].SetSize(150, 20);
                    Blank[5].SetPosition(250, 0); Blank[5].SetSize(10, 180);
                    Blank[6].SetPosition(150, 350); Blank[6].SetSize(150, 20);
                    Blank[7].SetPosition(180, 400); Blank[7].SetSize(150, 20);
                    Blank[8].SetPosition(220, 450); Blank[8].SetSize(100, 20);
                    Blank[9].SetPosition(240, 0); Blank[9].SetSize(130, 150);
                    Blank[10].SetPosition(380, 590); Blank[10].SetSize(300, 10);
                    RockBlock[0].SetPosition(250, 550);
                    RockBlock[1].SetPosition(240, 500);
                    RockBlock[2].SetPosition(270, 580);
                    RockBlock[3].SetPosition(400, 450);
                    RockBlock[4].SetPosition(430, 500);
                    RockBlock[5].SetPosition(490, 550);
                    break;

                case 2:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                    Blank[7].Show();
                    Blank[8].Show();
                    Blank[9].Show();
                    Blank[10].Show();
                    Blank[11].Show();
                    Blank[12].Show();
                    Blank[13].Show();
                    Blank[14].Show();
                    Blank[15].Show();
                    WarpPoints[2].Show();
                    RockBlock[6].Show();
                    RockBlock[7].Show();
                    RockBlock[8].Show();
                    RockBlock[9].Show();
                    RockBlock[10].Show();
                    RockBlock[11].Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(800, 70);
                    Blank[1].SetPosition(300, 0); Blank[1].SetSize(10, 120);
                    Blank[2].SetPosition(350, 0); Blank[2].SetSize(10, 130);
                    Blank[3].SetPosition(390, 0); Blank[3].SetSize(10, 150);
                    Blank[4].SetPosition(430, 0); Blank[4].SetSize(10, 170);
                    Blank[5].SetPosition(470, 0); Blank[5].SetSize(10, 180);
                    Blank[6].SetPosition(510, 0); Blank[6].SetSize(10, 190);
                    Blank[7].SetPosition(550, 0); Blank[7].SetSize(10, 200);
                    Blank[8].SetPosition(590, 0); Blank[8].SetSize(10, 210);
                    Blank[9].SetPosition(630, 0); Blank[9].SetSize(10, 220);
                    Blank[10].SetPosition(670, 0); Blank[10].SetSize(10, 400);
                    Blank[11].SetPosition(640, 450); Blank[11].SetSize(100, 10);
                    Blank[12].SetPosition(740, 0); Blank[12].SetSize(10, 260);
                    Blank[13].SetPosition(770, 0); Blank[13].SetSize(20, 290);
                    Blank[14].SetPosition(170, 580); Blank[14].SetSize(400, 30);
                    Blank[15].SetPosition(500, 550); Blank[15].SetSize(100, 30);
                    WarpPoints[2].SetPosition(100, 350);
                    RockBlock[6].SetPosition(500, 500);
                    RockBlock[7].SetPosition(550, 480);
                    RockBlock[8].SetPosition(600, 440);
                    RockBlock[9].SetPosition(700, 450);
                    RockBlock[10].SetPosition(680, 510);
                    RockBlock[11].SetPosition(610, 550);
                    break;
                case 3:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(800, 370);
                    Blank[1].SetPosition(180, 420); Blank[1].SetSize(620, 10);
                    Blank[2].SetPosition(260, 470); Blank[2].SetSize(540, 10);
                    Blank[3].SetPosition(310, 520); Blank[3].SetSize(590, 10);
                    Blank[4].SetPosition(375, 570); Blank[4].SetSize(340, 40);

                    break;

                case 4:
                    TowerPieces[0].Show();
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                    Blank[7].Show();
                    Blank[8].Show();
                    Blank[9].Show();
                    Blank[10].Show();
                    Blank[11].Show();
                    Blank[12].Show();
                    Blank[13].Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(470, 10);
                    Blank[1].SetPosition(0, 10); Blank[1].SetSize(415, 5);
                    Blank[2].SetPosition(0, 20); Blank[2].SetSize(395, 5);
                    Blank[3].SetPosition(0, 30); Blank[3].SetSize(375, 10);
                    Blank[4].SetPosition(0, 45); Blank[4].SetSize(340, 380);
                    Blank[5].SetPosition(0, 425); Blank[5].SetSize(350, 5);
                    Blank[6].SetPosition(0, 445); Blank[6].SetSize(360, 5);
                    Blank[7].SetPosition(0, 465); Blank[7].SetSize(370, 5);
                    Blank[8].SetPosition(0, 485); Blank[8].SetSize(380, 5);
                    Blank[9].SetPosition(0, 505); Blank[9].SetSize(390, 5);
                    Blank[10].SetPosition(0, 525); Blank[10].SetSize(400, 5);
                    Blank[11].SetPosition(0, 545); Blank[11].SetSize(410, 5);
                    Blank[12].SetPosition(0, 565); Blank[12].SetSize(430, 5);
                    Blank[13].SetPosition(0, 595); Blank[13].SetSize(580, 5);
                    
                    
                    TowerPieces[0].SetPosition(380, 50);
                    break;

                case 5:
                    hVillageblock[0].Show();
                    hVillageblock[1].Show();
                    WarpPoints[0].Show();
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    RockBlock[0].Show();
                    RockBlock[1].Show();
                    RockBlock[15].Show();
                    RockBlock[16].Show();
                    RockBlock[17].Show();

                    RockBlock[0].SetPosition(240, 0);
                    RockBlock[1].SetPosition(310, 10);
                    RockBlock[15].SetPosition(770, 400);
                    RockBlock[16].SetPosition(770, 440);
                    RockBlock[17].SetPosition(740, 420);
                    Blank[0].SetPosition(380, 0); Blank[0].SetSize(300, 10);
                    Blank[1].SetPosition(440, 50); Blank[1].SetSize(240, 10);
                    Blank[2].SetPosition(550, 100); Blank[2].SetSize(350, 10);
                    Blank[3].SetPosition(700, 150); Blank[3].SetSize(100, 10);
                    Blank[4].SetPosition(780, 90); Blank[4].SetSize(60, 310);
                    Blank[5].SetPosition(780, 500); Blank[5].SetSize(60, 100);


                    hVillageblock[0].SetPosition(370, 350);
                    hVillageblock[1].SetPosition(390, 230);
                    WarpPoints[0].SetPosition(400, 275);
                    break;

                case 6:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    RockBlock[6].Show();
                    RockBlock[7].Show();
                    RockBlock[12].Show();
                    RockBlock[13].Show();
                    RockBlock[14].Show();

                    Blank[0].SetPosition(0, 100); Blank[0].SetSize(60, 300);
                    Blank[1].SetPosition(0, 500); Blank[1].SetSize(60, 100);
                    Blank[2].SetPosition(170, 0); Blank[2].SetSize(400, 10);
                    Blank[3].SetPosition(170, 50); Blank[3].SetSize(190, 10);
                    Blank[4].SetPosition(100, 70); Blank[4].SetSize(190, 10);
                    Blank[5].SetPosition(0, 90); Blank[5].SetSize(270, 10);
                    Blank[6].SetPosition(0, 90); Blank[6].SetSize(300, 10);
                    RockBlock[6].SetPosition(570, 20);
                    RockBlock[12].SetPosition(80, 400);
                    RockBlock[13].SetPosition(80, 440);
                    RockBlock[14].SetPosition(110, 420);
             
                    break;

                case 7:
                    Blank[0].Show();
                  Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                   Blank[7].Show();
                    Blank[8].Show();
                    Blank[9].Show();
                   Blank[10].Show();
                    Blank[11].Show();
                    WarpPoints[4].Show();


                    Blank[0].SetPosition(365, 0); Blank[0].SetSize(340, 10);
                    Blank[1].SetPosition(400, 50); Blank[1].SetSize(375, 50);
                    Blank[2].SetPosition(410, 150); Blank[2].SetSize(110, 10);
                    Blank[3].SetPosition(440, 200); Blank[3].SetSize(125, 10);
                    Blank[4].SetPosition(490, 250); Blank[4].SetSize(125, 10);
                    Blank[5].SetPosition(460, 310); Blank[5].SetSize(125, 10);
                    Blank[6].SetPosition(450, 350); Blank[6].SetSize(125, 10);
                    Blank[7].SetPosition(455, 370); Blank[7].SetSize(125, 30);
                    Blank[8].SetPosition(455, 430); Blank[8].SetSize(125, 30);
                    Blank[9].SetPosition(430, 480); Blank[9].SetSize(125, 10);
                    Blank[10].SetPosition(420, 500); Blank[10].SetSize(125, 10);
                    Blank[11].SetPosition(390, 540); Blank[11].SetSize(125, 60);
                    WarpPoints[4].SetPosition(80, 300);
                    break;
                case 8:
                    TowerPieces[1].Show();
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                   Boat.Show();

                    Blank[0].SetPosition(0, 410); Blank[0].SetSize(800, 250);
                    Blank[1].SetPosition(0, 400); Blank[1].SetSize(700, 10);
                    Blank[2].SetPosition(0, 370); Blank[2].SetSize(410, 15);
                    Blank[3].SetPosition(0, 0); Blank[3].SetSize(140, 600);
                    Blank[4].SetPosition(0, 340); Blank[4].SetSize(200, 10);
                    Blank[5].SetPosition(0, 0); Blank[5].SetSize(450, 200);
                    Blank[6].SetPosition(0, 0); Blank[6].SetSize(580, 100);
                    Boat.SetPosition(40, 100);

                    TowerPieces[1].SetPosition(200, 300);
                    break;
                case 9:
                    TowerPieces[2].Show();
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                    Blank[8].Show();

                    Blank[0].SetPosition(790, 120); Blank[0].SetSize(10, 40);
                    Blank[1].SetPosition(760, 160); Blank[1].SetSize(150, 150);
                    Blank[3].SetPosition(660, 290); Blank[3].SetSize(150, 10);
                    Blank[4].SetPosition(550, 310); Blank[4].SetSize(150, 10);
                    Blank[5].SetPosition(500, 325); Blank[5].SetSize(150, 10);
                    Blank[6].SetPosition(100, 335); Blank[6].SetSize(800, 50);
                    Blank[8].SetPosition(0, 410); Blank[8].SetSize(100, 20);


                    TowerPieces[2].SetPosition(600, 100);
                    

                    break;

                case 10:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                    Blank[7].Show();
                    Blank[8].Show();


                    Blank[0].SetPosition(780, 270); Blank[0].SetSize(20, 20);
                    Blank[1].SetPosition(720, 300); Blank[1].SetSize(40, 10);
                    Blank[2].SetPosition(0, 240); Blank[2].SetSize(200, 10);
                    Blank[3].SetPosition(0, 200); Blank[3].SetSize(100, 10);
                    Blank[4].SetPosition(0, 160); Blank[4].SetSize(80, 10);
                    Blank[5].SetPosition(0, 0); Blank[5].SetSize(60, 300);
                    Blank[6].SetPosition(0, 270); Blank[6].SetSize(270, 10);
                    Blank[7].SetPosition(0, 300); Blank[7].SetSize(400, 10);
                    Blank[8].SetPosition(400, 330); Blank[8].SetSize(400, 10);
                    break;

                case 11:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    Blank[4].Show();
                    Blank[5].Show();
                    Blank[6].Show();
                    Blank[7].Show();
                    Blank[8].Show();

                    Blank[0].SetPosition(370,0); Blank[0].SetSize(230, 20);
                    Blank[1].SetPosition(350, 60); Blank[1].SetSize(150, 10);
                    Blank[2].SetPosition(325, 100); Blank[2].SetSize(150, 10);
                    Blank[3].SetPosition(265, 120); Blank[3].SetSize(150, 30);
                    Blank[4].SetPosition(230, 170); Blank[4].SetSize(150, 10);
                    Blank[5].SetPosition(180, 200); Blank[5].SetSize(150, 10);
                    Blank[6].SetPosition(135, 230); Blank[6].SetSize(150, 10);
                    Blank[7].SetPosition(90, 250); Blank[7].SetSize(150, 10);
                    Blank[8].SetPosition(0, 270); Blank[8].SetSize(200, 10);
                    break;
            
                case 20:
                    for (int i = 0; i < Bacteria.Length; i++)
                    {
                        Bacteria[i].Show();
                        Bacteria[i].Move();
                    }
                    break;

                case 21:

                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    School.Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(800, 15);
                    Blank[1].SetPosition(0, 0); Blank[1].SetSize(15, 600);
                    Blank[2].SetPosition(0, 585); Blank[2].SetSize(800, 15);
                    Blank[3].SetPosition(785, 0); Blank[3].SetSize(15, 600);
                    WarpPoints[1].Show();
                    WarpPoints[7].Show();
                    WarpPoints[1].SetPosition(400, 560);
                    WarpPoints[7].SetPosition(400, 190);
                    School.SetPosition(330, 170);
                    break;

                case 22:

                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(800, 15);
                    Blank[1].SetPosition(0, 0); Blank[1].SetSize(15, 600);
                    Blank[2].SetPosition(0, 585); Blank[2].SetSize(800, 15);
                    Blank[3].SetPosition(785, 0); Blank[3].SetSize(15, 600);
                    WarpPoints[3].Show();
                    WarpPoints[8].Show();
                    WarpPoints[3].SetPosition(400, 560);
                    WarpPoints[8].SetPosition(150, 200);
                    break;

                case 23:
                    Blank[0].Show();
                    Blank[1].Show();
                    Blank[2].Show();
                    Blank[3].Show();
                    WarpPoints[5].Show();
                    WarpPoints[6].Show();

                    Blank[0].SetPosition(0, 0); Blank[0].SetSize(800, 15);
                    Blank[1].SetPosition(0, 0); Blank[1].SetSize(15, 600);
                    Blank[2].SetPosition(0, 585); Blank[2].SetSize(800, 15);
                    Blank[3].SetPosition(785, 0); Blank[3].SetSize(15, 600);
                    WarpPoints[6].SetPosition(200, 200);
                    WarpPoints[5].SetPosition(400, 560);
                    break;
            }

             if (Map != 20)
             {
                 for (int i = 0; i < Bacteria.Length; i++)
                        Bacteria[i].OverWriteVisible = false;
             }

        }

        public bool Collisions(ref clsPlayer Player, ref clsHUDBank HUD, int Map, ref clsBlocking Collider, ref clsChatBoxBank TextMenus, ref clsBackground Background)
        {
            HideAll();
            SetMap(Map);

            for (int i = 0; i < 2; i++)
            {
                if (hVillageblock[i].Collide(Player))
                {
                    if (hVillageblock[i].Visible)
                    {
                        Collider = hVillageblock[i];
                        return true;
                    }
                }
            }

            if (School.Collide(Player))
            {
                if (School.Visible)
                {
                    Collider = School;
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (TowerPieces[i].Collide(Player))
                {
                    if (TowerPieces[i].Visible)
                    {
                        TowerPieces[i].MakeHidden();
                        Player.AddCollectable();
                        Collider = TowerPieces[i];
                        return true;
                    }
                }
            }

            for (int i = 0; i < Blank.Length; i++)
            {
                if (Blank[i].Collide(Player))
                {
                    if (Blank[i].Visible)
                    {
                        Collider = Blank[i];
                        return true;
                    }
                }
            }

            for (int i = 0; i < RockBlock.Length; i++)
            {
                if (RockBlock[i].Collide(Player))
                {
                    if (RockBlock[i].Visible)
                    {
                        Collider = RockBlock[i];
                        return true;
                    }
                }
            }

            for (int i = 0; i < Bacteria.Length; i++)
            {
                if (Bacteria[i].Visible)
                {

                    if (Bacteria[i].Collide(Player))
                    {
                        Collider = Bacteria[i];
                        Player.AddCollectable();
                        Player.ManipulateScore(10);

                        Bacteria[i].MakeHidden();

                        if (Bacteria[0].OverWriteVisible && Bacteria[1].OverWriteVisible && Bacteria[2].OverWriteVisible && Bacteria[3].OverWriteVisible
                            && Bacteria[4].OverWriteVisible && Bacteria[5].OverWriteVisible && Bacteria[6].OverWriteVisible && Bacteria[7].OverWriteVisible
                            && Bacteria[8].OverWriteVisible && Bacteria[9].OverWriteVisible && Bacteria[10].OverWriteVisible && Bacteria[11].OverWriteVisible
                            && Bacteria[12].OverWriteVisible && Bacteria[13].OverWriteVisible && Bacteria[14].OverWriteVisible)
                        {
                            Player.EndQuests();
                            TextMenus.Collectables.Closed();
                            Background.SetMap(23); Player.Sprite.position = new Vector2(200, 290);
                            HUD.DataBank.SetText(17, "To Be Continued");
                            TextMenus.RadioMessage.SetText("You have completed the\ngame! Check the databank to\ngo over what you have\nlearned.");
                            TextMenus.RadioMessage.ShowIndicator();
                        }
                        return true;
                    }
                }

            }
        


            for (int i = 0; i < 6; i++)
            {
                  if (WarpPoints[i].Visible)
                    {
                        if (WarpPoints[i].Collide(Player))
                        {
                            HUD.AreYouSure[i + 2].Show();     return true;

                        }
              
                }
            }

            if (WarpPoints[6].Visible)
            {
                if (WarpPoints[6].Collide(Player))
                {
                    if (Player.GetScore() >= 580)
                    {
                        HUD.AreYouSure[8].Show();
                    }
                    else
                    {
                        TextMenus.RadioMessage.SetText("You need 580 resources to\nclean the well water.");
                        TextMenus.RadioMessage.ShowIndicator();
                    }

                    return true;

                }
            }

            if (WarpPoints[7].Visible)
            {
                if (WarpPoints[7].Collide(Player))
                {
                    if (Player.GetScore() >= 190)
                    {
                        HUD.AreYouSure[9].Show();
                    }
                    else
                   {
                    TextMenus.RadioMessage.SetText("You need 190 resources to\nteach the children. Try talking\nwith local people.");
                    TextMenus.RadioMessage.ShowIndicator();
                    }

                    return true;
                    
                }
            }

            if (WarpPoints[8].Visible)
            {
                if (WarpPoints[8].Collide(Player))
                {
                    if (Player.GetScore() >= 360)
                    {
                        HUD.AreYouSure[10].Show();
                    }
                    else
                    {
                        TextMenus.RadioMessage.SetText("You need 360 resources to\n teach these people. Sorry.");
                        TextMenus.RadioMessage.ShowIndicator();
                    }

                    return true;

                }
            }

            for (int i = 9; i < WarpPoints.Length; i++)
            {
                if (WarpPoints[i].Visible)
                {
                    if (WarpPoints[i].Collide(Player))
                    {
                        HUD.AreYouSure[i + 2].Show();
                        return true;
                    }
                }
            }

            if (Boat.Visible)
            {
                if (Boat.Collide(Player))
                {
                    return true;
                }
            }

            return false;

        }

        public void Draw(SpriteBatch spriteBatch, int Map)
        {
            for (int i = 0; i < 2; i++)
            {
                hVillageblock[i].Draw(spriteBatch);
            }

            for (int i = 0; i < 3; i++)
            {
                TowerPieces[i].Draw(spriteBatch);
            }

            for (int i = 0; i < Blank.Length; i++)
            {
                Blank[i].Draw(spriteBatch);
            }


            for (int i = 0; i < Bacteria.Length; i++)
            {
                Bacteria[i].Draw(spriteBatch);
            }

            for (int i = 0; i < WarpPoints.Length; i++)
                WarpPoints[i].Draw(spriteBatch);

            for (int i = 0; i < RockBlock.Length; i++)
            {
                RockBlock[i].Draw(spriteBatch);
            }

            School.Draw(spriteBatch);

            Boat.Draw(spriteBatch);


        }

    }
}
