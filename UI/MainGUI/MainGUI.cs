using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Input;


using Sce.Pss.HighLevel.UI;
using Magnate;

namespace MagnateUI
{
    public partial class MainGUI : Scene
    {
		Game game = Game.Instance;
		
		TapGestureDetector btnBuildingsTabTG;
//		TapGestureDetector btnRecruitTabTG;
		TapGestureDetector btnOfficersTabTG;
		TapGestureDetector HideGUI;	
		TapGestureDetector ShowOptionsButtonTG;
		
		int count = 0;
		
		public static bool DialogueBoxVisible = false;
		public static bool TutorialMode = false;
		
		
		enum selectedTab {NONE,OFFICERS,BUILDINGS,RECRUIT};
		int curSelectedTab = (int)selectedTab.NONE;
		
		
        public MainGUI()
        {
            InitializeWidget();
			
			//all tabs are deselected by default
			BuildingsTabFocus.Visible = false;
			BuildingsTabTop.Visible = false;
			OfficersTabFocus.Visible = false;
			OfficersTabTop.Visible = false;
			RecruitTabTop.Visible = false;
			RecruitTabFocus.Visible = false;
			
			//dialogue box is deselected by default
			DialogueBox.Visible = false;
			
			//event-triggering buttons are transparent
			btnRecruitTab.Alpha= 0;
			btnOfficersTab.Alpha=0;
			btnBuildingsTab.Alpha=0;
			
			//register tap events
			btnBuildingsTabTG = new TapGestureDetector();
            btnBuildingsTabTG.TapDetected += btnBuildingsTabTGEventHandler;
            btnBuildingsTab.AddGestureDetector(btnBuildingsTabTG);
			
			btnOfficersTabTG = new TapGestureDetector();
            btnOfficersTabTG.TapDetected += btnOfficersTabTGEventHandler;
            btnOfficersTab.AddGestureDetector(btnOfficersTabTG);
			
//			btnRecruitTabTG = new TapGestureDetector();
//           btnRecruitTabTG.TapDetected += btnRecruitTabTGEventHandler;
//            btnRecruitTab.AddGestureDetector(btnRecruitTabTG);
			
			
			ShowOptionsButtonTG = new TapGestureDetector();
			ShowOptionsButtonTG.TapDetected += HandleShowOptionsButtonTGTapDetected;
			ShowOptions.AddGestureDetector(ShowOptionsButtonTG);
			
			HideGUI = new TapGestureDetector();
			HideGUI.TapDetected += HandleHideGUITapDetected;
			CloseGUI.AddGestureDetector(HideGUI);
			
			OptionsCheck.CheckedChanged += HandleOptionsCheckCheckedChanged;
			OptionsCloseButton.ButtonAction += HandleOptionsCloseButtonButtonAction;
			QUITDEMO.ButtonAction += HandleQUITDEMOButtonAction;
			
//			if(TutorialMode)
//			{
//			
//			TutorialContinue = new TapGestureDetector();
//			TutorialContinue.TapDetected += HandleTutContinueTapDetected;
//			TutorialContinueButton.AddGestureDetector(TutorialContinue);
//			
//			DisclaimerContinue  = new TapGestureDetector();
//			DisclaimerContinue.TapDetected += HandleDisclaimerContinueTapDetected;
//			DisclaimerContinueButton.AddGestureDetector(DisclaimerContinue);
//			}
			
			
			
        }

        void HandleDisclaimerContinueTapDetected (object sender, TapEventArgs e)
        {
        	count++;
        }

        

        void HandleTutContinueTapDetected (object sender, TapEventArgs e)
        {
			count++;
        }
		
		

        void HandleHideGUITapDetected (object sender, TapEventArgs e)
        {
			
			SceneManager.GUIFinished();
        }

        void HandleQUITDEMOButtonAction (object sender, TouchEventArgs e)
        {
        	game.Quit();
        }

        void HandleOptionsCloseButtonButtonAction (object sender, TouchEventArgs e)
        {
        	OptionsBox.Visible = false;
			OptionsCheck.Visible = false;
			OptionsCloseButton.Visible = false;
			OptionsTutorialOnorOff.Visible = false;
			QUITDEMO.Visible = false;
						
			ShowOptions.Visible = true;
			
        }
		

        void HandleOptionsCheckCheckedChanged (object sender, TouchEventArgs e)
        {
        	
			OptionsCheck.Enabled = false;
			CloseGUI.Visible = true;
			
				var chatScene = new ChatDialogueUI();
				var transition = new CrossFadeTransition();
				chatScene.Transition = transition;
				chatScene.setAiden = true;
				chatScene.setKira = true;
				
							
				UISystem.SetScene(chatScene);
			
			
        }

        

