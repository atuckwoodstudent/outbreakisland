#region Using Statements
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
#endregion

namespace IsometricGame
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        clsSpriteBank Sprites;
        clsNPC npcCollider;
        clsNPCBank NPC;
        clsArchitecture ArcCollider;
        clsArchitectureBank Environmentals;
        clsBlocking blkCollider;
        clsBlockingBank Blocks;
        clsChatBoxBank TextMenus;
        
        clsPlayer Player;
        clsBackground Background;

   
        clsHUDBank Hud;

        clsController Controller;
        clsKeyboard KBoard;

        SpriteBatch spriteBatch;

        Vector2 Mover, Animate;
        
        AudioEngine audioEngine;
        WaveBank waveBank;
        SoundBank soundBank;
        
        bool MenuButtonState;
        
        TimeSpan tmrAnimator;

        string Text;
        int PlayerAnimate, Number;
        
        SpriteFont RadioFont;
 
        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            audioEngine = new AudioEngine(@"Content\MySounds.xgs");
            waveBank = new WaveBank(audioEngine, @"Content\Wave Bank.xwb");
            soundBank = new SoundBank(audioEngine, @"Content\Sound Bank.xsb");
            tmrAnimator = TimeSpan.Zero;
            Controller = new clsController();
            KBoard = new clsKeyboard();
            Components.Add(new GamerServicesComponent(this));
            base.Initialize();          
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            RadioFont = Content.Load<SpriteFont>("RadioBox");
            Sprites = new clsSpriteBank(Content);

            TextMenus = new clsChatBoxBank(ref Sprites, ref RadioFont);
            NPC = new clsNPCBank(Content, ref Sprites);
            Environmentals = new clsArchitectureBank(Content, ref Sprites);
            Blocks = new clsBlockingBank(Content, ref Sprites);

            Hud = new clsHUDBank(ref Sprites, ref RadioFont);
            Player = new clsPlayer(Sprites.sprPlayer, 5, 15);
            Background = new clsBackground(Sprites.sprBackground);

            soundBank.PlayCue("Music");
        }
    
        protected override void UnloadContent()
        {
         Sprites.Unload();
         spriteBatch.Dispose();
        }

        public void GetHUDInput()
        {
            if (!Controller.A && !Controller.UP && !Controller.DOWN && !Controller.LEFT && !Controller.RIGHT && !KBoard.ACCESS && !KBoard.BACK && !KBoard.UP && !KBoard.DOWN && !KBoard.LEFT && !KBoard.RIGHT && !KBoard.START)
                    MenuButtonState = true;

            if (Hud.ShowAHud() || Hud.ShowDataBank())
            {
                if (MenuButtonState && Controller.A || MenuButtonState && KBoard.ACCESS || MenuButtonState && KBoard.START)
                { 
                   
                    Hud.GetSelected(ref TextMenus,ref MenuButtonState, ref Player, ref Environmentals, ref Blocks, ref NPC, ref Background);
                    if (Hud.GetQuit()) this.Exit();
                    MenuButtonState = false;
                }
            }

            if (MenuButtonState && Controller.DOWN || MenuButtonState && KBoard.DOWN)
            {
                Hud.DownOne();

                MenuButtonState = false;
            }

            if (MenuButtonState && Controller.UP || MenuButtonState && KBoard.UP)
            {
                Hud.UpOne();
                MenuButtonState = false;
            }

            if (MenuButtonState && Controller.LEFT || MenuButtonState && KBoard.LEFT)
            {
                Hud.LeftOne();
                MenuButtonState = false;
            }


            if (MenuButtonState && Controller.RIGHT || MenuButtonState && KBoard.RIGHT)
            {
                Hud.RightOne();
                MenuButtonState = false;
            }


            if (Background.GetMap() != -1)
            {
                if (Controller.START && MenuButtonState || KBoard.START && MenuButtonState)
                {
                    Hud.StartMenu.Show();
                    Hud.DataBank.Hide();
                    MenuButtonState = false;
                }
            }

            if (!Hud.ShowAHud())
            {
                if (TextMenus.Chatbox.GetActive())
                {
                    if (Controller.B || KBoard.BACK)
                        TextMenus.Chatbox.Closed(); ;
                }

                if (TextMenus.DataPopup.GetActive())
                {
                    if (Controller.B || KBoard.BACK)
                    {
                        TextMenus.DataPopup.Closed();
                    }
                }


                if (Controller.RT != 0 || KBoard.RIGHTBAR)
                {
                    Hud.DataBank.Show();
                    TextMenus.Databank.Open();
                }

                if (Controller.LT != 0 || KBoard.LEFTBAR)
                    TextMenus.RadioMessage.Open();
                if(Controller.LT == 0 && !KBoard.LEFTBAR)
                    TextMenus.RadioMessage.Closed();

                if (TextMenus.Letter.GetActive())
                {
                    Hud.DataBank.Hide();
                    if (Controller.B || KBoard.BACK)
                    {
                        TextMenus.Letter.Closed();
                        if (Player.GetQuest() < 0)
                        {
                            Player.StartQuest(0);
                            TextMenus.Collectables.Open();
                        }
                    }
                }
            }

            if(Controller.RT == 0 && !KBoard.RIGHTBAR)
            {
                Hud.DataBank.Hide();
                TextMenus.Databank.Closed();
            }

            
            if(!KBoard.RIGHT)
            { Mover.X = 0;}
            if(!KBoard.UP)
            {Mover.Y = 0;}
            if(!KBoard.DOWN)
            { Mover.Y = 0;}
            if(!KBoard.LEFT)
            {Mover.X = 0;}


            if(KBoard.RIGHT)
            { Mover.X = 1;}
            if(KBoard.UP)
            {Mover.Y = 1;}
            if(KBoard.DOWN)
            { Mover.Y = -1;}
            if(KBoard.LEFT)
            {Mover.X = -1;}


            Animate = new Vector2(Mover.X, Mover.Y);
            Animate = new Vector2(Animate.X + Controller.LSX, Animate.Y + Controller.LSY);

        }

        public void ProcessInput()
        {
            if (Player.GetQuest() == 0)
            {
                TextMenus.Collectables.SetText(Player.GetCollected() + "/3 Tower Pieces");
            }

            else if (Player.GetQuest() == 3)
            {
                TextMenus.Collectables.SetText(Player.GetCollected() + "/15 Bacteria Killed");
            }
          
            if (Background.GetMap()!=-1&&!Hud.ShowAHud() && !Hud.ShowDataBank() && !TextMenus.DataPopup.GetActive())
            {
                if (Animate.X == 0 && Animate.Y == 0)
                { Player.Sprite.frame = new Vector2(0, 0); Mover.X = 0; Mover.Y = 0; PlayerAnimate = 0; }
                else if (Animate.X > 0 && Animate.Y == 0)
                { Mover.X = 2f; Mover.Y = 0; PlayerAnimate = 1; }
                else if (Animate.X < 0 && Animate.Y == 0)
                { Mover.X = -2f; Mover.Y = 0; PlayerAnimate = 1; Player.FlipPlayer(true); }
                else if (Animate.X == 0 && Animate.Y > 0)
                { Mover.X = 0; Mover.Y = -2; PlayerAnimate = 2; }
                else if (Animate.X == 0 && Animate.Y < 0)
                { Mover.X = 0; Mover.Y = 2f; PlayerAnimate = 3; }

                else if (Animate.X > 0 && Animate.Y > 0)
                { Mover.X = 2f; Mover.Y = -1; PlayerAnimate = 4; }
                else if (Animate.X < 0 && Animate.Y < 0)
                { Mover.X = -2f; Mover.Y = 1; PlayerAnimate = 5; }
                else if (Animate.X > 0 && Animate.Y < 0)
                { Mover.X = 2f; Mover.Y = 1; PlayerAnimate = 5; Player.FlipPlayer(true); }
                else if (Animate.X < 0 && Animate.Y > 0)
                { Mover.X = -2f; Mover.Y = -1; PlayerAnimate = 4; Player.FlipPlayer(true); }


                if (Background.GetMap() == 20)
                {
                    PlayerAnimate = 0;
                    Player.Sprite.frame = new Vector2(1, 0);
                }

                Player.Sprite.Move();
            }
            else PlayerAnimate = 0;
        }

        public void ProcessCollisions()
        {
           TextMenus.A.Closed();


           if (NPC.Collisions(Player, Background.GetMap(), ref npcCollider, ref Hud, ref TextMenus.Databank, ref Number, ref Text))
            {
                Player.Sprite.velocity = new Vector2(0, 0);

                if (Controller.A || KBoard.ACCESS)
                {
                    TextMenus.Chatbox.SetText(npcCollider.Text);
                    TextMenus.Chatbox.SetName(npcCollider.Name);
                    TextMenus.Chatbox.Open();
                    if (!npcCollider.Sprite.Collided)
                    {
                        Player.ManipulateScore(10); npcCollider.Sprite.Collided = true;
                        Hud.DataBank.SetText(Number, Text);
                        TextMenus.Databank.ShowIndicator();
                    }
                }
                
               if (!Controller.A && !TextMenus.Chatbox.ShowConvo && !KBoard.ACCESS)
                {
                    TextMenus.A.Open();
                }
       }

            if (Environmentals.Collisions(ref Hud, ref TextMenus, ref Player, Background.GetMap(), ref ArcCollider, ref Blocks, ref NPC, ref Controller, ref KBoard))
                Player.Sprite.velocity = new Vector2(0, 0);
            
            if (Blocks.Collisions(ref Player, ref Hud, Background.GetMap(), ref blkCollider, ref TextMenus, ref Background))
                Player.Sprite.velocity = new Vector2(0, 0);
        }
        
        protected override void Update(GameTime gameTime)
        {
            tmrAnimator += gameTime.ElapsedGameTime;

            TextMenus.A.OpenSprite.position = new Vector2(Player.Sprite.position.X - 25, Player.Sprite.position.Y + 40);

            Player.FlipPlayer(false);
            TextMenus.PlayerScore.SetText("Resources: " + Player.GetScore());

            Controller.Update();
            KBoard.Update();

            GetHUDInput();
            
            ProcessInput();

            if (PlayerAnimate > 0)
                Player.Animate(ref tmrAnimator, PlayerAnimate);
            
            Player.Sprite.velocity = Mover;
            
            ProcessCollisions();
            Background.SwitchMap(ref Player);
                 
            base.Update(gameTime);
        }


        public void DrawUnderPlayer() 
        {
            Background.Draw(spriteBatch);
        }

        public void DrawOverPlayer()
        {
            if (Background.GetMap() != -1)
            {
                Environmentals.Draw(spriteBatch, Background.GetMap());
                Blocks.Draw(spriteBatch, Background.GetMap());
                NPC.Draw(spriteBatch);
            }
        }

        public void DrawHUD()
        {
            if (!Hud.ShowAHud())
            {
                if (Background.GetMap() != -1)
                {
                    if (Player.GetQuest() != 4)
                    {
                        TextMenus.Letter.Draw(spriteBatch);
                     
                        if (!TextMenus.Letter.GetActive())
                        {
                             TextMenus.DrawHUD(spriteBatch);
                        }
                    }
                    
                        if (!TextMenus.Letter.GetActive())
                        {
                            TextMenus.DrawPlayer(spriteBatch);
                        }

                   
                }
            }
            Hud.Draw(spriteBatch);
        }

        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteBlendMode.AlphaBlend);
          
            DrawUnderPlayer();
          
            if(Background.GetMap()!=-1)
            {
                Player.Draw(spriteBatch);
                DrawOverPlayer();  
            }

           DrawHUD();

           spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}


