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
        ImageBox EventBox_1;
        ImageBox BuildingsTabUnfocus;
        ImageBox BuildingsTabFocus;
        ImageBox RecruitTabUnfocus;
        ImageBox RecruitTabFocus;
        ImageBox OfficersTabFocus;
        ImageBox OfficersTabUnfocus;
        ImageBox MiniMap;
        ImageBox BottomMenuBar;
        ImageBox OfficersTabTop;
        ImageBox BuildingsTabTop;
        ImageBox RecruitTabTop;
        ImageBox EventBox_2;
        ImageBox EventBox_3;
        ImageBox EventBox_4;
        ImageBox EventBox_5;
        ImageBox EventBox_6;
        ImageBox EventBox_7;
        ImageBox EventBox_8;
        ImageBox RedRect_1;
        ImageBox BottomMenuExtra;
        ImageBox BlackSmith;
        ImageBox AidenPortrait;
        ImageBox KiraPortrait;
        ImageBox CharacterOutline_1;
        ImageBox CharacterOutline_2;
        Label DisclaimerBoxText;
        ImageBox DisclaimerContinueUnFocus;
        ImageBox DisclaimerContinueFocus;
        ImageBox TutBackUnfocus;
        ImageBox TutBackFocus;
        ImageBox TutOfficerArrow;
        ImageBox TutBuildingArrow;
        ImageBox TutRecruitArrow;
        ImageBox WorldMap;
        ImageBox TutEventsArrow;
        ImageBox TutLeftMenuArrow;
        ImageBox OptionsBox;
        Label OptionsTutorialOnorOff;
        ImageBox TutOptionsRedRect;
        ImageBox TutOptionsArrow;
        ImageBox ShowOptions;
        ImageBox btnOfficersTab;
        ImageBox btnBuildingsTab;
        ImageBox btnRecruitTab;
        ImageBox BottomMenuButton_1;
        ImageBox BottomMenuButton_2;
        ImageBox DisclaimerContinueButton;
        Button QUITDEMO;
        CheckBox OptionsCheck;
        Button OptionsCloseButton;
        ImageBox CloseGUI;
        ImageBox TutorialBox;
        Label Tutorialtext;
        ImageBox TutorialContinueOff;
        ImageBox TutorialContinueOn;
        ImageBox ScreenVignette;
        ImageBox TutorialContinueButton;
        ImageBox tutGUIArrow;
        ImageBox TutGUIRect;

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
            EventBox_1 = new ImageBox();
            EventBox_1.Name = "EventBox_1";
            BuildingsTabUnfocus = new ImageBox();
            BuildingsTabUnfocus.Name = "BuildingsTabUnfocus";
            BuildingsTabFocus = new ImageBox();
            BuildingsTabFocus.Name = "BuildingsTabFocus";
            RecruitTabUnfocus = new ImageBox();
            RecruitTabUnfocus.Name = "RecruitTabUnfocus";
            RecruitTabFocus = new ImageBox();
            RecruitTabFocus.Name = "RecruitTabFocus";
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
            RecruitTabTop = new ImageBox();
            RecruitTabTop.Name = "RecruitTabTop";
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
            RedRect_1 = new ImageBox();
            RedRect_1.Name = "RedRect_1";
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
            OptionsTutorialOnorOff = new Label();
            OptionsTutorialOnorOff.Name = "OptionsTutorialOnorOff";
			ShowOptions = new ImageBox();
            ShowOptions.Name = "ShowOptions";
            btnOfficersTab = new ImageBox();
            btnOfficersTab.Name = "btnOfficersTab";
            btnBuildingsTab = new ImageBox();
            btnBuildingsTab.Name = "btnBuildingsTab";
            btnRecruitTab = new ImageBox();
            btnRecruitTab.Name = "btnRecruitTab";
            BottomMenuButton_1 = new ImageBox();
            BottomMenuButton_1.Name = "BottomMenuButton_1";
            BottomMenuButton_2 = new ImageBox();
            BottomMenuButton_2.Name = "BottomMenuButton_2";
			