        void HandleShowOptionsButtonTGTapDetected (object sender, TapEventArgs e)
        {
        	OptionsBox.Visible = true;
			OptionsCheck.Visible = true;
			if(TutorialMode)
			{	
				OptionsCheck.Enabled = true;
				OptionsCheck.Checked = true;
			}
			OptionsCloseButton.Visible = true;
			OptionsTutorialOnorOff.Visible = true;
			QUITDEMO.Visible = true;
			
			ShowOptions.Visible = false;
			
        }
		
		void btnBuildingsTabTGEventHandler(object sender, TapEventArgs e)
        {
			if (curSelectedTab == (int)selectedTab.BUILDINGS){
				//deselects building tab
	            BuildingsTabFocus.Visible = false;
				BuildingsTabTop.Visible=false;
				
				if(!TutorialMode)
				DialogueBox.Visible = false;
				DialogueBoxVisible = false;
				BlackSmith.Visible = false;
				CharacterOutline_1.Visible = false;
				CharacterOutline_2.Visible = false;
				
				
				curSelectedTab = (int)selectedTab.NONE;
			}else{ 
				//deselects everything else
				OfficersTabTop.Visible =false;
				OfficersTabFocus.Visible = false;
				RecruitTabTop.Visible = false;
				RecruitTabFocus.Visible=false;
				AidenPortrait.Visible = false;
				KiraPortrait.Visible = false;
				
				
				
				//selects building tab
	            BuildingsTabFocus.Visible = true;
				BuildingsTabTop.Visible = true;
				//DialogueBox.Visible = true;
				BlackSmith.Visible = true;
				
				curSelectedTab = (int)selectedTab.BUILDINGS;
				
				DialogueBoxVisible = true;
			}
        }
		
