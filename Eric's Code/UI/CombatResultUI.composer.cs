// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class CombatResultUI
    {
        ImageBox charbox;
        ImageBox resultbox;
        ImageBox background;
        ImageBox btn_continue;
        ImageBox char1body;
        ImageBox char2body;
        ImageBox enemy1body;
        ImageBox enemy2body;
        ImageBox enemy3body;
        ImageBox char1overlay;
        ImageBox char2overlay;
        ImageBox enemy1overlay;
        ImageBox enemy2overlay;
        ImageBox enemy3overlay;
        ImageBox char1cross;
        ImageBox char2cross;
        ImageBox enemy1cross;
        ImageBox enemy2cross;
        ImageBox enemy3cross;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            charbox = new ImageBox();
            charbox.Name = "charbox";
            resultbox = new ImageBox();
            resultbox.Name = "resultbox";
            background = new ImageBox();
            background.Name = "background";
            btn_continue = new ImageBox();
            btn_continue.Name = "btn_continue";
            char1body = new ImageBox();
            char1body.Name = "char1body";
            char2body = new ImageBox();
            char2body.Name = "char2body";
            enemy1body = new ImageBox();
            enemy1body.Name = "enemy1body";
            enemy2body = new ImageBox();
            enemy2body.Name = "enemy2body";
            enemy3body = new ImageBox();
            enemy3body.Name = "enemy3body";
            char1overlay = new ImageBox();
            char1overlay.Name = "char1overlay";
            char2overlay = new ImageBox();
            char2overlay.Name = "char2overlay";
            enemy1overlay = new ImageBox();
            enemy1overlay.Name = "enemy1overlay";
            enemy2overlay = new ImageBox();
            enemy2overlay.Name = "enemy2overlay";
            enemy3overlay = new ImageBox();
            enemy3overlay.Name = "enemy3overlay";
            char1cross = new ImageBox();
            char1cross.Name = "char1cross";
            char2cross = new ImageBox();
            char2cross.Name = "char2cross";
            enemy1cross = new ImageBox();
            enemy1cross.Name = "enemy1cross";
            enemy2cross = new ImageBox();
            enemy2cross.Name = "enemy2cross";
            enemy3cross = new ImageBox();
            enemy3cross.Name = "enemy3cross";

            // charbox
            charbox.Image = new ImageAsset("assets/Combat UI/CombatResults_BordersXP.png");

            // resultbox
            resultbox.Image = new ImageAsset("assets/Combat UI/CombatResults_MainMenu.png");

            // background
            background.Image = new ImageAsset("assets/Combat UI/Combat_BorderBG.png");

            // btn_continue
            btn_continue.Image = new ImageAsset("assets/GUI/Button_ContinueOn.png");

            // char1body

            // char2body

            // enemy1body

            // enemy2body

            // enemy3body

            // char1overlay
            char1overlay.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedOverlay.png");

            // char2overlay
            char2overlay.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedOverlay.png");

            // enemy1overlay
            enemy1overlay.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedOverlay.png");

            // enemy2overlay
            enemy2overlay.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedOverlay.png");

            // enemy3overlay
            enemy3overlay.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedOverlay.png");

            // char1cross
            char1cross.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedX.png");

            // char2cross
            char2cross.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedX.png");

            // enemy1cross
            enemy1cross.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedX.png");

            // enemy2cross
            enemy2cross.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedX.png");

            // enemy3cross
            enemy3cross.Image = new ImageAsset("assets/Combat UI/CombatResults_DefeatedX.png");

            // Scene
            this.RootWidget.AddChildLast(charbox);
            this.RootWidget.AddChildLast(resultbox);
            this.RootWidget.AddChildLast(background);
            this.RootWidget.AddChildLast(btn_continue);
            this.RootWidget.AddChildLast(char1body);
            this.RootWidget.AddChildLast(char2body);
            this.RootWidget.AddChildLast(enemy1body);
            this.RootWidget.AddChildLast(enemy2body);
            this.RootWidget.AddChildLast(enemy3body);
            this.RootWidget.AddChildLast(char1overlay);
            this.RootWidget.AddChildLast(char2overlay);
            this.RootWidget.AddChildLast(enemy1overlay);
            this.RootWidget.AddChildLast(enemy2overlay);
            this.RootWidget.AddChildLast(enemy3overlay);
            this.RootWidget.AddChildLast(char1cross);
            this.RootWidget.AddChildLast(char2cross);
            this.RootWidget.AddChildLast(enemy1cross);
            this.RootWidget.AddChildLast(enemy2cross);
            this.RootWidget.AddChildLast(enemy3cross);

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

                charbox.SetPosition(-41, 88);
                charbox.SetSize(200, 200);
                charbox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                charbox.Visible = true;

                resultbox.SetPosition(423, 194);
                resultbox.SetSize(200, 200);
                resultbox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                resultbox.Visible = true;

                background.SetPosition(222, 159);
                background.SetSize(200, 200);
                background.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                background.Visible = true;

                btn_continue.SetPosition(355, 308);
                btn_continue.SetSize(200, 200);
                btn_continue.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btn_continue.Visible = true;

                char1body.SetPosition(200, 77);
                char1body.SetSize(200, 200);
                char1body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char1body.Visible = true;

                char2body.SetPosition(200, 77);
                char2body.SetSize(200, 200);
                char2body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char2body.Visible = true;

                enemy1body.SetPosition(200, 77);
                enemy1body.SetSize(200, 200);
                enemy1body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1body.Visible = true;

                enemy2body.SetPosition(200, 77);
                enemy2body.SetSize(200, 200);
                enemy2body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2body.Visible = true;

                enemy3body.SetPosition(200, 77);
                enemy3body.SetSize(200, 200);
                enemy3body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3body.Visible = true;

                char1overlay.SetPosition(341, 204);
                char1overlay.SetSize(200, 200);
                char1overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char1overlay.Visible = true;

                char2overlay.SetPosition(341, 204);
                char2overlay.SetSize(200, 200);
                char2overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char2overlay.Visible = true;

                enemy1overlay.SetPosition(341, 204);
                enemy1overlay.SetSize(200, 200);
                enemy1overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1overlay.Visible = true;

                enemy2overlay.SetPosition(341, 204);
                enemy2overlay.SetSize(200, 200);
                enemy2overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2overlay.Visible = true;

                enemy3overlay.SetPosition(341, 204);
                enemy3overlay.SetSize(200, 200);
                enemy3overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3overlay.Visible = true;

                char1cross.SetPosition(300, 332);
                char1cross.SetSize(200, 200);
                char1cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char1cross.Visible = true;

                char2cross.SetPosition(300, 332);
                char2cross.SetSize(200, 200);
                char2cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char2cross.Visible = true;

                enemy1cross.SetPosition(300, 332);
                enemy1cross.SetSize(200, 200);
                enemy1cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1cross.Visible = true;

                enemy2cross.SetPosition(300, 332);
                enemy2cross.SetSize(200, 200);
                enemy2cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2cross.Visible = true;

                enemy3cross.SetPosition(300, 332);
                enemy3cross.SetSize(200, 200);
                enemy3cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3cross.Visible = true;

                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

                charbox.SetPosition(140, 52);
                charbox.SetSize(505, 256);
                charbox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                charbox.Visible = true;

                resultbox.SetPosition(103, 45);
                resultbox.SetSize(575, 311);
                resultbox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                resultbox.Visible = true;

                background.SetPosition(0, 0);
                background.SetSize(854, 480);
                background.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                background.Visible = true;

                btn_continue.SetPosition(357, 312);
                btn_continue.SetSize(73, 25);
                btn_continue.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btn_continue.Visible = true;

                char1body.SetPosition(147, 128);
                char1body.SetSize(66, 167);
                char1body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char1body.Visible = false;

                char2body.SetPosition(222, 128);
                char2body.SetSize(66, 167);
                char2body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char2body.Visible = false;

                enemy1body.SetPosition(422, 128);
                enemy1body.SetSize(66, 167);
                enemy1body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1body.Visible = false;

                enemy2body.SetPosition(497, 128);
                enemy2body.SetSize(66, 167);
                enemy2body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2body.Visible = false;

                enemy3body.SetPosition(572, 128);
                enemy3body.SetSize(66, 167);
                enemy3body.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3body.Visible = false;

                char1overlay.SetPosition(147, 128);
                char1overlay.SetSize(66, 167);
                char1overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char1overlay.Visible = false;

                char2overlay.SetPosition(222, 128);
                char2overlay.SetSize(66, 167);
                char2overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char2overlay.Visible = false;

                enemy1overlay.SetPosition(422, 128);
                enemy1overlay.SetSize(66, 167);
                enemy1overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1overlay.Visible = false;

                enemy2overlay.SetPosition(497, 128);
                enemy2overlay.SetSize(66, 167);
                enemy2overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2overlay.Visible = false;

                enemy3overlay.SetPosition(572, 128);
                enemy3overlay.SetSize(66, 167);
                enemy3overlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3overlay.Visible = false;

                char1cross.SetPosition(151, 179);
                char1cross.SetSize(57, 61);
                char1cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char1cross.Visible = false;

                char2cross.SetPosition(226, 179);
                char2cross.SetSize(57, 61);
                char2cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                char2cross.Visible = false;

                enemy1cross.SetPosition(426, 179);
                enemy1cross.SetSize(57, 61);
                enemy1cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1cross.Visible = false;

                enemy2cross.SetPosition(501, 179);
                enemy2cross.SetSize(57, 61);
                enemy2cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2cross.Visible = false;

                enemy3cross.SetPosition(575, 179);
                enemy3cross.SetSize(57, 61);
                enemy3cross.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3cross.Visible = false;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                }
                break;

                default:
                {
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
                }
                break;

                default:
                {
                }
                break;
            }
        }
    }
}