//			if(TutorialMode){
//			DisclaimerBoxText = new Label();
//            DisclaimerBoxText.Name = "DisclaimerBoxText";
//            DisclaimerContinueUnFocus = new ImageBox();
//            DisclaimerContinueUnFocus.Name = "DisclaimerContinueUnFocus";
//            DisclaimerContinueFocus = new ImageBox();
//            DisclaimerContinueFocus.Name = "DisclaimerContinueFocus";
//            TutBackUnfocus = new ImageBox();
//            TutBackUnfocus.Name = "TutBackUnfocus";
//            TutBackFocus = new ImageBox();
//            TutBackFocus.Name = "TutBackFocus";
//            TutOfficerArrow = new ImageBox();
//            TutOfficerArrow.Name = "TutOfficerArrow";
//            TutBuildingArrow = new ImageBox();
//            TutBuildingArrow.Name = "TutBuildingArrow";
//            TutRecruitArrow = new ImageBox();
//            TutRecruitArrow.Name = "TutRecruitArrow";
//            TutEventsArrow = new ImageBox();
//            TutEventsArrow.Name = "TutEventsArrow";
//            TutLeftMenuArrow = new ImageBox();
//            TutLeftMenuArrow.Name = "TutLeftMenuArrow";
//            TutOptionsRedRect = new ImageBox();
//            TutOptionsRedRect.Name = "TutOptionsRedRect";
//            TutOptionsArrow = new ImageBox();
//            TutOptionsArrow.Name = "TutOptionsArrow";
//            DisclaimerContinueButton = new ImageBox();
//            DisclaimerContinueButton.Name = "DisclaimerContinueButton";
//            TutorialBox = new ImageBox();
//            TutorialBox.Name = "TutorialBox";
//            Tutorialtext = new Label();
//            Tutorialtext.Name = "Tutorialtext";
//            TutorialContinueOff = new ImageBox();
//            TutorialContinueOff.Name = "TutorialContinueOff";
//            TutorialContinueOn = new ImageBox();
//            TutorialContinueOn.Name = "TutorialContinueOn";
//			tutGUIArrow = new ImageBox();
//            tutGUIArrow.Name = "tutGUIArrow";
//            TutGUIRect = new ImageBox();
//            TutGUIRect.Name = "TutGUIRect";
//			TutorialContinueButton = new ImageBox();
//            TutorialContinueButton.Name = "TutorialContinueButton";
//			}
			
			QUITDEMO = new Button();
            QUITDEMO.Name = "QUITDEMO";
            OptionsCheck = new CheckBox();
            OptionsCheck.Name = "OptionsCheck";
            OptionsCloseButton = new Button();
            OptionsCloseButton.Name = "OptionsCloseButton";
            CloseGUI = new ImageBox();
            CloseGUI.Name = "CloseGUI";
            
            ScreenVignette = new ImageBox();
            ScreenVignette.Name = "ScreenVignette";
            
            

            // DialogueBox
            DialogueBox.Image = new ImageAsset("assets/GUI/Dialogue_Main.png");

            // LeftMenuBox
            LeftMenuBox.Image = new ImageAsset("assets/GUI/LeftMenu_Icon.png");

            // EventBox_1
            EventBox_1.Image = new ImageAsset("assets/GUI/Right_Events.png");

            // BuildingsTabUnfocus
            BuildingsTabUnfocus.Image = new ImageAsset("assets/GUI/MainTabs_BuildingsOff.png");

            // BuildingsTabFocus
            BuildingsTabFocus.Image = new ImageAsset("assets/GUI/MainTabs_BuildingsOn.png");

            // RecruitTabUnfocus
            RecruitTabUnfocus.Image = new ImageAsset("assets/GUI/MainTabs_RecruitOff.png");

            // RecruitTabFocus
            RecruitTabFocus.Image = new ImageAsset("assets/GUI/MainTabs_RecruitOn.png");

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

            // RecruitTabTop
            RecruitTabTop.Image = new ImageAsset("assets/GUI/MainTabs_Highlight.png");

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

            // RedRect_1
            RedRect_1.Image = new ImageAsset("assets/GameTutorial/RedRectangle.png");

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

            
			
			
//			if(TutorialMode){
//			
//			// DisclaimerBoxText
//            DisclaimerBoxText.TextColor = new UIColor(253f / 255f, 240f / 255f, 240f / 255f, 255f / 255f);
//            DisclaimerBoxText.Font = new Font( FontAlias.System, 18, FontStyle.Bold);
//            DisclaimerBoxText.TextTrimming = TextTrimming.Word;
//            DisclaimerBoxText.VerticalAlignment = VerticalAlignment.Top;
//
//            // DisclaimerContinueUnFocus
//            DisclaimerContinueUnFocus.Image = new ImageAsset("assets/GUI/Button_ContinueOff.png");
//
//            // DisclaimerContinueFocus
//            DisclaimerContinueFocus.Image = new ImageAsset("assets/GUI/Button_ContinueOn.png");
//
//            // TutBackUnfocus
//            TutBackUnfocus.Image = new ImageAsset("assets/GUI/LeftMenu_ButtonBackOff.png");
//
//            // TutBackFocus
//            TutBackFocus.Image = new ImageAsset("assets/GUI/LeftMenu_ButtonBackOn.png");
//
//            // TutOfficerArrow
//            TutOfficerArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");
//
//            // TutBuildingArrow
//            TutBuildingArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");
//
//            // TutRecruitArrow
//            TutRecruitArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");
//
//            // TutEventsArrow
//            TutEventsArrow.Image = new ImageAsset("assets/UI/ArrowRight.png");
//
//            // TutLeftMenuArrow
//            TutLeftMenuArrow.Image = new ImageAsset("assets/UI/ArrowLeft.png");
//				
//			 // TutOptionsRedRect
//            TutOptionsRedRect.Image = new ImageAsset("assets/GameTutorial/RedRectangle.png");
//
//            // TutOptionsArrow
//            TutOptionsArrow.Image = new ImageAsset("assets/UI/ArrowUp.png");
//			
//			 // TutorialBox
//            TutorialBox.Image = new ImageAsset("assets/GUI/Dialogue_Main.png");
//
//            // Tutorialtext
//            Tutorialtext.TextColor = new UIColor(253f / 255f, 244f / 255f, 244f / 255f, 255f / 255f);
//            Tutorialtext.Font = new Font( FontAlias.System, 18, FontStyle.Bold);
//            Tutorialtext.LineBreak = LineBreak.Character;
//            Tutorialtext.VerticalAlignment = VerticalAlignment.Top;
//
//            // TutorialContinueOff
//            TutorialContinueOff.Image = new ImageAsset("assets/GUI/Button_ContinueOff.png");
//
//            // TutorialContinueOn
//            TutorialContinueOn.Image = new ImageAsset("assets/GUI/Button_ContinueOn.png");
//
//            // ScreenVignette
//            ScreenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");
//
//            // TutorialContinueButton
//            TutorialContinueButton.Image = new ImageAsset("assets/Test/TransparencyLayer.png");
//
//            // tutGUIArrow
//            tutGUIArrow.Image = new ImageAsset("assets/UI/ArrowDown.png");
//
//            // TutGUIRect
//            TutGUIRect.Image = new ImageAsset("assets/GameTutorial/RedRectangle.png");
//			
//			DisclaimerContinueButton.Image = new ImageAsset("assets/Test/TransparencyLayer.png");
//			
//			}
			
			
			// WorldMap		
			WorldMap.Image = new ImageAsset("assets/UI/ArrowRight.png");

            

            // OptionsBox
            OptionsBox.Image = new ImageAsset("assets/GUI/Options_MainMenu.png");

            // OptionsTutorialOnorOff
            OptionsTutorialOnorOff.TextColor = new UIColor(246f / 255f, 230f / 255f, 230f / 255f, 255f / 255f);
            OptionsTutorialOnorOff.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            OptionsTutorialOnorOff.LineBreak = LineBreak.Character;
            OptionsTutorialOnorOff.HorizontalAlignment = HorizontalAlignment.Center;
            TextShadowSettings textShadow_OptionsTutorialOnorOff = new TextShadowSettings();
            textShadow_OptionsTutorialOnorOff.Color = new UIColor(247f / 255f, 8f / 255f, 8f / 255f, 127f / 255f);
            textShadow_OptionsTutorialOnorOff.HorizontalOffset = 2;
            textShadow_OptionsTutorialOnorOff.VerticalOffset = 2;
            OptionsTutorialOnorOff.TextShadow = textShadow_OptionsTutorialOnorOff;

           

            // ShowOptions
            ShowOptions.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // btnOfficersTab
            btnOfficersTab.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // btnBuildingsTab
            btnBuildingsTab.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // btnRecruitTab
            btnRecruitTab.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // BottomMenuButton_1
            BottomMenuButton_1.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // BottomMenuButton_2
            BottomMenuButton_2.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

            // DisclaimerContinueButton
            

            // QUITDEMO
            QUITDEMO.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            QUITDEMO.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            QUITDEMO.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // OptionsCheck
            OptionsCheck.Enabled = false;

            // OptionsCloseButton
            OptionsCloseButton.TextColor = new UIColor(250f / 255f, 239f / 255f, 239f / 255f, 255f / 255f);
            OptionsCloseButton.TextFont = new Font( FontAlias.System, 25, FontStyle.Regular);
            OptionsCloseButton.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);

            // CloseGUI
            CloseGUI.Image = new ImageAsset("assets/Test/TransparencyLayer.png");

           

            // Scene
            this.RootWidget.AddChildLast(DialogueBox);
            this.RootWidget.AddChildLast(LeftMenuBox);
            this.RootWidget.AddChildLast(EventBox_1);
            this.RootWidget.AddChildLast(BuildingsTabUnfocus);
            this.RootWidget.AddChildLast(BuildingsTabFocus);
            this.RootWidget.AddChildLast(RecruitTabUnfocus);
            this.RootWidget.AddChildLast(RecruitTabFocus);
            this.RootWidget.AddChildLast(OfficersTabFocus);
            this.RootWidget.AddChildLast(OfficersTabUnfocus);
            this.RootWidget.AddChildLast(MiniMap);
            this.RootWidget.AddChildLast(BottomMenuBar);
            this.RootWidget.AddChildLast(OfficersTabTop);
            this.RootWidget.AddChildLast(BuildingsTabTop);
            this.RootWidget.AddChildLast(RecruitTabTop);
            this.RootWidget.AddChildLast(EventBox_2);
            this.RootWidget.AddChildLast(EventBox_3);
            this.RootWidget.AddChildLast(EventBox_4);
            this.RootWidget.AddChildLast(EventBox_5);
            this.RootWidget.AddChildLast(EventBox_6);
            this.RootWidget.AddChildLast(EventBox_7);
            this.RootWidget.AddChildLast(EventBox_8);
            this.RootWidget.AddChildLast(RedRect_1);
            this.RootWidget.AddChildLast(BottomMenuExtra);
            this.RootWidget.AddChildLast(BlackSmith);
            this.RootWidget.AddChildLast(AidenPortrait);
            this.RootWidget.AddChildLast(KiraPortrait);
            this.RootWidget.AddChildLast(CharacterOutline_1);
            this.RootWidget.AddChildLast(CharacterOutline_2);
            
            
            this.RootWidget.AddChildLast(WorldMap);
			
            
