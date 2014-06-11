using System;
using System.Collections.Generic;

using Sce.Pss.Core;
using Sce.Pss.Core.Input;

using Sce.Pss.HighLevel.GameEngine2D;
using Sce.Pss.HighLevel.GameEngine2D.Base;

using Sce.Pss.HighLevel.UI;

using MagnateUI;

namespace Magnate
{
	public static class UserInput
	{
		
		
		public static void HandleInputStartScreen (ref StartscreenUI uiScene)
		{
			//switch(gameScene)	
			
			
			if (Input2.GamePad0.Down.Press)
			if (StateBools.startScreenSelectArrowNewGame == true) {
				uiScene.Arrow_1.Visible = false;
				uiScene.Arrow_2.Visible = true;
				
				StateBools.startScreenSelectArrowNewGame = false;
				StateBools.startScreenSelectArrowQuitGame = true;
			}	
			if (Input2.GamePad0.Up.Press) {
				if (StateBools.startScreenSelectArrowQuitGame == true) {
					uiScene.Arrow_1.Visible = true;
					uiScene.Arrow_2.Visible = false;
					
					StateBools.startScreenSelectArrowNewGame = true;
					StateBools.startScreenSelectArrowQuitGame = false;
				}
			
			}
			if (Input2.GamePad0.Cross.Press) {
				if (StateBools.startScreenSelectArrowNewGame == true)
					StartscreenUI.NewGameSceneExecute ();
				else
					StartscreenUI.QuitGameExecute ();
			}
		
		}
		
		public static void swapGUIwithScreenVigette ()
		{		
			if (Input2.GamePad0.Start.Press) 
			{
				if (StateBools.hideGUI == false)
				{
					
					CreateSceneMethods.SwapGUI();
					Console.WriteLine("SwapScreenGUI Called");
				}
				else
				{
					CreateSceneMethods.SwapScreenVignette();
					Console.Write("SwapScreenVignette called");
				}
				
			}
			
			
			//This section will set the GUI to create or destroy itself. However its not working how I Intend it to.
			
			
			
		}
	}
		
		
}


