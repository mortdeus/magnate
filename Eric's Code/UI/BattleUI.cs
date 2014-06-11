using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;
using Magnate;
using System.Collections;
using Sce.Pss.Core.Graphics;
using System.Threading;
using Sce.Pss.Core.Audio;


	namespace MagnateUI
	{
	    public partial class BattleUI : Scene
	    {
		
			//win or no?
			bool WinGame = false;
			bool battleOver = false;
		
			CharacterStates[] heroes;
			CharacterStates[] enemies;
			int enemyHPwidth;
			int heroHPwidth;
			int enemyMPwidth;
			int heroMPwidth;
		
			float ENEMYCOOLDOWN = 10000.0f;
			float enemyAtkTimer=0;
			int enemyAtkCounter=0;
			int mpRegenCounter=0;
		
			bool[] enemiesAlive = new bool[3]{true, true, true};
			bool[] heroesAlive = new bool[2]{true, true};
			int attackSelected = -1;
		
			TapGestureDetector hero1topTG;
			TapGestureDetector hero1leftTG;
			TapGestureDetector hero1rightTG;
		
			TapGestureDetector hero2topTG;
			TapGestureDetector hero2leftTG;
			TapGestureDetector hero2rightTG;
		
			TapGestureDetector enemy1TG;
			TapGestureDetector enemy2TG;
			TapGestureDetector enemy3TG;
		
			TapGestureDetector hero1TG;
			TapGestureDetector hero2TG;
			
			TapGestureDetector battleOverTG;
		
			//animation, max 5 on same targer
			AnimationImageBox[] animEnemy1 = new AnimationImageBox[5]{null,null,null,null,null};
			AnimationImageBox[] animEnemy2= new AnimationImageBox[5]{null,null,null,null,null};
			AnimationImageBox[] animEnemy3= new AnimationImageBox[5]{null,null,null,null,null};
			AnimationImageBox[] animAllenemy= new AnimationImageBox[5]{null,null,null,null,null};
			AnimationImageBox[] animHero1= new AnimationImageBox[5]{null,null,null,null,null};
			AnimationImageBox[] animHero2= new AnimationImageBox[5]{null,null,null,null,null};
		
			//animation counter
			int[] animCDEnemy1 = new int [5]{0,0,0,0,0};
			int[] animCDEnemy2 = new int [5]{0,0,0,0,0};
			int[] animCDEnemy3 = new int [5]{0,0,0,0,0};
			int[] animCDHero1 = new int [5]{0,0,0,0,0};
			int[] animCDHero2 = new int [5]{0,0,0,0,0};
			int[] animCDAllenemy = new int [5]{0,0,0,0,0};
		
			//round robin through the animation slots... why do we need this? well.. 
			//there is a race condition in the code and this is the easiest way to solve it
			int animIndexEnemy1=0;
			int animIndexEnemy2=0;
			int animIndexEnemy3=0;
			int animIndexHero1=0;
			int animIndexHero2=0;
		
			//oh ya.. also need a mutex as well?
			Mutex animMutex = new Mutex();
			Mutex soundMutex = new Mutex();
			
			//sound... let's hope this works
			SoundPlayer [] soundList = new SoundPlayer[5] {null,null,null,null,null};
			int soundCounter=0;
		
			ImageBox[] timerList ;
			ImageBox[] btnList;
			int[] CDList = new int[6]{0,0,0,0,0,0};
			int[] counterList = new int[6]{0,0,0,0,0,0};
			int originalCDSize = 34;
		
		
			int[] autoAttackTarget = new int[2]{-1,-1};
			float[] defBuff = new float[2]{0,0};
				
			int battlePhase =0;
	        public BattleUI(CharacterStates[] _heroes, CharacterStates[] _enemies, int phase) // should be replaced by other data structure later on
	        {
				
				InitializeWidget();
			
				timerList = new ImageBox[6] {CDHero1T,CDHero1L,CDHero1R,CDHero2T,CDHero2L,CDHero2R};
				btnList = new ImageBox[6] {btnHero1Skilltop, btnHero1Skillleft,
											btnHero1Skillright, btnHero2Skilltop,
											btnHero2Skillleft, btnHero2Skillright};
			
				heroes = _heroes;
				enemies = _enemies;
				enemyHPwidth = (int)Enemyhpbar1.Width;
				heroHPwidth = (int)Herohpbar1.Width;
				enemyMPwidth = (int)Enemympbar1.Width;
				heroMPwidth = (int)Herompbar1.Width;
				battlePhase = phase;
				
			
				//hide enemies based on which battle we are in
				if (battlePhase !=4)
				{					
					enemiesAlive[0] = false;
					enemiesAlive[2] = false;
					enemies[0].setHP(-1);
					enemies[2].setHP(-1);
				}
				/*
							 * 1 - Kira, Aiden ... bandit 3
							 * 2 - Aiden ... bandit 2
							 * 3 - Kira .. bandit 1
							 * 4 - Kira, Aiden ... bandit 1 2 3
							 * 5 - Aiden ... bear
				*/
			// hide kira
				if (battlePhase == 2 || battlePhase ==5)
				{
					heroesAlive[1] = false;
					heroes[1].setHP(-1);
				}
				if (battlePhase == 3)
				{
					heroesAlive[0]=false;
					heroes[0].setHP(-1);
				}
			
				//fill in enemy body portraits
				if (phase == 4)
				{
					EnemyBody1.Image = new ImageAsset(PlayerStates.getBodyFromOfficerID(enemies[0].getID()));
					EnemyBody3.Image = new ImageAsset(PlayerStates.getBodyFromOfficerID(enemies[2].getID()));
				}
			
				if (phase == 1){
					EnemyBody2.SetPosition(347, 88);
				}
				EnemyBody2.Image = new ImageAsset(PlayerStates.getBodyFromOfficerID(enemies[1].getID()));

			    //set health bar
				if (phase ==4)
				{
					Enemyhpbar1.Width = (int)((float)enemyHPwidth * ((float)enemies[0].getHP()/(float)enemies[0].getMaxHP()));
					Enemyhpbar3.Width = (int)((float)enemyHPwidth * ((float)enemies[2].getHP()/(float)enemies[2].getMaxHP()));
				}
				Enemyhpbar2.Width = (int)((float)enemyHPwidth * ((float)enemies[1].getHP()/(float)enemies[1].getMaxHP()));	
			    Herohpbar1.Width = (int)((float)heroHPwidth * ((float)heroes[0].getHP()/(float)heroes[0].getMaxHP()));
				Herohpbar2.Width = (int)((float)heroHPwidth * ((float)heroes[1].getHP()/(float)heroes[1].getMaxHP()));
				
				if (phase ==4)
				{
					enemy1_hpstats.Text = enemies[0].getHP().ToString() + "/" + enemies[0].getMaxHP().ToString();
					enemy3_hpstats.Text = enemies[2].getHP().ToString() + "/" + enemies[2].getMaxHP().ToString();
					enemy1_mpstats.Text = enemies[0].getMP().ToString() + "/" + enemies[0].getMaxMP().ToString();
					enemy3_mpstats.Text = enemies[2].getMP().ToString() + "/" + enemies[2].getMaxMP().ToString();
				}
				enemy2_mpstats.Text = enemies[1].getMP().ToString() + "/" + enemies[1].getMaxMP().ToString();
				enemy2_hpstats.Text = enemies[1].getHP().ToString() + "/" + enemies[1].getMaxHP().ToString();

			
				if (battlePhase != 2 && battlePhase!=5)
				{
					hero2_hpstats.Text = heroes[1].getHP().ToString() + "/" + heroes[1].getMaxHP().ToString();
					hero2_mpstats.Text = heroes[1].getMP().ToString() + "/" + heroes[1].getMaxMP().ToString();
				}
				if (battlePhase !=3){
					hero1_hpstats.Text = heroes[0].getHP().ToString() + "/" + heroes[0].getMaxHP().ToString();
					hero1_mpstats.Text = heroes[0].getMP().ToString() + "/" + heroes[0].getMaxMP().ToString();
				}
				
				//set mp bar
				if (phase == 4)
				{
					Enemympbar1.Width = (int)((float)enemyMPwidth * ((float)enemies[0].getMP()/(float)enemies[0].getMaxMP()));
					Enemympbar3.Width = (int)((float)enemyMPwidth * ((float)enemies[2].getMP()/(float)enemies[2].getMaxMP()));
				}
				Enemympbar2.Width = (int)((float)enemyMPwidth * ((float)enemies[1].getMP()/(float)enemies[1].getMaxMP()));			
			
				Herompbar1.Width = (int)((float)heroMPwidth * ((float)heroes[0].getMP()/(float)heroes[0].getMaxMP()));
				Herompbar2.Width = (int)((float)heroMPwidth * ((float)heroes[1].getMP()/(float)heroes[1].getMaxMP()));
				
				//fill in enemy portraits
				if (phase ==4)
				{
					EnemyPortrait1.Image = new ImageAsset(PlayerStates.getPortraitFromOfficerID(enemies[0].getID()));
					EnemyPortrait3.Image = new ImageAsset(PlayerStates.getPortraitFromOfficerID(enemies[2].getID()));
				}
				EnemyPortrait2.Image = new ImageAsset(PlayerStates.getPortraitFromOfficerID(enemies[1].getID()));

				//hero portrait
				if (battlePhase != 2 && battlePhase!=5)
				{
					HeroPortrait2.Image = new ImageAsset(PlayerStates.getPortraitFromOfficerID(heroes[1].getID()));
				}
				if (battlePhase != 3){
					HeroPortrait1.Image = new ImageAsset(PlayerStates.getPortraitFromOfficerID(heroes[0].getID()));
				}
				
				//fill in skill icons
				if (battlePhase != 3){
					//get the first heroe's first skill ID
	            	btnHero1Skilltop.Image = new ImageAsset(PlayerStates.getIconFromSkillID(heroes[0].getSkill(0).getSkillID()));
					//get the first hero's second skill ID etc etc.
	            	btnHero1Skillleft.Image = new ImageAsset(PlayerStates.getIconFromSkillID(heroes[0].getSkill(1).getSkillID()));
	            	btnHero1Skillright.Image = new ImageAsset(PlayerStates.getIconFromSkillID(heroes[0].getSkill(2).getSkillID()));
				}
				
				//get the second hero's first skill ID... and so on 
				if (battlePhase!=2 && battlePhase!=5)
				{
		            btnHero2Skilltop.Image = new ImageAsset(PlayerStates.getIconFromSkillID(heroes[1].getSkill(0).getSkillID()));
		            btnHero2Skillleft.Image = new ImageAsset(PlayerStates.getIconFromSkillID(heroes[1].getSkill(1).getSkillID()));
		            btnHero2Skillright.Image = new ImageAsset(PlayerStates.getIconFromSkillID(heroes[1].getSkill(2).getSkillID()));
				}
				
				if(battlePhase!=3){
					//fill in inactive skill icon
	            	Hero1Skilltop.Image = new ImageAsset(PlayerStates.getInactiveIconFromSkillID(heroes[0].getSkill(0).getSkillID()));
	            	Hero1Skillleft.Image = new ImageAsset(PlayerStates.getInactiveIconFromSkillID(heroes[0].getSkill(1).getSkillID()));
	            	Hero1Skillright.Image = new ImageAsset(PlayerStates.getInactiveIconFromSkillID(heroes[0].getSkill(2).getSkillID()));
				}
				
				if (battlePhase != 2 && battlePhase!=5)
				{
		            Hero2Skilltop.Image = new ImageAsset(PlayerStates.getInactiveIconFromSkillID(heroes[1].getSkill(0).getSkillID()));
		            Hero2Skillleft.Image = new ImageAsset(PlayerStates.getInactiveIconFromSkillID(heroes[1].getSkill(1).getSkillID()));
		            Hero2Skillright.Image = new ImageAsset(PlayerStates.getInactiveIconFromSkillID(heroes[1].getSkill(2).getSkillID()));
				}
			
				//first, draw background overlay
				this.RootWidget.AddChildFirst(BackgroundOverlay);
				//then draw the background
				this.RootWidget.InsertChildAfter(Background, BackgroundOverlay);
				//portraits after background
				this.RootWidget.InsertChildAfter(HeroPortrait1, Background);
				this.RootWidget.InsertChildAfter(HeroPortrait2, Background);
				this.RootWidget.InsertChildAfter(EnemyPortrait1, Background);
				this.RootWidget.InsertChildAfter(EnemyPortrait2, Background);
				this.RootWidget.InsertChildAfter(EnemyPortrait3, Background);
				//empty hp/mp bars after Background
				this.RootWidget.InsertChildAfter(Herohp1, Background);
				this.RootWidget.InsertChildAfter(Herohp2, Background);
				this.RootWidget.InsertChildAfter(Heromp1, Background);
				this.RootWidget.InsertChildAfter(Heromp2, Background);
				this.RootWidget.InsertChildAfter(Enemyhp1, Background);
				this.RootWidget.InsertChildAfter(Enemyhp2, Background);
				this.RootWidget.InsertChildAfter(Enemyhp3, Background);
				this.RootWidget.InsertChildAfter(Enemymp1, Background);
				this.RootWidget.InsertChildAfter(Enemymp2, Background);
				this.RootWidget.InsertChildAfter(Enemymp3, Background);
				//actual hp/mpbars after hp/mp
				this.RootWidget.InsertChildAfter(Herohpbar1, Herohp1);
				this.RootWidget.InsertChildAfter(Herohpbar2, Herohp2);
				this.RootWidget.InsertChildAfter(Herompbar1, Heromp1);
				this.RootWidget.InsertChildAfter(Herompbar2, Heromp2);
				this.RootWidget.InsertChildAfter(Enemyhpbar1, Enemyhp1);
				this.RootWidget.InsertChildAfter(Enemyhpbar2, Enemyhp2);
				this.RootWidget.InsertChildAfter(Enemyhpbar3, Enemyhp3);
				this.RootWidget.InsertChildAfter(Enemympbar1, Enemymp1);
				this.RootWidget.InsertChildAfter(Enemympbar2, Enemymp2);
				this.RootWidget.InsertChildAfter(Enemympbar3, Enemymp3);
				
				//deactive icon after portrait
				this.RootWidget.InsertChildAfter(Hero1Skillleft, HeroPortrait1);
				this.RootWidget.InsertChildAfter(Hero1Skillright, Hero1Skillleft);
				this.RootWidget.InsertChildAfter(Hero1Skilltop, Hero1Skillright);
				this.RootWidget.InsertChildAfter(Hero2Skillleft, HeroPortrait2);
				this.RootWidget.InsertChildAfter(Hero2Skillright, Hero2Skillleft);
				this.RootWidget.InsertChildAfter(Hero2Skilltop, Hero2Skillright);
			
				//draw cooldown after deactivate
				this.RootWidget.InsertChildAfter(CDHero1L, Hero1Skilltop);
				this.RootWidget.InsertChildAfter(CDHero1T, CDHero1L);
				this.RootWidget.InsertChildAfter(CDHero1R, CDHero1T);
				this.RootWidget.InsertChildAfter(CDHero2L, Hero2Skilltop);
				this.RootWidget.InsertChildAfter(CDHero2T, CDHero2L);
				this.RootWidget.InsertChildAfter(CDHero2R, CDHero2T);
				
				//draw frame after cooldown
				this.RootWidget.InsertChildAfter(HeroFrame1,CDHero1R);
				this.RootWidget.InsertChildAfter(HeroFrame2,CDHero2R);
				this.RootWidget.InsertChildAfter(EnemyFrame1,EnemyPortrait1);
				this.RootWidget.InsertChildAfter(EnemyFrame2,EnemyPortrait2);
				this.RootWidget.InsertChildAfter(EnemyFrame3,EnemyPortrait3);
			
			
				//buttons last
				this.RootWidget.AddChildLast(btnHero1);
				this.RootWidget.AddChildLast(btnHero2);
				this.RootWidget.AddChildLast(btnHero1Skillleft);
				this.RootWidget.AddChildLast(btnHero1Skillright);
				this.RootWidget.AddChildLast(btnHero1Skilltop);
				this.RootWidget.AddChildLast(btnHero2Skillleft);
				this.RootWidget.AddChildLast(btnHero2Skillright);
				this.RootWidget.AddChildLast(btnHero2Skilltop);
			
				this.RootWidget.AddChildLast(btn_continue);
			
				//hero portrait tap
				hero1TG = new TapGestureDetector();
				hero1TG.TapDetected += hero1TGEventHandler;
				btnHero1.AddGestureDetector(hero1TG);
			
				hero2TG = new TapGestureDetector();
				hero2TG.TapDetected += hero2TGEventHandler;
				btnHero2.AddGestureDetector(hero2TG);
			
			
				//enemy body tap
				enemy1TG = new TapGestureDetector();
				enemy1TG.TapDetected += enemy1TGEventHandler;
				EnemyBody1.AddGestureDetector(enemy1TG);
			
				enemy2TG = new TapGestureDetector();
				enemy2TG.TapDetected += enemy2TGEventHandler;
				EnemyBody2.AddGestureDetector(enemy2TG);
			
				enemy3TG = new TapGestureDetector();
				enemy3TG.TapDetected += enemy3TGEventHandler;
				EnemyBody3.AddGestureDetector(enemy3TG);
			
				//hero skill tap
				hero1topTG = new TapGestureDetector();
				hero1topTG.TapDetected += hero1topEventHandler;
				btnHero1Skilltop.AddGestureDetector(hero1topTG);
			
				hero1leftTG = new TapGestureDetector();
				hero1leftTG.TapDetected += hero1leftEventHandler;
				btnHero1Skillleft.AddGestureDetector(hero1leftTG);
			
				hero1rightTG = new TapGestureDetector();
				hero1rightTG.TapDetected += hero1rightEventHandler;
				btnHero1Skillright.AddGestureDetector(hero1rightTG);
			
				hero2topTG = new TapGestureDetector();
				hero2topTG.TapDetected += hero2topEventHandler;
				btnHero2Skilltop.AddGestureDetector(hero2topTG);
			
				hero2leftTG = new TapGestureDetector();
				hero2leftTG.TapDetected += hero2leftEventHandler;
				btnHero2Skillleft.AddGestureDetector(hero2leftTG);
			
				hero2rightTG = new TapGestureDetector();
				hero2rightTG.TapDetected += hero2rightEventHandler;
				btnHero2Skillright.AddGestureDetector(hero2rightTG);
				
				battleOverTG = new TapGestureDetector();
				battleOverTG.TapDetected += battleOverEventHandler;
				btn_continue.AddGestureDetector(battleOverTG);
			
			}
		
			void battleOverEventHandler(object sender, TapEventArgs e)
			{
				SceneManager.BattleFinished();
			}
		
			public bool Win{
				get{
					return WinGame;
				}
			}
				
			void hero1topEventHandler(object sender, TapEventArgs e)
			{
				attackSelected = 0;				
				switch(heroes[0].getSkill(0).getSkillID())
				{
					case (int)skillDictionary.AUTO_ATTACK:
						Skillname.Text = "Auto Attack";
						break;
					case (int)skillDictionary.FIELD_MEDIC:
						Skillname.Text = "Field Medic";
						break;
					case (int)skillDictionary.HEAVY_BOOK:
						Skillname.Text = "Heavy Book";
						break;
					case (int)skillDictionary.MICRO_BLAST:
						Skillname.Text = "Micro Blast";
						break;
					case (int)skillDictionary.QUICK_STRIKE:
						Skillname.Text = "Quick Strike";
						break;
					case (int)skillDictionary.RUN_DOWN:
						Skillname.Text = "Run Down";
						break;
					case (int)skillDictionary.SHIELD_STANCE:
						Skillname.Text = "Shield Stance";
						break;
					default:
						Skillname.Text = "";
						break;	
				}

				Skillname.Visible= true;
				Cooldowndesc.Visible =true;
				MPdesc.Visible= true;
				Skilldesc.Visible = true;
				Cooldowndesc.Text = "Cooldown: "+heroes[0].getSkill(0).getCooldown().ToString();
				MPdesc.Text = "MP: "+ heroes[0].getSkill(0).getMP().ToString();
							
				Skilldesc.Text = "Effect: "+ PlayerStates.getDescFromSkillID(heroes[0].getSkill(0).getSkillID());
			
			}
		
		
			void hero1leftEventHandler(object sender, TapEventArgs e)
			{
				attackSelected = 1;
				
				switch(heroes[0].getSkill(1).getSkillID())
				{
					case (int)skillDictionary.AUTO_ATTACK:
						Skillname.Text = "Auto Attack";
						break;
					case (int)skillDictionary.FIELD_MEDIC:
						Skillname.Text = "Field Medic";
						break;
					case (int)skillDictionary.HEAVY_BOOK:
						Skillname.Text = "Heavy Book";
						break;
					case (int)skillDictionary.MICRO_BLAST:
						Skillname.Text = "Micro Blast";
						break;
					case (int)skillDictionary.QUICK_STRIKE:
						Skillname.Text = "Quick Strike";
						break;
					case (int)skillDictionary.RUN_DOWN:
						Skillname.Text = "Run Down";
						break;
					case (int)skillDictionary.SHIELD_STANCE:
						Skillname.Text = "Shield Stance";
						break;
					default:
						Skillname.Text = "";
						break;	
				}

				Skillname.Visible= true;
				Cooldowndesc.Visible =true;
				MPdesc.Visible= true;
				Skilldesc.Visible = true;
				Cooldowndesc.Text = "Cooldown: "+heroes[0].getSkill(1).getCooldown().ToString();
				MPdesc.Text = "MP: "+ heroes[0].getSkill(1).getMP().ToString();
				Skilldesc.Text = "Effect: "+ PlayerStates.getDescFromSkillID(heroes[0].getSkill(1).getSkillID());
			
			}
		
		void hero1rightEventHandler(object sender, TapEventArgs e)
			{
				attackSelected = 2;
				
				switch(heroes[0].getSkill(2).getSkillID())
				{
					case (int)skillDictionary.AUTO_ATTACK:
						Skillname.Text = "Auto Attack";
						break;
					case (int)skillDictionary.FIELD_MEDIC:
						Skillname.Text = "Field Medic";
						break;
					case (int)skillDictionary.HEAVY_BOOK:
						Skillname.Text = "Heavy Book";
						break;
					case (int)skillDictionary.MICRO_BLAST:
						Skillname.Text = "Micro Blast";
						break;
					case (int)skillDictionary.QUICK_STRIKE:
						Skillname.Text = "Quick Strike";
						break;
					case (int)skillDictionary.RUN_DOWN:
						Skillname.Text = "Run Down";
						break;
					case (int)skillDictionary.SHIELD_STANCE:
						Skillname.Text = "Shield Stance";
						break;
					default:
						Skillname.Text = "";
						break;	
				}

				Skillname.Visible= true;
				Cooldowndesc.Visible =true;
				MPdesc.Visible= true;
				Skilldesc.Visible = true;
				Cooldowndesc.Text = "Cooldown: "+heroes[0].getSkill(2).getCooldown().ToString();
				MPdesc.Text = "MP: "+ heroes[0].getSkill(2).getMP().ToString();
				Skilldesc.Text = "Effect: "+ PlayerStates.getDescFromSkillID(heroes[0].getSkill(2).getSkillID());
			
			}
		
		void hero2topEventHandler(object sender, TapEventArgs e)
			{
				attackSelected = 3;
				
				switch(heroes[1].getSkill(0).getSkillID())
				{
					case (int)skillDictionary.AUTO_ATTACK:
						Skillname.Text = "Auto Attack";
						break;
					case (int)skillDictionary.FIELD_MEDIC:
						Skillname.Text = "Field Medic";
						break;
					case (int)skillDictionary.HEAVY_BOOK:
						Skillname.Text = "Heavy Book";
						break;
					case (int)skillDictionary.MICRO_BLAST:
						Skillname.Text = "Micro Blast";
						break;
					case (int)skillDictionary.QUICK_STRIKE:
						Skillname.Text = "Quick Strike";
						break;
					case (int)skillDictionary.RUN_DOWN:
						Skillname.Text = "Run Down";
						break;
					case (int)skillDictionary.SHIELD_STANCE:
						Skillname.Text = "Shield Stance";
						break;
					default:
						Skillname.Text = "";
						break;	
				}

				Skillname.Visible= true;
				Cooldowndesc.Visible =true;
				MPdesc.Visible= true;
				Skilldesc.Visible = true;
				Cooldowndesc.Text = "Cooldown: "+heroes[1].getSkill(0).getCooldown().ToString();
				MPdesc.Text = "MP: "+ heroes[1].getSkill(0).getMP().ToString();
				Skilldesc.Text = "Effect: "+ PlayerStates.getDescFromSkillID(heroes[1].getSkill(0).getSkillID());
			
			}
		
		void hero2leftEventHandler(object sender, TapEventArgs e)
			{
				attackSelected = 4;
				
				switch(heroes[1].getSkill(1).getSkillID())
				{
					case (int)skillDictionary.AUTO_ATTACK:
						Skillname.Text = "Auto Attack";
						break;
					case (int)skillDictionary.FIELD_MEDIC:
						Skillname.Text = "Field Medic";
						break;
					case (int)skillDictionary.HEAVY_BOOK:
						Skillname.Text = "Heavy Book";
						break;
					case (int)skillDictionary.MICRO_BLAST:
						Skillname.Text = "Micro Blast";
						break;
					case (int)skillDictionary.QUICK_STRIKE:
						Skillname.Text = "Quick Strike";
						break;
					case (int)skillDictionary.RUN_DOWN:
						Skillname.Text = "Run Down";
						break;
					case (int)skillDictionary.SHIELD_STANCE:
						Skillname.Text = "Shield Stance";
						break;
					default:
						Skillname.Text = "";
						break;	
				}

				Skillname.Visible= true;
				Cooldowndesc.Visible =true;
				MPdesc.Visible= true;
				Skilldesc.Visible = true;
				Cooldowndesc.Text = "Cooldown: "+heroes[1].getSkill(1).getCooldown().ToString();
				MPdesc.Text = "MP: "+ heroes[1].getSkill(1).getMP().ToString();
				Skilldesc.Text = "Effect: "+ PlayerStates.getDescFromSkillID(heroes[1].getSkill(1).getSkillID());
			
			}
		
		void hero2rightEventHandler(object sender, TapEventArgs e)
			{
				attackSelected = 5;
				
				switch(heroes[1].getSkill(2).getSkillID())
				{
					case (int)skillDictionary.AUTO_ATTACK:
						Skillname.Text = "Auto Attack";
						break;
					case (int)skillDictionary.FIELD_MEDIC:
						Skillname.Text = "Field Medic";
						break;
					case (int)skillDictionary.HEAVY_BOOK:
						Skillname.Text = "Heavy Book";
						break;
					case (int)skillDictionary.MICRO_BLAST:
						Skillname.Text = "Micro Blast";
						break;
					case (int)skillDictionary.QUICK_STRIKE:
						Skillname.Text = "Quick Strike";
						break;
					case (int)skillDictionary.RUN_DOWN:
						Skillname.Text = "Run Down";
						break;
					case (int)skillDictionary.SHIELD_STANCE:
						Skillname.Text = "Shield Stance";
						break;
					default:
						Skillname.Text = "";
						break;	
				}

				Skillname.Visible= true;
				Cooldowndesc.Visible =true;
				MPdesc.Visible= true;
				Skilldesc.Visible = true;
				Cooldowndesc.Text = "Cooldown: "+heroes[1].getSkill(2).getCooldown().ToString();
				MPdesc.Text = "MP: "+ heroes[1].getSkill(2).getMP().ToString();
				Skilldesc.Text = "Effect: "+ PlayerStates.getDescFromSkillID(heroes[1].getSkill(2).getSkillID());
			
			}
		
			void attackFinished(int skillIndex)
			{
				//disable skill descriptions
				Skillname.Visible= false;
				Cooldowndesc.Visible= false;
				Skilldesc.Visible= false;
				MPdesc.Visible = false;
			
				
				switch(skillIndex)
				{
					case 0:
						CDHero1T.Visible = true;
						btnHero1Skilltop.Visible= false;
						CDList[skillIndex] = heroes[0].getSkill(0).getCooldown() * 1000;
						counterList[skillIndex]= 0;
						break;
					case 1:
						CDHero1L.Visible = true;
						btnHero1Skillleft.Visible = false;
						CDList[skillIndex] = heroes[0].getSkill(1).getCooldown() * 1000;
						counterList[skillIndex]= 0;
						break;
					case 2:
						CDHero1R.Visible = true;
						btnHero1Skillright.Visible = false;
						CDList[skillIndex] = heroes[0].getSkill(2).getCooldown() * 1000;
						counterList[skillIndex]= 0;
						break;
					case 3:
						CDHero2T.Visible = true;
						btnHero2Skilltop.Visible= false;
						CDList[skillIndex] = heroes[1].getSkill(0).getCooldown() * 1000;
						counterList[skillIndex]= 0;
						break;
					case 4:
						CDHero2L.Visible = true;
						btnHero2Skillleft.Visible = false;
						CDList[skillIndex] = heroes[1].getSkill(1).getCooldown() * 1000;
						counterList[skillIndex]= 0;
						break;
					case 5:
						CDHero2R.Visible = true;
						btnHero2Skillright.Visible = false;
						CDList[skillIndex] = heroes[1].getSkill(2).getCooldown() * 1000;
						counterList[skillIndex]= 0;
						break;
					default:
						break;
				}
			
			}
		
			void hero1TGEventHandler(object sender, TapEventArgs e)
			{
				if (attackSelected != 1 && attackSelected !=5) return;
				
				int animSlot=0;
				string animFile;
				int frmCount;
				int frmInterval;
				int frmCD;
			
				int skillIndex = (attackSelected ==1)? 1:2;
				int heroIndex = (attackSelected==1)? 0:1;
			
				animSlot = (animIndexHero1 ==4)?0:animIndexHero1+1;
				animIndexHero1++;
			
				if(attackSelected ==1)//heal first hero
				{
					if ((heroes[0].getHP () + 400 )> heroes[0].getMaxHP())
						heroes[0].setHP(heroes[0].getMaxHP());
					else heroes[0].setHP (heroes[0].getHP()+400);
				
					animFile = "assets/Combat UI/FieldMedic.png";
					frmCount = 16;
					frmInterval = 90;
					frmCD = 100*12;
				
					//play heal sound
					soundMutex.WaitOne();
					if(soundList[soundCounter] != null){
						soundList[soundCounter].Dispose();
						soundList[soundCounter] = null;
					}
					Sound tempSound = new Sound("assets/SFX/MG_Heal_01.wav");
					soundList[soundCounter] = tempSound.CreatePlayer();
					tempSound.Dispose();
					soundList[soundCounter].Play();
					soundCounter++;
					if (soundCounter>4) soundCounter =0;
					soundMutex.ReleaseMutex();
				}else//buff first hero
				{
					defBuff[0] = 0.2f;
					animFile = "assets/Combat UI/ShieldStance.png";
					frmCount = 16;
					frmInterval = 90;
					frmCD = 100*12;
					
					//play shield stance sound
					soundMutex.WaitOne();
					if(soundList[soundCounter] != null){
						soundList[soundCounter].Dispose();
						soundList[soundCounter] = null;
					}
					Sound tempSound = new Sound("assets/SFX/shield_stance_01.wav");
					soundList[soundCounter] = tempSound.CreatePlayer();
					tempSound.Dispose();
					soundList[soundCounter].Play();
					soundCounter++;
					if (soundCounter>4) soundCounter =0;
					soundMutex.ReleaseMutex();
				}
			
				
				//create the animation
				animHero1[animSlot] = new AnimationImageBox();
				animHero1[animSlot].Image = new ImageAsset(animFile);
				animHero1[animSlot].FrameWidth = 100;
				animHero1[animSlot].FrameHeight = 100;
				animHero1[animSlot].FrameCount = frmCount;
				animHero1[animSlot].FrameInterval = frmInterval;
				animHero1[animSlot].SetPosition(242,362);
				animHero1[animSlot].SetSize(100,100);
				animHero1[animSlot].Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
				this.RootWidget.AddChildLast(animHero1[animSlot]);
				animHero1[animSlot].Visible = true;
				animHero1[animSlot].Start();
				
				animCDHero1[animSlot] = frmCD;
			
			
				heroes[heroIndex].setMP(heroes[heroIndex].getMP () - heroes[heroIndex].getSkill(skillIndex).getMP());
				attackFinished(attackSelected);				
				attackSelected =-1;
			}
			
			void hero2TGEventHandler(object sender, TapEventArgs e)
			{
				if (attackSelected != 1 && attackSelected !=5) return;
			
				int animSlot=0;
				string animFile;
				int frmCount;
				int frmInterval;
				int frmCD;
			
				int skillIndex = (attackSelected ==1)? 1:2;
				int heroIndex = (attackSelected==1)? 0:1;
			
			
				//which animation box to use?
				animSlot = (animIndexHero2 ==4)?0:animIndexHero2+1;
				animIndexHero2++;
			
				if(attackSelected ==1){//heal first hero
					if ((heroes[1].getHP () + 400 )> heroes[1].getMaxHP())
						heroes[1].setHP(heroes[1].getMaxHP());
					else heroes[1].setHP (heroes[1].getHP()+400);
				
					animFile = "assets/Combat UI/FieldMedic.png";
					frmCount = 16;
					frmInterval = 90;
					frmCD = 100*12;
					
					//play heal sound
					soundMutex.WaitOne();
					if(soundList[soundCounter] != null){
						soundList[soundCounter].Dispose();
						soundList[soundCounter] = null;
					}
					Sound tempSound = new Sound("assets/SFX/MG_Heal_01.wav");
					soundList[soundCounter] = tempSound.CreatePlayer();
					tempSound.Dispose();
					soundList[soundCounter].Play();
					soundCounter++;
					if (soundCounter>4) soundCounter =0;
					soundMutex.ReleaseMutex();
				
				}else
				{
					defBuff[1] = 0.2f;
					animFile = "assets/Combat UI/ShieldStance.png";
					frmCount = 16;
					frmInterval = 90;
					frmCD = 100*12;
				
					//play shield stance sound
					soundMutex.WaitOne();
					if(soundList[soundCounter] != null){
						soundList[soundCounter].Dispose();
						soundList[soundCounter] = null;
					}
					Sound tempSound = new Sound("assets/SFX/shield_stance_01.wav");
					soundList[soundCounter] = tempSound.CreatePlayer();
					tempSound.Dispose();
					soundList[soundCounter].Play();
					soundCounter++;
					if (soundCounter>4) soundCounter =0;
					soundMutex.ReleaseMutex();
				}
			
				//create the animation
				animHero2[animSlot] = new AnimationImageBox();
				animHero2[animSlot].Image = new ImageAsset(animFile);
				animHero2[animSlot].FrameWidth = 100;
				animHero2[animSlot].FrameHeight = 100;
				animHero2[animSlot].FrameCount = frmCount;
				animHero2[animSlot].FrameInterval = frmInterval;
				animHero2[animSlot].SetPosition(467,362);
				animHero2[animSlot].SetSize(100,100);
				animHero2[animSlot].Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
				this.RootWidget.AddChildLast(animHero2[animSlot]);
				animHero2[animSlot].Visible = true;
				animHero2[animSlot].Start();
				
				animCDHero2[animSlot] = frmCD;
			
				heroes[heroIndex].setMP(heroes[heroIndex].getMP () - heroes[heroIndex].getSkill(skillIndex).getMP());
				attackFinished(attackSelected);				
				attackSelected =-1;
			
			}
			
			void enemy1TGEventHandler(object sender, TapEventArgs e)
			{
				if (attackSelected==-1 ||
			    	attackSelected== 1 ||
			    	attackSelected== 5)return;// no heal + shield up!
			
				switch(attackSelected)
				{
					case 0:
						//autoattack
						heroAttack(0,0,0);
						autoAttackTarget[0] = 0;
						break;
					case 1:
						heroAttack(0,1,0);
						break;
					case 2:
						heroAttack(0,2,0);
						break;
					case 3:
						heroAttack(1,0,0);
						autoAttackTarget[1] = 0;
						break;
					case 4:
						heroAttack(1,1,0);
						break;
					case 5:
						heroAttack(1,2,0);
						break;
					default:
						break;
					
				}
				attackFinished(attackSelected);
				attackSelected = -1;//after the attack, deselect
			}
		
			void enemy2TGEventHandler(object sender, TapEventArgs e)
			{
				if (attackSelected==-1 ||
			    	attackSelected== 1 ||
			    	attackSelected== 5)return;// no heal + shield up!
				switch(attackSelected)
				{
					case 0:
						heroAttack(0,0,1);
						autoAttackTarget[0] = 1;
						break;
					case 1:
						heroAttack(0,1,1);
						break;
					case 2:
						heroAttack(0,2,1);
						break;
					case 3:
						heroAttack(1,0,1);
						autoAttackTarget[1] = 1;
						break;
					case 4:
						heroAttack(1,1,1);
						break;
					case 5:
						heroAttack(1,2,1);
						break;
					default:
						break;
					
				}
				attackFinished(attackSelected);
				attackSelected = -1;//after the attack, deselect
			}
			
			void enemy3TGEventHandler(object sender, TapEventArgs e)
			{
				if (attackSelected==-1 ||
			    	attackSelected== 1 ||
			    	attackSelected== 5)return;// no heal + shield up!
			
				
				switch(attackSelected)
				{
					case 0:				
						heroAttack(0,0,2);
						autoAttackTarget[0] = 2;
						break;
					case 1:
						heroAttack(0,1,2);
						break;
					case 2:
						heroAttack(0,2,2);
						break;
					case 3:
						heroAttack(1,0,2);
						autoAttackTarget[1] = 2;
						break;
					case 4:
						heroAttack(1,1,2);
						break;
					case 5:
						heroAttack(1,2,2);
						break;
					default:
						break;
					
				}
				attackFinished(attackSelected);
				attackSelected = -1;//after the attack, deselect
			}
		
			public void heroAttack(int heroIndex, int skillIndex, int enemyIndex)
			{
				//here is where the attack dmg is calculated	
				int [] curHP = new int[3] {enemies[0].getHP(),enemies[1].getHP(), enemies[2].getHP()};
				int curMP = heroes[heroIndex].getMP();
				int [] dmg = new int[3] {0,0,0};
				
				int animSlot=0;
				string animFile;
				int frmCount;
				int frmInterval;
				int frmCD;
				Sound tempSound;
			
				//first find available animation slot
				animMutex.WaitOne();
				if (skillIndex!=1){ // not AOE
					if (enemyIndex==0){
						animSlot = (animIndexEnemy1 ==4)?0: animIndexEnemy1+1;
						animIndexEnemy1 = animSlot;
					}else if(enemyIndex==1){
						animSlot = (animIndexEnemy2 ==4)?0: animIndexEnemy2+1;
						animIndexEnemy2 = animSlot;
					}else if(enemyIndex ==2){
						animSlot = (animIndexEnemy3 ==4)?0: animIndexEnemy3+1;
						animIndexEnemy3 = animSlot;
					}
				}	
				animMutex.ReleaseMutex();
				//Console.WriteLine("Hero:"+heroIndex+"|skill:"+skillIndex+"|enemy:"+enemyIndex+"|slot:"+animSlot);
						
				switch (skillIndex)
				{
					case 0:
						//auto attack
						dmg[enemyIndex] = heroes[heroIndex].getSkill(skillIndex).getDmg();
						animFile = "assets/Combat UI/AutoAttack.png";
						frmCount = 9;
						frmInterval = 115;
						frmCD = 115*5;
				
						//play autoattack sound
						soundMutex.WaitOne();
						if(soundList[soundCounter] != null){
							soundList[soundCounter].Dispose();
							soundList[soundCounter] = null;
						}
						tempSound = new Sound("assets/SFX/Long_Sword_hit_Flesh_01.wav");
						soundList[soundCounter] = tempSound.CreatePlayer();
						tempSound.Dispose();
						soundList[soundCounter].Play();
						soundCounter++;
						if (soundCounter>4) soundCounter =0;
						soundMutex.ReleaseMutex();
				
						break;
					case 1:
						//run down
						dmg[0] = heroes[heroIndex].getSkill(skillIndex).getDmg();
						dmg[1] = heroes[heroIndex].getSkill(skillIndex).getDmg();
						dmg[2] = heroes[heroIndex].getSkill(skillIndex).getDmg();
						animFile = "assets/Combat UI/RunDown.png";
						frmCount = 12;
						frmInterval = 105;
						frmCD = 105*8;
				
						//play rundown sound
						soundMutex.WaitOne();
						if(soundList[soundCounter] != null){
							soundList[soundCounter].Dispose();
							soundList[soundCounter] = null;
						}
						tempSound = new Sound("assets/SFX/Run_Down_01.wav");
						soundList[soundCounter] = tempSound.CreatePlayer();
						tempSound.Dispose();
						soundList[soundCounter].Play();
						soundCounter++;
						if (soundCounter>4) soundCounter =0;
						soundMutex.ReleaseMutex();
				
						break;
					case 2:
						//Micro Blast
						dmg[enemyIndex] = heroes[heroIndex].getSkill(skillIndex).getDmg();
						animFile = "assets/Combat UI/MicroBlast.png";
						frmCount = 14;
						frmInterval = 115;
						frmCD = 115*10;
				
						//play microblast sound
						soundMutex.WaitOne();
						if(soundList[soundCounter] != null){
							soundList[soundCounter].Dispose();
							soundList[soundCounter] = null;
						}
						tempSound = new Sound("assets/SFX/MG_Air_01.wav");
						soundList[soundCounter] = tempSound.CreatePlayer();
						tempSound.Dispose();
						soundList[soundCounter].Play();
						soundCounter++;
						if (soundCounter>4) soundCounter =0;
						soundMutex.ReleaseMutex();
						
						break;
					default:
						dmg[enemyIndex] = heroes[heroIndex].getSkill(skillIndex).getDmg();
						animFile = "assets/Combat UI/AutoAttack.png";
						frmCount = 19;
						frmInterval = 115;
						frmCD = 115*15;
						break;	
				}
			
				//schedule animation
				if(skillIndex ==1){// animate rundown, it's a bit different
				
					//create the animation
					animAllenemy[0] = new AnimationImageBox();
					animAllenemy[0].Image = new ImageAsset(animFile);
					animAllenemy[0].FrameWidth = 250;
					animAllenemy[0].FrameHeight = 250;
					animAllenemy[0].FrameCount = frmCount;
					animAllenemy[0].FrameInterval = frmInterval;
					animAllenemy[0].SetPosition(270,130);
					animAllenemy[0].SetSize(250,250);
					animAllenemy[0].Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
					this.RootWidget.AddChildLast(animAllenemy[0]);
					animAllenemy[0].Visible = true;
					animAllenemy[0].Start();
				
					animCDAllenemy[0] = frmCD;
				
				}else if(enemyIndex ==0){
					//create the animation
					animEnemy1[animSlot] = new AnimationImageBox();
					animEnemy1[animSlot].Image = new ImageAsset(animFile);//autoattack image
					animEnemy1[animSlot].FrameWidth = 100;
					animEnemy1[animSlot].FrameHeight = 100;
					animEnemy1[animSlot].FrameCount = frmCount;
					animEnemy1[animSlot].FrameInterval = frmInterval;
					animEnemy1[animSlot].SetPosition(75,150);
					animEnemy1[animSlot].SetSize(100,100);
					animEnemy1[animSlot].Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
					this.RootWidget.AddChildLast(animEnemy1[animSlot]);
					animEnemy1[animSlot].Visible = true;
					animEnemy1[animSlot].Start();
				
					animCDEnemy1[animSlot] = frmCD;
				}else if(enemyIndex ==1){
					//create the animation
					animEnemy2[animSlot] = new AnimationImageBox();
					animEnemy2[animSlot].Image = new ImageAsset(animFile);//autoattack image
					animEnemy2[animSlot].FrameWidth = 100;
					animEnemy2[animSlot].FrameHeight = 100;
					animEnemy2[animSlot].FrameCount = frmCount;
					animEnemy2[animSlot].FrameInterval = frmInterval;
					animEnemy2[animSlot].SetPosition(350,150);
					animEnemy2[animSlot].SetSize(100,100);
					animEnemy2[animSlot].Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
					this.RootWidget.AddChildLast(animEnemy2[animSlot]);
					animEnemy2[animSlot].Visible = true;
					animEnemy2[animSlot].Start();
				
					animCDEnemy2[animSlot] = frmCD;
				}else if(enemyIndex ==2){
					//create the animation
					animEnemy3[animSlot] = new AnimationImageBox();
					animEnemy3[animSlot].Image = new ImageAsset(animFile);//autoattack image
					animEnemy3[animSlot].FrameWidth = 100;
					animEnemy3[animSlot].FrameHeight = 100;
					animEnemy3[animSlot].FrameCount = frmCount;
					animEnemy3[animSlot].FrameInterval = frmInterval;
					animEnemy3[animSlot].SetPosition(620,150);
					animEnemy3[animSlot].SetSize(100,100);
					animEnemy3[animSlot].Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
					this.RootWidget.AddChildLast(animEnemy3[animSlot]);
					animEnemy3[animSlot].Visible = true;
					animEnemy3[animSlot].Start();
				
					animCDEnemy3[animSlot] = frmCD;
				}
			  	
					
			
				//dmg calculation
				for (int i=0;i<3;i++){
					enemies[i].setHP(curHP[i] - dmg[i]);
				}
			
				//mana calculation
				heroes[heroIndex].setMP(curMP - heroes[heroIndex].getSkill(skillIndex).getMP());
			}
			
			public void enemyAttack(int enemyIndex, int skillIndex, int heroIndex)
			{
				//here is where the attack dmg is calculated
				int curMP = enemies[enemyIndex].getMP();
			
				float def_multiplier = 1- defBuff[heroIndex];
			
				//if the target hero dies, we need to select a new target
				if (heroes[heroIndex].getHP()<=0)
				{
					for (int i=0;i<2;i++)
					{
						if (heroes[i].getHP() > 0)
							heroIndex = i;
					}
				}
			
				int totalDmg = (int)((float)enemies[enemyIndex].getSkill(skillIndex).getDmg() * 
								def_multiplier);
			
				//dmg calculation
				heroes[heroIndex].setHP(heroes[heroIndex].getHP() - totalDmg);
				enemies[enemyIndex].setMP(curMP - enemies[enemyIndex].getSkill(skillIndex).getMP());
			}
		
			protected void killEnemy(int enemyID)
			{
				//I know this doesn't look clean, I will fix it
				if (enemyID == 0){
					EnemyBody1.RemoveGestureDetector(enemy1TG);
				
					new FadeOutEffect()
                    {
                        Widget = EnemyBody1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = EnemyFrame1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = EnemyPortrait1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemyhp1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemyhpbar1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemymp1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemympbar1,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = enemy1_hpstats,
                    }
                    .Start();
					
					new FadeOutEffect()
                    {
                        Widget = enemy1_mpstats,
                    }
                    .Start();
				
				}else if (enemyID ==1){
					EnemyBody2.RemoveGestureDetector(enemy2TG);
					new FadeOutEffect()
					{
						Widget = EnemyBody2,
					}
					.Start();
				
					new FadeOutEffect()
                    {
                        Widget = EnemyFrame2,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = EnemyPortrait2,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemyhp2,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemyhpbar2,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemymp2,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemympbar2,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = enemy2_hpstats,
                    }
                    .Start();
					
					new FadeOutEffect()
                    {
                        Widget = enemy2_mpstats,
                    }
                    .Start();
				}else if (enemyID ==2){
					EnemyBody3.RemoveGestureDetector(enemy3TG);

					new FadeOutEffect()
					{
						Widget = EnemyBody3,
					}
					.Start();	
				
					new FadeOutEffect()
                    {
                        Widget = EnemyFrame3,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = EnemyPortrait3,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemyhp3,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemyhpbar3,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemymp3,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = Enemympbar3,
                    }
                    .Start();
				
					new FadeOutEffect()
                    {
                        Widget = enemy3_hpstats,
                    }
                    .Start();
					
					new FadeOutEffect()
                    {
                        Widget = enemy3_mpstats,
                    }
                    .Start();

				}
			}
		
			protected override void OnUpdate (float elapsedTime)
			{
				base.OnUpdate (elapsedTime);
				enemyAtkTimer += elapsedTime;
				mpRegenCounter += (int)elapsedTime;
			
				int [] heroMP = new int[2] {heroes[0].getMP(),heroes[1].getMP()};
				int [] enemyMP = new int[3] {enemies[0].getMP(), enemies[1].getMP(), enemies[2].getMP()};
				int rand_target;
				int rand_skill;
			
				//hide enemies depends on phase
				if (battlePhase!=4)
				{
					EnemyBody1.Visible = false;
                    EnemyFrame1.Visible = false;
                    EnemyPortrait1.Visible = false;
                    Enemyhp1.Visible = false;
                    Enemyhpbar1.Visible = false;
                    Enemymp1.Visible = false;
                    Enemympbar1.Visible = false;
                    enemy1_hpstats.Visible = false;
                    enemy1_mpstats.Visible = false;
					EnemyBody3.Visible = false;
                    EnemyFrame3.Visible = false;
                    EnemyPortrait3.Visible = false;
                    Enemyhp3.Visible = false;
                    Enemyhpbar3.Visible = false;
                    Enemymp3.Visible = false;
                    Enemympbar3.Visible = false;
                    enemy3_hpstats.Visible = false;
                    enemy3_mpstats.Visible = false;	
				}
			
				if (battlePhase==2 || battlePhase ==5){
					btnHero2Skillleft.Visible= false;
					btnHero2Skillright.Visible= false;
					btnHero2Skilltop.Visible= false;
					HeroPortrait2.Visible= false;
					Herohp2.Visible= false;
					Herohpbar2.Visible= false;
					Heromp2.Visible= false;
					Herompbar2.Visible= false;
					HeroFrame2.Visible= false;
					hero2_hpstats.Visible= false;
					hero2_mpstats.Visible= false;
					btnHero2.Visible= false;
					Hero2Skillleft.Visible= false;
					Hero2Skillright.Visible= false;
					Hero2Skilltop.Visible= false;
					CDHero2T.Visible = false;
					CDHero2L.Visible = false;
					CDHero2R.Visible = false;
				}
				if (battlePhase==3){
					btnHero1Skillleft.Visible= false;
					btnHero1Skillright.Visible= false;
					btnHero1Skilltop.Visible= false;
					HeroPortrait1.Visible= false;
					Herohp1.Visible= false;
					Herohpbar1.Visible= false;
					Heromp1.Visible= false;
					Herompbar1.Visible= false;
					HeroFrame1.Visible= false;
					hero1_hpstats.Visible= false;
					hero1_mpstats.Visible= false;
					btnHero1.Visible= false;
					Hero1Skillleft.Visible= false;
					Hero1Skillright.Visible= false;
					Hero1Skilltop.Visible= false;
					CDHero1T.Visible = false;
					CDHero1L.Visible = false;
					CDHero1R.Visible = false;
				}
			
			    //set health bar
				Enemyhpbar1.Width = (int)((float)enemyHPwidth * ((float)enemies[0].getHP()/(float)enemies[0].getMaxHP()));
				Enemyhpbar2.Width = (int)((float)enemyHPwidth * ((float)enemies[1].getHP()/(float)enemies[1].getMaxHP()));
				Enemyhpbar3.Width = (int)((float)enemyHPwidth * ((float)enemies[2].getHP()/(float)enemies[2].getMaxHP()));
				Herohpbar1.Width = (int)((float)heroHPwidth * ((float)heroes[0].getHP()/(float)heroes[0].getMaxHP()));
				Herohpbar2.Width = (int)((float)heroHPwidth * ((float)heroes[1].getHP()/(float)heroes[1].getMaxHP()));
				
				//set new mp bar
				Enemympbar1.Width = (int)((float)enemyMPwidth * ((float)enemies[0].getMP()/(float)enemies[0].getMaxMP()));
				Enemympbar2.Width = (int)((float)enemyMPwidth * ((float)enemies[1].getMP()/(float)enemies[1].getMaxMP()));
				Enemympbar3.Width = (int)((float)enemyMPwidth * ((float)enemies[2].getMP()/(float)enemies[2].getMaxMP()));
				Herompbar1.Width = (int)((float)heroMPwidth * ((float)heroes[0].getMP()/(float)heroes[0].getMaxMP()));
				Herompbar2.Width = (int)((float)heroMPwidth * ((float)heroes[1].getMP()/(float)heroes[1].getMaxMP()));
	
				//set text for hp and mana
				enemy1_hpstats.Text = enemies[0].getHP().ToString() + "/" + enemies[0].getMaxHP().ToString();
				enemy2_hpstats.Text = enemies[1].getHP().ToString() + "/" + enemies[1].getMaxHP().ToString();
				enemy3_hpstats.Text = enemies[2].getHP().ToString() + "/" + enemies[2].getMaxHP().ToString();
				enemy1_mpstats.Text = enemies[0].getMP().ToString() + "/" + enemies[0].getMaxMP().ToString();
				enemy2_mpstats.Text = enemies[1].getMP().ToString() + "/" + enemies[1].getMaxMP().ToString();
				enemy3_mpstats.Text = enemies[2].getMP().ToString() + "/" + enemies[2].getMaxMP().ToString();
			
				hero1_hpstats.Text = heroes[0].getHP().ToString() + "/" + heroes[0].getMaxHP().ToString();
				hero2_hpstats.Text = heroes[1].getHP().ToString() + "/" + heroes[1].getMaxHP().ToString();
				hero1_mpstats.Text = heroes[0].getMP().ToString() + "/" + heroes[0].getMaxMP().ToString();
				hero2_mpstats.Text = heroes[1].getMP().ToString() + "/" + heroes[1].getMaxMP().ToString();
			
				//skillanimation
				for (int i=0; i< 5; i++){
					if (animHero1[i]!=null && (animCDHero1[i] - (int)elapsedTime)<=0){
						//stop animation
						animCDHero1[i] =0;
						animHero1[i].Stop();
						this.RootWidget.RemoveChild(animHero1[i]);
						animHero1[i].Dispose();
						animHero1[i] = null;
					}else if(animCDHero1[i]>0){
						animCDHero1[i]-=(int)elapsedTime;
					}
			
					if (animHero2[i]!=null && (animCDHero2[i] - (int)elapsedTime)<=0){
						//stop animation
						animCDHero2[i] =0;
						animHero2[i].Stop();
						this.RootWidget.RemoveChild(animHero2[i]);
						animHero2[i].Dispose();
						animHero2[i] = null;
					}else if(animCDHero2[i]>0){
						animCDHero2[i]-=(int)elapsedTime;
					}
				
					if (animEnemy1[i]!=null && (animCDEnemy1[i] - (int)elapsedTime)<=0){
						//stop animation
						animCDEnemy1[i] =0;
						animEnemy1[i].Stop();
						this.RootWidget.RemoveChild(animEnemy1[i]);
						animEnemy1[i].Dispose();
						animEnemy1[i] = null;
					}else if(animCDEnemy1[i]>0){
						animCDEnemy1[i]-=(int)elapsedTime;
					}
				
					if (animEnemy2[i]!=null && (animCDEnemy2[i] - (int)elapsedTime)<=0){
						//stop animation					
						animCDEnemy2[i] =0;
						animEnemy2[i].Stop();
						this.RootWidget.RemoveChild(animEnemy2[i]);
						animEnemy2[i].Dispose();
						animEnemy2[i] = null;
					}else if(animCDEnemy2[i]>0){
						animCDEnemy2[i]-=(int)elapsedTime;
					}
					if (animEnemy3[i]!= null && (animCDEnemy3[i] - (int)elapsedTime)<=0){
						//stop animation
						animCDEnemy3[i] =0;
						animEnemy3[i].Stop();
						this.RootWidget.RemoveChild(animEnemy3[i]);
						animEnemy3[i].Dispose();
						animEnemy3[i] = null;
					}else if(animCDEnemy3[i]>0){
						animCDEnemy3[i]-=(int)elapsedTime;
					}
					if (animAllenemy[i]!=null && (animCDAllenemy[i] - (int)elapsedTime)<=0){
						//stop animation
						animCDAllenemy[i] =0;
						animAllenemy[i].Stop();
						this.RootWidget.RemoveChild(animAllenemy[i]);
						animAllenemy[i].Dispose();
						animAllenemy[i] = null;
					}else if(animCDAllenemy[i]>0){
						animCDAllenemy[i]-=(int)elapsedTime;
					}
				}
			
				//regen 1 MP every second
				if (mpRegenCounter >= 2000){ 
					for (int i=0; i<2; ++i)
					{
						if (heroMP[i]<heroes[i].getMaxMP())
							heroes[i].setMP (heroMP[i]+1);
					}
					mpRegenCounter =0;
				}
			
				//show/hide skills depends on the mana
				if (heroes[0].getSkill(0).getMP() > heroMP[0])btnHero1Skilltop.Visible=false;
				else if(CDList[0] ==0 && battlePhase!=3)
				{ // autoattack
					btnHero1Skilltop.Visible = true;
					if (autoAttackTarget[0]!=-1 &&
				    	enemiesAlive[autoAttackTarget[0]]) // if target is set and alive
					{
						heroAttack(0,0,autoAttackTarget[0]);
						attackFinished(0);
					}else if (autoAttackTarget[0]!=-1 && 
				          		!enemiesAlive[autoAttackTarget[0]])// if target is not alive
					{
						autoAttackTarget[0] = -1;
					}
					// if target is dead
				}
			
				if (heroes[0].getSkill(1).getMP() > heroMP[0])btnHero1Skillleft.Visible=false;
				else if(CDList[1] ==0 && battlePhase!=3)btnHero1Skillleft.Visible = true;

				if (heroes[0].getSkill(2).getMP() > heroMP[0])btnHero1Skillright.Visible=false;
				else if(CDList[2] ==0&& battlePhase!=3)btnHero1Skillright.Visible = true;
			
			/*
			 * 1 - Aiden, Kira ... bandit 3
			 * 2 - Aiden       ... bandit 2
			 * 3 -        Kira ... bandit 1
			 * 4 - Aiden, Kira ... bandit 1 2 3
			 * 5 - Aiden,      ... bear
			 */
			
				if (heroes[1].getSkill(0).getMP() > heroMP[1])btnHero2Skilltop.Visible=false;
				else if(CDList[3] ==0 && (battlePhase!=2  && battlePhase !=5))
				{
					btnHero2Skilltop.Visible = true;
					if (autoAttackTarget[1]!=-1 &&
				    	enemiesAlive[autoAttackTarget[1]]) // if target is set and alive
					{
						heroAttack(1,0,autoAttackTarget[1]);
						attackFinished(3);
					}else if (autoAttackTarget[1]!=-1 && 
				          		!enemiesAlive[autoAttackTarget[1]])// if target is not alive
					{
						autoAttackTarget[1] = -1;
					}
				}
			
				if (heroes[1].getSkill(1).getMP() > heroMP[1])btnHero2Skillleft.Visible=false;
				else if(CDList[4] ==0 && (battlePhase!=2  && battlePhase !=5))btnHero2Skillleft.Visible = true;
			
				if (heroes[1].getSkill(2).getMP() > heroMP[1])btnHero2Skillright.Visible=false;
				else if(CDList[5] ==0 && (battlePhase!=2  && battlePhase !=5))btnHero2Skillright.Visible = true;
			
			
				//display cooldown timer
				for(int i=0; i< CDList.Length; ++i)
				{
					if (CDList[i] >0)
					{
						//display timer
						timerList[i].Width = (int)((float)originalCDSize * (1.0f-((float)counterList[i]/(float)CDList[i])));
					
						//Console.WriteLine ((1.0f-(float)(counterList[i]/CDList[i])).ToString());
						//minus counter
						counterList[i] += (int)elapsedTime;
					}
				}
			
				//hide finished cooldown timers
				for (int i=0; i<CDList.Length; i++)
				{
					if (CDList[i] >0 && counterList[i]>=CDList[i])
					{
						timerList[i].Width = originalCDSize;
						timerList[i].Visible = false;
						btnList[i].Visible = true;
						counterList[i] =0;
						CDList[i]=0;
					}
				}
			
				//attacker's battle logic
				for (int i=0; i < 3; i++)
				{
					if (enemiesAlive[i])
					{	
						if (enemyAtkCounter >= 3 &&
					    	enemies[i].getSkill(1).getMP() > enemyMP[i] &&
					    	enemies[i].getSkill(2).getMP() > enemyMP[i]) //use skill
						{
							rand_target = new Random().Next(0,2);
							rand_skill = new Random().Next(1,3); 
							enemyAttack(i,rand_skill,rand_target);
						}else if (enemyAtkTimer >= ENEMYCOOLDOWN)//autoattack
						{
							rand_target = new Random().Next(0,2);
							enemyAttack(i,0,rand_target);
						}
					}
				}
				if (enemyAtkTimer >= ENEMYCOOLDOWN)
				{
					enemyAtkCounter ++;
					enemyAtkTimer=0;
				}
				if (enemyAtkTimer>=3) enemyAtkCounter=0;
				
				
				//death detector
				for (int i=0; i<3; i++)
				{
					if (enemiesAlive[i] && enemies[i].getHP()<=0)
					{
						killEnemy(i);
						enemiesAlive[i] = false;
					}
				}
			
				//YOU WIN!!!
				if(!enemiesAlive[0] &&
			   		!enemiesAlive[1] &&
			   		!enemiesAlive[2] &&
			   		!battleOver){
					WinGame = true;
					battleOver = true;
					
					//FOR ROGER: switch to ending screen
					for (int i=0; i<5; i++){
						if(soundList[soundCounter] != null){
							soundList[soundCounter].Dispose();
							soundList[soundCounter] = null;
						}
					}
					
					Game.Instance.BattleFinished = true;
					 new FadeInEffect()
                    {
                        Widget = btn_continue,
                    }
                    .Start();
					
				}
				//YOU LOSE!!!
				if(!heroesAlive[0] &&
			   		!heroesAlive[1] &&
			   		!heroesAlive[2]&&
			   		!battleOver) {
					WinGame = false;
					battleOver = true;
					
					//FOR ROGER: switch to ending screen
					for (int i=0; i<5; i++){
						if(soundList[soundCounter] != null){
							soundList[soundCounter].Dispose();
							soundList[soundCounter] = null;
						}
					}	
					Game.Instance.BattleFinished = true;
				
					new FadeInEffect()
                    {
                        Widget = btn_continue,
                    }
                    .Start();
				}
			
			}
	    }
	}


	