#region Tutorial
//			if(TutorialMode){
//			
//			this.RootWidget.AddChildLast(DisclaimerBoxText);
//            this.RootWidget.AddChildLast(DisclaimerContinueUnFocus);
//            this.RootWidget.AddChildLast(DisclaimerContinueFocus);	
//				
//			this.RootWidget.AddChildLast(TutorialBox);
//            this.RootWidget.AddChildLast(Tutorialtext);
//            this.RootWidget.AddChildLast(TutorialContinueOff);
//            this.RootWidget.AddChildLast(TutorialContinueOn);
//			this.RootWidget.AddChildLast(TutEventsArrow);
//            this.RootWidget.AddChildLast(TutLeftMenuArrow);
//            this.RootWidget.AddChildLast(TutOptionsRedRect);
//            this.RootWidget.AddChildLast(TutOptionsArrow);
//			this.RootWidget.AddChildLast(TutOfficerArrow);
//            this.RootWidget.AddChildLast(TutBuildingArrow);
//            this.RootWidget.AddChildLast(TutRecruitArrow);
//			this.RootWidget.AddChildLast(TutGUIRect);
//			this.RootWidget.AddChildLast(tutGUIArrow);
			//			}
#endregion
				
			this.RootWidget.AddChildLast(ScreenVignette);
            
			this.RootWidget.AddChildLast(ShowOptions);
            this.RootWidget.AddChildLast(btnOfficersTab);
            this.RootWidget.AddChildLast(btnBuildingsTab);
            this.RootWidget.AddChildLast(btnRecruitTab);
            this.RootWidget.AddChildLast(BottomMenuButton_1);
            this.RootWidget.AddChildLast(BottomMenuButton_2);
            
			
			this.RootWidget.AddChildLast(OptionsBox);
            this.RootWidget.AddChildLast(OptionsTutorialOnorOff);
			
