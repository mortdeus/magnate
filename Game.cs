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

using MagnateUI;

namespace Magnate
{
	public class Game
	{
		public static Game Instance;
				
		Game game = Game.Instance;
		
		public int battlePhase = 1;
		public bool startscreenmusic = true;
		
		static GraphicsContext graphics;
	    public bool Running = true;
				
		//GameEngine2D
		public WorldMap 	   World    {get;set;}
		public StartScreen 	   Start	{get;set;}
		
		//UI scenes
		public MainGUI		   GUI	   	{get; set;}
		public BattleUI 	   Battle   {get; set;}
		public ScreenVignette  screen   {get; set;}
		public ChatDialogueUI  chat 	{get; set;}
		public StartScreenUI   startui  {get; set;}
		
		public Mine	Mine {get;set;}
		public GoodTown GoodTown {get;set;}
		public Hilltop Hilltop {get;set;}
		public DestroyedTown DestroyedTown {get;set;}
		public FinalBattle FinalBattle {get;set;}
		public FirstScene FirstScene {get;set;}
		public Dungeon Dungeon {get;set;}
		public Fortress Fortress {get;set;}
		public BlackSmith BlackSmith {get;set;}
		
							//Like its the 90s yo!
		public BgmPlayer 	  BOOMBOX  {get; set;}
		
		public Bgm 			  Music{get;set;}
		
		
		
		public bool StartScreenFinished {get;set;}
		public bool BattleFinished		{get;set;}
		public bool ChatFinished 		{get;set;}
		public bool ScreenFinished		{get;set;}
		public bool guiFinished 		{get;set;}
		public bool resetCount			{get;set;}
		
		public bool StartBattle			{get; set;}
		public bool ResumeChat			{get; set;}
		
		public bool StartScreenCleanup 	{get; set;}
		public bool ChatSceneCleanup 	{get; set;}
		public bool VignetteCleanup		{get; set;}
		public bool WorldMapCleanUp 	{get; set;}
		public bool BattleCleanUp 		{get; set;}
		public bool MusicCleanUp		{get; set;}
		public bool GUICleanup			{get; set;}
		public bool startmusic 			{get; set;}
		public bool quitmusic 			{get;set;}
		
		public bool CleanUI				{get; set;}
		
		private static List<TouchData> touch_data;
		
		public void Initialize ()
		{			
		
		uint spriteCapacity = 500;
		uint drawHelpersCapacity = 400;
		graphics = new GraphicsContext ();
								
		StartUpMethods.SetUpDirector (spriteCapacity, drawHelpersCapacity, graphics);	
		
		var uitransition = new CrossFadeTransition();	
		
		
		
		Start = new StartScreen();	
		
					
		startui = new StartScreenUI();	
		
		startui.Transition = uitransition;	
			
		Director.Instance.RunWithScene (Start, true);
			
		StartUpMethods.SetUpUI(graphics, startui);
				
		}

		public void Update ()
		{		
			touch_data = Touch.GetData(0);

			// Not strictly neccessary 
			Input2.Touch.SetData(0, touch_data);
			
			Director.Instance.Update ();
			UISystem.Update (touch_data);
			
			
			
			if(StartBattle)
			{
				SceneManager.PushUIScene((int)UI.BATTLE,battlePhase);
				StartBattle = false;
									
				
				
			}
			if(ResumeChat)
			{
				
				
			}
			
			
			
				
			
		}

		public void Render ()
		{
			graphics.SetClearColor (Colors.Black);
			
			Director.Instance.Render ();
			UISystem.Render ();
						
			Director.Instance.GL.Context.SwapBuffers ();
			Director.Instance.PostSwap ();
			
		}
		
		public void Cleanup ()
		{
			
			
			Director.Terminate ();
			UISystem.Terminate ();
			
			
		}
		public void Quit()
		{
			Running = false;
			
			
		}
		public void CleanAllUI()
		{			
			StartScreenCleanup 	= true;
			VignetteCleanup 	= true;
			GUICleanup 	    	= true;
			BattleCleanUp 		= true;
			
			game.CleanUI = 		  true;
			
			
		}
		
	}
/******************************************************************************************************************************/
	
	public static class StartUpMethods
	{
		
		
		public static void SetUpDirector (uint spriteCapacity, uint drawHelperCapacity, 
		                                 Sce.Pss.Core.Graphics.GraphicsContext context)
		{	
		
					
			Director.Initialize (spriteCapacity, drawHelperCapacity, context);	
			

			Director.Instance.GL.Context.SetClearColor (Colors.White);
		

			Director.Instance.DebugFlags |= DebugFlags.Navigate; 

		
		}
		
		public static void SetUpUI (GraphicsContext graphics, Sce.Pss.HighLevel.UI.Scene scene)
		{
			UISystem.Initialize (graphics);
			UISystem.SetScene (scene);
		}
		
		
		
		
		
	}	
	
}