		void btnOfficersTabTGEventHandler(object sender, TapEventArgs e)
        {
			if (curSelectedTab == (int)selectedTab.OFFICERS){
				//deselects officer tab
	            OfficersTabFocus.Visible = false;
				OfficersTabTop.Visible=false;
				
				if(!TutorialMode)
				DialogueBox.Visible = false;
				DialogueBoxVisible = false;
				KiraPortrait.Visible = false;
				AidenPortrait.Visible = false;
				CharacterOutline_1.Visible=false;
				CharacterOutline_2.Visible=false;
				
				curSelectedTab = (int)selectedTab.NONE;
			}else{ //selects officer tab
				//deselects everything else
				BuildingsTabTop.Visible =false;
				BuildingsTabFocus.Visible = false;
				RecruitTabTop.Visible = false;
				RecruitTabFocus.Visible=false;
				BlackSmith.Visible = false;
				
				//display proper UI
	            OfficersTabFocus.Visible = true;
				OfficersTabTop.Visible = true;
				
				DialogueBoxVisible = true;
				AidenPortrait.Visible = true;
				KiraPortrait.Visible = true;
				CharacterOutline_1.Visible = true;
				CharacterOutline_2.Visible = true;
				curSelectedTab = (int)selectedTab.OFFICERS;
			}
        }
		/*
		void btnRecruitTabTGEventHandler(object sender, TapEventArgs e)
        {
			if (curSelectedTab == (int)selectedTab.RECRUIT){
				//deselects officer tab
	            RecruitTabFocus.Visible = false;
				RecruitTabTop.Visible=false;
				DialogueBox.Visible = false;
				DialogueBoxVisible = false;
				curSelectedTab = (int)selectedTab.NONE;
			}else{ //selects officer tab
				//deselects everything else
				OfficersTabTop.Visible =false;
				OfficersTabFocus.Visible = false;
				BuildingsTabTop.Visible = false;
				BuildingsTabFocus.Visible=false;
				
				//display proper UI
	            RecruitTabFocus.Visible = true;
				RecruitTabTop.Visible = true;
				DialogueBox.Visible = true;
				DialogueBoxVisible = true;
				curSelectedTab = (int)selectedTab.RECRUIT;
			}
			
        }
		*/
		public void HideDialogueBox()
		{
				OfficersTabTop.Visible =false;
				OfficersTabFocus.Visible = false;
				BuildingsTabTop.Visible = false;
				BuildingsTabFocus.Visible=false;
				RecruitTabTop.Visible = false;
				RecruitTabFocus.Visible=false;
				DialogueBox.Visible = false;
				AidenPortrait.Visible = false;
				KiraPortrait.Visible = false;
				CharacterOutline_1.Visible = false;
				CharacterOutline_2.Visible = false;
				if(!TutorialMode)
				DialogueBoxVisible = false;
				BlackSmith.Visible = false;
		}
		
//		public void Tutorial()
//		{
//			
//			
//						
//			switch(count)
//			{
//			case 0:
//				DisclaimerBoxText.Text = "Welcome to the Magnate demo created with the Playstation\u2122 Suite SDK beta version .97. " +
//					"This demo was created by Dominion Art        Studio\u2122 (refered hereafter as DAS) and all code was programmed  within 12 days using only the tools " +
//					 "provided within the SDK itself by two programmers selected by Sony to be apart of the SDK's closed beta. All rights to Magnate and all rights to Sony software" +
//					 " belong   to their own respective parties. DAS claims no ownership to            Playstation\u2122 Suite or any other Sony Computer Entertainment\u2122 " +
//					 "      held intellectual property and/or copyrights. Now with all that legal mumbo jumbo behind us; The entire team that makes up DAS        sincerely hopes you enjoy our demo of Magnate\u2122 and look forward to seeing the official release coming soon later this year.";
//					
//				DialogueBox.Visible = true;
//				DisclaimerBoxText.Visible = true;
//				DisclaimerContinueUnFocus.Visible = true;
//				DisclaimerContinueFocus.Visible = true;
//				DisclaimerContinueButton.Visible = true;
//				
//				CloseGUI.Visible = false;
//				
//				break;
//				
//			case 1:
//								
//				Tutorialtext.Text = "Magnate is a strategy RPG that    blends turn based table top        strategy RPGs with a more Online RPG dynamic system in regards   to quests and combat.";
//				DisclaimerBoxText.Visible = false;
//				DisclaimerContinueFocus.Visible = false;
//				DisclaimerContinueUnFocus.Visible = false;
//				DisclaimerContinueButton.Visible = false;
//				DialogueBox.Visible = false;
//				
//				TutorialBox.Visible = true;
//				Tutorialtext.Visible = true;
//				TutorialContinueOff.Visible = true;
//				TutorialContinueOn.Visible = true;
//				TutorialContinueButton.Visible = true;
//				
//				
//				break;
//			case 2:
//				Tutorialtext.Text = "At any point in this tutorial, you can exit out of the tutorial or the demo by touching the top of the screen and clicking the check button.";
//				TutOptionsRedRect.Visible = true;
//				TutOptionsArrow.Visible = true;
//				
//				break;	
//			case 3:
//				TutOptionsArrow.Visible = false;
//				TutOptionsRedRect.Visible = false;
//				
//				Tutorialtext.Text = "Also for future consideration when the tutorial is complete, taping the lower right hand of the screen opens and closes the GUI.";
//				TutGUIRect.Visible = true;
//				tutGUIArrow.Visible = true;
//				
//				
//				
//				break;	
//			case 4:
//				TutGUIRect.Visible = false;
//				tutGUIArrow.Visible = false;
//				
//				Tutorialtext.Text = " A further note regarding the options is that it will only activate " +
//					"when the GUI is open.";
//				
//				break;	
//			case 5:
//				
//					Tutorialtext.Text = "Now to explain the basic game mechanics. On the world map you will " +
//						"see different map pieces.";
//				
//				break;	
//			case 6:
//					Tutorialtext.Text = " Each peice represents either a mine cave, a mine drill, a lumber mill. " +
//						"or a stronghold(aka towns).";
//				
//				break;	
//			case 7:
//					Tutorialtext.Text = "These peieces will be typically controlled by your enemy. " +
//						"For which you will have to take by force.";
//				
//				break;	
//			case 8: 
//				Tutorialtext.Text = "Each peiece that you control will generate resources that can " +
//					"be used for crafting armor, " +
//					"upgrading your map pieces and constructing buildings inside your controlled strongholds";
//					
//				break;	
//			case 9:
//				Tutorialtext.Text = "When the game starts, you will want to start by clicking the first strong hold. In which a screen will pop up showing the inside of the town.";
//				
//				
//				break;	
//			case 10:
//				
//				Tutorialtext.Text = "In this screen you will see that there is an empty plot of land. If you select your buildings tab you will see that you have a free blacksmith courtesy of the generous folks at DAS";
//				
//				break;	
//			case 11:
//				Tutorialtext.Text = "During the game you will click on the plot, and then click on the building in your menu to build it.";
//				
//				break;	
//			case 12:
//				Tutorialtext.Text ="During the game you may then click on the building and enter it to help the blacksmith.";
//				
//				break;	
//			case 13:
//				Tutorialtext.Text ="The officer tab will display your character portraits. In the official release these menus will include things like armor and skill trees.";
//				
//				break;	
//			case 14:
//				Tutorialtext.Text ="However due to time constraits, they only contain each characters bio.";
//				break;	
//			case 15:
//				Tutorialtext.Text ="Combat is real time, and thus we have an auto attack feature. You can click on the skill icons to use cooldown abilities.";
//				
//				break;	
//			case 16:
//				Tutorialtext.Text ="At this point I would say its relatively safe to let go of the reins and let you try out a very aplha version of Magnate. :) "; 
//				
//				break;	
//			case 17:
//				Tutorialtext.Text ="Also please ignore any bugs that you may come across, unless you are intentionally trying to break our game. Then have fun. :) Enjoy the rest of your time at GDC. ";			
//				break;	
//			
//			}
//		}
		
		
    }
}