//			if(TutorialMode)
//			this.RootWidget.AddChildLast(DisclaimerContinueButton);
            
			this.RootWidget.AddChildLast(QUITDEMO);
            this.RootWidget.AddChildLast(OptionsCheck);
            this.RootWidget.AddChildLast(OptionsCloseButton);
            this.RootWidget.AddChildLast(CloseGUI);
            
//			if(TutorialMode)
//			this.RootWidget.AddChildLast(TutorialContinueButton);
			
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
				#region vertical
			case LayoutOrientation.Vertical:
                this.DesignWidth = 480;
                this.DesignHeight = 854;

                DialogueBox.SetPosition(206, 92);
                DialogueBox.SetSize(200, 200);
                DialogueBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueBox.Visible = true;

                LeftMenuBox.SetPosition(0, 395);
                LeftMenuBox.SetSize(200, 200);
                LeftMenuBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LeftMenuBox.Visible = true;

                EventBox_1.SetPosition(817, 143);
                EventBox_1.SetSize(200, 200);
                EventBox_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_1.Visible = true;

                BuildingsTabUnfocus.SetPosition(166, 386);
                BuildingsTabUnfocus.SetSize(200, 200);
                BuildingsTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabUnfocus.Visible = true;

                BuildingsTabFocus.SetPosition(186, 395);
                BuildingsTabFocus.SetSize(200, 200);
                BuildingsTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabFocus.Visible = true;

                RecruitTabUnfocus.SetPosition(259, 385);
                RecruitTabUnfocus.SetSize(200, 200);
                RecruitTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RecruitTabUnfocus.Visible = true;

                RecruitTabFocus.SetPosition(259, 380);
                RecruitTabFocus.SetSize(200, 200);
                RecruitTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RecruitTabFocus.Visible = true;

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

                RecruitTabTop.SetPosition(173, 380);
                RecruitTabTop.SetSize(200, 200);
                RecruitTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RecruitTabTop.Visible = true;

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

                RedRect_1.SetPosition(138, 378);
                RedRect_1.SetSize(200, 200);
                RedRect_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RedRect_1.Visible = true;

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

