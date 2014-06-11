// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class StartScreenUI
    {
        ImageBox Title_1;
        ImageBox ScreenVignette;
       
        
        ImageBox btnNewgame;
        ImageBox btnQuit;
        

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
           
			
			Title_1 = new ImageBox();
            Title_1.Name = "Title_1";
                  
            ScreenVignette = new ImageBox();
            ScreenVignette.Name = "ScreenVignette";
            
            btnNewgame = new ImageBox();
            btnNewgame.Name = "btnNewgame";
            btnQuit = new ImageBox();
            btnQuit.Name = "btnQuit";
            

            // Title_1
            Title_1.Image = new ImageAsset("assets/StartScreen/magnate-title2.png");

            // Arrow_2
           

            // ScreenVignette
            ScreenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");

            // Tutbox
           

            // Label_1
           
            // btnNewgame
            btnNewgame.Image = new ImageAsset("assets/StartScreen/newgame.png");

            // btnQuit
            btnQuit.Image = new ImageAsset("assets/StartScreen/quit.png");

            // Button_2
           
            // Button_1
           
            // Scene
            this.RootWidget.AddChildLast(Title_1);
           
            this.RootWidget.AddChildLast(ScreenVignette);
            
            this.RootWidget.AddChildLast(btnNewgame);
            this.RootWidget.AddChildLast(btnQuit);
            
            this.Showing += new EventHandler(onShowing);
            this.Shown += new EventHandler(onShown);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
            case LayoutOrientation.Vertical:
                this.DesignWidth = 480;
                this.DesignHeight = 854;

                Title_1.SetPosition(529, 94);
                Title_1.SetSize(200, 200);
                Title_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Title_1.Visible = true;

                

                ScreenVignette.SetPosition(0, 0);
                ScreenVignette.SetSize(200, 200);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;

               

                btnNewgame.SetPosition(685, 279);
                btnNewgame.SetSize(200, 200);
                btnNewgame.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnNewgame.Visible = true;

                btnQuit.SetPosition(685, 279);
                btnQuit.SetSize(200, 200);
                btnQuit.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnQuit.Visible = true;

               

                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

                Title_1.SetPosition(131, 9);
                Title_1.SetSize(593, 181);
                Title_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Width;
                Title_1.Visible = true;

               

                ScreenVignette.SetPosition(0, 0);
                ScreenVignette.SetSize(856, 479);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;

                

                btnNewgame.SetPosition(661, 326);
                btnNewgame.SetSize(192, 69);
                btnNewgame.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnNewgame.Visible = true;

                btnQuit.SetPosition(660, 411);
                btnQuit.SetSize(192, 66);
                btnQuit.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnQuit.Visible = true;

                

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            
            this.Title = "Worldmap";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    Title_1.Visible = false;
                  
                    btnNewgame.Visible = false;
                    btnQuit.Visible = false;
                }
                break;

                default:
                {
                    Title_1.Visible = false;
                 
                    btnNewgame.Visible = false;
                    btnQuit.Visible = false;
                }
                break;
            }
        }
        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    new SlideInEffect()
                    {
                        Widget = Title_1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                 
                    new SlideInEffect()
                    {
                        Widget = btnNewgame,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnQuit,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                }
                break;

                default:
                {
                    new SlideInEffect()
                    {
                        Widget = Title_1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                 
                    new SlideInEffect()
                    {
                        Widget = btnNewgame,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnQuit,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                }
                break;
            }
        }
    }
}
