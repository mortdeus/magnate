// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class MainGUI
    {
        ImageBox DialogueBox;
        ImageBox LeftMenuBox;
        ImageBox BuildingsTabUnfocus;
        ImageBox BuildingsTabFocus;
        ImageBox OfficersTabFocus;
        ImageBox OfficersTabUnfocus;
        ImageBox MiniMap;
        ImageBox BottomMenuBar;
        ImageBox OfficersTabTop;
        ImageBox BuildingsTabTop;
        ImageBox EventBox_1;
        ImageBox EventBox_2;
        ImageBox EventBox_3;
        ImageBox EventBox_4;
        ImageBox EventBox_5;
        ImageBox EventBox_6;
        ImageBox EventBox_7;
        ImageBox EventBox_8;
        ImageBox BottomMenuExtra;
        ImageBox BlackSmith;
        ImageBox AidenPortrait;
        ImageBox KiraPortrait;
        ImageBox CharacterOutline_1;
        ImageBox CharacterOutline_2;
        ImageBox WorldMap;
        ImageBox OptionsBox;
        ImageBox BottomMenuButton_1;
        ImageBox BottomMenuButton_2;
        ImageBox CloseGUI;
        ImageBox ScreenVignette;
        Button CreditsButton;
        Button ArtButton;
        Button QUITDEMO;
        Button ExtraButton;
        Button Close;
        Button SFX;
        Button Music;
        Button Button_1;
        Slider Volume;
        ImageBox btnOfficersTab;
        ImageBox btnBuildingsTab;
        ImageBox ArrowRight;
        ImageBox MoneyIcon;
        ImageBox CandleIcon;
        ImageBox ArmorIcon;
        ImageBox WatchIcon;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            DialogueBox = new ImageBox();
            DialogueBox.Name = "DialogueBox";
            LeftMenuBox = new ImageBox();
            LeftMenuBox.Name = "LeftMenuBox";
            BuildingsTabUnfocus = new ImageBox();
            BuildingsTabUnfocus.Name = "BuildingsTabUnfocus";
            BuildingsTabFocus = new ImageBox();
            BuildingsTabFocus.Name = "BuildingsTabFocus";
            OfficersTabFocus = new ImageBox();
            OfficersTabFocus.Name = "OfficersTabFocus";
            OfficersTabUnfocus = new ImageBox();
            OfficersTabUnfocus.Name = "OfficersTabUnfocus";
            MiniMap = new ImageBox();
            MiniMap.Name = "MiniMap";
            BottomMenuBar = new ImageBox();
            BottomMenuBar.Name = "BottomMenuBar";
            OfficersTabTop = new ImageBox();
            OfficersTabTop.Name = "OfficersTabTop";
            BuildingsTabTop = new ImageBox();
            BuildingsTabTop.Name = "BuildingsTabTop";
            EventBox_1 = new ImageBox();
            EventBox_1.Name = "EventBox_1";
            EventBox_2 = new ImageBox();
            EventBox_2.Name = "EventBox_2";
            EventBox_3 = new ImageBox();
            EventBox_3.Name = "EventBox_3";
            EventBox_4 = new ImageBox();
            EventBox_4.Name = "EventBox_4";
            EventBox_5 = new ImageBox();
            EventBox_5.Name = "EventBox_5";
            EventBox_6 = new ImageBox();
            EventBox_6.Name = "EventBox_6";
            EventBox_7 = new ImageBox();
            EventBox_7.Name = "EventBox_7";
            EventBox_8 = new ImageBox();
            EventBox_8.Name = "EventBox_8";
            BottomMenuExtra = new ImageBox();
            BottomMenuExtra.Name = "BottomMenuExtra";
            BlackSmith = new ImageBox();
            BlackSmith.Name = "BlackSmith";
            AidenPortrait = new ImageBox();
            AidenPortrait.Name = "AidenPortrait";
            KiraPortrait = new ImageBox();
            KiraPortrait.Name = "KiraPortrait";
            CharacterOutline_1 = new ImageBox();
            CharacterOutline_1.Name = "CharacterOutline_1";
            CharacterOutline_2 = new ImageBox();
            CharacterOutline_2.Name = "CharacterOutline_2";
            WorldMap = new ImageBox();
            WorldMap.Name = "WorldMap";
            OptionsBox = new ImageBox();
            OptionsBox.Name = "OptionsBox";
            BottomMenuButton_1 = new ImageBox();
            BottomMenuButton_1.Name = "BottomMenuButton_1";
            BottomMenuButton_2 = new ImageBox();
            BottomMenuButton_2.Name = "BottomMenuButton_2";
            CloseGUI = new ImageBox();
            CloseGUI.Name = "CloseGUI";
            ScreenVignette = new ImageBox();
            ScreenVignette.Name = "ScreenVignette";
            CreditsButton = new Button();
            CreditsButton.Name = "CreditsButton";
            ArtButton = new Button();
            ArtButton.Name = "ArtButton";
            QUITDEMO = new Button();
            QUITDEMO.Name = "QUITDEMO";
            ExtraButton = new Button();
            ExtraButton.Name = "ExtraButton";
            Close = new Button();
            Close.Name = "Close";
            SFX = new Button();
            SFX.Name = "SFX";
            Music = new Button();
            Music.Name = "Music";
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Volume = new Slider();
            Volume.Name = "Volume";
            btnOfficersTab = new ImageBox();
            btnOfficersTab.Name = "btnOfficersTab";
            btnBuildingsTab = new ImageBox();
            btnBuildingsTab.Name = "btnBuildingsTab";
            ArrowRight = new ImageBox();
            ArrowRight.Name = "ArrowRight";
            MoneyIcon = new ImageBox();
            MoneyIcon.Name = "MoneyIcon";
            CandleIcon = new ImageBox();
            CandleIcon.Name = "CandleIcon";
            ArmorIcon = new ImageBox();
            ArmorIcon.Name = "ArmorIcon";
            WatchIcon = new ImageBox();
            WatchIcon.Name = "WatchIcon";

            // DialogueBox
            DialogueBox.Image = new ImageAsset("assets/GUI/Dialogue_Main.png");

            // LeftMenuBox
            LeftMenuBox.Image = new ImageAsset("assets/GUI/LeftMenu_Icon.png");

            // BuildingsTabUnfocus
            BuildingsTabUnfocus.Image = new ImageAsset("assets/GUI/MainTabs_BuildingsOff.png");

            // BuildingsTabFocus
            BuildingsTabFocus.Image = new ImageAsset("assets/GUI/MainTabs_BuildingsOn.png");

            // OfficersTabFocus
            OfficersTabFocus.Image = new ImageAsset("assets/GUI/MainTabs_OfficersOn.png");

            // OfficersTabUnfocus
            OfficersTabUnfocus.Image = new ImageAsset("assets/GUI/MainTabs_OfficersOff.png");

            // MiniMap
            MiniMap.Image = new ImageAsset("assets/GUI/MainMenu_Map.png");

            // BottomMenuBar
            BottomMenuBar.Image = new ImageAsset("assets/GUI/BottomMenu_Icons.png");

            // OfficersTabTop
            OfficersTabTop.Image = new ImageAsset("assets/GUI/MainTabs_Highlight.png");

            // BuildingsTabTop
            BuildingsTabTop.Image = new ImageAsset("assets/GUI/MainTabs_Highlight.png");

            // EventBox_1
            EventBox_1.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_2
            EventBox_2.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_3
            EventBox_3.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_4
            EventBox_4.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_5
            EventBox_5.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_6
            EventBox_6.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_7
            EventBox_7.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // EventBox_8
            EventBox_8.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // BottomMenuExtra
            BottomMenuExtra.Image = new ImageAsset("assets/GUI/BottomMenu_Extra.png");

            // BlackSmith
            BlackSmith.Image = new ImageAsset("assets/GUI/blacksmith1.png");

            // AidenPortrait
            AidenPortrait.Image = new ImageAsset("assets/GUI/Aidan.png");

            // KiraPortrait
            KiraPortrait.Image = new ImageAsset("assets/GUI/Kira.png");

            // CharacterOutline_1
            CharacterOutline_1.Image = new ImageAsset("assets/GUI/Left Character Outline.png");

            // CharacterOutline_2
            CharacterOutline_2.Image = new ImageAsset("assets/GUI/Character Outline.png");

            // WorldMap
            WorldMap.Image = new ImageAsset("assets/UI/ArrowRight.png");

            // OptionsBox
            OptionsBox.Image = new ImageAsset("assets/GUI/Options_MainMenu.png");

            // BottomMenuButton_1
            BottomMenuButton_1.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // BottomMenuButton_2
            BottomMenuButton_2.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // CloseGUI
            CloseGUI.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // ScreenVignette
            ScreenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");

            // CreditsButton
            CreditsButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            CreditsButton.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            CreditsButton.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // ArtButton
            ArtButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            ArtButton.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            ArtButton.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // QUITDEMO
            QUITDEMO.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            QUITDEMO.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            QUITDEMO.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // ExtraButton
            ExtraButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            ExtraButton.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            ExtraButton.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Close
            Close.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Close.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            Close.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // SFX
            SFX.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            SFX.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            SFX.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Music
            Music.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Music.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            Music.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new Font( FontAlias.System, 20, FontStyle.Regular);
            Button_1.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Volume
            Volume.MinValue = 0;
            Volume.MaxValue = 100;
            Volume.Value = 0;
            Volume.Step = 100;

            // btnOfficersTab
            btnOfficersTab.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // btnBuildingsTab
            btnBuildingsTab.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // ArrowRight
            ArrowRight.Image = new ImageAsset("assets/UI/Arrow.png");

            // MoneyIcon
            MoneyIcon.Image = new ImageAsset("assets/UI/mmicon_economy.png");

            // CandleIcon
            CandleIcon.Image = new ImageAsset("assets/UI/mmicon_espionage.png");

            // ArmorIcon
            ArmorIcon.Image = new ImageAsset("assets/UI/mmicon_military.png");

            // WatchIcon
            WatchIcon.Image = new ImageAsset("assets/UI/mmicon_questlog.png");

            // Scene
            this.RootWidget.AddChildLast(DialogueBox);
            this.RootWidget.AddChildLast(LeftMenuBox);
            this.RootWidget.AddChildLast(BuildingsTabUnfocus);
            this.RootWidget.AddChildLast(BuildingsTabFocus);
            this.RootWidget.AddChildLast(OfficersTabFocus);
            this.RootWidget.AddChildLast(OfficersTabUnfocus);
            this.RootWidget.AddChildLast(MiniMap);
            this.RootWidget.AddChildLast(BottomMenuBar);
            this.RootWidget.AddChildLast(OfficersTabTop);
            this.RootWidget.AddChildLast(BuildingsTabTop);
            this.RootWidget.AddChildLast(EventBox_1);
            this.RootWidget.AddChildLast(EventBox_2);
            this.RootWidget.AddChildLast(EventBox_3);
            this.RootWidget.AddChildLast(EventBox_4);
            this.RootWidget.AddChildLast(EventBox_5);
            this.RootWidget.AddChildLast(EventBox_6);
            this.RootWidget.AddChildLast(EventBox_7);
            this.RootWidget.AddChildLast(EventBox_8);
            this.RootWidget.AddChildLast(BottomMenuExtra);
            this.RootWidget.AddChildLast(BlackSmith);
            this.RootWidget.AddChildLast(AidenPortrait);
            this.RootWidget.AddChildLast(KiraPortrait);
            this.RootWidget.AddChildLast(CharacterOutline_1);
            this.RootWidget.AddChildLast(CharacterOutline_2);
            this.RootWidget.AddChildLast(WorldMap);
            this.RootWidget.AddChildLast(OptionsBox);
            this.RootWidget.AddChildLast(BottomMenuButton_1);
            this.RootWidget.AddChildLast(BottomMenuButton_2);
            this.RootWidget.AddChildLast(CloseGUI);
            this.RootWidget.AddChildLast(ScreenVignette);
            this.RootWidget.AddChildLast(CreditsButton);
            this.RootWidget.AddChildLast(ArtButton);
            this.RootWidget.AddChildLast(QUITDEMO);
            this.RootWidget.AddChildLast(ExtraButton);
            this.RootWidget.AddChildLast(Close);
            this.RootWidget.AddChildLast(SFX);
            this.RootWidget.AddChildLast(Music);
            this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(Volume);
            this.RootWidget.AddChildLast(btnOfficersTab);
            this.RootWidget.AddChildLast(btnBuildingsTab);
            this.RootWidget.AddChildLast(ArrowRight);
            this.RootWidget.AddChildLast(MoneyIcon);
            this.RootWidget.AddChildLast(CandleIcon);
            this.RootWidget.AddChildLast(ArmorIcon);
            this.RootWidget.AddChildLast(WatchIcon);
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
                this.DesignHeight = 855;

                DialogueBox.SetPosition(206, 92);
                DialogueBox.SetSize(200, 200);
                DialogueBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueBox.Visible = true;

                LeftMenuBox.SetPosition(0, 395);
                LeftMenuBox.SetSize(200, 200);
                LeftMenuBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LeftMenuBox.Visible = true;

                BuildingsTabUnfocus.SetPosition(166, 386);
                BuildingsTabUnfocus.SetSize(200, 200);
                BuildingsTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabUnfocus.Visible = true;

                BuildingsTabFocus.SetPosition(186, 395);
                BuildingsTabFocus.SetSize(200, 200);
                BuildingsTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabFocus.Visible = true;

                OfficersTabFocus.SetPosition(332, 384);
                OfficersTabFocus.SetSize(200, 200);
                OfficersTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabFocus.Visible = true;

                OfficersTabUnfocus.SetPosition(332, 380);
                OfficersTabUnfocus.SetSize(200, 200);
                OfficersTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabUnfocus.Visible = true;

                MiniMap.SetPosition(822, 46);
                MiniMap.SetSize(200, 200);
                MiniMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MiniMap.Visible = true;

                BottomMenuBar.SetPosition(584, 432);
                BottomMenuBar.SetSize(200, 200);
                BottomMenuBar.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuBar.Visible = true;

                OfficersTabTop.SetPosition(173, 380);
                OfficersTabTop.SetSize(200, 200);
                OfficersTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabTop.Visible = true;

                BuildingsTabTop.SetPosition(173, 380);
                BuildingsTabTop.SetSize(200, 200);
                BuildingsTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabTop.Visible = true;

                EventBox_1.SetPosition(817, 143);
                EventBox_1.SetSize(200, 200);
                EventBox_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_1.Visible = true;

                EventBox_2.SetPosition(817, 143);
                EventBox_2.SetSize(200, 200);
                EventBox_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_2.Visible = true;

                EventBox_3.SetPosition(817, 143);
                EventBox_3.SetSize(200, 200);
                EventBox_3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_3.Visible = true;

                EventBox_4.SetPosition(817, 143);
                EventBox_4.SetSize(200, 200);
                EventBox_4.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_4.Visible = true;

                EventBox_5.SetPosition(817, 143);
                EventBox_5.SetSize(200, 200);
                EventBox_5.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_5.Visible = true;

                EventBox_6.SetPosition(817, 143);
                EventBox_6.SetSize(200, 200);
                EventBox_6.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_6.Visible = true;

                EventBox_7.SetPosition(817, 143);
                EventBox_7.SetSize(200, 200);
                EventBox_7.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_7.Visible = true;

                EventBox_8.SetPosition(817, 143);
                EventBox_8.SetSize(200, 200);
                EventBox_8.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_8.Visible = true;

                BottomMenuExtra.SetPosition(525, 369);
                BottomMenuExtra.SetSize(200, 200);
                BottomMenuExtra.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuExtra.Visible = true;

                BlackSmith.SetPosition(178, 296);
                BlackSmith.SetSize(200, 200);
                BlackSmith.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BlackSmith.Visible = true;

                AidenPortrait.SetPosition(147, 399);
                AidenPortrait.SetSize(200, 200);
                AidenPortrait.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AidenPortrait.Visible = true;

                KiraPortrait.SetPosition(192, 443);
                KiraPortrait.SetSize(200, 200);
                KiraPortrait.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                KiraPortrait.Visible = true;

                CharacterOutline_1.SetPosition(160, 412);
                CharacterOutline_1.SetSize(200, 200);
                CharacterOutline_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterOutline_1.Visible = true;

                CharacterOutline_2.SetPosition(241, 412);
                CharacterOutline_2.SetSize(200, 200);
                CharacterOutline_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterOutline_2.Visible = true;

                WorldMap.SetPosition(649, 22);
                WorldMap.SetSize(200, 200);
                WorldMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                WorldMap.Visible = true;

                OptionsBox.SetPosition(171, 1);
                OptionsBox.SetSize(200, 200);
                OptionsBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsBox.Visible = true;

                BottomMenuButton_1.SetPosition(184, 383);
                BottomMenuButton_1.SetSize(200, 200);
                BottomMenuButton_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_1.Visible = true;

                BottomMenuButton_2.SetPosition(184, 383);
                BottomMenuButton_2.SetSize(200, 200);
                BottomMenuButton_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_2.Visible = true;

                CloseGUI.SetPosition(621, 368);
                CloseGUI.SetSize(200, 200);
                CloseGUI.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CloseGUI.Visible = true;

                ScreenVignette.SetPosition(-1, 0);
                ScreenVignette.SetSize(200, 200);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;

                CreditsButton.SetPosition(51, 85);
                CreditsButton.SetSize(214, 56);
                CreditsButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CreditsButton.Visible = true;

                ArtButton.SetPosition(77, 157);
                ArtButton.SetSize(214, 56);
                ArtButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ArtButton.Visible = true;

                QUITDEMO.SetPosition(310, 175);
                QUITDEMO.SetSize(214, 56);
                QUITDEMO.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                QUITDEMO.Visible = true;

                ExtraButton.SetPosition(32, 74);
                ExtraButton.SetSize(214, 56);
                ExtraButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ExtraButton.Visible = true;

                Close.SetPosition(48, 156);
                Close.SetSize(214, 56);
                Close.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Close.Visible = true;

                SFX.SetPosition(77, 157);
                SFX.SetSize(214, 56);
                SFX.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                SFX.Visible = true;

                Music.SetPosition(77, 157);
                Music.SetSize(214, 56);
                Music.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Music.Visible = true;

                Button_1.SetPosition(-56, 238);
                Button_1.SetSize(214, 56);
                Button_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Button_1.Visible = true;

                Volume.SetPosition(320, 334);
                Volume.SetSize(362, 58);
                Volume.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Volume.Visible = true;

                btnOfficersTab.SetPosition(332, 380);
                btnOfficersTab.SetSize(200, 200);
                btnOfficersTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnOfficersTab.Visible = true;

                btnBuildingsTab.SetPosition(166, 386);
                btnBuildingsTab.SetSize(200, 200);
                btnBuildingsTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnBuildingsTab.Visible = true;

                ArrowRight.SetPosition(774, 405);
                ArrowRight.SetSize(200, 200);
                ArrowRight.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ArrowRight.Visible = true;

                MoneyIcon.SetPosition(458, 474);
                MoneyIcon.SetSize(200, 200);
                MoneyIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MoneyIcon.Visible = true;

                CandleIcon.SetPosition(672, 493);
                CandleIcon.SetSize(200, 200);
                CandleIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CandleIcon.Visible = true;

                ArmorIcon.SetPosition(324, 487);
                ArmorIcon.SetSize(200, 200);
                ArmorIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ArmorIcon.Visible = true;

                WatchIcon.SetPosition(175, 476);
                WatchIcon.SetSize(200, 200);
                WatchIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                WatchIcon.Visible = true;

                break;

            default:
                this.DesignWidth = 855;
                this.DesignHeight = 480;

                DialogueBox.SetPosition(131, 40);
                DialogueBox.SetSize(612, 324);
                DialogueBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueBox.Visible = true;

                LeftMenuBox.SetPosition(1, 195);
                LeftMenuBox.SetSize(161, 286);
                LeftMenuBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LeftMenuBox.Visible = true;

                BuildingsTabUnfocus.SetPosition(260, 365);
                BuildingsTabUnfocus.SetSize(80, 35);
                BuildingsTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabUnfocus.Visible = true;

                BuildingsTabFocus.SetPosition(260, 365);
                BuildingsTabFocus.SetSize(80, 35);
                BuildingsTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabFocus.Visible = true;

                OfficersTabFocus.SetPosition(170, 365);
                OfficersTabFocus.SetSize(80, 35);
                OfficersTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabFocus.Visible = true;

                OfficersTabUnfocus.SetPosition(170, 365);
                OfficersTabUnfocus.SetSize(80, 35);
                OfficersTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabUnfocus.Visible = true;

                MiniMap.SetPosition(710, 0);
                MiniMap.SetSize(145, 116);
                MiniMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MiniMap.Visible = true;

                BottomMenuBar.SetPosition(140, 365);
                BottomMenuBar.SetSize(715, 120);
                BottomMenuBar.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuBar.Visible = true;

                OfficersTabTop.SetPosition(175, 362);
                OfficersTabTop.SetSize(75, 10);
                OfficersTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabTop.Visible = true;

                BuildingsTabTop.SetPosition(266, 362);
                BuildingsTabTop.SetSize(77, 10);
                BuildingsTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabTop.Visible = true;

                EventBox_1.SetPosition(778, 110);
                EventBox_1.SetSize(78, 40);
                EventBox_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_1.Visible = true;

                EventBox_2.SetPosition(778, 141);
                EventBox_2.SetSize(78, 40);
                EventBox_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_2.Visible = true;

                EventBox_3.SetPosition(777, 171);
                EventBox_3.SetSize(78, 40);
                EventBox_3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_3.Visible = true;

                EventBox_4.SetPosition(778, 202);
                EventBox_4.SetSize(78, 40);
                EventBox_4.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_4.Visible = true;

                EventBox_5.SetPosition(778, 234);
                EventBox_5.SetSize(78, 40);
                EventBox_5.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_5.Visible = true;

                EventBox_6.SetPosition(778, 265);
                EventBox_6.SetSize(78, 40);
                EventBox_6.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_6.Visible = true;

                EventBox_7.SetPosition(777, 296);
                EventBox_7.SetSize(78, 40);
                EventBox_7.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_7.Visible = true;

                EventBox_8.SetPosition(777, 328);
                EventBox_8.SetSize(78, 40);
                EventBox_8.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_8.Visible = true;

                BottomMenuExtra.SetPosition(377, 333);
                BottomMenuExtra.SetSize(319, 64);
                BottomMenuExtra.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuExtra.Visible = true;

                BlackSmith.SetPosition(147, 411);
                BlackSmith.SetSize(99, 52);
                BlackSmith.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BlackSmith.Visible = true;

                AidenPortrait.SetPosition(155, 410);
                AidenPortrait.SetSize(95, 54);
                AidenPortrait.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AidenPortrait.Visible = true;

                KiraPortrait.SetPosition(255, 410);
                KiraPortrait.SetSize(95, 54);
                KiraPortrait.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                KiraPortrait.Visible = true;

                CharacterOutline_1.SetPosition(155, 410);
                CharacterOutline_1.SetSize(95, 55);
                CharacterOutline_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterOutline_1.Visible = true;

                CharacterOutline_2.SetPosition(255, 410);
                CharacterOutline_2.SetSize(95, 55);
                CharacterOutline_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterOutline_2.Visible = true;

                WorldMap.SetPosition(649, 22);
                WorldMap.SetSize(50, 50);
                WorldMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                WorldMap.Visible = false;

                OptionsBox.SetPosition(380, 80);
                OptionsBox.SetSize(345, 250);
                OptionsBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsBox.Visible = true;

                BottomMenuButton_1.SetPosition(263, 415);
                BottomMenuButton_1.SetSize(77, 44);
                BottomMenuButton_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_1.Visible = true;

                BottomMenuButton_2.SetPosition(160, 414);
                BottomMenuButton_2.SetSize(75, 46);
                BottomMenuButton_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_2.Visible = true;

                CloseGUI.SetPosition(763, 382);
                CloseGUI.SetSize(110, 93);
                CloseGUI.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CloseGUI.Visible = true;

                ScreenVignette.SetPosition(0, 0);
                ScreenVignette.SetSize(852, 479);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;

                CreditsButton.SetPosition(85, 11);
                CreditsButton.SetSize(150, 56);
                CreditsButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CreditsButton.Visible = true;

                ArtButton.SetPosition(425, 175);
                ArtButton.SetSize(88, 56);
                ArtButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ArtButton.Visible = true;

                QUITDEMO.SetPosition(485, 100);
                QUITDEMO.SetSize(150, 56);
                QUITDEMO.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                QUITDEMO.Visible = true;

                ExtraButton.SetPosition(485, 175);
                ExtraButton.SetSize(150, 56);
                ExtraButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ExtraButton.Visible = true;

                Close.SetPosition(485, 255);
                Close.SetSize(150, 56);
                Close.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Close.Visible = true;

                SFX.SetPosition(520, 175);
                SFX.SetSize(88, 56);
                SFX.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                SFX.Visible = true;

                Music.SetPosition(615, 175);
                Music.SetSize(88, 56);
                Music.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Music.Visible = true;

                Button_1.SetPosition(9, 8);
                Button_1.SetSize(86, 56);
                Button_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Button_1.Visible = true;

                Volume.SetPosition(391, 336);
                Volume.SetSize(289, 58);
                Volume.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Volume.Visible = true;

                btnOfficersTab.SetPosition(174, 368);
                btnOfficersTab.SetSize(73, 27);
                btnOfficersTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnOfficersTab.Visible = true;

                btnBuildingsTab.SetPosition(267, 373);
                btnBuildingsTab.SetSize(68, 21);
                btnBuildingsTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnBuildingsTab.Visible = true;

                ArrowRight.SetPosition(772, 401);
                ArrowRight.SetSize(50, 50);
                ArrowRight.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ArrowRight.Visible = true;

                MoneyIcon.SetPosition(718, 417);
                MoneyIcon.SetSize(28, 35);
                MoneyIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MoneyIcon.Visible = true;

                CandleIcon.SetPosition(700, 390);
                CandleIcon.SetSize(35, 35);
                CandleIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CandleIcon.Visible = true;

                ArmorIcon.SetPosition(687, 420);
                ArmorIcon.SetSize(31, 32);
                ArmorIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ArmorIcon.Visible = true;

                WatchIcon.SetPosition(701, 443);
                WatchIcon.SetSize(35, 35);
                WatchIcon.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                WatchIcon.Visible = true;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            CreditsButton.Text = "Credits";
            ArtButton.Text = "Art";
            QUITDEMO.Text = "Quit Demo";
            ExtraButton.Text = "Extras";
            Close.Text = "Close";
            SFX.Text = "SFX";
            Music.Text = "Music";
            Button_1.Text = "Options";
            this.Title = "MainGUI";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    DialogueBox.Visible = false;
                    LeftMenuBox.Visible = false;
                    BuildingsTabUnfocus.Visible = false;
                    BuildingsTabFocus.Visible = false;
                    OfficersTabFocus.Visible = false;
                    OfficersTabUnfocus.Visible = false;
                    MiniMap.Visible = false;
                    BottomMenuBar.Visible = false;
                    OfficersTabTop.Visible = false;
                    BuildingsTabTop.Visible = false;
                    EventBox_1.Visible = false;
                    EventBox_2.Visible = false;
                    EventBox_3.Visible = false;
                    EventBox_4.Visible = false;
                    EventBox_5.Visible = false;
                    EventBox_6.Visible = false;
                    EventBox_7.Visible = false;
                    EventBox_8.Visible = false;
                    ScreenVignette.Visible = false;
                    btnOfficersTab.Visible = false;
                    btnBuildingsTab.Visible = false;
                }
                break;

                default:
                {
                    DialogueBox.Visible = false;
                    LeftMenuBox.Visible = false;
                    BuildingsTabUnfocus.Visible = false;
                    BuildingsTabFocus.Visible = false;
                    OfficersTabFocus.Visible = false;
                    OfficersTabUnfocus.Visible = false;
                    MiniMap.Visible = false;
                    BottomMenuBar.Visible = false;
                    OfficersTabTop.Visible = false;
                    BuildingsTabTop.Visible = false;
                    EventBox_1.Visible = false;
                    EventBox_2.Visible = false;
                    EventBox_3.Visible = false;
                    EventBox_4.Visible = false;
                    EventBox_5.Visible = false;
                    EventBox_6.Visible = false;
                    EventBox_7.Visible = false;
                    EventBox_8.Visible = false;
                    ScreenVignette.Visible = false;
                    btnOfficersTab.Visible = false;
                    btnBuildingsTab.Visible = false;
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
                        Widget = DialogueBox,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = LeftMenuBox,
                        MoveDirection = FourWayDirection.Right,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BuildingsTabUnfocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BuildingsTabFocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = OfficersTabFocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = OfficersTabUnfocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = MiniMap,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BottomMenuBar,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = OfficersTabTop,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BuildingsTabTop,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_1,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_2,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_3,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_4,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_5,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_6,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_7,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_8,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = ScreenVignette,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnOfficersTab,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnBuildingsTab,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                }
                break;

                default:
                {
                    new SlideInEffect()
                    {
                        Widget = DialogueBox,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = LeftMenuBox,
                        MoveDirection = FourWayDirection.Right,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BuildingsTabUnfocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BuildingsTabFocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = OfficersTabFocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = OfficersTabUnfocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = MiniMap,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BottomMenuBar,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = OfficersTabTop,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = BuildingsTabTop,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_1,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_2,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_3,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_4,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_5,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_6,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_7,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EventBox_8,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = ScreenVignette,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnOfficersTab,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnBuildingsTab,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                }
                break;
            }
        }
    }
}
