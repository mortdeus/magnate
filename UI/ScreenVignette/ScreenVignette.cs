#undef DEBUG
using System;
using System.Collections.Generic;
using System.Timers;

using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;
using Magnate;

namespace MagnateUI
{
	public enum MapPieceSelected
	{
		NONE,
		STARTINGTOWN,
		TOWN2,
		TOWN3,
		BOSSTOWN,
		LUMBERMILL1,
		LUMBERMILL2,
		MINE
	};

	public enum LocatedAt
	{
		LUMBERMILL1,
		STARTINGTOWN,
		TOWN2,
		TOWN3,
		BOSSTOWN,
		LUMBERMILL2,
		MINE
	};

	public enum ActiveCharacter
	{
		KIRA,
		AIDEN
	};
	
	public partial class ScreenVignette : Scene
	{
		#region vars
		TapGestureDetector showGUI;
		TapGestureDetector StartingTownTGD;
		TapGestureDetector Town2TGD;
		TapGestureDetector Town3TGD;
		TapGestureDetector BossTownTGD;
		TapGestureDetector LumberMill1TGD;
		TapGestureDetector LumberMill2TGD;
		TapGestureDetector IronMineTGD;
		TapGestureDetector ContinueTGD;
		static bool startingtownowned = false;
		static bool town2owned = false;
		static bool town3owned = false;
		static bool bosstownowned = false;
		static bool lumbermill1owned = true;
		static bool lumbermill2owned = false;
		static bool mineowned = false;
		static bool HasSword = false;
		static bool HasQuest = false;
		static bool characterdialoguefired = false;
		static bool disablebuttons = false;
		static bool democomplete = false;
		static int IAmHere = 0;
		static int IAmlookingAt = 0;
		MainGUI gui;
		#endregion
		
		public ScreenVignette ()
		{
			InitializeWidget ();
			
			
			
			
			
						
			showGUI = new TapGestureDetector ();
			showGUI.TapDetected += ShowGUIEvent;
			ShowGUI.AddGestureDetector (showGUI);
			
			StartingTownTGD = new TapGestureDetector ();
			StartingTownTGD.TapDetected += HandleTapDetected;
			StartingTownButton.AddGestureDetector (StartingTownTGD);
			
			Town2TGD = new TapGestureDetector ();
			Town2TGD.TapDetected += HandleTapDetected;
			StrongHold2Button.AddGestureDetector (Town2TGD);
			
			Town3TGD = new TapGestureDetector ();
			Town3TGD.TapDetected += HandleTapDetected;
			Town3Button.AddGestureDetector (Town3TGD);
			
			BossTownTGD = new TapGestureDetector ();
			BossTownTGD.TapDetected += HandleTapDetected;
			BossTownButton.AddGestureDetector (BossTownTGD);
			
			LumberMill1TGD = new TapGestureDetector ();
			LumberMill1TGD.TapDetected += HandleTapDetected;
			LumberMill1Button.AddGestureDetector (LumberMill1TGD);
			
			LumberMill2TGD = new TapGestureDetector ();
			LumberMill2TGD.TapDetected += HandleTapDetected;
			LumberMill2Button.AddGestureDetector (LumberMill2TGD);
			
			IronMineTGD = new TapGestureDetector ();
			IronMineTGD.TapDetected += HandleTapDetected;
			IronMineButton.AddGestureDetector (IronMineTGD);
			
			ContinueTGD = new TapGestureDetector ();
			ContinueTGD.TapDetected += HandleTapDetected;
			Continue.AddGestureDetector (ContinueTGD);
			
			GotoButton.ButtonAction += HandleGotoButtonButtonAction;
			Visit.ButtonAction += HandleVisitButtonAction;
			Close.ButtonAction += HandleCloseButtonAction;
			
			UpdateIAmHere ();
			
		}

