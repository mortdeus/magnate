using System;
using System.Collections.Generic;

using Sce.Pss.Core;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Input;
using Sce.Pss.Core.Audio;

using Sce.Pss.HighLevel.GameEngine2D;
using Sce.Pss.HighLevel.GameEngine2D.Base;

using Sce.Pss.HighLevel.UI;

using UIScene = Sce.Pss.HighLevel.UI.Scene;
using GameScene = Sce.Pss.HighLevel.GameEngine2D.Scene;

using MagnateUI;
namespace Magnate
{
	public enum UI{SCREEN, GUI, BATTLE, CHAT}; 
	public enum GE2D{START, FIRST ,WORLD, MINE, HILL, DESTOWN, GOODTOWN, FORT, DUNGEON, FINAL, BLACKSMITH};
	
	public static class SceneManager
	{
		
		static bool first = true;
		
		public static void PushUIScene (int scene = 0, int phase = 0)
		{
			var game = Game.Instance;
			
			switch (scene) {
			
			case (int)UI.SCREEN:
				game.screen = new ScreenVignette();
				UISystem.PushScene(game.screen);
				break;
				
			case (int)UI.GUI:
				game.GUI = new MainGUI();
				UISystem.PushScene(game.GUI);
				break;
			
			case (int)UI.BATTLE:
				game.Battle = InitiateCombatUI(phase);
				UISystem.PushScene(game.Battle);
				break;		

			case (int)UI.CHAT:
				game.chat = new ChatDialogueUI();
				UISystem.PushScene(game.chat);
				break;
			
			}
		}
		
		public static void SetUIScene (int scene = 0, int phase = 0)
		{
			
			var game = Game.Instance;
			
			var transition = new CrossFadeTransition();
			
			switch (scene) 
			{
			
			case (int)UI.SCREEN:
				game.screen = new ScreenVignette();
				game.screen.Transition = transition;
				UISystem.SetScene(game.screen);
				break;
				
			case (int)UI.GUI:
				game.GUI = new MainGUI();
				game.GUI.Transition = transition;
				UISystem.SetScene(game.GUI);
				break;
			
			case (int)UI.BATTLE:
				game.Battle = InitiateCombatUI(phase);
				game.Battle.Transition = transition;
				UISystem.SetScene(game.Battle);
				break;		

			case (int)UI.CHAT:
				game.chat = new ChatDialogueUI();
				game.chat.Transition = transition;
				UISystem.SetScene(game.chat);
				break;
			}
			
		}
		
		public static void ReplaceScene(int scene)
		{
			var game = Game.Instance;
			
			
			switch(scene)
			{	
			case (int)GE2D.START:
				
				var start = game.Start;
				start = new StartScreen();
				Director.Instance.ReplaceScene(start);
				break;
			
			case (int)GE2D.WORLD:
				game.World = new WorldMap();
				var world = game.World;
				Director.Instance.ReplaceScene(world);
				break;
				
			case (int)GE2D.FIRST:
				game.FirstScene = new FirstScene();
				Director.Instance.ReplaceScene(game.FirstScene);
				break;
				
				
			case (int)GE2D.MINE:
				game.Mine = new Mine();
				
				Director.Instance.ReplaceScene(game.Mine);
				break;
			
			case (int)GE2D.HILL:
				game.Hilltop = new Hilltop();
			
				Director.Instance.ReplaceScene(game.Hilltop);
				break;
				
			case (int)GE2D.GOODTOWN:
				game.GoodTown = new GoodTown();
				Director.Instance.ReplaceScene(game.GoodTown);
				break;
				
			case (int)GE2D.DESTOWN:
				game.DestroyedTown = new DestroyedTown();
				
				Director.Instance.ReplaceScene(game.DestroyedTown);
				break;
				
			case (int)GE2D.FORT:
				
				game.Fortress = new Fortress();
				Director.Instance.ReplaceScene(game.Fortress);
				break;
				
			case (int)GE2D.DUNGEON:
				game.Dungeon = new Dungeon();
				Director.Instance.ReplaceScene(game.Dungeon);
				break;
				
			case (int)GE2D.FINAL:
				
				game.FinalBattle = new FinalBattle();
				Director.Instance.ReplaceScene(game.FinalBattle);
				break;
			case (int)GE2D.BLACKSMITH:
				game.BlackSmith = new BlackSmith();
				Director.Instance.ReplaceScene(game.BlackSmith);
				break;
				
				
			}
		}
		
