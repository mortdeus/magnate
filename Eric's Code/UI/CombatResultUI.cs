using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    public partial class CombatResultUI : Scene
    {
		
		TapGestureDetector continueTG;
		
        public CombatResultUI(string[] players,bool[] playerAlive, string[] enemies, bool[]enemiesAlive, int phase)
        {
            InitializeWidget();
			
			if (phase == 1 && phase == 4)
			{
				char1body.Visible = true;
				char1body.Image = new ImageAsset(players[0]);
				char2body.Visible = true;
				char2body.Image = new ImageAsset(players[1]);
				if (!playerAlive[0]){
					char1cross.Visible = true;
					char1overlay.Visible = true;
				}
				if (!playerAlive[1]){
					char2cross.Visible = true;
					char2overlay.Visible = true;
				}
			}else{
				char1body.Visible = true;
				char1body.Image = new ImageAsset(players[0]);
				if (!playerAlive[1]){
					char1overlay.Visible = true;
					char1cross.Visible= true;
				}
			}
			
			if (phase == 4){
				enemy1body.Visible = true;
				enemy1body.Image = new ImageAsset(enemies[0]);
				enemy2body.Visible = true;
				enemy2body.Image = new ImageAsset(enemies[1]);
				enemy3body.Visible = true;
				enemy3body.Image = new ImageAsset(enemies[2]);
				if(!enemiesAlive[0]){
					enemy1cross.Visible = true;
					enemy1overlay.Visible = true;
				}else if(!enemiesAlive[1]){
					enemy2cross.Visible = true;
					enemy2overlay.Visible = true;
				}else if(!enemiesAlive[2]){
					enemy3cross.Visible = true;
					enemy3overlay.Visible = true;
				}
			}else{
				enemy1body.Visible = true;	
				enemy1body.Image = new ImageAsset(enemies[0]);

				if(!enemiesAlive[0]){
					enemy1cross.Visible = true;
					enemy1overlay.Visible = true;
				}
			}
			
			continueTG = new TapGestureDetector();
			continueTG.TapDetected += continueTGEventHandler;
			btn_continue.AddGestureDetector(continueTG);
        }
		
		void continueTGEventHandler(object sender, TapEventArgs e)
		{
			//FOR ROGER: pop the result UI scene here
			
			UISystem.PopScene();
		}

    }
}