		void HandleVisitButtonAction (object sender, TouchEventArgs e)
		{
			clearinterface();
			
			switch(IAmHere){
			case (int)LocatedAt.STARTINGTOWN:
			
				if(!HasQuest){
					if(!democomplete)
					{
					SceneManager.PushChatScene((int)GE2D.DESTOWN);
					
					HasQuest = true;
					Console.WriteLine(HasQuest);
					
					if(mineowned)
					{
						startingtownowned = true;
						lumbermill2owned = true;
					}
						
					if(town3owned)
							
						HasSword = true;
						Console.WriteLine(HasSword);
					}
				else	
					if(bosstownowned)
					{
						democomplete = true;
						SceneManager.PushChatScene((int)GE2D.GOODTOWN);
					}
						
					}				
				StartCutscene();
				break;
			
			
			
			case (int)LocatedAt.BOSSTOWN:
								
				
				SceneManager.PushChatScene((int)GE2D.FINAL);
				
				StartCutscene();	
				
				
				
				break;
				
			case(int)LocatedAt.MINE:
				
				SceneManager.PushChatScene((int)GE2D.MINE);
				
				mineowned = true;
				HasQuest = false;
						
				StartCutscene();
				
				break;
			
			case(int)LocatedAt.TOWN2:
				
				SceneManager.PushChatScene((int)GE2D.FORT);
				
				town2owned = true;
				HasQuest = false;
				
				StartCutscene();
				break;
			case(int)LocatedAt.TOWN3:
				SceneManager.PushChatScene((int)GE2D.FORT);
				
				town3owned = true;
				HasQuest = false;
				
				StartCutscene();	
			
				break;
					
				
			
			}	
		}

		void HandleCloseButtonAction (object sender, TouchEventArgs e)
		{
			resetlookatarrows ();
			UpdateIAmHere ();
			clearinterface ();
		}

