using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;
using Magnate;
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
		Hurt,
		
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
			if (AidenBox == null) 
			{
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
				
			if(!firstrunthrough)
			AidenBox.Image.Dispose();	
			
			AidenBox.Image = new ImageAsset (Aiden.image, PixelFormat.Rgba);
				
			Aiden.image.Dispose();
		}
		
		void SetUpKira ()
		{
			if (KiraBox == null) 
			{
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
					
			if(!firstrunthrough)
			KiraBox.Image.Dispose();
				
			KiraBox.Image = new ImageAsset (Kira.image, PixelFormat.Rgba);
				
			Kira.image.Dispose();	
				
		}
		
	}
	
	partial class ChatDialogueUI
	{			
		static public Sprite Aiden;
		static public Sprite Kira;
		static public Sprite Bear;
		static public Sprite Bandit1;
		static public Sprite Bandit2;
		static public Sprite Bandit3;
		public bool setAiden = false;
		public bool setKira = false;
		public bool setBear = false;
		public bool setBandit1 = false;
		public bool setBandit2 = false;
		public bool setBandit3 = false;
		public bool kiraOnLeft = false;
		bool firstrun = true;
		
		
		
		
		
			
		public void SetUpCharacters (Sprite LSpriteL = null, Sprite LSpriteR = null, 
		                              	    Sprite RSpriteL = null, Sprite RSpriteM = null, Sprite RSpriteR = null)
		{									
						
			
			if (setAiden) {
					
					
				SetUpAiden ();
				
				
			} else				
				Aiden.inscene = false;
				
			if (setKira){
				
				SetUpKira ();
				
				
			}
			else
				Kira.inscene = false;
			
			if (setBear){
								
				SetUpBear ();
					
			}
			else
				Bear.inscene = false;
			
			
			if (setBandit1)
			{
				SetUpBandit1 ();
				
				
			}
			else
				Bandit1.inscene = false;
		
			
			if (setBandit2)
			{
				SetUpBandit2 ();
				
			}
			else
				Bandit2.inscene = false;
			
			
			
			if (setBandit3)
			{	

				SetUpBandit3 ();
				
			}
			else
				Bandit3.inscene = false;
				
			if(game.ChatFinished)
			SceneManager.ChatFinished();
		
			
			else{	
			SetCharacterImage (LSpriteL, LSpriteR, RSpriteL, RSpriteM, RSpriteR);
			
			CharacaterUpdate (LSpriteL, LSpriteR, RSpriteL, RSpriteM, RSpriteR);
			
			firstrun = false;
				}
		
				
	
}

		void SetUpAiden ()
		{
			
			Aiden.filename = "assets/CharacterSheets/aidensheet.png";
			Aiden.position.x = 130;
			Aiden.position.y = 40;			
			Aiden.inscene = true;
			Aiden.tiles.x = 4;
			Aiden.tiles.y = 2;
			Aiden.size.x = 200;
			Aiden.size.y = 315;
				
			if(Aiden.image != null)
			Aiden.image.Dispose();
			
			SpriteSheetManagerUI.CreateImage (ref Aiden);
				
		}

		void SetUpKira ()
		{			
			Kira.filename = "assets/CharacterSheets/kirasheet.png";
			if (kiraOnLeft) {
				Kira.position.x = 250;
				Kira.position.y = 40;
			} else {
				Kira.position.x = 450;
				Kira.position.y = 40;
			}
			Kira.inscene = true;
				
			Kira.tiles.x = 4;
			Kira.tiles.y = 2;			
			Kira.size.x = 200;
			Kira.size.y = 315;
			
			if(Kira.image != null)
			Kira.image.Dispose();
			
			SpriteSheetManagerUI.CreateImage (ref Kira);
		}

		void SetUpBear ()
		{
			Bear.filename = "assets/CharacterSheets/bearsheet.png";
			Bear.position.x = 485;
			Bear.position.y = 40;
			Bear.inscene = setBear;
			
			Bear.tiles.x = 4;
			Bear.tiles.y = 2;
			Bear.size.x = 250;
			Bear.size.y = 325;
		
			if(Bear.image != null)
			Bear.image.Dispose();
			
			SpriteSheetManagerUI.CreateImage (ref Bear);
		}

		void SetUpBandit1 ()
		{
				
				
			Bandit1.filename = "assets/CharacterSheets/banditsheet.png";
			Bandit1.position.x = 400;
			Bandit1.position.y = 40;
			Bandit1.inscene = setBandit1;
			
			Bandit1.tiles.x = 3;
			Bandit1.tiles.y = 3;
			Bandit1.size.x = 240;
			Bandit1.size.y = 310;
			
			
			if(Bandit1.image != null)
			Bandit1.image.Dispose();
			
			SpriteSheetManagerUI.CreateImage (ref Bandit1);
				
				
		}

		void SetUpBandit2 ()
		{
				
				
			Bandit2.filename = "assets/CharacterSheets/banditsheet.png";
			Bandit2.position.x = 325;
			Bandit2.position.y = 40;
			Bandit2.inscene = setBandit2;
			
			Bandit2.tiles.x = 3;
			Bandit2.tiles.y = 3;
			Bandit2.size.x = 240;
			Bandit2.size.y = 310;
				
			if(Bandit2.image != null)
			Bandit2.image.Dispose();
			
			SpriteSheetManagerUI.CreateImage (ref Bandit2);
				
				
			
		}

		void SetUpBandit3 ()
		{
				
				
			Bandit3.filename = "assets/CharacterSheets/banditsheet.png";
			Bandit3.position.x = 450;
			Bandit3.position.y = 40;
			Bandit3.inscene = setBandit3;
			
			Bandit3.tiles.x = 3;
			Bandit3.tiles.y = 3;
			Bandit3.size.x = 240;
			Bandit3.size.y = 310;	
				
			if(Bandit3.image != null)
			Bandit3.image.Dispose();
			
			SpriteSheetManagerUI.CreateImage (ref Bandit3);
				
				
		}
			
		void CharacaterUpdate (Sprite LSpriteL = null, Sprite LSpriteR = null, Sprite RSpriteL = null, Sprite RSpriteM = null, Sprite RSpriteR = null)
		{
			
			CharacterUpdateInnerLoop(LSpriteL, LCharBoxL);
			CharacterUpdateInnerLoop(LSpriteR, LCharboxR);
			CharacterUpdateInnerLoop(RSpriteL, RCharBoxL);
			CharacterUpdateInnerLoop(RSpriteM, RCharBoxM);
			CharacterUpdateInnerLoop(RSpriteR, RCharBoxR);
						
		}
		
		public void SetCharacterImage (Sprite LSpriteL = null, Sprite LSpriteR = null, 
		                              	    Sprite RSpriteL = null, Sprite RSpriteM = null, Sprite RSpriteR = null)
		{
			if (LSpriteL != null){
				if(LSpriteL.image != null){
				if (!firstrun)
						if(LCharBoxL.Image != null)
					LCharBoxL.Image.Dispose ();
				LCharBoxL.Image = new ImageAsset (LSpriteL.image, PixelFormat.Rgba);
				}
			}
			if (LSpriteR != null){
				if(LSpriteR.image != null){
				if (!firstrun)
						if(LCharboxR.Image != null)
					LCharboxR.Image.Dispose ();
				LCharboxR.Image = new ImageAsset (LSpriteR.image, PixelFormat.Rgba);
				
				}
			}
			if (RSpriteL != null){
				if(RSpriteL.image != null){
				if (!firstrun)
					if(RCharBoxL.Image != null)
					RCharBoxL.Image.Dispose ();	
				RCharBoxL.Image = new ImageAsset (RSpriteL.image, PixelFormat.Rgba);
				
				}
			}
			if (RSpriteM != null) {
				if(RSpriteM.image != null){
				if (!firstrun)
						if(RCharBoxM.Image != null)
					RCharBoxM.Image.Dispose ();	
				RCharBoxM.Image = new ImageAsset (RSpriteM.image, PixelFormat.Rgba);
				
				}
			}
			if (RSpriteR != null) {
				if(RSpriteR.image != null){
				if (!firstrun)
						if(RCharBoxR.Image != null)
					RCharBoxR.Image.Dispose ();
				RCharBoxR.Image = new ImageAsset (RSpriteR.image, PixelFormat.Rgba);
				
				}
			}
		}
		
		void FadeInCharacter(Sprite sprite, ImageBox box)
		{
			if(sprite.state != sprite.oldState){
			new FadeInEffect(box, 2000f, FadeInEffectInterpolator.EaseOutQuad).Start();
			sprite.oldState = sprite.state;}
			
			else if(sprite.forcevisible){
			new FadeInEffect(box, 2000f, FadeInEffectInterpolator.EaseOutQuad).Start();
			sprite.forcevisible = false;
			}
			
		}
		void FadeOutCharacter(ImageBox box)
		{
			new FadeOutEffect(box, 1000f, FadeOutEffectInterpolator.EaseOutQuad).Start();
		
		}
		
		void CharacterUpdateInnerLoop(Sprite sprite, ImageBox box)
		{
			if (sprite != null) {
				box.SetPosition (sprite.position.x, sprite.position.y);
				box.SetSize (sprite.size.x, sprite.size.y);
                
				if (sprite.inscene){
				FadeInCharacter(sprite, box);
				sprite.ExitScene = false;	
				}
				else if(!sprite.ExitScene){
				FadeOutCharacter(box);
				sprite.ExitScene = true;
				}
					
			}
		}
	}
}

