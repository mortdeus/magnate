using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;
using Magnate;

enum CurrentScene
{
	First   = 1,
	Second  = 2,
	Third   = 3,
	Fourth  = 4,
	Fifth   = 5,
	Sixth   = 6,
	Seventh = 7,
	Eighth  = 8,
	Nineth  = 9,
	Tenth   = 10
};

namespace MagnateUI
{
	public partial class ChatDialogueUI : Scene
	{
		Game game = Game.Instance;
		TapGestureDetector continueTapGestureDetector;
		int count = 0;
		static int currentPhase = 0;
		bool forceSetUp = false;
		
		public ChatDialogueUI ()
		{	
			
            
			Aiden = new Sprite ();
			Kira = new Sprite ();
			Bear = new Sprite ();
			Bandit1 = new Sprite ();
			Bandit2 = new Sprite ();
			Bandit3 = new Sprite ();
			
			LCharBoxL = new ImageBox ();
			LCharBoxL.Name = "LCharBoxL";
			LCharboxR = new ImageBox ();
			LCharboxR.Name = "LCharboxR";
			RCharBoxR = new ImageBox ();
			RCharBoxR.Name = "RCharBoxR";
			RCharBoxL = new ImageBox ();
			RCharBoxL.Name = "RCharBoxL";
			RCharBoxM = new ImageBox ();
			RCharBoxM.Name = "RCharBoxM";
			DialogueText = new Label ();
			DialogueText.Name = "DialogueText";
			screenVignette = new ImageBox ();
			screenVignette.Name = "ScreenVignette";
			ChatBox = new ImageBox ();
			ChatBox.Name = "ChatBox";
			DialogueText = new Label ();
			DialogueText.Name = "DialogueText";
			
			Aiden.state = (int)CharacterState.Normal;
			Kira.state = (int)CharacterState.Normal;
			Bear.state = (int)CharacterState.Normal;
			Bandit1.state = (int)BanditState.BANDIT1_SMUG;
			Bandit2.state = (int)BanditState.BANDIT2_SMUG;
			Bandit3.state = (int)BanditState.BANDIT3_SMUG;
	    	
					
			currentPhase++;
						
			InitializeWidget ();
						
			continueTapGestureDetector = new TapGestureDetector ();
			
			continueTapGestureDetector.TapDetected += TextTapGestureEventHandler;
			
			screenVignette.AddGestureDetector (continueTapGestureDetector);
			
			UpdateLanguage ();
			
		}
		
		void TextTapGestureEventHandler (object sender, TapEventArgs e)
		{
			UpdateLanguage ();
			
			
		}
		