		void HandleGotoButtonButtonAction (object sender, TouchEventArgs e)
		{
			
//#if DEBUG
//			Console.WriteLine ("Handle Go to button pre");
//			Console.WriteLine ("Startown \t\t\t" + startingtownowned);
//			Console.WriteLine ("town2owned \t\t\t" + town2owned);
//			Console.WriteLine ("town3owned \t\t\t" + town3owned);
//			Console.WriteLine ("bosstownowned \t\t\t" + bosstownowned);
//			Console.WriteLine ("lumbermill1owned\t\t\t" + lumbermill1owned);
//			Console.WriteLine ("lumbermill2owned\t\t\t" + lumbermill2owned);
//			Console.WriteLine ("mineowned\t\t\t" + mineowned);
//			Console.WriteLine ("HasSword\t\t\t" + HasSword);
//			Console.WriteLine ("HasQuest\t\t\t" + HasQuest);
//			Console.WriteLine ("characterdialoguefired\t\t\t" + characterdialoguefired);
//			Console.WriteLine ("disablebuttons\t\t\t" + disablebuttons);
//			Console.WriteLine ("democomplete\t\t\t" + democomplete);
//			Console.WriteLine ("IAmHere\t\t\t" + IAmHere);
//			Console.WriteLine ("IAmlookingAt\t\t\t" + IAmlookingAt);
//#endif
			
			GotoButton.Visible = false;
			
			switch (IAmlookingAt) {
			
			case (int)MapPieceSelected.BOSSTOWN:
				
				if (IAmHere == (int)LocatedAt.STARTINGTOWN)
				{
					if(HasQuest)
					if (startingtownowned & town2owned & town3owned & mineowned & lumbermill2owned & lumbermill1owned & HasSword)
					{					
						IAmHere = (int)LocatedAt.BOSSTOWN;
					
						UpdateIAmHere();
					}
					else if(bosstownowned)
					{	
						IAmHere = (int)LocatedAt.BOSSTOWN;
						UpdateIAmHere();
					}
					else 
						CharacterDialogue ();
				}
				else 
					CharacterDialogue();
				break;
				
			case (int)MapPieceSelected.LUMBERMILL1:
				
				if (IAmHere == (int)LocatedAt.STARTINGTOWN)
				{
					IAmHere = (int)LocatedAt.LUMBERMILL1;
					UpdateIAmHere();
				}
				else
					CharacterDialogue ();		
				
				break;
					
			case (int)MapPieceSelected.LUMBERMILL2:
				if (IAmHere == (int)LocatedAt.STARTINGTOWN) {
					if (mineowned)
					{
						IAmHere = (int)LocatedAt.LUMBERMILL2;
						UpdateIAmHere();
					}
					else
						CharacterDialogue ();
				} else
					CharacterDialogue ();		
				
				break;
								
			case (int)MapPieceSelected.MINE:
				if (IAmHere == (int)LocatedAt.STARTINGTOWN) {
					if (HasQuest | mineowned)
					{
						IAmHere = (int)LocatedAt.MINE;
						UpdateIAmHere();
					}
					else
						CharacterDialogue ();		
				
				} else
					CharacterDialogue ();		
				
				break;
				
				
			case (int)MapPieceSelected.STARTINGTOWN:
				IAmHere = (int)LocatedAt.STARTINGTOWN;
				UpdateIAmHere();
				
				break;
			case (int)MapPieceSelected.TOWN2:
				if (IAmHere == (int)LocatedAt.STARTINGTOWN) {
					if (HasQuest)
					{
						if(startingtownowned)
						{
							IAmHere = (int)LocatedAt.TOWN2;
							UpdateIAmHere();
						}
					}
					else if (town2owned)
					{
						IAmHere = (int)LocatedAt.TOWN2;
						UpdateIAmHere();
					}
					else
						CharacterDialogue ();		
				}
				else if (IAmHere == (int)LocatedAt.TOWN3) 
				{
					IAmHere = (int)LocatedAt.TOWN2;
					UpdateIAmHere();
				} 
				else
					CharacterDialogue ();		
			
				break;
				
			case (int)MapPieceSelected.TOWN3:
				if (IAmHere == (int)LocatedAt.STARTINGTOWN) {
					if (HasQuest)
						if(town2owned)
					{
						IAmHere = (int)LocatedAt.TOWN3;
						UpdateIAmHere();
					}
					else if (town3owned)
					{
						IAmHere = (int)LocatedAt.TOWN3;
						UpdateIAmHere();
					}
					else
						CharacterDialogue ();		
				
				} else if (IAmHere == (int)LocatedAt.TOWN2) {
					if (HasQuest)
					{
						IAmHere = (int)LocatedAt.TOWN3;
						UpdateIAmHere();
					}
					else if (town3owned)
					{
						IAmHere = (int)LocatedAt.TOWN3;
						UpdateIAmHere();
					}
					else
						CharacterDialogue ();		
				
					
				} else
					CharacterDialogue ();		
				
				break;
				
			}
			
			if (!characterdialoguefired) {
				resetlookatarrows ();
				clearinterface ();
			}
			
//			#if DEBUG
//			Console.WriteLine ("Handle Go to button post");
//			
//			Console.WriteLine ("Startown \t\t\t" + startingtownowned);
//			Console.WriteLine ("town2owned \t\t\t" + town2owned);
//			Console.WriteLine ("town3owned \t\t\t" + town3owned);
//			Console.WriteLine ("bosstownowned \t\t\t" + bosstownowned);
//			Console.WriteLine ("lumbermill1owned\t\t\t" + lumbermill1owned);
//			Console.WriteLine ("lumbermill2owned\t\t\t" + lumbermill2owned);
//			Console.WriteLine ("mineowned\t\t\t" + mineowned);
//			Console.WriteLine ("HasSword\t\t\t" + HasSword);
//			Console.WriteLine ("HasQuest\t\t\t" + HasQuest);
//			Console.WriteLine ("characterdialoguefired\t\t\t" + characterdialoguefired);
//			Console.WriteLine ("disablebuttons\t\t\t" + disablebuttons);
//			Console.WriteLine ("democomplete\t\t\t" + democomplete);
//			Console.WriteLine ("IAmHere\t\t\t" + IAmHere);
//			Console.WriteLine ("IAmlookingAt\t\t\t" + IAmlookingAt);
//			#endif
			
		}

