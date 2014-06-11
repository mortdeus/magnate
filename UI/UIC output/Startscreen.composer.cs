// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class Startscreen
    {
        ImageBox ScreenVignette;
        ImageBox btnNewgame;
        ImageBox btnQuit;
        Button Button_2;
        Button Button_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ScreenVignette = new ImageBox();
            ScreenVignette.Name = "ScreenVignette";
            btnNewgame = new ImageBox();
            btnNewgame.Name = "btnNewgame";
            btnQuit = new ImageBox();
            btnQuit.Name = "btnQuit";
            Button_2 = new Button();
            Button_2.Name = "Button_2";
            Button_1 = new Button();
            Button_1.Name = "Button_1";

            // ScreenVignette
            ScreenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");

            // btnNewgame
            btnNewgame.Image = new ImageAsset("assets/StartScreen/newgame.png");

            // btnQuit
            btnQuit.Image = new ImageAsset("assets/StartScreen/quit.png");

            // Button_2
            Button_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_2.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            Button_2.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            Button_1.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Scene
            this.RootWidget.AddChildLast(ScreenVignette);
            this.RootWidget.AddChildLast(btnNewgame);
            this.RootWidget.AddChildLast(btnQuit);
            this.RootWidget.AddChildLast(Button_2);
            this.RootWidget.AddChildLast(Button_1);
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

                Button_2.SetPosition(200, 308);
                Button_2.SetSize(214, 56);
                Button_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Button_2.Visible = true;

                Button_1.SetPosition(414, 309);
                Button_1.SetSize(214, 56);
                Button_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Button_1.Visible = true;

                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

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

                Button_2.SetPosition(202, 248);
                Button_2.SetSize(214, 56);
                Button_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Button_2.Visible = false;

                Button_1.SetPosition(440, 247);
                Button_1.SetSize(214, 56);
                Button_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Button_1.Visible = false;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            Button_2.Text = "No";
            Button_1.Text = "Yes";
            this.Title = "Worldmap";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    btnNewgame.Visible = false;
                    btnQuit.Visible = false;
                }
                break;

                default:
                {
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
