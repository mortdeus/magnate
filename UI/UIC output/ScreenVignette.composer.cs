// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class ScreenVignette
    {
        ImageBox AtLumberMill1;
        ImageBox AtStartingTown;
        ImageBox AtBossTown;
        ImageBox AtLumberMill2;
        ImageBox AtIronMine;
        ImageBox AtTown2;
        ImageBox TownArrow2;
        ImageBox LumberMillArrow2;
        ImageBox LumberMillArrow1;
        ImageBox BossTownArrow;
        ImageBox IronMineArrow;
        ImageBox AtTown3;
        ImageBox TownArrow3;
        ImageBox StartingTownArrow;
        ImageBox screenVignette;
        ImageBox LumberMill2Button;
        ImageBox IronMineButton;
        ImageBox StrongHold2Button;
        ImageBox LumberMill1Button;
        ImageBox BossTownButton;
        ImageBox StartingTownButton;
        ImageBox Town3Button;
        ImageBox CharacterBox;
        ImageBox Kira;
        ImageBox Aiden;
        ImageBox TextBox;
        Label PieceTypeText;
        Label PieceInfoText;
        Button GotoButton;
        ImageBox ShowGUI;
        Label TextBoxText;
        ImageBox Continue;
        ImageBox Philsoraptor;
        Button Visit;
        Button Close;
        ImageBox StartingTownBlackSmith;
        ImageBox StartingTownBlacksmith2;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            AtLumberMill1 = new ImageBox();
            AtLumberMill1.Name = "AtLumberMill1";
            AtStartingTown = new ImageBox();
            AtStartingTown.Name = "AtStartingTown";
            AtBossTown = new ImageBox();
            AtBossTown.Name = "AtBossTown";
            AtLumberMill2 = new ImageBox();
            AtLumberMill2.Name = "AtLumberMill2";
            AtIronMine = new ImageBox();
            AtIronMine.Name = "AtIronMine";
            AtTown2 = new ImageBox();
            AtTown2.Name = "AtTown2";
            TownArrow2 = new ImageBox();
            TownArrow2.Name = "TownArrow2";
            LumberMillArrow2 = new ImageBox();
            LumberMillArrow2.Name = "LumberMillArrow2";
            LumberMillArrow1 = new ImageBox();
            LumberMillArrow1.Name = "LumberMillArrow1";
            BossTownArrow = new ImageBox();
            BossTownArrow.Name = "BossTownArrow";
            IronMineArrow = new ImageBox();
            IronMineArrow.Name = "IronMineArrow";
            AtTown3 = new ImageBox();
            AtTown3.Name = "AtTown3";
            TownArrow3 = new ImageBox();
            TownArrow3.Name = "TownArrow3";
            StartingTownArrow = new ImageBox();
            StartingTownArrow.Name = "StartingTownArrow";
            screenVignette = new ImageBox();
            screenVignette.Name = "screenVignette";
            LumberMill2Button = new ImageBox();
            LumberMill2Button.Name = "LumberMill2Button";
            IronMineButton = new ImageBox();
            IronMineButton.Name = "IronMineButton";
            StrongHold2Button = new ImageBox();
            StrongHold2Button.Name = "StrongHold2Button";
            LumberMill1Button = new ImageBox();
            LumberMill1Button.Name = "LumberMill1Button";
            BossTownButton = new ImageBox();
            BossTownButton.Name = "BossTownButton";
            StartingTownButton = new ImageBox();
            StartingTownButton.Name = "StartingTownButton";
            Town3Button = new ImageBox();
            Town3Button.Name = "Town3Button";
            CharacterBox = new ImageBox();
            CharacterBox.Name = "CharacterBox";
            Kira = new ImageBox();
            Kira.Name = "Kira";
            Aiden = new ImageBox();
            Aiden.Name = "Aiden";
            TextBox = new ImageBox();
            TextBox.Name = "TextBox";
            PieceTypeText = new Label();
            PieceTypeText.Name = "PieceTypeText";
            PieceInfoText = new Label();
            PieceInfoText.Name = "PieceInfoText";
            GotoButton = new Button();
            GotoButton.Name = "GotoButton";
            ShowGUI = new ImageBox();
            ShowGUI.Name = "ShowGUI";
            TextBoxText = new Label();
            TextBoxText.Name = "TextBoxText";
            Continue = new ImageBox();
            Continue.Name = "Continue";
            Philsoraptor = new ImageBox();
            Philsoraptor.Name = "Philsoraptor";
            Visit = new Button();
            Visit.Name = "Visit";
            Close = new Button();
            Close.Name = "Close";
            StartingTownBlackSmith = new ImageBox();
            StartingTownBlackSmith.Name = "StartingTownBlackSmith";
            StartingTownBlacksmith2 = new ImageBox();
            StartingTownBlacksmith2.Name = "StartingTownBlacksmith2";

            // AtLumberMill1
            AtLumberMill1.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // AtStartingTown
            AtStartingTown.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // AtBossTown
            AtBossTown.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // AtLumberMill2
            AtLumberMill2.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // AtIronMine
            AtIronMine.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // AtTown2
            AtTown2.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // TownArrow2
            TownArrow2.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // LumberMillArrow2
            LumberMillArrow2.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // LumberMillArrow1
            LumberMillArrow1.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // BossTownArrow
            BossTownArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // IronMineArrow
            IronMineArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // AtTown3
            AtTown3.Image = new ImageAsset("assets/UI/Hero_Crest.png");

            // TownArrow3
            TownArrow3.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // StartingTownArrow
            StartingTownArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");

            // screenVignette
            screenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");

            // LumberMill2Button
            LumberMill2Button.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // IronMineButton
            IronMineButton.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // StrongHold2Button
            StrongHold2Button.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // LumberMill1Button
            LumberMill1Button.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // BossTownButton
            BossTownButton.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // StartingTownButton
            StartingTownButton.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // Town3Button
            Town3Button.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // CharacterBox
            CharacterBox.Image = new ImageAsset("assets/GUI/Dialogue_Main.png");

            // Kira
            Kira.Image = new ImageAsset("assets/kira/kira_think.png");

            // Aiden
            Aiden.Image = new ImageAsset("assets/aiden/aiden_think.png");

            // TextBox
            TextBox.Image = new ImageAsset("assets/GUI/Dialogue_ChatBox.png");

            // PieceTypeText
            PieceTypeText.TextColor = new UIColor(251f / 255f, 242f / 255f, 242f / 255f, 255f / 255f);
            PieceTypeText.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            PieceTypeText.LineBreak = LineBreak.Character;
            PieceTypeText.HorizontalAlignment = HorizontalAlignment.Center;

            // PieceInfoText
            PieceInfoText.TextColor = new UIColor(247f / 255f, 233f / 255f, 233f / 255f, 255f / 255f);
            PieceInfoText.Font = new Font( FontAlias.System, 20, FontStyle.Regular);
            PieceInfoText.LineBreak = LineBreak.Character;
            PieceInfoText.VerticalAlignment = VerticalAlignment.Top;

            // GotoButton
            GotoButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            GotoButton.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            GotoButton.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // ShowGUI
            ShowGUI.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // TextBoxText
            TextBoxText.TextColor = new UIColor(250f / 255f, 239f / 255f, 239f / 255f, 255f / 255f);
            TextBoxText.Font = new Font( FontAlias.System, 18, FontStyle.Regular);
            TextBoxText.VerticalAlignment = VerticalAlignment.Top;

            // Continue
            Continue.Image = new ImageAsset("assets/GUI/Button_ContinueOn.png");

            // Philsoraptor
            Philsoraptor.Image = new ImageAsset("assets/UI/Philsoraptor.png");

            // Visit
            Visit.TextColor = new UIColor(251f / 255f, 241f / 255f, 241f / 255f, 255f / 255f);
            Visit.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            Visit.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // Close
            Close.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Close.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            Close.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // StartingTownBlackSmith
            StartingTownBlackSmith.Image = new ImageAsset("assets/GUI/blacksmith1.png");

            // StartingTownBlacksmith2
            StartingTownBlacksmith2.Image = new ImageAsset("assets/GUI/blacksmith2.png");

            // Scene
            this.RootWidget.AddChildLast(AtLumberMill1);
            this.RootWidget.AddChildLast(AtStartingTown);
            this.RootWidget.AddChildLast(AtBossTown);
            this.RootWidget.AddChildLast(AtLumberMill2);
            this.RootWidget.AddChildLast(AtIronMine);
            this.RootWidget.AddChildLast(AtTown2);
            this.RootWidget.AddChildLast(TownArrow2);
            this.RootWidget.AddChildLast(LumberMillArrow2);
            this.RootWidget.AddChildLast(LumberMillArrow1);
            this.RootWidget.AddChildLast(BossTownArrow);
            this.RootWidget.AddChildLast(IronMineArrow);
            this.RootWidget.AddChildLast(AtTown3);
            this.RootWidget.AddChildLast(TownArrow3);
            this.RootWidget.AddChildLast(StartingTownArrow);
            this.RootWidget.AddChildLast(screenVignette);
            this.RootWidget.AddChildLast(LumberMill2Button);
            this.RootWidget.AddChildLast(IronMineButton);
            this.RootWidget.AddChildLast(StrongHold2Button);
            this.RootWidget.AddChildLast(LumberMill1Button);
            this.RootWidget.AddChildLast(BossTownButton);
            this.RootWidget.AddChildLast(StartingTownButton);
            this.RootWidget.AddChildLast(Town3Button);
            this.RootWidget.AddChildLast(CharacterBox);
            this.RootWidget.AddChildLast(Kira);
            this.RootWidget.AddChildLast(Aiden);
            this.RootWidget.AddChildLast(TextBox);
            this.RootWidget.AddChildLast(PieceTypeText);
            this.RootWidget.AddChildLast(PieceInfoText);
            this.RootWidget.AddChildLast(GotoButton);
            this.RootWidget.AddChildLast(ShowGUI);
            this.RootWidget.AddChildLast(TextBoxText);
            this.RootWidget.AddChildLast(Continue);
            this.RootWidget.AddChildLast(Philsoraptor);
            this.RootWidget.AddChildLast(Visit);
            this.RootWidget.AddChildLast(Close);
            this.RootWidget.AddChildLast(StartingTownBlackSmith);
            this.RootWidget.AddChildLast(StartingTownBlacksmith2);

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

                AtLumberMill1.SetPosition(445, 47);
                AtLumberMill1.SetSize(200, 200);
                AtLumberMill1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtLumberMill1.Visible = true;

                AtStartingTown.SetPosition(445, 47);
                AtStartingTown.SetSize(200, 200);
                AtStartingTown.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtStartingTown.Visible = true;

                AtBossTown.SetPosition(445, 47);
                AtBossTown.SetSize(200, 200);
                AtBossTown.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtBossTown.Visible = true;

                AtLumberMill2.SetPosition(445, 47);
                AtLumberMill2.SetSize(200, 200);
                AtLumberMill2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtLumberMill2.Visible = true;

                AtIronMine.SetPosition(445, 47);
                AtIronMine.SetSize(200, 200);
                AtIronMine.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtIronMine.Visible = true;

                AtTown2.SetPosition(445, 47);
                AtTown2.SetSize(200, 200);
                AtTown2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtTown2.Visible = true;

                TownArrow2.SetPosition(537, 299);
                TownArrow2.SetSize(200, 200);
                TownArrow2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TownArrow2.Visible = true;

                LumberMillArrow2.SetPosition(412, 240);
                LumberMillArrow2.SetSize(200, 200);
                LumberMillArrow2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMillArrow2.Visible = true;

                LumberMillArrow1.SetPosition(401, 180);
                LumberMillArrow1.SetSize(200, 200);
                LumberMillArrow1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMillArrow1.Visible = true;

                BossTownArrow.SetPosition(505, 223);
                BossTownArrow.SetSize(200, 200);
                BossTownArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BossTownArrow.Visible = true;

                IronMineArrow.SetPosition(575, 240);
                IronMineArrow.SetSize(200, 200);
                IronMineArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                IronMineArrow.Visible = true;

                AtTown3.SetPosition(445, 47);
                AtTown3.SetSize(200, 200);
                AtTown3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtTown3.Visible = true;

                TownArrow3.SetPosition(537, 299);
                TownArrow3.SetSize(200, 200);
                TownArrow3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TownArrow3.Visible = true;

                StartingTownArrow.SetPosition(537, 299);
                StartingTownArrow.SetSize(200, 200);
                StartingTownArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownArrow.Visible = true;

                screenVignette.SetPosition(0, 0);
                screenVignette.SetSize(200, 200);
                screenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                screenVignette.Visible = true;

                LumberMill2Button.SetPosition(456, 227);
                LumberMill2Button.SetSize(200, 200);
                LumberMill2Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMill2Button.Visible = true;

                IronMineButton.SetPosition(456, 227);
                IronMineButton.SetSize(200, 200);
                IronMineButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                IronMineButton.Visible = true;

                StrongHold2Button.SetPosition(456, 227);
                StrongHold2Button.SetSize(200, 200);
                StrongHold2Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StrongHold2Button.Visible = true;

                LumberMill1Button.SetPosition(456, 227);
                LumberMill1Button.SetSize(200, 200);
                LumberMill1Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMill1Button.Visible = true;

                BossTownButton.SetPosition(456, 227);
                BossTownButton.SetSize(200, 200);
                BossTownButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BossTownButton.Visible = true;

                StartingTownButton.SetPosition(328, 378);
                StartingTownButton.SetSize(200, 200);
                StartingTownButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownButton.Visible = true;

                Town3Button.SetPosition(456, 227);
                Town3Button.SetSize(200, 200);
                Town3Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Town3Button.Visible = true;

                CharacterBox.SetPosition(96, 0);
                CharacterBox.SetSize(200, 200);
                CharacterBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterBox.Visible = true;

                Kira.SetPosition(83, -8);
                Kira.SetSize(200, 200);
                Kira.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Kira.Visible = true;

                Aiden.SetPosition(125, -123);
                Aiden.SetSize(200, 200);
                Aiden.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Aiden.Visible = true;

                TextBox.SetPosition(0, 204);
                TextBox.SetSize(200, 200);
                TextBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TextBox.Visible = true;

                PieceTypeText.SetPosition(-55, 264);
                PieceTypeText.SetSize(214, 36);
                PieceTypeText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                PieceTypeText.Visible = true;

                PieceInfoText.SetPosition(-10, 322);
                PieceInfoText.SetSize(214, 36);
                PieceInfoText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                PieceInfoText.Visible = true;

                GotoButton.SetPosition(73, 415);
                GotoButton.SetSize(214, 56);
                GotoButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                GotoButton.Visible = true;

                ShowGUI.SetPosition(0, 0);
                ShowGUI.SetSize(200, 200);
                ShowGUI.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ShowGUI.Visible = true;

                TextBoxText.SetPosition(-49, 398);
                TextBoxText.SetSize(214, 36);
                TextBoxText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TextBoxText.Visible = true;

                Continue.SetPosition(146, 457);
                Continue.SetSize(200, 200);
                Continue.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Continue.Visible = true;

                Philsoraptor.SetPosition(214, -132);
                Philsoraptor.SetSize(200, 200);
                Philsoraptor.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Philsoraptor.Visible = true;

                Visit.SetPosition(61, 410);
                Visit.SetSize(214, 56);
                Visit.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Visit.Visible = true;

                Close.SetPosition(22, 336);
                Close.SetSize(214, 56);
                Close.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Close.Visible = true;

                StartingTownBlackSmith.SetPosition(82, 194);
                StartingTownBlackSmith.SetSize(200, 200);
                StartingTownBlackSmith.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownBlackSmith.Visible = true;

                StartingTownBlacksmith2.SetPosition(99, 193);
                StartingTownBlacksmith2.SetSize(200, 200);
                StartingTownBlacksmith2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownBlacksmith2.Visible = true;

                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

                AtLumberMill1.SetPosition(401, 180);
                AtLumberMill1.SetSize(54, 53);
                AtLumberMill1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtLumberMill1.Visible = false;

                AtStartingTown.SetPosition(505, 223);
                AtStartingTown.SetSize(54, 53);
                AtStartingTown.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtStartingTown.Visible = false;

                AtBossTown.SetPosition(514, 133);
                AtBossTown.SetSize(54, 53);
                AtBossTown.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtBossTown.Visible = false;

                AtLumberMill2.SetPosition(412, 240);
                AtLumberMill2.SetSize(54, 53);
                AtLumberMill2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtLumberMill2.Visible = false;

                AtIronMine.SetPosition(571, 240);
                AtIronMine.SetSize(54, 53);
                AtIronMine.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtIronMine.Visible = false;

                AtTown2.SetPosition(537, 299);
                AtTown2.SetSize(54, 53);
                AtTown2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtTown2.Visible = false;

                TownArrow2.SetPosition(537, 299);
                TownArrow2.SetSize(50, 50);
                TownArrow2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TownArrow2.Visible = false;

                LumberMillArrow2.SetPosition(412, 240);
                LumberMillArrow2.SetSize(50, 50);
                LumberMillArrow2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMillArrow2.Visible = false;

                LumberMillArrow1.SetPosition(401, 180);
                LumberMillArrow1.SetSize(50, 50);
                LumberMillArrow1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMillArrow1.Visible = false;

                BossTownArrow.SetPosition(514, 133);
                BossTownArrow.SetSize(50, 50);
                BossTownArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BossTownArrow.Visible = false;

                IronMineArrow.SetPosition(575, 240);
                IronMineArrow.SetSize(50, 50);
                IronMineArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                IronMineArrow.Visible = false;

                AtTown3.SetPosition(408, 299);
                AtTown3.SetSize(54, 53);
                AtTown3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AtTown3.Visible = false;

                TownArrow3.SetPosition(408, 299);
                TownArrow3.SetSize(50, 50);
                TownArrow3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TownArrow3.Visible = false;

                StartingTownArrow.SetPosition(509, 226);
                StartingTownArrow.SetSize(50, 50);
                StartingTownArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownArrow.Visible = false;

                screenVignette.SetPosition(0, 0);
                screenVignette.SetSize(854, 479);
                screenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                screenVignette.Visible = true;

                LumberMill2Button.SetPosition(412, 287);
                LumberMill2Button.SetSize(63, 59);
                LumberMill2Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMill2Button.Visible = true;

                IronMineButton.SetPosition(568, 293);
                IronMineButton.SetSize(63, 59);
                IronMineButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                IronMineButton.Visible = true;

                StrongHold2Button.SetPosition(546, 352);
                StrongHold2Button.SetSize(36, 42);
                StrongHold2Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StrongHold2Button.Visible = true;

                LumberMill1Button.SetPosition(412, 238);
                LumberMill1Button.SetSize(33, 25);
                LumberMill1Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LumberMill1Button.Visible = true;

                BossTownButton.SetPosition(523, 181);
                BossTownButton.SetSize(36, 42);
                BossTownButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BossTownButton.Visible = true;

                StartingTownButton.SetPosition(505, 276);
                StartingTownButton.SetSize(54, 52);
                StartingTownButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownButton.Visible = true;

                Town3Button.SetPosition(425, 346);
                Town3Button.SetSize(22, 34);
                Town3Button.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Town3Button.Visible = true;

                CharacterBox.SetPosition(0, 252);
                CharacterBox.SetSize(376, 228);
                CharacterBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterBox.Visible = false;

                Kira.SetPosition(173, 89);
                Kira.SetSize(203, 305);
                Kira.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Kira.Visible = false;

                Aiden.SetPosition(32, 56);
                Aiden.SetSize(178, 338);
                Aiden.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Aiden.Visible = false;

                TextBox.SetPosition(12, 372);
                TextBox.SetSize(352, 70);
                TextBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TextBox.Visible = false;

                PieceTypeText.SetPosition(76, 264);
                PieceTypeText.SetSize(214, 36);
                PieceTypeText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                PieceTypeText.Visible = false;

                PieceInfoText.SetPosition(12, 316);
                PieceInfoText.SetSize(339, 101);
                PieceInfoText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                PieceInfoText.Visible = false;

                GotoButton.SetPosition(272, 411);
                GotoButton.SetSize(86, 56);
                GotoButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                GotoButton.Visible = false;

                ShowGUI.SetPosition(768, 405);
                ShowGUI.SetSize(84, 73);
                ShowGUI.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ShowGUI.Visible = true;

                TextBoxText.SetPosition(17, 394);
                TextBoxText.SetSize(336, 44);
                TextBoxText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TextBoxText.Visible = false;

                Continue.SetPosition(149, 446);
                Continue.SetSize(73, 26);
                Continue.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Continue.Visible = false;

                Philsoraptor.SetPosition(26, 59);
                Philsoraptor.SetSize(330, 332);
                Philsoraptor.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Philsoraptor.Visible = false;

                Visit.SetPosition(136, 411);
                Visit.SetSize(100, 56);
                Visit.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Visit.Visible = false;

                Close.SetPosition(16, 411);
                Close.SetSize(91, 56);
                Close.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Close.Visible = false;

                StartingTownBlackSmith.SetPosition(82, 194);
                StartingTownBlackSmith.SetSize(199, 199);
                StartingTownBlackSmith.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownBlackSmith.Visible = false;

                StartingTownBlacksmith2.SetPosition(99, 193);
                StartingTownBlacksmith2.SetSize(199, 199);
                StartingTownBlacksmith2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                StartingTownBlacksmith2.Visible = false;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            PieceTypeText.Text = "label";
            GotoButton.Text = "Goto";
            Visit.Text = "Visit";
            Close.Text = "Close";
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