		void HandleTapDetected (object sender, TapEventArgs e)
		{
			
			resetlookatarrows ();
						
			CharacterBox.Visible = true;
			PieceTypeText.Visible = true;
			PieceInfoText.Visible = true;
			GotoButton.Visible = true;
			Visit.Visible = false;
			Close.Visible = true;			
			
			#if DEBUG
			Console.WriteLine ("Handle Tap Detected");
			
			Console.WriteLine ("IAmHere\t\t\t" + IAmHere);
			Console.WriteLine ("IAmlookingAt\t\t\t" + IAmlookingAt);
			#endif
			
			
			if (e.Source.Equals (StartingTownButton)) {
				
				PieceTypeText.Text = "My Hometown";
				PieceInfoText.Text = "This town is where the hero and heroine grew up. They havent been home in quite awhile...";
				
				IAmlookingAt = (int)MapPieceSelected.STARTINGTOWN;
				
				Visit.Visible = false;
				
				if (IAmHere != (int)LocatedAt.STARTINGTOWN)
				{
					if (!StartingTownArrow.Visible)	
						StartingTownArrow.Visible = true;
				}
				else
				{
					StartingTownArrow.Visible = false;
					GotoButton.Visible = false;
					
					if(!HasQuest)
						if(!Visit.Visible)
							Visit.Visible = true;
					
							
				}
				
				
				
			}
			if (e.Source.Equals (LumberMill1Button)) {
				PieceTypeText.Text = "LumberMill lvl1";
				PieceInfoText.Text = "This is the default lumber mill you start with. For the demo none of the resources produce anything, they are purely points you need to conquer.";
				
				IAmlookingAt = (int)MapPieceSelected.LUMBERMILL1;
						
				if (IAmHere != (int)LocatedAt.LUMBERMILL1)
				{
					if (!LumberMillArrow1.Visible)
						LumberMillArrow1.Visible = true;
					else
						LumberMillArrow1.Visible = false;
				}
				else
					GotoButton.Visible = false;
				
				
			}
			if (e.Source.Equals (LumberMill2Button)) {
				PieceTypeText.Text = "LumberMill lvl2";
				PieceInfoText.Text = "This is a level two version of the lumber mill. Eventually it will generate even more resources for crafting, however currently its just an aesthetic.";  
					
				IAmlookingAt = (int)MapPieceSelected.LUMBERMILL2;
				
				if (IAmHere != (int)LocatedAt.LUMBERMILL2)
				{
					if (!LumberMillArrow2.Visible)
						LumberMillArrow2.Visible = true;
					else
						LumberMillArrow2.Visible = false;
				}
				else
					GotoButton.Visible = false;
			}
			
			
			if (e.Source.Equals (IronMineButton)) {
				PieceTypeText.Text = "IronMineDrill";
				PieceInfoText.Text = "This is an iron mine. In future versions we will be able to craft different armors and weapons with ore at the blacksmith.";
				
				IAmlookingAt = (int)MapPieceSelected.MINE;
				if (IAmHere != (int)LocatedAt.MINE)
				{
					if (!IronMineArrow.Visible)
						IronMineArrow.Visible = true;
					else
						IronMineArrow.Visible = false;
				}
				else{
					GotoButton.Visible = false;
					if(HasQuest)
						if(!mineowned)
							if(!Visit.Visible)	
								Visit.Visible = true;
					}
			}
			
			if (e.Source.Equals (BossTownButton)) {
				PieceTypeText.Text = "Final Stronghold";
				PieceInfoText.Text = "This is the last strong hold in the game for us to conquer. The last boss awaits!";
					
				IAmlookingAt = (int)MapPieceSelected.BOSSTOWN;
				if (IAmHere != (int)LocatedAt.BOSSTOWN)
				{	
					
					if (!BossTownArrow.Visible)
						BossTownArrow.Visible = true;
				}
				else
				{
					BossTownArrow.Visible = false;
					GotoButton.Visible = false;
					
					if(HasQuest)
						if(HasSword)
							if(!Visit.Visible)
								Visit.Visible = true;	
				}
				
			}
			
			if (e.Source.Equals (StrongHold2Button)) {
				PieceTypeText.Text = "StrongHold2";
				PieceInfoText.Text = "This is the second stronghold. It holds necessary resource map pieces you need to finish your quest.";
				
				IAmlookingAt = (int)MapPieceSelected.TOWN2;
				
				Visit.Visible = false;
				if (IAmHere != (int)LocatedAt.TOWN2)
				{
					if (!TownArrow2.Visible)	
						TownArrow2.Visible = true;
					else
						TownArrow2.Visible = false;
				}
				else
				{
					GotoButton.Visible = false;
				
					if(HasQuest)
						if(!Visit.Visible)
								Visit.Visible = true;
				}
			}
			if (e.Source.Equals (Town3Button)) {
				PieceTypeText.Text = "StrongHold3";
				PieceInfoText.Text = "This is the third strong hold and like the other two, it holds different types of resources from the others.";
				
				IAmlookingAt = (int)MapPieceSelected.TOWN3;
				
				Visit.Visible = false;
				if (IAmHere != (int)LocatedAt.TOWN3)
				{
					if (!TownArrow3.Visible)
						TownArrow3.Visible = true;
					else
						TownArrow3.Visible = false;
				}
				else
				{
					GotoButton.Visible = false;
				
					if(HasQuest)
						if(!Visit.Visible)
								Visit.Visible = true;
				}
				
				
			}
			if (e.Source.Equals (Continue)) {
				clearinterface ();
				DisableOrEnableButtons (true);
				UpdateIAmHere ();
				characterdialoguefired = false;
			}
			
		}
		