/******************************************************************************************************************************/
	
	enum officerDictionary {AIDEN,KIRA,BANDIT1,BANDIT2,BANDIT3, BEAR};
	enum skillDictionary {AUTO_ATTACK, FIELD_MEDIC, MICRO_BLAST, RUN_DOWN, 
							SHIELD_STANCE, QUICK_STRIKE, HEAVY_BOOK};
	enum effectDictionary {HEAL, DEFUP, ATKUP, STUN, ADDITIONAL_ATTACK}
	
	
/******************************************************************************************************************************/	
		
namespace Magnate
{
	public class skillInfo
	{
		int mp;
		int dmg;
		int skillID;
		List<int> effects = new List<int>();
		List<float> effects_properties = new List<float>();
		int cooldown;
		
		public skillInfo(int skill)
		{
			skillID = skill;
			if (skill == (int)skillDictionary.AUTO_ATTACK){
				mp = 0;
				dmg = 15;
				cooldown = 10;
			}else if (skill == (int)skillDictionary.FIELD_MEDIC){
				mp = 25;
				dmg = 0;
				effects.Add((int)effectDictionary.HEAL);
				effects_properties.Add (400.0f);
				cooldown = 30;
			}else if (skill == (int)skillDictionary.MICRO_BLAST){
				mp = 25;
				dmg = 50;
				effects.Add ((int)effectDictionary.STUN);
				effects_properties.Add (3.0f);
				cooldown = 30;
			}else if(skill == (int)skillDictionary.RUN_DOWN){
				mp = 50;
				dmg = 75;
				effects.Add ((int)effectDictionary.STUN);
				effects_properties.Add(2.0f);
				cooldown = 30;
			}else if(skill == (int)skillDictionary.SHIELD_STANCE){
				mp = 25;
				dmg = 0;
				effects.Add ((int)effectDictionary.DEFUP);
				effects_properties.Add(0.2f);
				cooldown = 30;
			}else if (skill == (int)skillDictionary.QUICK_STRIKE){
				mp = 25;
				dmg = 50;
				effects.Add ((int)effectDictionary.ADDITIONAL_ATTACK);
				effects_properties.Add(2.0f);
				cooldown = 30;
			}else if (skill == (int)skillDictionary.HEAVY_BOOK){
				mp = 25;
				dmg =0;
				//TEMP EFFECT
				effects.Add((int)effectDictionary.ATKUP);
				effects_properties.Add(0.3f);
				cooldown = 60;
			}
				
				
		}
		public int getMP()
		{
			return mp;	
		}
		public int getDmg()
		{
			return dmg;
		}
		public int getSkillID()
		{
			return skillID;	
		}
		public int getCooldown()
		{
			return cooldown;	
		}
	}
	