		public void UpdateLanguage ()
		{
						
				
			switch (currentPhase) {
				#region Scene One
			case (int)CurrentScene.First:
						

					
				if (count == 0) {			
					
					DialogueText.Text = "It has been five years of long conquest for our young \theroes Aiden and Kira, who are trying to restore    peace " +
						"amongst the volatile Kingdoms of Adura."; 				
					
				}
					
				if (count == 1) {	

					DialogueText.Text = "Wary from battle our heroes have finally set their" +
						"     eyes on their goal, Cuprille.";
				}
				if (count == 2) {
					DialogueText.Text = "However; feelings of relief were short lived when     they realize the town they once " +
						"knew as a kingdom  of prosperity,";
				}
					
				if (count == 3)
					DialogueText.Text = "is now a barren rundown ghost town...";	

				if (count == 4) {
					Aside = false;
					
					game.ChatFinished = true;
					game.resetCount = true;
				}
				if (count == 0 | count == 4)
					SetUpCharacters ();
					
				count++;
				
					
				break;
				#endregion
						
				#region Scene Two
			case (int)CurrentScene.Second:
					
					

				if (count == 0) {
					
					
					DialogueText.Text = "Aiden and Kira emerge in the town and are filled     " +
						"with grief when the place they once called home is  " +
						"just a mere shadow of its former self. The question  of what or whom could have " +
						"caused this devestation to their beloved town is brought to their minds.";
					
				}

				if (count == 1) {
					
					setAiden = true;
					setKira = true;
					Aside = false;
					
					DialogueText.Text = " Aiden & Kira: Cuprille!?";
					setAiden = true;
					setKira = true;
					Aiden.state = (int)CharacterState.Shocked;
					Kira.state = (int)CharacterState.Shocked;
					
					SetWidgetLayout (LayoutOrientation.Horizontal);
					
				}
								
				if (count == 2) {	
					DialogueText.Text = "Aiden: What has happened?! " +
					"It's deserted!";
						
				}
				if (count == 3) {
					DialogueText.Text = "Kira: There are no children playing anymore, or fragrances of hot apple pie at every window.";	
				}
					
				if (count == 4) {
					DialogueText.Text = "Kira: What could have caused this...? We need to get to the bottom of this.";
					Kira.state = (int)CharacterState.Thinking;			
					Aiden.state = (int)CharacterState.Thinking;	
				}
				if (count == 5) {
					DialogueText.Text = "BlackSmith: Hey kids! Get over here!";
				}
				if (count == 6) {
					DialogueText.Text = "Aiden & Kira: Huh?";
					Aiden.state = (int)CharacterState.Shocked;
					Kira.state = (int)CharacterState.Shocked;
				}
					
				if (count == 7) {
					DialogueText.Text = "Blacksmith: Hurry, before someone sees you!";

				}
				if (count == 8) {
					SceneManager.ReplaceScene ((int)GE2D.BLACKSMITH);
										
					DialogueText.Text = "Our heroes run towards the door, and the blacksmith shuts it behind them. " +
				"The blacksmith remains in the shadows.";
					Aside = true;
					setKira = false;
					setAiden = false;
					
					SetUpCharacters (Aiden, Kira);
					SetWidgetLayout (LayoutOrientation.Horizontal);
				}
				if (count == 9) {
					DialogueText.Text = "Kira: Why have you called us in here, blacksmith? What has hap.....";
					Aside = false;
					setAiden = true;
					setKira = true;
					Aiden.state = (int)CharacterState.Thinking;
					Kira.state = (int)CharacterState.Thinking;
					SetWidgetLayout (LayoutOrientation.Horizontal);
				}
				if (count == 10) {
					DialogueText.Text = "BlackSmith: Silence. These times are too dangerous and time too short for chit chat. " +
				"I saw you and your army coming in from the east.";
				}
				if (count == 11) {
					DialogueText.Text = "So, I'm going to make this short. We need your help to take back this land from an evil knight that " +
				"sieged our neighbor kingdom from the north";
				}
				if (count == 12) {
					DialogueText.Text = "Aiden: Rihan has been sieged too!?";
					Aiden.state = (int)CharacterState.Shocked;
					Kira.state = (int)CharacterState.Shocked;
				}
				if (count == 13) {
					DialogueText.Text = "Kira: Things are worse then we thought.";
					Kira.state = (int)CharacterState.Thinking;	
					Aiden.state = (int)CharacterState.Worried;
				}
				if (count == 14) {
					DialogueText.Text = "Aiden: So where do we start?";
					Aiden.state = (int)CharacterState.Thinking;
				}

				if (count == 15) {
					DialogueText.Text = "Blacksmith: I suggest we first take back our mines. " +
				"Then I may be more of a use in our revolt against our oppressors.";		
				}
					
				if (count == 16) {
					DialogueText.Text = "Aiden: Right. Well, we will be back soon after we reclaim the mines."; 	
					Aiden.state = (int)CharacterState.Angry;
					Kira.state = (int)CharacterState.Normal;
				}

				if (count == 17) {
					DialogueText.Text = "Blacksmith: Oh, and be careful; some say lately that the mines have become... Haunted";
					setAiden = false;
					setKira = false;
				}

				if (Aiden.state != Aiden.oldState | Kira.state != Kira.oldState)				
					SetUpCharacters (Aiden, Kira);
					
				if (count == 18) {
					game.ChatFinished = true;
					game.resetCount = true;
					SetUpCharacters ();	
				}
				count++;
			
					
				break;
				#endregion
				
					
				#region Scene Three
			case (int)CurrentScene.Third:
				
				
				
				if (count == 0) {	
					DialogueText.Text = "Our heroes aproach the mines. A sense of unease has filled the air while the " +
					"blacksmith's grave warning of a haunted mine echoes in their minds";
												
					
				}
																		
				if (count == 1) {	
					DialogueText.Text = "Aiden: Well, here we are. At the \"haunted\" mines.";
					Aiden.state = (int)CharacterState.Normal;				
					setAiden = true;
					setKira = true;
					Aside = false;
					//SetUpCharacters (Aiden, Kira);
					SetWidgetLayout (LayoutOrientation.Horizontal);
						
				}
				if (count == 2) {
					DialogueText.Text = "Kira: Haunted mines or not, men, we will not let any make believe ghosts hold us " +
					"back from glory! Charge in there!";
					Kira.state = (int)CharacterState.Angry;	
				}
					
				if (count == 3) {
					DialogueText.Text = "As the men charge into the mine, a few moments pass before shrieks of fear echo out of the cave. " +
						"Suddenly all sound stops and anxiety slowly creeps in.";
					Aside = true;
					setAiden = false;
					setKira = false;
					//SetUpCharacters (Aiden, Kira);
					SetWidgetLayout (LayoutOrientation.Horizontal);

				}
							
				
				if (count == 4) {
					DialogueText.Text = "Aiden: We need to help them! All men, I'm at point, charge!";
					setAiden = true;
					setKira = true;
					
					Aiden.state = (int)CharacterState.Angry;
					Kira.state = (int)CharacterState.Worried;
					
					
					Aside = false;
					SetWidgetLayout (LayoutOrientation.Horizontal);
				}
				if (count == 5) {
					DialogueText.Text = "Aiden and Kira choose to split up and after a few moments of decending deeper into to the mines. " +
				"They come to the central main shaft.";
					
					Aside = true;
					setAiden = false;
					setKira = false;
					
					SetWidgetLayout (LayoutOrientation.Horizontal);
				}
				if (count == 6) {
					DialogueText.Text = "Kira: Did you see anything?";
					setAiden = true;
					setKira = true;
					
					Aside = false;
					SetWidgetLayout (LayoutOrientation.Horizontal);
					
					Kira.state = (int)CharacterState.Normal;
					Aiden.state = (int)CharacterState.Worried;
				}
				if (count == 7) {
					DialogueText.Text = "Aiden: Nothing. No blood, no weapons, no signs of struggle. It's as if they...";
					Aiden.state = (int)CharacterState.Thinking;
				}
				if (count == 8) {
					DialogueText.Text = "Aiden & Kira: Vanished!"; 
								
					Kira.state = (int)CharacterState.Thinking;
				}
				if (count == 9) {
					DialogueText.Text = "Unknown: Heh heh heh. Combusted and disintegrated to be more precise."; 
				}
				
				if (count == 10) {
						
					
					DialogueText.Text = "Aiden: Who said that? Show yourself!";
					Aiden.state = (int)CharacterState.Shocked;
					Kira.state = (int)CharacterState.Shocked;
				}
				if (count == 11) {
					DialogueText.Text = "Unknown: It will be a pleasure. I am Elider the Taint."; 
					setBandit3 = true;
					kiraOnLeft = true;
					Bandit3.state = (int)BanditState.BANDIT3_SMUG;
					Kira.forcevisible = true;
					
				}
				if (count == 12) {
					DialogueText.Text = "Kira: You did this to my men!? You will pay for what you have done!";				
					Aiden.state = (int)CharacterState.Angry;
					Kira.state = (int)CharacterState.Angry;	
				}
				if (count == 13) {
					DialogueText.Text = "Elider: If you want to die, little girl, it will be my pleasure to grant your wish.";
					Bandit3.state = (int)BanditState.BANDIT3_ANNOY;
					SetUpCharacters (Aiden, Kira, Bandit3);
				}
				if (count == 14) {
					DialogueText.Text = "Kira: Just shut up and draw your sword, old man!";
					Kira.state = (int)CharacterState.Angry;
				}
				if (count == 15) {
				game.StartBattle = true;
					
				}
				if (count == 16) {
					DialogueText.Text = "Kira: Heh. Old man, I didn't even break a sweat. Now to put you out of your misery!";
					Kira.forcevisible = true;
					Aiden.state = (int)CharacterState.Happy;
					Bandit3.state = (int)BanditState.BANDIT3_MAD;
				}
				if (count == 17) {
					DialogueText.Text = "Elider: Ugghhh, you little nitwits. Do you have any idea of who you are messing with here? " +
						"Lord Darius will not be pleased to hear of your interference with our plans.";
					Bandit3.state = (int)BanditState.BANDIT3_MAD;
				}
				if (count == 18) {
					DialogueText.Text = "Aiden: Kira wait, Lord Darius!? It can't be! My father vanquished him and his legion long ago!";
					Aiden.state = (int)CharacterState.Shocked;
					Kira.state = (int)CharacterState.Normal;
				}
				
				if (count == 19) {
					DialogueText.Text = "Elider: HA HA HA HA!  Well well, so you must be the son of Aimes the Magnate? And you are trying to " +
					"follow in your fathers footsteps too, I see? What a noble way to lead your life... to your death; much like your father did!";
					Bandit1.state = (int)BanditState.BANDIT3_SMUG;
				}
					if (count == 20) {
						DialogueText.Text = "Kira: WHY YOU! I will cut out your tongue for insulting the greatest hero in the history of Adura...!";
					Aiden.state = (int)CharacterState.Worried;	
					Kira.state = (int)CharacterState.Angry;					
					}
					

					if (count == 21) {
						DialogueText.Text = "Aiden: Kira... back down. Mage, Go tell your master to prepare for war. We end this now.";
						Aiden.state = (int)CharacterState.Angry;		
						
						
					}
					
					if (count == 22) {
						DialogueText.Text = "Kira: We are letting him go?! But my men...";
						Kira.state = (int)CharacterState.Shocked;
						setBandit3 = false;
						
						
				}
					if (count == 23) {
						DialogueText.Text = "Aiden: Kira, I'm sorry about your men, but I want to make sure Lord Darius is fully aware of who is at " +
				"his doorstep ready for battle. Also, the man was clearly defeated. We do not murder unarmed opponenets. " +
				"Or else we become the same as them.";
						Aiden.state = (int)CharacterState.Angry;							
					}

				

					if (count == 24) {
						DialogueText.Text = "Kira: But... GRRR! Fine. Stupid men with their morals and egos. I'm out of here!";
						Kira.state = (int)CharacterState.Angry;			

					}
					
					if (count == 25) {
						
						DialogueText.Text = "Aiden: Kira! Wait...";
						Aiden.state = (int)CharacterState.Shocked;
						setKira = false;
						kiraOnLeft = false;
					}
					
					if (count == 26) {
					SceneManager.ReplaceScene((int)GE2D.HILL);
					
					
					DialogueText.Text = " Later that evening, Aiden sits ontop of a hill having isolated himself from his men. " +
				"A lone tear runs down his face as he remembers a dear memory from his youth with his father.";
						Aiden.state = (int)CharacterState.Worried;

					}
					if (count == 27) {
						DialogueText.Text = " Inside, Aiden believes that if he could even become half the hero his father was, he could pass on " +
				"from this world completely satisifed he lived a fulfilling life."; 


					}
					if (count == 28) {
						DialogueText.Text = "It's been a long five years without his father's guidance, but he is fully aware of what his " +
				"next move must be.  Suddenly, he begins to collect himself as he senses someone approaching.";
					Aiden.state = (int)CharacterState.Normal;

					}
					if (count == 29) {
						DialogueText.Text = "Kira: Look Aiden. I'm sorry about earlier. You are right considering the fact that, as leaders, " +
				"we don't kill unarmed defeated men. We must set the example. However, why would you want to give away the element of surprise?";
						
					setKira = true;
					Kira.state = (int)CharacterState.Worried;			
					}
					if (count == 30) {
						DialogueText.Text = "Aiden: The element of surprise against Darius? He knows that our army is here. " +
				"However, I want him to personally know that I am here. To avenge my fathers death, by defeating his murderer at his best!"; 
						Aiden.state = (int)CharacterState.Angry;			

					}

					if (count == 31) {
						DialogueText.Text = "Kira: Darius killed your father? But I thought he died from a rare illness that he caught on " +
				"during his last campaign that would have unitied all of Adura?";
						Aiden.state = (int)CharacterState.Worried;
						Kira.state = (int)CharacterState.Shocked;
						
					}
									
					if (count == 32) {
						DialogueText.Text = "Aiden: My father was poisoned by an unknown agent at the time. Considering that we were so " +
				"close to reuniting the kingdoms of Adura, my father's last order was to falsify the story of his death";				
						Aiden.state = (int)CharacterState.Worried;			


					}
					if (count == 33) {					
						DialogueText.Text = "Kira: So the other kingdoms wouldn't suspect each other of treachery due to the down defense?"; 
						Kira.state = (int)CharacterState.Thinking;			


					}
					if (count == 34) {
						DialogueText.Text = "Aiden: Exactly, However, we were under the conclusion that Darius was not alive. So we " +
				"came to the conclusion it was one of his loyalists avenging his death.";
						Aiden.state = (int)CharacterState.Thinking;					


					}
					if (count == 35) {
						DialogueText.Text = "But considering the current intel that's been brought to my attention, it's obvious the hit " +
				"was ordered by the coward himself.";
						Aiden.state = (int)CharacterState.Angry;				


					}
					if (count == 36) {
						DialogueText.Text = "Kira: Look Aiden, I am very sorry. Aimes was a real father figure to me as well. " +
				"He taught us every thing we know. I agree that we must stop him!";
						Kira.state = (int)CharacterState.Worried;				


					}
					if (count == 37) {
						DialogueText.Text = "Aiden: Indeed... Tomorrow I must gather more resources and report back to the blacksmith in " +
				"Cuprille, however WE is no longer an option Kira. This is my battle."; 	
						Aiden.state = (int)CharacterState.Normal;				

					}

					if (count == 38) {
						DialogueText.Text = "Aiden: Therefore, tomorrow at the break of dawn I am ordering you and your men out of this Kingdom.";
						Aiden.state = (int)CharacterState.Angry;			


					}
					if (count == 39) {
						DialogueText.Text = "Kira: AIDEN! You can't send me...";
						Kira.state = (int)CharacterState.Shocked;				


					}
					if (count == 40) {
						DialogueText.Text = "Aiden: That's an order.";
									

				
					}
					if (count == 41) {
						DialogueText.Text = "Kira: But...";
						Kira.state = (int)CharacterState.Worried;				

					}
					if (count == 42) {
						DialogueText.Text = "Aiden: Soldier! As your commanding officer, my orders are the law in this battalion. Need I strip rank?";
						Aiden.state = (int)CharacterState.Angry;			

					}
					if (count == 43) {	
						DialogueText.Text = "Kira: No sir...";
						Kira.state = (int)CharacterState.Normal;				

					}
					if (count == 44) {
						DialogueText.Text = "Kira walks away, obviously frustrated and partially hurt that Aiden would humble her with his rank.";
				

						setKira = false;

					}	
				
					if (count == 45) {
						DialogueText.Text = "However Aiden cares deeply for Kira and knows that there is a great chance that he may not " +
				"survive the battle with Darius. Thoughts of her survival is his only source of strength ";
						Aiden.state = (int)CharacterState.Thinking;

					}
				if (count == 46)
				{
					game.ChatFinished = true;
					SetUpCharacters(Aiden);
					break;
				}
					
					if(count <= 22){
					if (Aiden.state != Aiden.oldState | Kira.state != Kira.oldState | Bandit3.state != Bandit3.oldState | forceSetUp)				
						SetUpCharacters (Aiden, Kira, Bandit3);}
				else {
					if (Aiden.state != Aiden.oldState | Kira.state != Kira.oldState)
						SetUpCharacters(Aiden,Kira);
				}
				
				
					count++;
					
				break;
			#endregion					
				
			
				#region Scene Four
			case (int)CurrentScene.Fourth:
					
			if(count == 0){
				
				DialogueText.Text = " The sun rises in the east and Aiden is watching Kira march her army away. How he wishes she " +
				"would look back at him. Not a single glance.";
					Aside = true;
					SetWidgetLayout(LayoutOrientation.Horizontal);
			}
				
			if(count ==1){		
					SceneManager.ReplaceScene((int)GE2D.BLACKSMITH);
					DialogueText.Text = "Aiden: Blacksmith! I am back, and we have secured the mine. Now if we are going to take " +
				"back this land, I will need the finest sword you will ever create.";
					setAiden = true;
					Aiden.state = (int)CharacterState.Normal;
					Aside = false;
					SetWidgetLayout(LayoutOrientation.Horizontal);


				}
			if(count ==2){
				
					DialogueText.Text = "Blacksmith: Ahhh, what happened to the fine lass you had with you yesterday?";

					}
			if(count ==3){		
					
					DialogueText.Text = "Aiden: That's of no concern to you. Just tell me what you need.";
					Aiden.state = (int)CharacterState.Angry;			


				}
			if(count ==4){
					
					DialogueText.Text = "Blacksmith: No need to be so testy, mate. I'm just wonderin'. Hmmm. Well, we need to secure our " +
				"other two strongholds first for their mines.";


				}
			if(count ==5){
					
					DialogueText.Text = "Aiden: Is that it?";
					Aiden.state = (int)CharacterState.Normal;			

				
			}
			if(count ==6){
					
					DialogueText.Text = " Blacksmith: Yep, we already got them mills to the east while you were in them mines. " +
				"You get them resources that we need and I can create a sword that will slay giants.";
				

				}
			if(count ==7){
					
					DialogueText.Text = "Aiden: Alright, I will be back.";
					Aiden.state = (int)CharacterState.Normal;				


				}
			if(count ==8){
				
				game.ChatFinished = true;
				SetUpCharacters(Aiden);
				break;
			}
				
				if(Aiden.state != Aiden.oldState)
				{
					SetUpCharacters(Aiden);
					
				}
				count++;
				break;
			#endregion
				
				#region Scene Five
				case (int)CurrentScene.Fifth:

				if(count ==0){
					DialogueText.Text = " Aiden arrives at the the southern strong hold and motions for his army to hold rank.";
				Aside = true;
					SetWidgetLayout(LayoutOrientation.Horizontal);
					                

				}
				if(count ==1){
					
					DialogueText.Text = "Aiden: Tell whoever leads this fortress to present himself, so that we may negotiate his surrender";
					
					Aside = false;
					setAiden = true;
					Aiden.state = (int)CharacterState.Angry;
					SetUpCharacters(Aiden);
					SetWidgetLayout(LayoutOrientation.Horizontal);

				}
				if(count ==2){

					
					DialogueText.Text = " A few moments pass, and as Aiden's patience begins to wear thin, the front gate is " +
				"pushed open and a man walks toward Aiden.";


				}
				if(count ==3){
					

					DialogueText.Text = "Aiden: Are you the leader of this outpost? If so, surrender...";
					Aiden.state = (int)CharacterState.Normal;
					setBandit2 = true;

				}
				if(count ==4){

					
					DialogueText.Text = "Unknown: Surrender? Surrender to whom? A little boy and his army with second rate equipment " +
				"and armor? Move along, flea; you're not drawing any blood here.";
					Bandit2.state = (int)BanditState.BANDIT2_SMUG;			

				}
				if(count ==5){

					
					DialogueText.Text = " Aiden: Do not turn your back on me naively! I am Aiden, son of Aimes the Magnate. And I will cut " +
				"you down there where you stand.";
					Aiden.state = (int)CharacterState.Angry;				


				}
				if(count ==6){
					
					DialogueText.Text = " Unknown: Hmmmmm, As a matter of fact. Maybe this would be interesting after all. There has been a " +
				"very expensive bounty put on a... Son of Mr. Dead and forgotten.";
					Bandit2.state = (int)BanditState.BANDIT2_SMUG;				

				}
				if(count ==7){
					
					DialogueText.Text = " However, I will inform you that my name is Jasz of Bane.";
					Bandit2.state = (int)BanditState.BANDIT2_SMUG;				

				}
				if(count ==8){

					
					DialogueText.Text = " Aiden: Less introduction, more battling!";
					Aiden.state = (int)CharacterState.Angry;			

				}
				if(count ==9){
					game.StartBattle =true;
					
				}
				if(count ==10){

					DialogueText.Text = " Aiden: You are defeated, now surrender your town or my cold steel will be the last thing you " +
				"ever feel in this life";
					
					
					Aiden.state = (int)CharacterState.Angry;
					Bandit2.state = (int)BanditState.BANDIT2_ANNOY;	
				
					

				}
				if(count ==11){
							
					
					DialogueText.Text = "Jasz of Bane: Alright, just don't kill me.";
								

				}
				if(count ==12){
					
					DialogueText.Text = "Aiden: men take him in chains. We're keeping him prisoner.";
					Aiden.state = (int)CharacterState.Normal;			
					setBandit2 = false;
									
				}
				if(count ==13){	
				game.ChatFinished = true;
				SetUpCharacters(Aiden);
				break;
					
						
				}
				if(Aiden.state != Aiden.oldState | Bandit2.state != Bandit2.oldState)
					SetUpCharacters(Aiden, Bandit2);
				count++;
				break;
				#endregion
				
			case (int)CurrentScene.Sixth:
			
			if(count ==0){
					
					SceneManager.ReplaceScene((int)GE2D.BLACKSMITH);
					DialogueText.Text = "A few days pass and plenty of ore is mined from this stronghold. Aiden begins to worry a bit " +
				"about Kira. He is unsure if she would forgive him, or if he would even see her again.";
			
				}
			if(count ==1){		
				
					DialogueText.Text = "Aiden: Alright Blacksmith, just one more stronghold to take. Then I will be back.";
					setAiden = true;
					Aiden.state = (int)CharacterState.Normal;
					Aside = false;
					SetWidgetLayout(LayoutOrientation.Horizontal);
									
				}
				if(count ==2)
				{
					game.ChatFinished = true;
					
					
				}
				
				SetUpCharacters(Aiden);
				count++;
				break;
				
			case(int)CurrentScene.Seventh:
			if(count ==0){
					SceneManager.ReplaceScene((int)GE2D.FORT);
					DialogueText.Text = "Aiden's army approaches the second stronghold. However, curiously, the front door is wide open.";
					
				
					}
			if(count ==1){
					DialogueText.Text = "Aiden orders his men to hold back as he enters the stronghold himself.";
			
					}
			if(count ==2){				
												
					DialogueText.Text = " Aiden: Is anybody in here?! Show yourself! I am Aiden of Ventus and I am here to claim thi...";
					setAiden = true;
					Aside = false;
					Aiden.state = (int)CharacterState.Angry;			
					SetWidgetLayout(LayoutOrientation.Horizontal);
				}
			if(count ==3){
			
					
					DialogueText.Text = "Unsuspecting to Aiden, a blow to the back of the head had knocked him completely unconscious."; 
			
					Aiden.state = (int)CharacterState.Hurt;
					setBandit1 = true;
					setBandit2 = true;
					setBandit3 = true;			
			
				}
			if(count ==4){
				
					DialogueText.Text = " Jasz of Bane: Lord Arkan will reward us well for taking him alive.";
					
					setAiden = false;
					
					Bandit1.state = (int)BanditState.BANDIT1_SMUG;
					Bandit2.state = (int)BanditState.BANDIT2_SMUG;
					Bandit3.state = (int)BanditState.BANDIT3_SMUG;	
			
				}
			if(count ==5){
				
					DialogueText.Text = " Elider: Why must we take him alive.... Why not just say he struggled and we HAD TO KILL HIM."; 
					Bandit3.state = (int)BanditState.BANDIT3_MAD;					
			
			}
			if(count ==6){
					
					DialogueText.Text = " Unknown: Shut your face, Elider, before I punch a crater in it.";
					Bandit1.state = (int)BanditState.BANDIT1_ANNOY;				
			
			}
			if(count ==7){
				
					
					DialogueText.Text = " Elider: But Rasz...";
					Bandit3.state = (int)BanditState.BANDIT3_ANNOY;	
			
				}
			if(count ==8){
				
					
					DialogueText.Text = " Rasz snaps back and wrecks his fist against Elider's jaw, knocking him out cold."; 
					setBandit3 = false;	
					Bandit1.state = (int)BanditState.BANDIT1_MAD;
			
				
					}
			if(count ==9){
					DialogueText.Text = " Jasz: Thank you, Brother. His whining was getting on my last nerve.";
					Bandit2.state = (int)BanditState.BANDIT2_SMUG;				
			
			
				}
			if(count ==10){
					
					DialogueText.Text = " Rasz: Shut it! Just carry the prisoner's body; I will have my quarrel to pick with you later. " +
				"I'm going to order my men who had sieged his puny force to start executing them immediately.";
					Bandit1.state = (int)BanditState.BANDIT1_ANNOY;				
					setBandit1 = false;
					setBandit2 = false;	
					setBandit3 = false;
				}
			if(count ==11){
					SceneManager.ReplaceScene((int)GE2D.DUNGEON);
					DialogueText.Text = "Kira: Psst! Aiden, wake up.";
					setAiden = true;
					setKira = true;	
					Aiden.forcevisible = true;
					Kira.state = (int)CharacterState.Worried;
					kiraOnLeft = true;
					SetUpCharacters(Aiden,Kira);
			
				}
			if(count ==12){
				
					DialogueText.Text = "Aiden: Uughhhh. K-Kira? Is that you? Nghhh my head. Where are we?";
					Aiden.state = (int)CharacterState.Hurt;				
			}
			if(count ==13){
			
				
					DialogueText.Text = "Kira: There's no time to explain everything, but right now we are in a dungeon. Now, let's get out of here.";
					Kira.state = (int)CharacterState.Worried;				
			
			}
			if(count ==14){
				
					DialogueText.Text = "Aiden: Where are my men?";
					Aiden.state = (int)CharacterState.Hurt;				
			}
			if(count ==15){
			
				
					DialogueText.Text = "Kira: Aiden....";
					Kira.state = (int)CharacterState.Worried;			
			
			}
			if(count ==16){
					
					DialogueText.Text = "Rasz: Your men are dead. I just finished exterminating the last one. He screamed like a little " +
				"girl before I ripped his throat out.";
					setBandit1 = true;
					Bandit1.state = (int)BanditState.BANDIT1_SMUG;		
			
					}
			if(count ==17){
					DialogueText.Text = "Aiden: YOU BASTARD!";
					
			
				}
			if(count ==18){
				
					DialogueText.Text = "Rasz: And in a moment, I'm going to rip your little girlfriend's throat out too. Well hey, she's " +
				"kind of a cutie, maybe we can have a little personal time first.";
					Bandit1.state = (int)BanditState.BANDIT1_SMUG;			
			
				}
			if(count ==19){
							
					DialogueText.Text = "Aiden: Don't you touch her!";
					Aiden.state = (int)CharacterState.Hurt;			
			
			}
			if(count ==20){
					
					DialogueText.Text = "As Rasz walks closer to her, Kira roundhouse kicks him in the face and knocks Rasz to the floor";
			
			}
			if(count ==21){
				
					
					DialogueText.Text = "Rasz: You will pay for that, wench";
							
			
			}
			if(count ==22){
				
				
					DialogueText.Text = "Aiden: Let me out, Kira. You can't take him alone!";
					Aiden.state = (int)CharacterState.Hurt;			
			
				}
			if(count ==23){
					
					DialogueText.Text = "Kira: Aiden, I can hold my own against this thug.";
					Kira.state = (int)CharacterState.Angry;
				
				}
				
			if(count ==24)
				{
					game.StartBattle = true;
				}
			if(count ==25){
				
					DialogueText.Text = "Rasz: ughhhh...";
					Bandit1.state = (int)BanditState.BANDIT1_MAD;
				
				}
			if(count ==26){
					
					DialogueText.Text = "Kira: Your better stay down. Unless you want my dagger through your gut, you'll stay down and quiet.";
					Kira.state = (int)CharacterState.Normal;	
				
				}
			if(count ==27){
					
					DialogueText.Text = "Kira: Hold on, Aiden, I'll get you out...";
					Kira.state = (int)CharacterState.Worried;	
				
				}
			if(count ==28){
					
					DialogueText.Text = "Kira frees Aiden from his cell, but as she does so, Rasz seemingly vanishes. Together, " +
				"the two young heroes return with Kira's men to town.";
					setBandit1 = false;

					}
			if(count ==29){
					DialogueText.Text = "Aiden: Tomorrow, we'll go and face Darius.";
					Aiden.state = (int)CharacterState.Normal;
				
					}
			if(count ==30){
					DialogueText.Text = "Kira: Together.";
					Kira.state = (int)CharacterState.Happy;	
				
					}
			if(count ==31){
					DialogueText.Text = "Aiden: ...Kira, I'm sorry. For sending you away.";
					Aiden.state = (int)CharacterState.Worried;
				}
			if(count ==32){
				
					DialogueText.Text = "Kira: Just don't do it again, okay? I can't save your ass if I'm not here.";
					Kira.state = (int)CharacterState.Happy;	
				
				}
			if(count ==33)
				{
					game.ChatFinished = true;
					SetUpCharacters(Aiden);
					break;
				}
				
				if(count <= 17){
				if(Aiden.state != Aiden.oldState | Bandit1.state != Bandit1.oldState | Bandit2.state != Bandit2.oldState | Bandit3.state != Bandit3.oldState)
				{
					SetUpCharacters(Aiden, null, Bandit2, Bandit1, Bandit3);
				}
				}
				else if(Aiden.state != Aiden.oldState | Bandit1.state != Bandit1.oldState | Kira.state != Kira.oldState)
				SetUpCharacters(Aiden, Kira, Bandit1);
			
				count++;
			break;
				
			case (int)CurrentScene.Eighth:
			
				
				if(count ==0){
					SceneManager.ReplaceScene((int)GE2D.BLACKSMITH);
					DialogueText.Text = "The next morning dawns clear and bright as Kira and Aiden ready themselves " +
				"for battle. They approach the Blacksmith one more time.";
					Aside = true;
					SetWidgetLayout(LayoutOrientation.Horizontal);
				}
			if(count ==1){
					DialogueText.Text = "Blacksmith: Well, if the little lady ain't back!";
					Aside = false;
					setAiden = true;
					setKira = true;
					SetWidgetLayout(LayoutOrientation.Horizontal);

				}
			if(count ==2){
					
					DialogueText.Text = "Kira: I hear you have something for Aiden.";
					Kira.state = (int)CharacterState.Normal;
				
				}
			if(count ==3){
					DialogueText.Text = "Blacksmith: You bet! You'll never find a finer sword than this one.";

				}
			if(count ==4){
					
					DialogueText.Text = "Kira:  Aiden, do you even know how to swing that?";
					Kira.state = (int)CharacterState.Shocked;
				}
			if(count ==5){
				
					
					DialogueText.Text = "Aiden: Ha ha ha Very funny Kira. Can you give me a break about what happened yesterday?";
					Aiden.state = (int)CharacterState.Normal;
				
				}
			if(count ==6){
					
					DialogueText.Text = "Kira: Oh alright ill stop teasing you. However I do think your father would be proud of you.  But please, don't cut your own head off hehe.";
					Kira.state = (int)CharacterState.Happy;
				
				}
			if(count ==8){
					game.ChatFinished = true;
					
					SetUpCharacters();
					break;
					}
			if(Aiden.state != Aiden.oldState | Kira.state != Kira.oldState)
				SetUpCharacters(Aiden, Kira);
				count++;
				break;
				
			case (int)CurrentScene.Nineth:
				
			if(count ==0){
			
					
					DialogueText.Text = "With their army, Kira and Aiden approach the northern stronghold.  But before they can " +
				"call out for Lord Arkan to show himself, three very familiar faces appear before them.";
					
				
				}
			if(count ==1){
					
					DialogueText.Text = "Elider: You thought you'd seen the last of us, didnt you?";
					Bandit1.state = (int)BanditState.BANDIT1_SMUG;
					Bandit2.state = (int)BanditState.BANDIT2_SMUG;
					Bandit3.state = (int)BanditState.BANDIT3_SMUG;
					setAiden = true;
					setKira = true;
					setBandit1 = true; 
					setBandit2 = true; 
					setBandit3 = true;
					kiraOnLeft = true;
					
					Aside = false;
					SetWidgetLayout(LayoutOrientation.Horizontal);
				
				}
			if(count ==2){
					
					DialogueText.Text = "Jasz: With Lord Darius on our side, we are undefeatable!";
					
				
					}
			if(count ==3){
					DialogueText.Text = "Rasz: Face it, brats; you can't win!";
					
				}
			if(count ==4){
					DialogueText.Text = "Aiden: Big talk for a bunch of sore losers!  Ready, Kira?";
					Aiden.state = (int)CharacterState.Normal;
				}
			if(count ==5){
					
					DialogueText.Text = "Kira: Always, Aiden.  For Ventus!";
					Kira.state = (int)CharacterState.Normal;
				
				}
			if(count ==6){
				
					game.StartBattle = true;	
				}
			if(count ==7){
				
					DialogueText.Text = "Kira: So much for undefeatable.  Now, let's go find Darius!";
					Kira.state = (int)CharacterState.Happy;
					setBandit1 = false;
					setBandit2 = false; 
					setBandit3 = false;
				}
			if(count ==8){
						
					DialogueText.Text = "Aiden: Right!";
					Aiden.state = (int)CharacterState.Happy;
				}
			if(count ==9){
					SceneManager.ReplaceScene((int)GE2D.FINAL);
					DialogueText.Text = "However, as our heroes set forth, a terrible clattering resounds throughout the room. " +
				"Aiden pushes Kira away from himself just as a gate slams down between them, separating them.";
				}
			if(count ==10){
						
					DialogueText.Text = "Aiden: Kira!";
					Aiden.state = (int)CharacterState.Shocked;
				}
			if(count ==11){
						
					DialogueText.Text = "Kira: Aiden! Behind you!";
					Kira.state = (int)CharacterState.Worried;
					setKira = false;  
					setBear = true;
				}
			if(count ==12){
				
					
					DialogueText.Text = "Darius: So, the little rat comes scurrying into my keep, does he?";
					Bear.state = (int)CharacterState.Normal;
				
					}
			if(count ==13){
					DialogueText.Text = "Aiden: Darius!, Your days of inslaving innocent people are over! On my father's honor you will pay";
					Aiden.state = (int)CharacterState.Angry;
				}
			if(count ==14){
						
					DialogueText.Text = "Darius: I am not as easily beaten as the rats that came before me, boy. Draw your sword only if you have a death wish wanting to be granted";
					Bear.state = (int)CharacterState.Angry;
				}
			if(count ==15){
						
					DialogueText.Text = "Aiden: I will draw my sword for the sake of all of Audra! For I am Aiden of Ventus, son of Aimes the Magnate. " +
				"I won't be defeated!";
					Aiden.state = (int)CharacterState.Angry;
				
				}
			if(count ==16){
					
					game.StartBattle = true;
			
					}
			if(count ==17){

					DialogueText.Text = "As Darius falls, Aiden releases the lock on the gate that seperates him from Kira,";

					setKira = true;
					setBear = false;
					Aiden.state = (int)CharacterState.Hurt;
				}
			if(count ==18){
						
					DialogueText.Text = "Aiden: I...I did it.  I avenged my father.";
			
				}
			if(count ==19){
						
					DialogueText.Text = "Kira: You did indeed. And now Adura is safe once more from the likes of Arkan.";
					Kira.state = (int)CharacterState.Normal;

				}
			if(count ==20){
						
					DialogueText.Text = "Aiden: Kira, I...";
			}
			if(count ==21){
					SceneManager.ReplaceScene((int)GE2D.GOODTOWN);
						
					DialogueText.Text = "Kira: Come on, let's go back to town. I bet we can convince someone to make us some pie.";
					Kira.state = (int)CharacterState.Happy;
						}
			if(count ==22){
					DialogueText.Text = "Aiden: Apple?";
					Aiden.state = (int)CharacterState.Happy;
						}
			if(count ==23){
					DialogueText.Text = "Kira: Hot and fresh on the windowsill!";
					Kira.state = (int)CharacterState.Happy;
						}
				
				if(count == 24)
				{
					DialogueText.Text = "Aiden and Kira have successfully liberated their homeland, and have won the battle. However as always with the ways of war, this is just one battle of many waiting our young heroes. Unknown to them an even greater threat to all of Audra rests on the horizon....";
					
				
				}
				if(Aiden.state != Aiden.oldState | Kira.state != Kira.oldState)
				{
					SetUpCharacters(Aiden,Kira);
				}
				
				if(Bandit1.state != Bandit1.oldState | Bandit2.state != Bandit2.oldState | Bandit3.state != Bandit3.oldState)
				{
					SetUpCharacters(Aiden, Kira, Bandit1, Bandit2, Bandit3);
				}
				
				if(setBear == true | Bear.state != Bear.oldState)
				{
					SetUpCharacters(Aiden, Kira, Bear);
				}
				count++;
				break;
			}
		}
	}
}