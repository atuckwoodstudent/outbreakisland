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
    class clsSpriteBank
    {

        public clsSprite sprSchool, sprInteract, sprInteract_Closed, sprPlayer, sprBackground, sprChatBox, sprChatBox_Closed, sprDataBox, sprDataBox_Closed, sprDataBox_Indicate, sprRadioBox, sprRadioBox_Closed, sprRadioBox_Indicate, sprLetter, sprLetter_Closed, sprPlayerScore, sprCollectables, sprCollectable_Closed, sprBoat;
        public clsSprite[] sprNPC, sprRockBlock;
        public clsSprite sprMainMenu, sprStartMenu, sprOptions, sprDataBank_HUD, sprAreYouSure, sprCredits, sprDataPopup, sprDataPopup_Closed, sprFoodGame, sprTeachGame, sprFoodGame_Closed, sprTeachGame_Closed;
        public clsSprite[] sprARC_Head, sprARC_Body;
        public clsSprite[] sprTree_Head, sprTree_Body;
        public clsSprite[] sprBarrier, sprBlocked;
        public clsSprite[] sprTowerPiece, sprBacteria, sprTownMarker;
        public ContentManager Contents;
        public Texture2D[] ARCBuildings, ARCTrees, PIETower;
        public Texture2D[] Blk;
        public Texture2D Bacteria, Indicator, PlayerScore, Collectables, Marker, FactSheet, Well, Table, NPC;
        
        public clsSpriteBank(ContentManager Content)
        {
            Contents = Content;

            sprTree_Head = new clsSprite[10];
            sprTree_Body = new clsSprite[10];
            sprARC_Body = new clsSprite[20];
            sprARC_Head = new clsSprite[20];
            sprBlocked = new clsSprite[25];
            sprBarrier = new clsSprite[4];
            sprTowerPiece = new clsSprite[5];
            sprBacteria = new clsSprite[15];
            sprTownMarker = new clsSprite[9];
            sprNPC = new clsSprite[13];
            sprRockBlock = new clsSprite[18];

            ARCBuildings = new Texture2D[8];
            ARCTrees = new Texture2D[4];
            PIETower = new Texture2D[3];
            Blk = new Texture2D[50];
       
            NPC = Content.Load<Texture2D>("NPC");

            ARCBuildings[0] = Content.Load<Texture2D>("Building1_Body");
            ARCBuildings[1] = Content.Load<Texture2D>("Building1_Head");
            ARCBuildings[2] = Content.Load<Texture2D>("Mudhut_Base");
            ARCBuildings[3] = Content.Load<Texture2D>("Mudhut_Top");
            ARCBuildings[4] = Content.Load<Texture2D>("Building1_Body");
            ARCBuildings[5] = Content.Load<Texture2D>("Building1_Head");
            ARCBuildings[6] = Content.Load<Texture2D>("Building1_Body");
            ARCBuildings[7] = Content.Load<Texture2D>("Building1_Head");

            ARCTrees[0] = Content.Load<Texture2D>("Tree");
            ARCTrees[1] = Content.Load<Texture2D>("Tree_Top");
            ARCTrees[2] = Content.Load<Texture2D>("Tree");
            ARCTrees[3] = Content.Load<Texture2D>("Tree_Top");

            PIETower[0] = Content.Load<Texture2D>("Piece");
            PIETower[1] = Content.Load<Texture2D>("Piece");
            PIETower[2] = Content.Load<Texture2D>("Piece");

            Blk[0] = Content.Load<Texture2D>("hBlocker");
            Blk[2] = Content.Load<Texture2D>("Blank");
            Blk[3] = Content.Load<Texture2D>("Piece");
            Blk[4] = Content.Load<Texture2D>("Tower_Bottom");
            Blk[5] = Content.Load<Texture2D>("Tower_Top");
            Blk[6] = Content.Load<Texture2D>("Rock");

            Bacteria = Content.Load<Texture2D>("Bacteria");
            Indicator = Content.Load<Texture2D>("Indicator");
            PlayerScore = Content.Load<Texture2D>("PlayerScore");
            Collectables = Content.Load<Texture2D>("Collectables");
            Marker = Content.Load<Texture2D>("CityMarker");
            Well = Content.Load<Texture2D>("Well");
            FactSheet = Content.Load<Texture2D>("FactSheet");
            Table = Content.Load<Texture2D>("Table");

            sprSchool = new clsSprite(Content.Load<Texture2D>("School"), new Vector2(344f, 234f),new Vector2(45,44));

            sprBoat = new clsSprite(Content.Load<Texture2D>("boat"), new Vector2(344f, 234f),
             new Vector2(191, 133));

            sprAreYouSure = new clsSprite(Content.Load<Texture2D>("AreYouSure"), new Vector2(344f, 234f),
               new Vector2(122, 134));

            sprStartMenu = new clsSprite(Content.Load<Texture2D>("Start_Menu"), new Vector2(348f, 249f),
               new Vector2(126, 104));
            sprMainMenu = new clsSprite(Blk[2], new Vector2(326f, 200f),
                          new Vector2(156f, 224f));

            sprCredits = new clsSprite(Blk[2], new Vector2(250f, 200f),
              new Vector2(300f, 200f));

            sprOptions = new clsSprite(Blk[2], new Vector2(326f, 230f),
                                         new Vector2(156f, 224f));

            sprInteract = new clsSprite(Content.Load<Texture2D>("A"), new Vector2(350f, 300f),
                                    new Vector2(77f, 31f), new Vector2(0, 0));

            sprInteract_Closed = new clsSprite(Blk[2], new Vector2(350f, 300f),
                                  new Vector2(35f, 31f), new Vector2(0, 0));



            sprPlayer = new clsSprite(Content.Load<Texture2D>("Main_Char"), new Vector2(350f, 300f),
                                    new Vector2(32f, 48f), new Vector2(0, 0));

            sprBackground = new clsSprite(Content.Load<Texture2D>("Background"), new Vector2(0, 0),
                            new Vector2(800f, 600f), new Vector2(0, 4));

            sprChatBox = new clsSprite(Content.Load<Texture2D>("Conversations"), new Vector2(0, 540f),
                                    new Vector2(800f, 60f), new Vector2(0, 0));

            sprDataBox = new clsSprite(Content.Load<Texture2D>("DataBank"), new Vector2(588f, 45f),
                                   new Vector2(212f, 495f), new Vector2(0, 0));

            sprRadioBox = new clsSprite(Content.Load<Texture2D>("RadioMessage"), new Vector2(0f, 100f),
                                   new Vector2(212f, 380f), new Vector2(0, 0));

            sprLetter = new clsSprite(Content.Load<Texture2D>("LetterMessage"), new Vector2(60f, 60f),
                               new Vector2(697f, 485f), new Vector2(0, 0));

            sprChatBox_Closed = new clsSprite(Blk[2], new Vector2(0, 0f),
                        new Vector2(0, 0f), new Vector2(0, 0));

            sprDataBox_Closed = new clsSprite(Content.Load<Texture2D>("DataBank_Closed"), new Vector2(787f, 45f),
                                   new Vector2(13f, 495f), new Vector2(0, 0));

            sprRadioBox_Closed = new clsSprite(Content.Load<Texture2D>("RadioMessage_Closed"), new Vector2(0f, 100f),
                                   new Vector2(12f, 380f), new Vector2(0, 0));

            
            sprLetter_Closed = new clsSprite(Blk[2], new Vector2(0f, 0f),
                               new Vector2(0, 0), new Vector2(0, 0));


            sprRadioBox_Indicate = new clsSprite(Indicator, new Vector2(14f, 105f),
                                   new Vector2(54f, 40f), new Vector2(0, 0));

            sprDataBox_Indicate = new clsSprite(Indicator, new Vector2(730f, 105f),
                       new Vector2(54f, 40f), new Vector2(1, 0));

            sprDataBank_HUD = new clsSprite(Blk[2], new Vector2(600f, 70f),
                      new Vector2(100f, 100f), new Vector2(0, 0));

            sprPlayerScore = new clsSprite(PlayerScore, new Vector2(562f, 10f),
                                   new Vector2(188f, 31f), new Vector2(0, 0));

            sprCollectables = new clsSprite(Collectables, new Vector2(50f, 10f),
                                   new Vector2(188f, 31f), new Vector2(0, 0));

            sprCollectable_Closed = new clsSprite(Blk[2], new Vector2(0f, 10f),
                       new Vector2(188f, 31f), new Vector2(0, 0));



            sprDataPopup = new clsSprite(FactSheet, new Vector2(280f, 180f),
                                   new Vector2(238f, 273f), new Vector2(0, 0));

            sprDataPopup_Closed = new clsSprite(Blk[2], new Vector2(320f, 400f),
                       new Vector2(188f, 31f), new Vector2(0, 0));

            sprFoodGame = new clsSprite(Blk[2], new Vector2(185f, 80f),
                       new Vector2(188f, 31f), new Vector2(0, 0));

            sprTeachGame = new clsSprite(Blk[2], new Vector2(30f, 40f),
                       new Vector2(188f, 31f), new Vector2(0, 0));

            sprFoodGame_Closed = new clsSprite(Blk[2], new Vector2(320f, 400f),
           new Vector2(188f, 31f), new Vector2(0, 0));

            sprTeachGame_Closed = new clsSprite(Blk[2], new Vector2(320f, 400f),
                       new Vector2(188f, 31f), new Vector2(0, 0));

            sprTowerPiece[0] = new clsSprite(Blk[3], new Vector2(500,400), new Vector2(32,32), new Vector2(0,0));
            sprTowerPiece[1] = new clsSprite(Blk[3], new Vector2(500, 400), new Vector2(32, 32), new Vector2(0, 0));
            sprTowerPiece[2] = new clsSprite(Blk[3], new Vector2(500, 400), new Vector2(32, 32), new Vector2(0, 0));
            sprTowerPiece[3] = new clsSprite(Blk[4], new Vector2(559, 152), new Vector2(280f, 76), new Vector2(1, 0));
            sprTowerPiece[4] = new clsSprite(Blk[5], new Vector2(559, 204), new Vector2(280f,204), new Vector2(1,0));

            sprTownMarker[0] = new clsSprite(Marker, new Vector2(100,100), new Vector2(47,47), new Vector2(0,0));
            sprTownMarker[1] = new clsSprite(Marker, new Vector2(100, 100), new Vector2(47, 47), new Vector2(0, 0));
            sprTownMarker[2] = new clsSprite(Marker, new Vector2(100, 100), new Vector2(47, 47), new Vector2(0, 0));
            sprTownMarker[3] = new clsSprite(Marker, new Vector2(100, 100), new Vector2(47, 47), new Vector2(0, 0));
            sprTownMarker[4] = new clsSprite(Marker, new Vector2(100, 100), new Vector2(47, 47), new Vector2(0, 0));
            sprTownMarker[5] = new clsSprite(Marker, new Vector2(100, 100), new Vector2(47, 47), new Vector2(0, 0));
            sprTownMarker[6] = new clsSprite(Well, new Vector2(100, 100), new Vector2(49, 53), new Vector2(0, 0));
            sprTownMarker[7] = new clsSprite(Marker, new Vector2(100, 100), new Vector2(47, 47), new Vector2(0, 0));
            sprTownMarker[8] = new clsSprite(Table, new Vector2(100, 100), new Vector2(55, 28), new Vector2(0, 0));


            sprNPC[0] = new clsSprite(NPC, new Vector2(100,100), new Vector2(32,48), new Vector2(0,0));
            sprNPC[1] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(1, 0));
            sprNPC[2] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(2, 0));
            sprNPC[3] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(3, 0));
            sprNPC[4] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(0, 1));
            sprNPC[5] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(1, 1));
            sprNPC[6] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(2, 1));
            sprNPC[7] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(3, 1));
            sprNPC[8] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(0, 2));
            sprNPC[9] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(1, 2));
            sprNPC[10] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(2, 2));
            sprNPC[11] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(3, 2));
            sprNPC[12] = new clsSprite(NPC, new Vector2(100, 100), new Vector2(32, 48), new Vector2(0, 3));

            sprBarrier[0] = new clsSprite(Blk[0], new Vector2(100, 100), new Vector2(115, 56), new Vector2(0, 0));
            sprBarrier[1] = new clsSprite(Blk[0], new Vector2(100, 100), new Vector2(115, 56), new Vector2(0, 0));

            for(int i = 0; i<sprBlocked.Length; i++)
            sprBlocked[i] = new clsSprite(Blk[2], new Vector2(100, 100), new Vector2(400, 600), new Vector2(0, 0));

              for(int i = 0; i<sprRockBlock.Length; i++)
            sprRockBlock[i] = new clsSprite(Blk[6], new Vector2(100, 100), new Vector2(49, 40), new Vector2(0, 0));

            sprBacteria[0] = new clsSprite(Bacteria, new Vector2(10,10),new Vector2(64,64),new Vector2(2f,1f), new Vector2(0,0));
            sprBacteria[1] = new clsSprite(Bacteria, new Vector2(50,40),new Vector2(64,64),new Vector2(1f,2f), new Vector2(1,0));
            sprBacteria[2] = new clsSprite(Bacteria, new Vector2(200, 200), new Vector2(64, 64), new Vector2(4f, 1f), new Vector2(2, 0));
            sprBacteria[3] = new clsSprite(Bacteria, new Vector2(600, 100), new Vector2(64, 64), new Vector2(2f, 2f), new Vector2(0, 0));
            sprBacteria[4] = new clsSprite(Bacteria, new Vector2(10, 400), new Vector2(64, 64), new Vector2(2f, -3f), new Vector2(1, 0));
            sprBacteria[5] = new clsSprite(Bacteria, new Vector2(700, 10), new Vector2(64, 64), new Vector2(1f, 2f), new Vector2(2, 0));
            sprBacteria[6] = new clsSprite(Bacteria, new Vector2(80, 500), new Vector2(64, 64), new Vector2(-2f, 1f), new Vector2(0, 0));
            sprBacteria[7] = new clsSprite(Bacteria, new Vector2(400, 400), new Vector2(64, 64), new Vector2(1f, 4f), new Vector2(1, 0));
            sprBacteria[8] = new clsSprite(Bacteria, new Vector2(700, 500), new Vector2(64, 64), new Vector2(3f, 3f), new Vector2(2, 0));
            sprBacteria[9] = new clsSprite(Bacteria, new Vector2(720, 40), new Vector2(64, 64), new Vector2(1f, 1f), new Vector2(0, 0));
            sprBacteria[10] = new clsSprite(Bacteria, new Vector2(30, 80), new Vector2(64, 64), new Vector2(-1f, 1f), new Vector2(1, 0));
            sprBacteria[11] = new clsSprite(Bacteria, new Vector2(500, 500), new Vector2(64, 64), new Vector2(-2f, -1f), new Vector2(2, 0));
            sprBacteria[12] = new clsSprite(Bacteria, new Vector2(20, 70), new Vector2(64, 64), new Vector2(-2f, -2f), new Vector2(0, 0));
            sprBacteria[13] = new clsSprite(Bacteria, new Vector2(90, 90), new Vector2(64, 64), new Vector2(3f, -2f), new Vector2(1, 0));
            sprBacteria[14] = new clsSprite(Bacteria, new Vector2(30, 500), new Vector2(64, 64), new Vector2(1f, 1f), new Vector2(2, 0));

                

            sprARC_Body[0] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));       
            sprARC_Head[0] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[1] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[1] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[2] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[2] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[3] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[3] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[4] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[4] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[5] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[5] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[6] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[6] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[7] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[7] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[8] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[8] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));
            sprARC_Body[9] = new clsSprite(ARCBuildings[0], new Vector2(300, 300), new Vector2(56, 28), new Vector2(0, 0));
            sprARC_Head[9] = new clsSprite(ARCBuildings[1], new Vector2(0, 0), new Vector2(67, 39), new Vector2(0, 0));

            sprARC_Body[10] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[10] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[11] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[11] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[12] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[12] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[13] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[13] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[14] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[14] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[15] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[15] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[16] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[16] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[17] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[17] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[18] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[18] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));
            sprARC_Body[19] = new clsSprite(ARCBuildings[2], new Vector2(0, 0), new Vector2(108, 56), new Vector2(0, 0));
            sprARC_Head[19] = new clsSprite(ARCBuildings[3], new Vector2(300, 300), new Vector2(134, 87), new Vector2(0, 0));




            sprTree_Body[0] = new clsSprite(ARCTrees[0], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[0] = new clsSprite(ARCTrees[1], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[1] = new clsSprite(ARCTrees[2], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[1] = new clsSprite(ARCTrees[3], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[2] = new clsSprite(ARCTrees[0], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[2] = new clsSprite(ARCTrees[1], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[3] = new clsSprite(ARCTrees[2], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[3] = new clsSprite(ARCTrees[3], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[4] = new clsSprite(ARCTrees[0], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[4] = new clsSprite(ARCTrees[1], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[5] = new clsSprite(ARCTrees[2], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[5] = new clsSprite(ARCTrees[3], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[6] = new clsSprite(ARCTrees[0], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[6] = new clsSprite(ARCTrees[1], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[7] = new clsSprite(ARCTrees[2], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[7] = new clsSprite(ARCTrees[3], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[8] = new clsSprite(ARCTrees[0], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[8] = new clsSprite(ARCTrees[1], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
            sprTree_Body[9] = new clsSprite(ARCTrees[2], new Vector2(200, 500), new Vector2(18, 36), new Vector2(0, 0));
            sprTree_Head[9] = new clsSprite(ARCTrees[3], new Vector2(0, 0), new Vector2(115, 109), new Vector2(0, 0));
        }

        public void Unload()
        {
            sprPlayer.texture.Dispose();
            sprBackground.texture.Dispose();

          
                NPC.Dispose();
            for (int i = 0; i < ARCBuildings.Length; i++)
                ARCBuildings[i].Dispose();
            for (int i = 0; i < ARCTrees.Length; i++)
                ARCTrees[i].Dispose();
            for (int i = 0; i < PIETower.Length; i++)
                PIETower[i].Dispose();
           /*for (int i = 0; i < Blk.Length; i++)
                Blk[i].Dispose();*/


        }
    }
}
