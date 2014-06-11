using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
	public enum CharacterState
	{
		Normal,
		Happy,
		Angry,
		Worried,
		Shocked,
		Thinking,
		Hurt
	};
	
	public enum BanditState
	{
		BANDIT1_ANNOY,
		BANDIT1_SMUG,
		BANDIT1_MAD, 
		BANDIT2_ANNOY,
		BANDIT2_SMUG,
		BANDIT2_MAD,
		BANDIT3_ANNOY,
		BANDIT3_SMUG,
		BANDIT3_MAD
			
	};
		
	partial class ScreenVignette
	{
		public Sprite Aiden;
		public Sprite Kira;
		public bool setAiden = false;
		public bool setKira = false;
		public bool kiraOnLeft = false;
		bool firstrunthrough = true;
		bool forceToScene = false;
		int aidenState = (int)CharacterState.Thinking;
		int kiraState = (int)CharacterState.Thinking;
		
		public void setupcharactors ()
		{
			if (firstrunthrough) {
				SetUpAiden ();
				SetUpKira ();
									
				CharacaterUpdate ();
				firstrunthrough = false;
			} else {		
				if (setAiden)
					SetUpAiden ();
				else				
					Aiden.inscene = false;	
				
				if (setKira)
					SetUpKira ();
				else
					Kira.inscene = false;
				
				
			}
		}
		
		void CharacaterUpdate ()
		{
			AidenBox.SetPosition (Aiden.position.x, Aiden.position.y);
			AidenBox.SetSize (Aiden.size.x, Aiden.size.y);
                
			if (Aiden.inscene)
				AidenBox.Visible = true;
			else 
				AidenBox.Visible = false;
			
			KiraBox.SetPosition (Kira.position.x, Kira.position.y);
			KiraBox.SetSize (Kira.size.x, Kira.size.y);
               
               
			if (Kira.inscene)
				KiraBox.Visible = true;
			else 
				KiraBox.Visible = false;
								
		}
		
		void ForceAddCharactersToScene ()
		{
			if (!Aiden.inscene)
				this.RootWidget.AddChildLast (AidenBox);
			if (!Kira.inscene)
				this.RootWidget.AddChildLast (KiraBox);
			
			
		}
		
		void SetUpAiden ()
		{
			if (AidenBox == null) {
				AidenBox = new ImageBox ();
				AidenBox.Name = "AidenBox";
			}
			Aiden = new Sprite ();
			Aiden.filename = "assets/CharacterSheets/aidensheet.png";
			Aiden.position.x = 35;
			Aiden.position.y = 100;
			Aiden.inscene = setAiden;
			Aiden.state = aidenState;
			Aiden.tiles.x = 4;
			Aiden.tiles.y = 2;
			Aiden.size.x = 200;
			Aiden.size.y = 315;
				
			SpriteSheetManagerUI.CreateImage (ref Aiden);
			
			AidenBox.Image = new ImageAsset (Aiden.image, PixelFormat.Rgba);
				
			
		}
		
		void SetUpKira ()
		{
			if (KiraBox == null) {
				KiraBox = new ImageBox ();
				KiraBox.Name = "KiraBox";
			}
			Kira = new Sprite ();
			Kira.filename = "assets/CharacterSheets/kirasheet.png";

			Kira.position.x = 150;
			Kira.position.y = 100;				
			Kira.inscene = setKira;
			Kira.state = kiraState;
				
				
			Kira.tiles.x = 4;
			Kira.tiles.y = 2;			
			Kira.size.x = 200;
			Kira.size.y = 315;
				
			
			SpriteSheetManagerUI.CreateImage (ref Kira);
			KiraBox.Image = new ImageAsset (Kira.image, PixelFormat.Rgba);
				
				
				
		}
		
	}
	
	partial class ChatDialogueUI
	{			
		public Sprite Aiden;
		public Sprite Kira;
		public Sprite Bear;
		public Sprite Bandit1;
		public Sprite Bandit2;
		public Sprite Bandit3;
		public bool setAiden = false;
		public bool setKira = false;
		public bool setBear = false;
		public bool setBandit1 = false;
		public bool setBandit2 = false;
		public bool setBandit3 = false;
		public bool kiraOnLeft = false;
		bool firstrun = true;
		static int currentPhase = 1;
		int aidenState = (int)CharacterState.Normal;
		int kiraState = (int)CharacterState.Normal;
		int bearState = (int)CharacterState.Normal;
		int Bandit1State = (int)BanditState.BANDIT1_SMUG;
		int Bandit2State = (int)BanditState.BANDIT2_SMUG;
		int Bandit3State = (int)BanditState.BANDIT3_SMUG;
		int aiden_OldState = (int)CharacterState.Normal;
		int  kira_OldState = (int)CharacterState.Normal;
		int  bear_OldState = (int)CharacterState.Normal;
		int Bandit1_OldState = (int)BanditState.BANDIT1_SMUG;
		int Bandit2_OldState = (int)BanditState.BANDIT2_SMUG;
		int Bandit3_OldState = (int)BanditState.BANDIT3_SMUG;
			
		public void SetUpCharacters (Sprite LSpriteL = null, Sprite LSpriteR = null, 
		                              	    Sprite RSpriteL = null, Sprite RSpriteM = null, Sprite RSpriteR = null)
		{									
			if (firstrun) {
				SetUpAiden ();
				SetUpBear ();
				SetUpKira ();
				SetUpBandit1 ();
				SetUpBandit2 ();
				SetUpBandit3 ();
			}
			
			
			if (setAiden) {
					
				if (aidenState != aiden_OldState)
					SetUpAiden ();
			} else				
				Aiden.inscene = false;
				
			if (setKira){
				if (kiraState != kira_OldState)
				kira_OldState = kiraState;
				SetUpKira ();
			}
			else
				Kira.inscene = false;
			
			if (setBear){
				if(bearState != bear_OldState)
					bear_OldState = bearState;					
					SetUpBear ();
			}
			else
				Bear.inscene = false;
			
			
			if (setBandit1)
			{
				if(Bandit1State != Bandit1_OldState)	
				SetUpBandit1 ();
				Bandit1_OldState = Bandit1State;
			}
			else
				Bandit1.inscene = false;
		
			
			if (setBandit2)
			{
				if(Bandit2State != Bandit2_OldState)
				SetUpBandit2 ();
				Bandit2_OldState = Bandit2State;
			}
					else
				Bandit2.inscene = false;
			
			
			
			if (setBandit3)
			{	
				if(Bandit3State != Bandit3_OldState)	
				SetUpBandit3 ();
				Bandit3_OldState = Bandit3State;
			}
				else
				Bandit3.inscene = false;
				
				
			SetCharacterImage (LSpriteL, LSpriteR, RSpriteL, RSpriteM, RSpriteR);
			CharacaterUpdate (LSpriteL, LSpriteR, RSpriteL, RSpriteM, RSpriteR);
				
		}

		void SetUpAiden ()
		{
				
			Aiden.filename = "assets/CharacterSheets/aidensheet.png";
			Aiden.position.x = 130;
			Aiden.position.y = 10;
			Aiden.inscene = setAiden;
			Aiden.state = aidenState;
			Aiden.tiles.x = 4;
			Aiden.tiles.y = 2;
			Aiden.size.x = 200;
			Aiden.size.y = 315;
				
				
			SpriteSheetManagerUI.CreateImage (ref Aiden);
				
		}

		void SetUpKira ()
		{			
			Kira.filename = "assets/CharacterSheets/kirasheet.png";
			if (kiraOnLeft) {
				Kira.position.x = 250;
				Kira.position.y = 10;
			} else {
				Kira.position.x = 450;
				Kira.position.y = 10;
			}
			Kira.inscene = setKira;
			Kira.state = kiraState;
				
			Kira.tiles.x = 4;
			Kira.tiles.y = 2;			
			Kira.size.x = 200;
			Kira.size.y = 315;
			
			SpriteSheetManagerUI.CreateImage (ref Kira);
		}

		void SetUpBear ()
		{
			Bear.filename = "assets/CharacterSheets/bearsheet.png";
			Bear.position.x = 485;
			Bear.position.y = 10;
			Bear.inscene = setBear;
			Bear.state = bearState;
			Bear.tiles.x = 4;
			Bear.tiles.y = 2;
			Bear.size.x = 250;
			Bear.size.y = 325;
		
			SpriteSheetManagerUI.CreateImage (ref Bear);
		}

		void SetUpBandit1 ()
		{
				
				
			Bandit1.filename = "assets/CharacterSheets/banditsheet.png";
			Bandit1.position.x = 400;
			Bandit1.position.y = 5;
			Bandit1.inscene = setBandit1;
			Bandit1.state = Bandit1State;
			Bandit1.tiles.x = 3;
			Bandit1.tiles.y = 3;
			Bandit1.size.x = 240;
			Bandit1.size.y = 310;
				
				
			SpriteSheetManagerUI.CreateImage (ref Bandit1);
				
				
		}

		void SetUpBandit2 ()
		{
				
				
			Bandit2.filename = "assets/CharacterSheets/banditsheet.png";
			Bandit2.position.x = 545;
			Bandit2.position.y = 5;
			Bandit2.inscene = setBandit2;
			Bandit2.state = Bandit2State;
			Bandit2.tiles.x = 3;
			Bandit2.tiles.y = 3;
			Bandit2.size.x = 240;
			Bandit2.size.y = 310;
				
			
			SpriteSheetManagerUI.CreateImage (ref Bandit2);
				
				
			
		}

		void SetUpBandit3 ()
		{
				
				
			Bandit3.filename = "assets/CharacterSheets/banditsheet.png";
			Bandit3.position.x = 500;
			Bandit3.position.y = 5;
			Bandit3.inscene = setBandit3;
			Bandit3.state = Bandit3State;
			Bandit3.tiles.x = 3;
			Bandit3.tiles.y = 3;
			Bandit3.size.x = 240;
			Bandit3.size.y = 310;	
				
			
			SpriteSheetManagerUI.CreateImage (ref Bandit3);
				
				
		}
			
		void CharacaterUpdate (Sprite LSpriteL, Sprite LSpriteR, Sprite RSpriteL, Sprite RSpriteM, Sprite RSpriteR)
		{
			if (LSpriteL != null) {
				LCharBoxL.SetPosition (LSpriteL.position.x, LSpriteL.position.y);
				LCharBoxL.SetSize (LSpriteL.size.x, LSpriteL.size.y);
                
				if (LSpriteL.inscene)
					LCharBoxL.Visible = true;
				else
					LCharBoxL.Visible = false;
			}
			
			if (LSpriteR != null) {
				LCharboxR.SetPosition (LSpriteR.position.x, LSpriteR.position.y);
				LCharboxR.SetSize (LSpriteR.size.x, LSpriteR.size.y);
                
				if (LSpriteR.inscene)
					LCharboxR.Visible = true;
				else
					LCharboxR.Visible = false;
			}
			if (RSpriteR != null) {
				RCharBoxR.SetPosition (RSpriteR.position.x, RSpriteR.position.y);
				RCharBoxR.SetSize (RSpriteR.size.x, RSpriteR.size.y);
                
				if (RSpriteR.inscene)
					RCharBoxR.Visible = true;
				else
					RCharBoxR.Visible = false;
			}
				
			if (RSpriteL != null) {
				RCharBoxL.SetPosition (RSpriteL.position.x, RSpriteL.position.y);
				RCharBoxL.SetSize (RSpriteL.size.x, RSpriteL.size.y);
                
				if (LSpriteL.inscene)
					RCharBoxL.Visible = true;
				else
					RCharBoxL.Visible = false;
			}
				
			if (RSpriteM != null) {
				RCharBoxM.SetPosition (RSpriteM.position.x, RSpriteM.position.y);
				RCharBoxM.SetSize (RSpriteM.size.x, RSpriteM.size.y);
                
				if (LSpriteL.inscene)
					RCharBoxL.Visible = true;
				else
					RCharBoxL.Visible = false;
			}	
		}
		
		public void SetCharacterImage (Sprite LSpriteL, Sprite LSpriteR, 
		                              	    Sprite RSpriteL, Sprite RSpriteM, Sprite RSpriteR)
		{
			if (LSpriteL != null) {
				if (!firstrun)
					LCharBoxL.Image.Dispose ();
				LCharBoxL.Image = new ImageAsset (LSpriteL.image, PixelFormat.Rgba);
				LSpriteL.image.Dispose ();
			}
			if (LSpriteR != null) {
				if (!firstrun)
					LCharboxR.Image.Dispose ();
				LCharboxR.Image = new ImageAsset (LSpriteR.image, PixelFormat.Rgba);
				LSpriteR.image.Dispose ();
			}
			if (RSpriteL != null) {
				if (!firstrun)
					RCharBoxL.Image.Dispose ();	
				RCharBoxL.Image = new ImageAsset (RSpriteL.image, PixelFormat.Rgba);
				RSpriteL.image.Dispose ();
			}
			if (RSpriteM != null) {
				if (!firstrun)
					RCharBoxM.Image.Dispose ();	
				RCharBoxM.Image = new ImageAsset (RSpriteM.image, PixelFormat.Rgba);
				RSpriteM.image.Dispose ();
			}
			if (RSpriteR != null) {
				if (!firstrun)
					RCharBoxR.Image.Dispose ();
				RCharBoxR.Image = new ImageAsset (RSpriteR.image, PixelFormat.Rgba);
				RSpriteR.image.Dispose ();
			
			}
		}
	}
}