		public static void PushChatScene(int scene)
		{
			var game = Game.Instance;
			
			
			switch(scene)
			{	
			
										
			case (int)GE2D.MINE:
				game.Mine = new Mine();
				
				Director.Instance.ReplaceScene(game.Mine);
				break;
				
				
			case (int)GE2D.HILL:
				game.Hilltop = new Hilltop();
			
				Director.Instance.ReplaceScene(game.Hilltop);
				break;
				
			case (int)GE2D.GOODTOWN:
				game.GoodTown = new GoodTown();
				Director.Instance.ReplaceScene(game.GoodTown);
				break;
				
			case (int)GE2D.DESTOWN:
				game.DestroyedTown = new DestroyedTown();
				
				Director.Instance.ReplaceScene(game.DestroyedTown);
				break;
				
			case (int)GE2D.FORT:
				
				game.Fortress = new Fortress();
				Director.Instance.ReplaceScene(game.Fortress);
				break;
				
			case (int)GE2D.DUNGEON:
				
				game.Dungeon = new Dungeon();
				Director.Instance.ReplaceScene(game.Fortress);
				
				
				break;
			case (int)GE2D.FINAL:
				
				game.FinalBattle = new FinalBattle();
				Director.Instance.PushScene(game.FinalBattle);
				break;
			
				
			}
		}
		
		
		
		#region CleanUIScenes
		public static void StartFinished()
		{		
				var game = Game.Instance;	
			
				Game.Instance.StartScreenFinished = true;
				SetUIScene((int)UI.CHAT);
				
				Game.Instance.StartScreenCleanup = true;
				
				ReplaceScene((int)GE2D.FIRST);
			
				
			
				CleanUpUI();		
			
		}
		public static void ChatFinished()
		{
								
				if(first){
				SetUIScene((int)UI.SCREEN);
				ReplaceScene((int)GE2D.WORLD);
				}
				else				
				Game.Instance.WorldMapCleanUp = true;
				UISystem.PopScene();
			
				first = false;
								
				Game.Instance.ChatSceneCleanup = true;
				Game.Instance.ChatFinished = false;	
			
				
				Game.Instance.World = new WorldMap();
				Director.Instance.ReplaceScene(Game.Instance.World);
				CleanUpUI();
			}
			
		
		
		
		public static void GUIFinished()
		{
			
				UISystem.PopScene();
				
				Game.Instance.GUICleanup = true;
				
				CleanUpUI();
				
			
		}
		public static void BattleFinished()
		{
			if(Game.Instance.BattleFinished)
			{
				Game.Instance.battlePhase++;
				
				UISystem.PopScene();
				Game.Instance.chat.UpdateLanguage();
				
				Game.Instance.ResumeChat = true;
				
				CleanUpUI();
				
								
			}
		}
		public static void CleanUpUI()
		{
			var game = Game.Instance;
			
			if(game.StartScreenCleanup)
				{
				
				
				foreach(Widget c in game.startui.RootWidget.Children)
					c.Dispose();
				
				game.startui.RootWidget.Dispose();
				
				game.StartScreenCleanup = false;
					
				}
			
			if(game.ChatSceneCleanup)
				{
				foreach(Widget c in game.chat.RootWidget.Children)
					c.Dispose();
				
				game.chat.RootWidget.Dispose();
								
				
				ChatDialogueUI.Aiden.Dispose();
				ChatDialogueUI.Aiden = null;				
				game.chat.setAiden = false;
				
				
				ChatDialogueUI.Kira.Dispose();
				ChatDialogueUI.Kira = null;
				game.chat.setKira = false;
				
				ChatDialogueUI.Bear.Dispose();
				ChatDialogueUI.Bear = null;
				game.chat.setKira = false;
				
				ChatDialogueUI.Bandit1.Dispose();
				ChatDialogueUI.Bandit1 = null;				
				game.chat.setBandit1 = false;
				
				ChatDialogueUI.Bandit2.Dispose();
				ChatDialogueUI.Bandit2 = null;
				game.chat.setBandit2 = false;
				
				ChatDialogueUI.Bandit3.Dispose();
				ChatDialogueUI.Bandit3 = null;
				game.chat.setBandit3 = false;
				
				
				game.ChatSceneCleanup = false;
				}
			
			if(game.BattleCleanUp)
			{
				//foreach(Widget c in game.Battle.RootWidget.Children)
				//	c.Dispose();
				
				game.Battle.RootWidget.Dispose();
				game.Battle = null;
				game.BattleCleanUp = false;
				
				
				
				
			}
			
			if(game.MusicCleanUp)
				game.BOOMBOX.Dispose();
				game.MusicCleanUp = false;
			
			if(game.VignetteCleanup)
			{
				foreach(Widget c in game.screen.RootWidget.Children)
					c.Dispose();
				game.screen.RootWidget.Dispose();
				game.screen = null;
				
			}
				
			if(game.GUICleanup)
			{
				foreach(Widget c in game.GUI.RootWidget.Children)
					c.Dispose();
				game.GUI.RootWidget.Dispose();
				game.GUI = null;
				game.GUICleanup = false;
				
			}
									
			if(Game.Instance.Running == false)
			{
				game.Quit();
			}
						
			game.CleanUI = false;
		}
		#endregion
		