	//this class stores the states of each character
	public class CharacterStates
	{
		private int officerID;
		private int level;
		private int maxhp;
		private int hp;
		private int maxmp;
		private int mp;
		
		skillInfo[] skills = new skillInfo[4];
		public CharacterStates(int officer){
			//create the character
			officerID = officer;
			if (officer == (int)officerDictionary.AIDEN)
			{
				level = 1;
				maxhp = 300;
				hp = 300;
				maxmp = 60;
				mp = 60;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.FIELD_MEDIC);
				skills[2] = new skillInfo((int)skillDictionary.MICRO_BLAST);
				skills[3] = null;
			}else if(officer == (int)officerDictionary.KIRA){
				level = 1;
				maxhp = 300;
				hp = 300;
				maxmp = 100;
				mp = 100;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.RUN_DOWN);
				skills[2] = new skillInfo((int)skillDictionary.SHIELD_STANCE);
				skills[3] = null;
			}else if (officer == (int)officerDictionary.BANDIT1){
				level = 1;
				maxhp = 300;
				hp = 300;
				maxmp = 100;
				mp = 100;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.RUN_DOWN);
				skills[2] = new skillInfo((int)skillDictionary.SHIELD_STANCE);
				skills[3] = null;
			}else if (officer == (int)officerDictionary.BANDIT2){
				level = 1;
				maxhp = 300;
				hp = 300;
				maxmp = 100;
				mp = 100;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.RUN_DOWN);
				skills[2] = new skillInfo((int)skillDictionary.SHIELD_STANCE);
				skills[3] = null;
			}else if (officer == (int)officerDictionary.BANDIT3)
			{
				level = 1;
				maxhp = 200;
				hp = 200;
				maxmp = 100;
				mp = 100;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.QUICK_STRIKE);
				skills[2] = null;
				skills[3] = null;
			}else if (officer ==(int)officerDictionary.BANDIT3){
				level = 1;
				maxhp = 200;
				hp = 200;
				maxmp = 100;
				mp = 100;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.HEAVY_BOOK);
				skills[2] = new skillInfo((int)skillDictionary.MICRO_BLAST);
				skills[3] = null;
			}else if (officer==(int)officerDictionary.BEAR){
				level =1;
				maxhp = 600;
				hp = 600;
				maxmp=600;
				mp = 600;
				skills[0] = new skillInfo((int)skillDictionary.AUTO_ATTACK);
				skills[1] = new skillInfo((int)skillDictionary.RUN_DOWN);
				skills[2] = new skillInfo((int)skillDictionary.MICRO_BLAST);
				skills[3] = null;
			}
		}
		public skillInfo getSkill(int ele){ return skills[ele];}
		public int getID(){ return officerID; }
		public int getHP(){ return hp;}
		public int getMaxHP(){return maxhp;}
		public int getMP(){ return mp;}
		public int getMaxMP() { return maxmp; }
		
		public void setHP(int _hp){hp = _hp;}
		public void setMP(int _mp){mp = _mp;}
		
		
		
	}
	