//               if(TutorialMode)
//				{
//				
//				DisclaimerBoxText.SetPosition(243, 16);
//                DisclaimerBoxText.SetSize(214, 36);
//                DisclaimerBoxText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerBoxText.Visible = true;
//
//                DisclaimerContinueUnFocus.SetPosition(374, 184);
//                DisclaimerContinueUnFocus.SetSize(200, 200);
//                DisclaimerContinueUnFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerContinueUnFocus.Visible = true;
//
//                DisclaimerContinueFocus.SetPosition(428, 177);
//                DisclaimerContinueFocus.SetSize(200, 200);
//                DisclaimerContinueFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerContinueFocus.Visible = true;
//
//                TutBackUnfocus.SetPosition(301, 244);
//                TutBackUnfocus.SetSize(200, 200);
//                TutBackUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutBackUnfocus.Visible = true;
//
//                TutBackFocus.SetPosition(270, 251);
//                TutBackFocus.SetSize(200, 200);
//                TutBackFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutBackFocus.Visible = true;
//
//                TutOfficerArrow.SetPosition(177, 321);
//                TutOfficerArrow.SetSize(200, 200);
//                TutOfficerArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutOfficerArrow.Visible = true;
//
//                TutBuildingArrow.SetPosition(251, 319);
//                TutBuildingArrow.SetSize(200, 200);
//                TutBuildingArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutBuildingArrow.Visible = true;
//
//                TutRecruitArrow.SetPosition(326, 321);
//                TutRecruitArrow.SetSize(200, 200);
//                TutRecruitArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutRecruitArrow.Visible = true;
//				
//					
//				TutEventsArrow.SetPosition(723, 176);
//                TutEventsArrow.SetSize(200, 200);
//                TutEventsArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutEventsArrow.Visible = true;
//
//                TutLeftMenuArrow.SetPosition(142, 273);
//                TutLeftMenuArrow.SetSize(200, 200);
//                TutLeftMenuArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutLeftMenuArrow.Visible = true;
//				
//				TutOptionsRedRect.SetPosition(269, 0);
//                TutOptionsRedRect.SetSize(200, 200);
//                TutOptionsRedRect.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutOptionsRedRect.Visible = true;
//
//                TutOptionsArrow.SetPosition(395, 94);
//                TutOptionsArrow.SetSize(200, 200);
//                TutOptionsArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutOptionsArrow.Visible = true;	
//					
//				DisclaimerContinueButton.SetPosition(195, 94);
//                DisclaimerContinueButton.SetSize(200, 200);
//                DisclaimerContinueButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerContinueButton.Visible = true;
//				
//				TutorialBox.SetPosition(-1, -1);
//                TutorialBox.SetSize(200, 200);
//                TutorialBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialBox.Visible = true;
//
//                Tutorialtext.SetPosition(10, 14);
//                Tutorialtext.SetSize(214, 36);
//                Tutorialtext.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                Tutorialtext.Visible = true;
//
//                TutorialContinueOff.SetPosition(216, 128);
//                TutorialContinueOff.SetSize(200, 200);
//                TutorialContinueOff.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialContinueOff.Visible = true;
//
//                TutorialContinueOn.SetPosition(216, 128);
//                TutorialContinueOn.SetSize(200, 200);
//                TutorialContinueOn.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialContinueOn.Visible = true;
//				
//				TutorialContinueButton.SetPosition(146, 45);
//                TutorialContinueButton.SetSize(200, 200);
//                TutorialContinueButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialContinueButton.Visible = true;
//
//                tutGUIArrow.SetPosition(770, 324);
//                tutGUIArrow.SetSize(200, 200);
//                tutGUIArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                tutGUIArrow.Visible = true;
//
//                TutGUIRect.SetPosition(557, 379);
//                TutGUIRect.SetSize(200, 200);
//                TutGUIRect.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutGUIRect.Visible = true;
//				
//				
//				}
                WorldMap.SetPosition(649, 22);
                WorldMap.SetSize(200, 200);
                WorldMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                WorldMap.Visible = true;

                

                OptionsBox.SetPosition(171, 1);
                OptionsBox.SetSize(200, 200);
                OptionsBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsBox.Visible = true;

                OptionsTutorialOnorOff.SetPosition(325, 78);
                OptionsTutorialOnorOff.SetSize(214, 36);
                OptionsTutorialOnorOff.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsTutorialOnorOff.Visible = true;

                

                ShowOptions.SetPosition(274, 4);
                ShowOptions.SetSize(200, 200);
                ShowOptions.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ShowOptions.Visible = true;

                btnOfficersTab.SetPosition(332, 380);
                btnOfficersTab.SetSize(200, 200);
                btnOfficersTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnOfficersTab.Visible = true;

                btnBuildingsTab.SetPosition(166, 386);
                btnBuildingsTab.SetSize(200, 200);
                btnBuildingsTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnBuildingsTab.Visible = true;

                btnRecruitTab.SetPosition(259, 385);
                btnRecruitTab.SetSize(200, 200);
                btnRecruitTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnRecruitTab.Visible = true;

                BottomMenuButton_1.SetPosition(184, 383);
                BottomMenuButton_1.SetSize(200, 200);
                BottomMenuButton_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_1.Visible = true;

                BottomMenuButton_2.SetPosition(184, 383);
                BottomMenuButton_2.SetSize(200, 200);
                BottomMenuButton_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_2.Visible = true;

               

                QUITDEMO.SetPosition(310, 175);
                QUITDEMO.SetSize(214, 56);
                QUITDEMO.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                QUITDEMO.Visible = true;

                OptionsCheck.SetPosition(405, 132);
                OptionsCheck.SetSize(56, 56);
                OptionsCheck.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsCheck.Visible = true;

                OptionsCloseButton.SetPosition(331, 279);
                OptionsCloseButton.SetSize(214, 56);
                OptionsCloseButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsCloseButton.Visible = true;

                CloseGUI.SetPosition(621, 368);
                CloseGUI.SetSize(200, 200);
                CloseGUI.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CloseGUI.Visible = true;

                

                ScreenVignette.SetPosition(-1, 0);
                ScreenVignette.SetSize(200, 200);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;
				
				#endregion
                

                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

                DialogueBox.SetPosition(136, 40);
                DialogueBox.SetSize(608, 337);
                DialogueBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueBox.Visible = false;

                LeftMenuBox.SetPosition(3, 238);
                LeftMenuBox.SetSize(162, 238);
                LeftMenuBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                LeftMenuBox.Visible = false;

                EventBox_1.SetPosition(778, 110);
                EventBox_1.SetSize(78, 40);
                EventBox_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EventBox_1.Visible = true;

                BuildingsTabUnfocus.SetPosition(242, 378);
                BuildingsTabUnfocus.SetSize(64, 28);
                BuildingsTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabUnfocus.Visible = true;

                BuildingsTabFocus.SetPosition(242, 378);
                BuildingsTabFocus.SetSize(64, 28);
                BuildingsTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabFocus.Visible = false;

                RecruitTabUnfocus.SetPosition(314, 378);
                RecruitTabUnfocus.SetSize(64, 28);
                RecruitTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RecruitTabUnfocus.Visible = false;

                RecruitTabFocus.SetPosition(314, 378);
                RecruitTabFocus.SetSize(64, 28);
                RecruitTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RecruitTabFocus.Visible = false;

                OfficersTabFocus.SetPosition(170, 378);
                OfficersTabFocus.SetSize(64, 28);
                OfficersTabFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabFocus.Visible = false;

                OfficersTabUnfocus.SetPosition(170, 378);
                OfficersTabUnfocus.SetSize(64, 28);
                OfficersTabUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabUnfocus.Visible = true;

                MiniMap.SetPosition(710, 0);
                MiniMap.SetSize(145, 116);
                MiniMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MiniMap.Visible = true;

                BottomMenuBar.SetPosition(140, 377);
                BottomMenuBar.SetSize(712, 105);
                BottomMenuBar.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuBar.Visible = true;

                OfficersTabTop.SetPosition(174, 378);
                OfficersTabTop.SetSize(60, 8);
                OfficersTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OfficersTabTop.Visible = false;

                BuildingsTabTop.SetPosition(246, 378);
                BuildingsTabTop.SetSize(60, 8);
                BuildingsTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BuildingsTabTop.Visible = false;

                RecruitTabTop.SetPosition(318, 378);
                RecruitTabTop.SetSize(60, 8);
                RecruitTabTop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RecruitTabTop.Visible = false;

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

                RedRect_1.SetPosition(138, 408);
                RedRect_1.SetSize(262, 70);
                RedRect_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                RedRect_1.Visible = false;

                BottomMenuExtra.SetPosition(382, 337);
                BottomMenuExtra.SetSize(312, 63);
                BottomMenuExtra.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuExtra.Visible = false;

                BlackSmith.SetPosition(155, 404);
                BlackSmith.SetSize(82, 66);
                BlackSmith.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BlackSmith.Visible = false;

                AidenPortrait.SetPosition(154, 415);
                AidenPortrait.SetSize(82, 51);
                AidenPortrait.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                AidenPortrait.Visible = false;

                KiraPortrait.SetPosition(238, 414);
                KiraPortrait.SetSize(85, 52);
                KiraPortrait.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                KiraPortrait.Visible = false;

                CharacterOutline_1.SetPosition(151, 413);
                CharacterOutline_1.SetSize(86, 55);
                CharacterOutline_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterOutline_1.Visible = false;

                CharacterOutline_2.SetPosition(236, 414);
                CharacterOutline_2.SetSize(88, 54);
                CharacterOutline_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CharacterOutline_2.Visible = false;
				
				