		public void UpdateIAmHere ()
		{
#if DEBUG
			Console.WriteLine ("Pre UpdateIamHere");
			Console.WriteLine ("IAmHere\t\t\t" + IAmHere);
			Console.WriteLine ("IAmlookingAt\t\t\t" + IAmlookingAt);
#endif
			
			AtStartingTown.Visible = false;
			AtTown2.Visible = false;
			AtTown3.Visible = false;
			AtStartingTown.Visible = false;
			AtBossTown.Visible = false;
			AtLumberMill1.Visible = false;
			AtLumberMill2.Visible = false;
			AtIronMine.Visible = false;
			
			if (IAmHere == (int)LocatedAt.STARTINGTOWN)
				AtStartingTown.Visible = true;
			if (IAmHere == (int)LocatedAt.TOWN2)
				AtTown2.Visible = true;
			if (IAmHere == (int)LocatedAt.TOWN3)
				AtTown3.Visible = true;
			if (IAmHere == (int)LocatedAt.BOSSTOWN)
				AtBossTown.Visible = true;
			if (IAmHere == (int)LocatedAt.LUMBERMILL1)
				AtLumberMill1.Visible = true;
			if (IAmHere == (int)LocatedAt.LUMBERMILL2)
				AtLumberMill2.Visible = true;
			if (IAmHere == (int)LocatedAt.MINE)
				AtIronMine.Visible = true;
			
			clearinterface();
			
			#if DEBUG
			Console.WriteLine ("Post UpdateIAmHere"); 
			
			Console.WriteLine ("IAmHere\t\t\t" + IAmHere);
			Console.WriteLine ("IAmlookingAt\t\t\t" + IAmlookingAt);
			#endif
			
		}
		
		void ShowGUIEvent (object sender, TapEventArgs e)
		{
			SceneManager.PushUIScene((int)UI.GUI,0);
		}
		
