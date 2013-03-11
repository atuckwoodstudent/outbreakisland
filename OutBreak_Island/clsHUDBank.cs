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
    class clsHUDBank
    {

        public clsHUD MainMenu, Options, StartMenu, DataBank, Credits;
        public clsHUD[] AreYouSure, FoodGame, TeachGame;

        public clsHUDBank(ref clsSpriteBank Sprites, ref SpriteFont Font)
        {
            MainMenu = new clsHUD(Sprites.sprMainMenu, Font, 3);
            Options = new clsHUD(Sprites.sprOptions, Font, 3);
            StartMenu = new clsHUD(Sprites.sprStartMenu, Font, 2);
            DataBank = new clsHUD(Sprites.sprDataBank_HUD, Font, 18);
            Credits = new clsHUD(Sprites.sprCredits, Font, 4);
            AreYouSure = new clsHUD[20];
            FoodGame = new clsHUD[5];
            TeachGame = new clsHUD[5];


            for (int i = 0; i < FoodGame.Length; i++)
            {
                FoodGame[i] = new clsHUD(Sprites.sprFoodGame, Font, 2);
            }

            FoodGame[0].SetText(0, "This food looks a bit burnt\nbut is cooked thoroughly.");
            FoodGame[0].SetText(1, "This food looks pale and\npossibly under-cooked.");

            FoodGame[1].SetText(0, "This food has had its meats\nmixed up.");
            FoodGame[1].SetText(1, "This food has had its meats\nprepared seperately.");

            FoodGame[2].SetText(0, "This food has been\nprepared by people \nwithout cholera.");
            FoodGame[2].SetText(1, "This food has had people\nwith cholera handling it..\nbut I am sure it tastes\ngood!!");

            FoodGame[3].SetText(0, "This cooked food has been\nmixed with raw salads and\nrelishes yum yum!!");
            FoodGame[3].SetText(1, "This cooked food has not\nbeen mixed raw salads and\nrelishes");

            FoodGame[4].SetText(0, "Grab a fresh plate and Ill\ngive you some food!!");
            FoodGame[4].SetText(1, "Go and help yourself from\nthat comunial food container");
             
            for (int i = 0; i < FoodGame.Length; i++)
            {
            FoodGame[i].SetOffSet(0,0, new Vector2(250,0));
            }

            for (int i = 0; i < TeachGame.Length; i++)
            {
                TeachGame[i] = new clsHUD(Sprites.sprTeachGame, Font, 3);
                TeachGame[i].SetOffSet(0f, 0f, new Vector2(0,110));
            }

            TeachGame[0].SetText(0, "Hey kids, today we are going to talk about cholera. Cholera can\nform in food and water in places where there is very little\nsanitation.");
            TeachGame[0].SetText(1, "Hey kids, today we are going to talk about cholera. Cholera\nappears only in water when you are not sanitary enough.");
            TeachGame[0].SetText(2, "Hey kids, today we are going to talk about cholera. Cholera\nappears only in food when you are not sanitary enough.");

            TeachGame[1].SetText(0, "Cholera is caused by the consumption of the bacterium named\nCholerae Vibrium");
            TeachGame[1].SetText(1, "Cholera is caused by the consumption of the bacterium named\nVibrio Cholerae");
            TeachGame[1].SetText(2, "Cholera is caused by consuming any bacteria.");

            TeachGame[2].SetText(0, "Not disposing of waste properly means these bacterium can\nreproduce.");
            TeachGame[2].SetText(1, "Not filtering water properly means these bacterium can\nreproduce.");
            TeachGame[2].SetText(2, "Staying clean after going to the toilet means these\nbacterium can reproduce.");

            TeachGame[3].SetText(0, "It is important to do this to stop cholera spreading further.");
            TeachGame[3].SetText(1, "It is important to do this to make sure an outbreak of cholera\ndoesn't form in the first place.");
            TeachGame[3].SetText(2, "It is important to do this to stop passing cholera on to other\npeople directly.");

            TeachGame[4].SetText(0, "Lastly, Cholera cannot be cured once you have it, and it almost\nalways kills.");
            TeachGame[4].SetText(1, "Lastly, Cholera is difficuly to treat without antibiotics and the\nbacteria itself is a killer");
            TeachGame[4].SetText(2, "Lastly, Cholera is fairly easy to treat with a mixture of clean\nwater and sugar, the dehydration it causes is a killer.");



            for (int i = 0; i < AreYouSure.Length; i++)
            {
                AreYouSure[i] = new clsHUD(Sprites.sprAreYouSure, Font, 2);
                AreYouSure[i].SetText(0, " No");
                AreYouSure[i].SetText(1,"Yes");
                AreYouSure[i].SetOffSet(50, 50, new Vector2(0,30));
            }

            AreYouSure[8].SetText(0, "Back");
            AreYouSure[8].SetText(1, "Decontaminate");
            AreYouSure[8].SetOffSet(20, 50, new Vector2(0,50));

            AreYouSure[9].SetText(0, "Back");
            AreYouSure[9].SetText(1, "Educate");
            AreYouSure[9].SetOffSet(20, 50, new Vector2(0, 50));

            AreYouSure[10].SetText(0, "Back");
            AreYouSure[10].SetText(1, "Lecture");
            AreYouSure[10].SetOffSet(20, 50, new Vector2(0, 50));

            MainMenu.SetText(0, "Start Game");
            MainMenu.SetText(1, "  Options");
            MainMenu.SetText(2, " Quit Game");

            Options.SetText(0, "Turn off Sound");
            Options.SetText(1, "      Credits");
            Options.SetText(2, "  Back to Main");

            Credits.SetText(0, "          Programming, Alan Tuckwood");
            Credits.SetText(1, "         Object Graphics, Lee Croxton");
            Credits.SetText(2, "  Level & Sprite Graphics, Katherine Young");
            Credits.SetText(3, "                      Back to Main");
            Credits.SetOffSet(12, 50,new Vector2(0,18));

            StartMenu.SetText(0, "  Continue");
            StartMenu.SetText(1, "Quit to Main");

            DataBank.SetText(0, "A Pandemic");
            DataBank.SetText(1, "No Data Yet");
            DataBank.SetText(2, "No Data Yet");
            DataBank.SetText(3, "No Data Yet");
            DataBank.SetText(4, "No Data Yet");
            DataBank.SetText(5, "No Data Yet");
            DataBank.SetText(6, "No Data Yet");
            DataBank.SetText(7, "No Data Yet");
            DataBank.SetText(8, "No Data Yet");
            DataBank.SetText(9, "No Data Yet");
            DataBank.SetText(10, "No Data Yet");
            DataBank.SetText(11, "No Data Yet");
            DataBank.SetText(12, "No Data Yet");
            DataBank.SetText(13, "No Data Yet");
            DataBank.SetText(14, "No Data Yet");
            DataBank.SetText(15, "No Data Yet");
            DataBank.SetText(16, "No Data Yet");
            DataBank.SetText(17, "No Data Yet");

            DataBank.SetOffSet(20f, 0f,new Vector2(0,25));


            MainMenu.SetOffSet(40f, 70f, new Vector2(0,30));
            Options.SetOffSet(30f, 40f,new Vector2(0,30));
            StartMenu.SetOffSet(20f, 30f, new Vector2(0,30));
            
            MainMenu.Show();
            Options.Hide();
            StartMenu.Hide();
            DataBank.Hide();

            for (int i = 0; i < AreYouSure.Length; i++)
                AreYouSure[i].Hide();


            for (int i = 0; i < TeachGame.Length; i++)
               TeachGame[i].Hide();

        }

        public void RightOne()
        {
            for (int i = 0; i < FoodGame.Length; i++)
            {
                if (FoodGame[i].Visible)
                    FoodGame[i].DownOne();
            }
        }

        public void LeftOne()
        {
            for (int i = 0; i < FoodGame.Length; i++)
            {
                if (FoodGame[i].Visible)
                    FoodGame[i].UpOne();
            }
        }

        public void DownOne()
        {
            if (MainMenu.Visible)
                MainMenu.DownOne();

            if (Options.Visible)
                Options.DownOne();

            if (StartMenu.Visible)
                StartMenu.DownOne();

            for (int i = 0; i < AreYouSure.Length; i++)
            {
                if (AreYouSure[i].Visible)
                    AreYouSure[i].DownOne();
            }

            if (DataBank.Visible)
                DataBank.DownOne();

            for (int i = 0; i < TeachGame.Length; i++)
            {
                if (TeachGame[i].Visible)
                    TeachGame[i].DownOne();
            }

        }

        public void UpOne()
        {
            if (MainMenu.Visible)
                MainMenu.UpOne();

            if (Options.Visible)
                Options.UpOne();

            if (StartMenu.Visible)
                StartMenu.UpOne();

            for (int i = 0; i < AreYouSure.Length; i++)
            {
                if (AreYouSure[i].Visible)
                    AreYouSure[i].UpOne();
            }

            if (DataBank.Visible)
                DataBank.UpOne();

            for (int i = 0; i < TeachGame.Length; i++)
            {
                if (TeachGame[i].Visible)
                    TeachGame[i].UpOne();
            }

        }

        public bool GetQuit()
        {
                if (AreYouSure[0].Visible)
                {
                    switch (AreYouSure[0].GetSelected())
                    {
                        case 1: return true;
                    }
                }
            

            return false;
        }


        public void GetSelected(ref clsChatBoxBank TextMenus, ref bool ButtonPressed, ref clsPlayer Player, ref clsArchitectureBank Architecture, ref clsBlockingBank Blocking, ref clsNPCBank NPC, ref clsBackground Background)
        {
            if (MainMenu.Visible)
            {
                switch (MainMenu.GetSelected())
                {
                    case 0: 
                        MainMenu.Hide();
                        Background.SetMap(8);

                        Blocking.TowerPieces[0].OverWriteVisible = false;
                        Blocking.TowerPieces[1].OverWriteVisible = false;
                        Blocking.TowerPieces[2].OverWriteVisible = false;

                        for (int i = 0; i < NPC.NPCS.Length; i++ )
                            NPC.NPCS[i].Sprite.Collided = false;

                        for (int i = 0; i < Blocking.RockBlock.Length; i++)
                            Blocking.RockBlock[i].OverWriteVisible = false;

                        for (int i = 0; i < Blocking.hVillageblock.Length; i++)
                            Blocking.hVillageblock[i].OverWriteVisible = false;

                        Architecture.Tower.Body.frame = new Vector2(1, 0);
                        Architecture.Tower.Head.frame = new Vector2(1, 0);

                        for (int i = 0; i < Blocking.WarpPoints.Length; i++)
                            Blocking.WarpPoints[i].OverWriteVisible = false;

                        NPC.NPCS[1].SetSpeech("My job is to make sure nobody gets into this village because of the disease.\n What's that? A relief worker? Until I can talk to your boss on the radio, you can't come in.");
                        NPC.NPCS[2].SetSpeech("Fix the tower you say? It looks pretty demolished if you ask me...");

                        DataBank.SetText(0, "A Pandemic");

                        for (int i = 1; i < 18; i++)
                        DataBank.SetText(i, "No Data Yet");
                        
                        Player.Sprite.position = new Vector2(300,220);
                        Player.ResetScore();
                        Player.EndQuests();

                        TextMenus.Letter.Open();
                        TextMenus.Letter.SetText("Hey Jim,\n\nWe have been having reports that a large outbreak of cholera has\nemerged in the area marked on your map. You are the closest\nguy we have out there, so I'm counting on you to help out the\nlocals. First things, first though. I have been told that you have\nto fix the island's radio tower as the local geology messes\nwith our usual lines of communication. Try asking the locals if you\nget lost.\n\nGood luck, we're all counting on you back home.\n\nRegards, Steve");
                        TextMenus.RadioMessage.SetText("In this box will be your\ncurrent objective. As you\nhave not yet fixed the radio\ntower, all you will recieve is\nstatic. Fix the radio tower\nto recieve objectives.");
                        TextMenus.Databank.SetText("");
                        TextMenus.RadioMessage.ShowIndicator();
                        TextMenus.Databank.ShowIndicator();
                        Player.ClearCollected();
                        break;

                    case 1: Options.Show(); MainMenu.Hide(); Options.Selected = 0; break;
                    case 2: ButtonPressed = false; AreYouSure[0].Show(); MainMenu.Hide(); break;
                }
            }

            if (AreYouSure[0].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[0].GetSelected())
                    {
                        case 0:
                            MainMenu.Show(); MainMenu.Selected = 0; AreYouSure[0].Hide();
                            break;
                    }
                }
            }

            if (Options.Visible)
            {
                switch (Options.GetSelected())
                {
                    case 0: break;
                    case 1: ButtonPressed = false; Options.Hide(); Credits.Show(); Credits.Selected = 3; break;
                    case 2: MainMenu.Show(); Options.Hide(); break;
                }
            }

            if (StartMenu.Visible)
            {
                switch (StartMenu.GetSelected())
                {
                    case 0: StartMenu.Hide(); break;
                    case 1: StartMenu.Hide(); AreYouSure[1].Show(); ButtonPressed = false; break;
                }
            }

            if (AreYouSure[1].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[1].GetSelected())
                    {
                        case 0:
                            StartMenu.Show(); StartMenu.Selected = 0; AreYouSure[1].Hide();
                            break;
                        case 1:
                            MainMenu.Show(); Background.SetMap(-1); MainMenu.Selected = 0; AreYouSure[1].Hide();
                            break;
                    }
                }
            }

            if (AreYouSure[2].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[2].GetSelected())
                    {
                        case 0:
                            AreYouSure[2].Hide();
                            break;
                        case 1:
                            AreYouSure[2].Hide(); Player.Sprite.position = new Vector2(400, 500); Background.SetMap(21);
                            break;
                    }
                }
            }

            if (AreYouSure[3].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[3].GetSelected())
                    {
                        case 0:
                            AreYouSure[3].Hide();
                            break;
                        case 1:
                            AreYouSure[3].Hide(); Player.Sprite.position = new Vector2(400, 350); Background.SetMap(5);
                            break;
                    }
                }
            }

            if (AreYouSure[4].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[4].GetSelected())
                    {
                        case 0:
                            AreYouSure[4].Hide();
                            break;
                        case 1:
                            AreYouSure[4].Hide(); Player.Sprite.position = new Vector2(400, 500); Background.SetMap(22);
                            break;
                    }
                }
            }

            if (AreYouSure[5].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[5].GetSelected())
                    {
                        case 0:
                            AreYouSure[5].Hide();
                            break;
                        case 1:
                            AreYouSure[5].Hide(); Player.Sprite.position = new Vector2(100, 280); Background.SetMap(2);
                            break;
                    }
                }
            }

            if (AreYouSure[6].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[6].GetSelected())
                    {
                        case 0:
                            AreYouSure[6].Hide();
                            break;
                        case 1:
                            AreYouSure[6].Hide(); Player.Sprite.position = new Vector2(400, 500); Background.SetMap(23);
                            break;
                    }
                }
            }

            if (AreYouSure[7].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[7].GetSelected())
                    {
                        case 0:
                            AreYouSure[7].Hide();
                            break;
                        case 1:
                            AreYouSure[7].Hide(); Player.Sprite.position = new Vector2(150, 300); Background.SetMap(7);
                            break;
                    }
                }
            }


            if (AreYouSure[8].Visible)
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[8].GetSelected())
                    {
                        case 0:
                            AreYouSure[8].Hide();
                            break;
                        case 1:
                            AreYouSure[8].Hide(); Player.Sprite.position = new Vector2(400, 400); Background.SetMap(20); Player.ClearCollected();
                            break;
                    }
                }
            }

            if (Credits.Visible)
            {
                if (ButtonPressed)
                {
                    ButtonPressed = false; Options.Selected = 0; Options.Show(); Credits.Hide();
                }
            }

            if (DataBank.Visible)
            {
                if (DataBank.Text[DataBank.GetSelected()] == "No Data Yet")
                {
                    TextMenus.DataPopup.SetText("We have no data for this yet.");
                    TextMenus.DataPopup.Open();
                }
                else
                {
                    switch (DataBank.GetSelected())
                    {
                        case 0:
                            TextMenus.DataPopup.SetText("Since 1817, there have been\nseven worldwide cholera\npandemics.In Asia, Africa, and\nLatin America, there is an ongoing\npandemic that has spanned the\nlast four decades.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 1:
                            TextMenus.DataPopup.SetText("Cholera remains a problem in\nalmost every developing country.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 2:
                            TextMenus.DataPopup.SetText("Because of advanced water\nand sanitation systems, cholera is\nnot a major threat in the United\nStates. However, everyone,\nespecially travelers, should be\naware of how cholera is\ntransmitted and what can be\ndone to prevent it.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 3:
                            TextMenus.DataPopup.SetText("Mixing raw vegetables with meats\nis called cross contamination.\nBacteria from the meat enters \nthe salad. The salad would not be\ncooked to a high enough\ntemperature for the bacteria to be\ndestroyed.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 4:
                            TextMenus.DataPopup.SetText("There are obvious benefits to\nteaching. Related to cholera, the\nunderstanding of identifying,\nbeing aware of and preventing\nthe spread of such a disease\nwould be transferrable when\nthese children become parents\nthemselves.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 5:
                            TextMenus.DataPopup.SetText("Cholera transmission typically\noccurs by drinking water or\neating food that is contaminated\nwith Vibrio cholerae.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 6:
                            TextMenus.DataPopup.SetText("Assistance, such as money, food,\nor shelter, given to the needy,\naged, or victims of disaster. It is\nusually granted on a temporary\nbasis.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 7:
                            TextMenus.DataPopup.SetText("Sanitary measures are put into\nplace to prevent infection from\noccuring, not to cure oneself of it.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 8:
                            TextMenus.DataPopup.SetText("A total of 236 896 cases were\nreported in 2006, an overall\nincrease of 79% compared with\nthe number of cases reported in\n2005.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 9:
                            TextMenus.DataPopup.SetText("Most bacteria are destroyed\nwhen meat reaches a certain\ntemperature. In order to make\nmeat safe to eat, you have to\ncook it thoroughly.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 10:
                            TextMenus.DataPopup.SetText("Neither vaccination, quarantine,\nnor travel restrictions prevent\ncholera from spreading.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 11:
                            TextMenus.DataPopup.SetText("Cholera usually occurs after a\nnatural disaster such as a flood.\nThe disaster itself can displace\nfamilies and cause much confusion.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 12:
                            TextMenus.DataPopup.SetText("By having a shared pot of food\nthat anyone has access to,\ncholera outbreaks can arise\nsignificantly.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 13:
                            TextMenus.DataPopup.SetText("Cholera initially causes severe\ndehydration. This is what kills\nmost people.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 14:
                            TextMenus.DataPopup.SetText("Even if you are from a place which\ndoesn't usually suffer an outbreak,\ncholera can still hurt you.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 15:
                            TextMenus.DataPopup.SetText("75% of cholera sufferers do\nnot exibit any symptoms.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 16:
                            TextMenus.DataPopup.SetText("Cholera is caused by eating\ncontaminated foodstuffs.\nTransmission is primarily due to\nthe fecal contamination of food\nand water due to poor sanitation.\nThis bacterium can, however,\nlive naturally in any environment.");
                            TextMenus.DataPopup.Open();
                            break;
                        case 17:
                            TextMenus.DataPopup.SetText("Cholera will never be fully cured...");
                            TextMenus.DataPopup.Open();
                            break;
                    }
                }
            }

            if (AreYouSure[9].Visible) 
            {
                if (ButtonPressed)
                {
                        switch (AreYouSure[9].GetSelected())
                        {
                            case 0:
                                AreYouSure[9].Hide();
                                break;
                            case 1:
                                AreYouSure[9].Hide(); Player.Sprite.position = new Vector2(540, 260); Background.SetMap(24); Player.ClearCollected(); Player.StartQuest(1); ButtonPressed = false; Player.ClearCorrect(); TeachGame[0].Show(); Player.Sprite.frame = new Vector2(3, 5); Player.FlipPlayer(true);
                                break;
                        }
                    }
                }
            

                        if (AreYouSure[10].Visible) 
            {
                if (ButtonPressed)
                {
                    switch (AreYouSure[10].GetSelected())
                    {
                        case 0:
                            AreYouSure[10].Hide();
                            break;
                        case 1:
                            AreYouSure[10].Hide(); Player.Sprite.position = new Vector2(400, 400); Background.SetMap(25); Player.ClearCollected(); Player.StartQuest(2); ButtonPressed = false; Player.ClearCorrect(); FoodGame[0].Show(); Player.Sprite.frame = new Vector2(0, 2);
                            break;
                    }
                }
            }

            if (TeachGame[0].Visible)
            {
                if (ButtonPressed)
                {
                    switch (TeachGame[0].GetSelected())
                    {
                        case 0: TeachGame[1].Show(); TeachGame[0].Hide(); Player.AddCorrect();  ButtonPressed = false;
                            break;
                        case 1: TeachGame[1].Show(); TeachGame[0].Hide(); ButtonPressed = false;
                            break;
                        case 2: TeachGame[1].Show(); TeachGame[0].Hide(); ButtonPressed = false;
                            break;
                    }
                }
            }

            if (TeachGame[1].Visible)
            {
                if (ButtonPressed)
                {
                    switch (TeachGame[1].GetSelected())
                    {
                        case 0: TeachGame[1].Hide(); TeachGame[2].Show(); ButtonPressed = false;
                            break;
                        case 1: TeachGame[1].Hide(); TeachGame[2].Show(); Player.AddCorrect(); ButtonPressed = false;
                            break;
                        case 2: TeachGame[1].Hide(); TeachGame[2].Show(); ButtonPressed = false;
                            break;
                    }
                }
               
            }

            if (TeachGame[2].Visible)
            {
                if (ButtonPressed)
                {
                    switch (TeachGame[2].GetSelected())
                    {
                        case 0: TeachGame[2].Hide(); TeachGame[3].Show(); Player.AddCorrect();  ButtonPressed = false;
                            break;
                        case 1: TeachGame[2].Hide(); TeachGame[3].Show(); ButtonPressed = false;
                            break;
                        case 2: TeachGame[2].Hide(); TeachGame[3].Show(); ButtonPressed = false;
                            break;
                    }
                }
            }

            if (TeachGame[3].Visible)
            {
                if (ButtonPressed)
                {
                    switch (TeachGame[3].GetSelected())
                    {
                        case 0: TeachGame[3].Hide(); TeachGame[4].Show(); ButtonPressed = false;
                            break;
                        case 1: TeachGame[3].Hide(); TeachGame[4].Show(); Player.AddCorrect(); ButtonPressed = false;
                            break;
                        case 2: TeachGame[3].Hide(); TeachGame[4].Show(); ButtonPressed = false;
                            break;
                    }
                }
            }

           if (TeachGame[4].Visible)
           {
               if (ButtonPressed)
               {
                   switch (TeachGame[4].GetSelected())
                   {
                       case 0: TeachGame[4].Hide(); Player.Sprite.position = new Vector2(400, 270); Background.SetMap(21); ButtonPressed = false;
                           break;
                       case 1: TeachGame[4].Hide(); Player.Sprite.position = new Vector2(400, 270); Background.SetMap(21); ButtonPressed = false;
                           break;
                       case 2: TeachGame[4].Hide(); Player.AddCorrect(); Player.Sprite.position = new Vector2(400, 270); Background.SetMap(21); ButtonPressed = false;
                           break;
                   }

                   switch (Player.GetCorrect())
                   {
                       case 0:
                       case 1:
                           TextMenus.RadioMessage.SetText("Oh dear, I'm not sure what\nhappened there. You gave\nquite a few wrong messages.\nYou will have to try again\nbefore I can give you the\nnext mission.");
                           break;
                       case 2:
                           TextMenus.RadioMessage.SetText("You scored 2 out of 5.\nIt's not quite good enough to\nlet you proceed to the next\nmission. You will have to try\nagain.");
                           break;
                       case 3:
                       case 4:
                           TextMenus.RadioMessage.SetText("Almost there, you just missed\nout on a few vital points.\nTry again.");
                           break;
                       case 5:
                           TextMenus.RadioMessage.SetText("Excellent work. \nTo the village north-east of\nthis location, there is a\nserious problem with food\nsanitation. Go show 'em\nwhat to do!");
                           Player.ManipulateScore(150);
                           Blocking.WarpPoints[7].MakeHidden();

                           for(int i=0; i<6; i++)
                               Blocking.RockBlock[i].MakeHidden();

                           DataBank.SetText(4, "Those Who Can...");
                           TextMenus.RadioMessage.ShowIndicator();
                           TextMenus.Databank.ShowIndicator();
                           Player.StartQuest(2);
                           
                           break;
                   }
                   TextMenus.RadioMessage.ShowIndicator();
               }
           }

           if (FoodGame[0].Visible)
           {
               Player.Sprite.frame = new Vector2(3, 0);
               if (ButtonPressed)
               {
                   switch (FoodGame[0].GetSelected())
                   {
                       case 0: FoodGame[1].Show(); FoodGame[0].Hide(); Player.AddCorrect(); ButtonPressed = false;
                           break;
                       case 1: FoodGame[1].Show(); FoodGame[0].Hide(); ButtonPressed = false;
                           break;
                   }
               }
           }

           if (FoodGame[1].Visible)
           {
               Player.Sprite.frame = new Vector2(3, 0);
               if (ButtonPressed)
               {
                   switch (FoodGame[1].GetSelected())
                   {
                       case 0: FoodGame[1].Hide(); FoodGame[2].Show(); ButtonPressed = false;
                           break;
                       case 1: FoodGame[1].Hide(); FoodGame[2].Show(); Player.AddCorrect(); ButtonPressed = false;
                           break;
                   }
               }

           }

           if (FoodGame[2].Visible)
           {
               Player.Sprite.frame = new Vector2(3, 0);
               if (ButtonPressed)
               {
                   switch (FoodGame[2].GetSelected())
                   {
                       case 0: FoodGame[2].Hide(); FoodGame[3].Show(); Player.AddCorrect(); ButtonPressed = false;
                           break;
                       case 1: FoodGame[2].Hide(); FoodGame[3].Show(); ButtonPressed = false;
                           break;
                   }
               }
           }

           if (FoodGame[3].Visible)
           {
               Player.Sprite.frame = new Vector2(3, 0);
               if (ButtonPressed)
               {
                   switch (FoodGame[3].GetSelected())
                   {
                       case 0: FoodGame[3].Hide(); FoodGame[4].Show(); ButtonPressed = false;
                           break;
                       case 1: FoodGame[3].Hide(); FoodGame[4].Show(); Player.AddCorrect(); ButtonPressed = false;
                           break;
                   }
               }
           }

           if (FoodGame[4].Visible)
           {
               Player.Sprite.frame = new Vector2(3, 0);
               if (ButtonPressed)
               {
                   switch (FoodGame[4].GetSelected())
                   {
                       case 0: FoodGame[4].Hide(); Player.Sprite.position = new Vector2(150, 250); Player.AddCorrect(); Background.SetMap(22); ButtonPressed = false;
                           break;
                       case 1: FoodGame[4].Hide(); Player.Sprite.position = new Vector2(150, 250); Background.SetMap(22); ButtonPressed = false;
                           break;
                   }

                   switch (Player.GetCorrect())
                   {
                       case 0:
                       case 1:
                           TextMenus.RadioMessage.SetText("Oh dear, I'm not sure what\nhappened there. You gave\nquite a few wrong messages.\nYou will have to try again\nbefore I can give you the\nnext mission.");
                           break;
                       case 2:
                           TextMenus.RadioMessage.SetText("You scored 2 out of 5.\nIt's not quite good enough to\nlet you proceed to the next\nmission. You will have to try\nagain.");
                           break;
                       case 3:
                       case 4:
                           TextMenus.RadioMessage.SetText("Almost there, you just missed\nout on a few vital points.\nTry again.");
                           break;
                       case 5:
                           TextMenus.RadioMessage.SetText("Excellent work. The third\nvillage is to the east of this\nlocation, you need to use the\nresources you have obtained\nto sanitise their drinking\nwater from the well.");
                           Player.ManipulateScore(150);
                           Blocking.WarpPoints[8].MakeHidden();

                           for (int i = 6; i < 18; i++)
                               Blocking.RockBlock[i].MakeHidden();

                           DataBank.SetText(16, "Nom Nom");
                           TextMenus.RadioMessage.ShowIndicator();
                           TextMenus.Databank.ShowIndicator();
                           Player.StartQuest(3);
                           TextMenus.Collectables.Open();

                           break;
                   }
                   TextMenus.RadioMessage.ShowIndicator();
               }
           }
        



        }

        public bool ShowAHud()
        {
            if (MainMenu.Visible)
                return true;
            if (Options.Visible)
                return true;
            if (StartMenu.Visible)
                return true;
            for (int i = 0; i < AreYouSure.Length; i++)
            {
                if (AreYouSure[i].Visible)
                    return true;
            }
            if (Credits.Visible)
                return true;

            for (int i = 0; i < TeachGame.Length; i++)
            {
                if (TeachGame[i].Visible)
                    return true;
            }


            for (int i = 0; i < FoodGame.Length; i++)
            {
                if (FoodGame[i].Visible)
                    return true;
            }

            return false;
        }

        public bool ShowDataBank()
        {
            if (DataBank.Visible)
                return true;

            return false;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (MainMenu.Visible)
                MainMenu.Draw(spriteBatch);

            if (Options.Visible)
                Options.Draw(spriteBatch);

            if (StartMenu.Visible)
                StartMenu.Draw(spriteBatch);

            for (int i = 0; i < AreYouSure.Length; i++)
            {
                if (AreYouSure[i].Visible)
                    AreYouSure[i].Draw(spriteBatch);
            }

            if (Credits.Visible)
                Credits.Draw(spriteBatch);

            if (DataBank.Visible)
                DataBank.Draw(spriteBatch);

            if(!MainMenu.Visible && !Options.Visible && !StartMenu.Visible)

            for (int i = 0; i < TeachGame.Length; i++)
            {
                if (TeachGame[i].Visible)
                    TeachGame[i].Draw(spriteBatch);
            }

            for (int i = 0; i < FoodGame.Length; i++)
            {
                if (FoodGame[i].Visible)
                    FoodGame[i].Draw(spriteBatch);
            }
        }
    }
}