//				if(TutorialMode)
//				{
//					
//                DisclaimerBoxText.SetPosition(151, 53);
//                DisclaimerBoxText.SetSize(557, 257);
//                DisclaimerBoxText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerBoxText.Visible = false;
//
//                DisclaimerContinueUnFocus.SetPosition(375, 320);
//                DisclaimerContinueUnFocus.SetSize(135, 40);
//                DisclaimerContinueUnFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerContinueUnFocus.Visible = false;
//
//                DisclaimerContinueFocus.SetPosition(375, 320);
//                DisclaimerContinueFocus.SetSize(135, 40);
//                DisclaimerContinueFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerContinueFocus.Visible = false;
//
//                TutBackUnfocus.SetPosition(160, 315);
//                TutBackUnfocus.SetSize(135, 40);
//                TutBackUnfocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutBackUnfocus.Visible = false;
//
//                TutBackFocus.SetPosition(160, 315);
//                TutBackFocus.SetSize(135, 40);
//                TutBackFocus.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutBackFocus.Visible = false;
//
//                TutOfficerArrow.SetPosition(177, 321);
//                TutOfficerArrow.SetSize(50, 50);
//                TutOfficerArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutOfficerArrow.Visible = false;
//
//                TutBuildingArrow.SetPosition(251, 319);
//                TutBuildingArrow.SetSize(50, 50);
//                TutBuildingArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutBuildingArrow.Visible = false;
//
//                TutRecruitArrow.SetPosition(326, 321);
//                TutRecruitArrow.SetSize(50, 50);
//                TutRecruitArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutRecruitArrow.Visible = false;
//				
//					
//				TutEventsArrow.SetPosition(723, 176);
//                TutEventsArrow.SetSize(50, 50);
//                TutEventsArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutEventsArrow.Visible = false;
//
//                TutLeftMenuArrow.SetPosition(142, 273);
//                TutLeftMenuArrow.SetSize(50, 50);
//                TutLeftMenuArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutLeftMenuArrow.Visible = false;
//					
//				TutOptionsRedRect.SetPosition(303, 0);
//                TutOptionsRedRect.SetSize(243, 87);
//                TutOptionsRedRect.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutOptionsRedRect.Visible = false;
//
//                TutOptionsArrow.SetPosition(395, 94);
//                TutOptionsArrow.SetSize(50, 50);
//                TutOptionsArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutOptionsArrow.Visible = false;	
//					
//				 TutorialBox.SetPosition(4, 5);
//                TutorialBox.SetSize(297, 158);
//                TutorialBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialBox.Visible = false;
//
//                Tutorialtext.SetPosition(10, 14);
//                Tutorialtext.SetSize(282, 110);
//                Tutorialtext.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                Tutorialtext.Visible = false;
//
//                TutorialContinueOff.SetPosition(216, 128);
//                TutorialContinueOff.SetSize(73, 25);
//                TutorialContinueOff.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialContinueOff.Visible = false;
//
//                TutorialContinueOn.SetPosition(216, 128);
//                TutorialContinueOn.SetSize(73, 25);
//                TutorialContinueOn.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialContinueOn.Visible = false;	
//				
//				TutorialContinueButton.SetPosition(212, 121);
//                TutorialContinueButton.SetSize(80, 41);
//                TutorialContinueButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutorialContinueButton.Visible = false;
//
//                tutGUIArrow.SetPosition(770, 324);
//                tutGUIArrow.SetSize(50, 50);
//                tutGUIArrow.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                tutGUIArrow.Visible = false;
//
//                TutGUIRect.SetPosition(733, 380);
//                TutGUIRect.SetSize(118, 100);
//                TutGUIRect.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                TutGUIRect.Visible = false;	
//				
//				DisclaimerContinueButton.SetPosition(374, 321);
//                DisclaimerContinueButton.SetSize(135, 38);
//                DisclaimerContinueButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
//                DisclaimerContinueButton.Visible = false;
//				
//				}

                WorldMap.SetPosition(649, 22);
                WorldMap.SetSize(50, 50);
                WorldMap.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                WorldMap.Visible = false;

                

                OptionsBox.SetPosition(163, 29);
                OptionsBox.SetSize(524, 338);
                OptionsBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsBox.Visible = false;

                OptionsTutorialOnorOff.SetPosition(325, 80);
                OptionsTutorialOnorOff.SetSize(214, 36);
                OptionsTutorialOnorOff.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsTutorialOnorOff.Visible = false;

               

                ShowOptions.SetPosition(287, 3);
                ShowOptions.SetSize(246, 96);
                ShowOptions.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ShowOptions.Visible = true;

                btnOfficersTab.SetPosition(169, 377);
                btnOfficersTab.SetSize(64, 28);
                btnOfficersTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnOfficersTab.Visible = true;

                btnBuildingsTab.SetPosition(241, 380);
                btnBuildingsTab.SetSize(64, 28);
                btnBuildingsTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnBuildingsTab.Visible = true;

                btnRecruitTab.SetPosition(316, 378);
                btnRecruitTab.SetSize(64, 28);
                btnRecruitTab.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnRecruitTab.Visible = false;

                BottomMenuButton_1.SetPosition(157, 419);
                BottomMenuButton_1.SetSize(77, 44);
                BottomMenuButton_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_1.Visible = false;

                BottomMenuButton_2.SetPosition(245, 418);
                BottomMenuButton_2.SetSize(75, 46);
                BottomMenuButton_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BottomMenuButton_2.Visible = false;
				
			
				
              

                QUITDEMO.SetPosition(332, 206);
                QUITDEMO.SetSize(214, 56);
                QUITDEMO.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                QUITDEMO.Visible = false;

                OptionsCheck.SetPosition(409, 135);
                OptionsCheck.SetSize(56, 56);
                OptionsCheck.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsCheck.Visible = false;

                OptionsCloseButton.SetPosition(331, 279);
                OptionsCloseButton.SetSize(214, 56);
                OptionsCloseButton.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                OptionsCloseButton.Visible = false;

                CloseGUI.SetPosition(738, 382);
                CloseGUI.SetSize(110, 93);
                CloseGUI.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CloseGUI.Visible = true;
               

                ScreenVignette.SetPosition(0, 0);
                ScreenVignette.SetSize(852, 479);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;

                

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            OptionsTutorialOnorOff.Text = "Tutorial on/off";
            QUITDEMO.Text = "QUIT DEMO";
            OptionsCloseButton.Text = "CLOSE";
            