		void CharacterDialogue ()
		{
			DisableOrEnableButtons (false);
			
			Close.Visible = false;
			Visit.Visible = false;
			
			Random rand;
			
			characterdialoguefired = true;
			
			int seed = System.DateTime.Now.Second;
			
			rand = new Random (seed);
			
			PieceInfoText.Visible = false;
			PieceTypeText.Visible = false;
			
			switch (IAmlookingAt) {
			
			case (int)MapPieceSelected.BOSSTOWN:
				if (IAmHere != (int)LocatedAt.STARTINGTOWN) {
					TextBoxText.Text = "Thats too far";
					
				} else {
					TextBoxText.Text = "We are not strong enough to go there yet.";
					
				}
				SetUpScene (rand.Next (1, 100));
				break;	
			
			case (int)MapPieceSelected.LUMBERMILL1:
				TextBoxText.Text = "Thats too far away, we need to move closer";
				SetUpScene (rand.Next (1, 100));
				
				break;	
			case (int)MapPieceSelected.LUMBERMILL2:
				
				if (IAmHere != (int)LocatedAt.STARTINGTOWN) {
					TextBoxText.Text = "Thats way too far to reach from here";
					
				} else if (!startingtownowned) {
					TextBoxText.Text = "We Should go see the blacksmith first in town.";
				}					
				
				SetUpScene (rand.Next (1, 100));
				break;
			case (int)MapPieceSelected.MINE:
				if (IAmHere != (int)LocatedAt.STARTINGTOWN) {
					TextBoxText.Text = "Thats way too far to reach from here";
					
				}
				
				if (!HasQuest) {
					TextBoxText.Text = "We need stronger weapons first. Lets see the blacksmith";
					
				}
				
				SetUpScene (rand.Next (1, 100));
				break;
			case (int)MapPieceSelected.TOWN2:
				if (IAmHere == (int)LocatedAt.STARTINGTOWN) {
					if (!startingtownowned)
					if (!HasQuest)

						TextBoxText.Text = "We need to finish our current mission first";
					
				} else {
					TextBoxText.Text = "We cant travel that far without rest.";
				}
						
				SetUpScene (rand.Next (1, 100));
				
			
				
				break;
			case (int)MapPieceSelected.TOWN3:
				
				if (IAmHere == (int)LocatedAt.STARTINGTOWN) {
					if (!town2owned)						
					if (!HasQuest)
						TextBoxText.Text = "We need to finish our current mission first";
					
				} else if (IAmHere == (int)LocatedAt.TOWN2) {
					if (!HasQuest)
					
						TextBoxText.Text = "We need to go report back to the blacksmith";
					
				} else
					TextBoxText.Text = "We cant travel that far without resting somewhere closer...";
				
					
				SetUpScene (rand.Next (1, 100));
				
				break;
				
			}
			
		}
		
		void SetUpScene (int character)
		{
			if (character < 50) {
				AidenBox.Visible = true;
				
				
				
			} else if (character == 50) {
				Philsoraptor.Visible = true; //Yes...........mwahahahahahahahahahahahahahhahahahahah	
			} else {
				KiraBox.Visible = true;
				
			}
			CharacterBox.Visible = true;
			TextBoxText.Visible = true;
			TextBox.Visible = true;
			Continue.Visible = true;
		}
		
		void resetlookatarrows ()
		{
			IronMineArrow.Visible = false;
			StartingTownArrow.Visible = false;
			TownArrow2.Visible = false;
			TownArrow3.Visible = false;
			LumberMillArrow1.Visible = false;
			LumberMillArrow2.Visible = false;
			BossTownArrow.Visible = false;
		}
		
		void clearinterface ()
		{
			GotoButton.Visible = false;
			CharacterBox.Visible = false;
			AidenBox.Visible = false;
			KiraBox.Visible = false;
			TextBox.Visible = false;
			PieceTypeText.Visible = false;
			PieceInfoText.Visible = false;
			Continue.Visible = false;
			TextBoxText.Visible = false;
			Philsoraptor.Visible = false;
			Visit.Visible = false;
			Close.Visible = false;
		}
		
		void DisableOrEnableButtons (bool flag)
		{
			IronMineButton.Visible = flag;
			LumberMill1Button.Visible = flag;
			StartingTownButton.Visible = flag;
			BossTownButton.Visible = flag;
			Town3Button.Visible = flag;
			LumberMill2Button.Visible = flag;
			StrongHold2Button.Visible = flag;
			
		}
		
		void StartCutscene()
		{
			SceneManager.PushUIScene((int)UI.CHAT); 
			
		}
		
		
	}
}