/******************************************************************************************************************************/	
	
	public class PlayerStates
	{
		private static List<CharacterStates> officersList = new List<CharacterStates>();
		
		public PlayerStates (){}
		
		public static CharacterStates[] getCurrentOfficers(){
			return officersList.ToArray();
		}
		
		public static void addOfficer(int officerID){
			CharacterStates newOfficer = new CharacterStates(officerID);
			officersList.Add(newOfficer);
		}
		
		//this function is used to find portrait picture for a given character ID
		public static String getPortraitFromOfficerID(int officerID){
			if (officerID == (int)officerDictionary.KIRA){
				return "assets/Combat UI/kira_portrait.png";	
			}else if(officerID == (int)officerDictionary.AIDEN){
				return "assets/Combat UI/aiden_portrait.png";	
			}else if(officerID == (int)officerDictionary.BANDIT1){
				return "assets/Combat UI/bandit1_portrait.png";	
			}else if(officerID == (int)officerDictionary.BANDIT2){
				return "assets/Combat UI/bandit2_portrait.png";	
			}else if(officerID == (int)officerDictionary.BANDIT3){
				return "assets/Combat UI/bandit3_portrait.png";	
			}else if(officerID == (int)officerDictionary.BEAR){
				return "assets/Combat UI/bear_portrait.png";	
			}
			else{
				//default picture
				return "assets/Combat UI/portrait.png";	
			}
		}
		
		
		//this function is used to fetch the full body shot of a given character
		public static String getBodyFromOfficerID(int officerID){
			if (officerID == (int)officerDictionary.BANDIT1){
				return "assets/Combat UI/bandit1_angry.png";
			}else if(officerID == (int)officerDictionary.BANDIT2){
				return "assets/Combat UI/bandit2_angry.png";
			}else if(officerID == (int)officerDictionary.BANDIT3){
				return "assets/Combat UI/bandit3_angry.png";
			}else if(officerID == (int)officerDictionary.AIDEN){
				return "assets/Combat UI/aiden_body.png";	
			}else if(officerID == (int)officerDictionary.KIRA){
				return "assets/Combat UI/kira_body.png";	
			}else if(officerID == (int)officerDictionary.BEAR){
				return "assets/Combat UI/bear_angry.png";
			}else{//default
				return "assets/Combat UI/bandit1_angry.png";
			}
		}
		
		public static String getDescFromSkillID(int skillID)
		{
			if (skillID == (int)skillDictionary.AUTO_ATTACK)
			{
					return "Auto attacks a single enemy";
			}
			else if (skillID == (int) skillDictionary.FIELD_MEDIC)
			{
				return "Heals 400 for a single ally";
			}
			else if (skillID == (int) skillDictionary.HEAVY_BOOK)
			{
				return "Increases damage for 20s";
			}
			else if (skillID == (int) skillDictionary.MICRO_BLAST)
			{
				return "Stuns a single enemy for 3s";
			}
			else if (skillID == (int) skillDictionary.QUICK_STRIKE)
			{
				return "Attacks twice for 25";
			}
			else if (skillID == (int) skillDictionary.RUN_DOWN)
			{
				return "Stuns all enemies for 2s";
			}
			else if (skillID == (int) skillDictionary.SHIELD_STANCE)
			{
				return "Increases defense by 20% for the rest of the Battle";
			}
			else 
			{
				return "";
			}
			
		}
		
		//this function is used to fetch the icon picture for a given skill ID
		public static String getIconFromSkillID(int skillID)
		{
			if (skillID == (int)skillDictionary.AUTO_ATTACK)
			{
					return "assets/Combat UI/quickstrike_active.png";
			}
			else if (skillID == (int) skillDictionary.FIELD_MEDIC)
			{
				return "assets/Combat UI/fieldmedic_active.png";
			}
			else if (skillID == (int) skillDictionary.HEAVY_BOOK)
			{
				return "assets/Combat UI/heavybook_active.png";
			}
			else if (skillID == (int) skillDictionary.MICRO_BLAST)
			{
				return "assets/Combat UI/microblast_active.png";
			}
			else if (skillID == (int) skillDictionary.QUICK_STRIKE)
			{
				return "assets/Combat UI/quickstrike_active.png";
			}
			else if (skillID == (int) skillDictionary.RUN_DOWN)
			{
				return "assets/Combat UI/rundown_active.png";
			}
			else if (skillID == (int) skillDictionary.SHIELD_STANCE)
			{
				return "assets/Combat UI/shieldstance_active.png";
			}
			else 
			{
				return "assets/Combat UI/btnSkill.png";
			}
		}
		
		public static String getInactiveIconFromSkillID(int skillID)
		{
			if (skillID == (int)skillDictionary.AUTO_ATTACK)
			{
					return "assets/Combat UI/quickstrike_inactive.png";
			}
			else if (skillID == (int) skillDictionary.FIELD_MEDIC)
			{
				return "assets/Combat UI/fieldmedic_inactive.png";
			}
			else if (skillID == (int) skillDictionary.HEAVY_BOOK)
			{
				return "assets/Combat UI/heavybook_inactive.png";
			}
			else if (skillID == (int) skillDictionary.MICRO_BLAST)
			{
				return "assets/Combat UI/microblast_inactive.png";
			}
			else if (skillID == (int) skillDictionary.QUICK_STRIKE)
			{
				return "assets/Combat UI/quickstrike_inactive.png";
			}
			else if (skillID == (int) skillDictionary.RUN_DOWN)
			{
				return "assets/Combat UI/rundown_inactive.png";
			}
			else if (skillID == (int) skillDictionary.SHIELD_STANCE)
			{
				return "assets/Combat UI/shieldstance_inactive.png";
			}
			else 
			{
				return "assets/Combat UI/btnSkill.png";
			}
			
		}
	}
	
}