//			if(TutorialMode)
//			Tutorialtext.Text = "label";
//            this.Title = "MainGUI";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    DialogueBox.Visible = false;
                    LeftMenuBox.Visible = false;
                    EventBox_1.Visible = false;
                    BuildingsTabUnfocus.Visible = false;
                    BuildingsTabFocus.Visible = false;
                    RecruitTabUnfocus.Visible = false;
                    RecruitTabFocus.Visible = false;
                    OfficersTabFocus.Visible = false;
                    OfficersTabUnfocus.Visible = false;
                    MiniMap.Visible = false;
                    BottomMenuBar.Visible = false;
                    OfficersTabTop.Visible = false;
                    BuildingsTabTop.Visible = false;
                    RecruitTabTop.Visible = false;
                    EventBox_2.Visible = false;
                    EventBox_3.Visible = false;
                    EventBox_4.Visible = false;
                    EventBox_5.Visible = false;
                    EventBox_6.Visible = false;
                    EventBox_7.Visible = false;
                    EventBox_8.Visible = false;
                    
//				if(TutorialMode)
//					{
//					DisclaimerBoxText.Visible = false;
//                    DisclaimerContinueUnFocus.Visible = false;
//                    DisclaimerContinueFocus.Visible = false;
//                    TutBackUnfocus.Visible = false;
//                    TutBackFocus.Visible = false;
//					}
//					
					btnOfficersTab.Visible = false;
                    btnBuildingsTab.Visible = false;
                    btnRecruitTab.Visible = false;
                    ScreenVignette.Visible = false;
                }
                break;

                default:
                {
                    EventBox_1.Visible = false;
                    BuildingsTabUnfocus.Visible = false;
                    OfficersTabUnfocus.Visible = false;
                    MiniMap.Visible = false;
                    BottomMenuBar.Visible = false;
                    EventBox_2.Visible = false;
                    EventBox_3.Visible = false;
                    EventBox_4.Visible = false;
                    EventBox_5.Visible = false;
                    EventBox_6.Visible = false;
                    EventBox_7.Visible = false;
                    EventBox_8.Visible = false;
                    btnOfficersTab.Visible = false;
                    btnBuildingsTab.Visible = false;
                    ScreenVignette.Visible = false;
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
                        Widget = EventBox_1,
                        MoveDirection = FourWayDirection.Left,
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
                        Widget = RecruitTabUnfocus,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = RecruitTabFocus,
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
                        Widget = RecruitTabTop,
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
                    new SlideInEffect()
                    {
                        Widget = DisclaimerBoxText,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = DisclaimerContinueUnFocus,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = DisclaimerContinueFocus,
                        MoveDirection = FourWayDirection.Down,
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
                    new SlideInEffect()
                    {
                        Widget = btnRecruitTab,
                        MoveDirection = FourWayDirection.Left,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = ScreenVignette,
                    }
                    .Start();
                }
                break;

                default:
                {
                    new SlideInEffect()
                    {
                        Widget = EventBox_1,
                        MoveDirection = FourWayDirection.Left,
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
                    new FadeInEffect()
                    {
                        Widget = ScreenVignette,
                    }
                    .Start();
                }
                break;
            }
        }
    }
}
