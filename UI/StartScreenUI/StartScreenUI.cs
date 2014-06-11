using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Input;
using Sce.Pss.Core.Audio;
using Sce.Pss.HighLevel.GameEngine2D;
using Sce.Pss.HighLevel.GameEngine2D.Base;

using Sce.Pss.HighLevel.UI;

using UIScene = Sce.Pss.HighLevel.UI.Scene;
using GameScene = Sce.Pss.HighLevel.GameEngine2D.Scene;



using Magnate;

namespace MagnateUI
	
	
{
    public partial class StartScreenUI : Sce.Pss.HighLevel.UI.Scene
	{
        Game game = Game.Instance;
		
		TapGestureDetector btnNewgameTapGesture;
		TapGestureDetector btnQuitgameTapGesture;
											
        public StartScreenUI()
        {
            InitializeWidget();
						
			btnNewgameTapGesture = new TapGestureDetector();
            btnNewgameTapGesture.TapDetected += btnNewgameTapEventHandler;
            btnNewgame.AddGestureDetector(btnNewgameTapGesture);
			
			btnQuitgameTapGesture = new TapGestureDetector();
			btnQuitgameTapGesture.TapDetected += btnQuitgameTapEventHandler;
			btnQuit.AddGestureDetector(btnQuitgameTapGesture);
					
							
		}
		

		void btnNewgameTapEventHandler(object sender, TapEventArgs e)
        {
				SceneManager.StartFinished();
        }

		
		
		public void NewGameSceneExecute()
		{						
				SceneManager.StartFinished();		
		}
				
		void btnQuitgameTapEventHandler(object sender, TapEventArgs e)
		{
			game.Quit();
		}
		public void QuitGameExecute()
		{
			
			game.Quit();
		}
		
		
			
				
		
    }
}