		public static BattleUI InitiateCombatUI(int phase)
		{
			/*
			 * 1 - Kira, Aiden ... bandit 3
			 * 2 - Aiden ... bandit 2
			 * 3 - Kira .. bandit 1
			 * 4 - Kira, Aiden ... bandit 1 2 3
			 * 5 - Kira, Aiden ... bear
			 */
			//Console.WriteLine(phase.ToString());
			CharacterStates[] arrHeroes;
			CharacterStates[] arrEnemies;
			if (phase == 1){
				//create our characters
				arrHeroes = new CharacterStates[2]{
					new CharacterStates((int)officerDictionary.AIDEN),
					new CharacterStates((int)officerDictionary.KIRA)
				};
				//create our enemies
				arrEnemies = new CharacterStates[3]{
				new CharacterStates((int)officerDictionary.BANDIT2),
				new CharacterStates((int)officerDictionary.BANDIT3),
				new CharacterStates((int)officerDictionary.BANDIT1)};
			}else if (phase ==2){
				//create our characters
				arrHeroes = new CharacterStates[2]{
					new CharacterStates((int)officerDictionary.AIDEN),
					new CharacterStates((int)officerDictionary.KIRA)
				};
				//create our enemies
				arrEnemies = new CharacterStates[3]{
				new CharacterStates((int)officerDictionary.BANDIT3),
				new CharacterStates((int)officerDictionary.BANDIT2),
				new CharacterStates((int)officerDictionary.BANDIT1)};
			}else if (phase ==3){
				//create our characters
				arrHeroes = new CharacterStates[2]{
					new CharacterStates((int)officerDictionary.AIDEN),
					new CharacterStates((int)officerDictionary.KIRA)
				};
				//create our enemies
				arrEnemies = new CharacterStates[3]{
				new CharacterStates((int)officerDictionary.BANDIT3),
				new CharacterStates((int)officerDictionary.BANDIT1),
				new CharacterStates((int)officerDictionary.BANDIT2),
				};
			}else if (phase ==4){
				//create our characters
				arrHeroes = new CharacterStates[2]{
					new CharacterStates((int)officerDictionary.AIDEN),
					new CharacterStates((int)officerDictionary.KIRA)
				};
				//create our enemies
				arrEnemies = new CharacterStates[3]{
				new CharacterStates((int)officerDictionary.BANDIT1),
				new CharacterStates((int)officerDictionary.BANDIT2),
				new CharacterStates((int)officerDictionary.BANDIT3)
				};
			}else{
				//create our characters
				arrHeroes = new CharacterStates[2]{
					new CharacterStates((int)officerDictionary.AIDEN),
					new CharacterStates((int)officerDictionary.KIRA)
				};
				//create our enemies
				arrEnemies = new CharacterStates[3]{
				new CharacterStates((int)officerDictionary.BANDIT1),
				new CharacterStates((int)officerDictionary.BEAR),
				new CharacterStates((int)officerDictionary.BANDIT3)
				};
			}
			
			
			BattleUI scene = new BattleUI(arrHeroes, arrEnemies, phase);
			
			//BattleUI.BattleStarted = true;
			return scene;
		}
	}
	
}
	
	
	

