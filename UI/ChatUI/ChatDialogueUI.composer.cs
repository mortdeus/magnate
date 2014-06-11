// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Graphics;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class ChatDialogueUI
    {
        
		
		
        ImageBox LCharBoxL;
        ImageBox LCharboxR;
        ImageBox RCharBoxR;
        ImageBox RCharBoxL;
        ImageBox RCharBoxM;
        ImageBox ChatBox;
        Label DialogueText;
        ImageBox screenVignette;
		bool Aside = true;
       
        

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
                    
           
           
			// ChatBox
            ChatBox.Image = new ImageAsset("assets/GUI/Dialogue_ChatBox.png");
			
           
			if(Aside){
			// DialogueText
            DialogueText.TextColor = new UIColor(231f / 255f, 235f / 255f, 237f / 255f, 255f / 255f);
            DialogueText.Font = new Font( FontAlias.System, 14, FontStyle.Bold);
            DialogueText.TextTrimming = TextTrimming.Word;
            DialogueText.HorizontalAlignment = HorizontalAlignment.Center;
			}
			else
			{
				  // DialogueText
            DialogueText.TextColor = new UIColor(231f / 255f, 235f / 255f, 237f / 255f, 255f / 255f);
            DialogueText.Font = new Font( FontAlias.System, 16, FontStyle.Bold);
            DialogueText.TextTrimming = TextTrimming.Word;
            DialogueText.VerticalAlignment = VerticalAlignment.Top;
				
			}
            // ScreenVignette
            screenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");
			// TextEvent
           
            this.RootWidget.AddChildLast(LCharBoxL);
            this.RootWidget.AddChildLast(LCharboxR);
            this.RootWidget.AddChildLast(RCharBoxR);
            this.RootWidget.AddChildLast(RCharBoxL);
            this.RootWidget.AddChildLast(RCharBoxM);
            this.RootWidget.AddChildLast(ChatBox);
            this.RootWidget.AddChildLast(DialogueText);
            this.RootWidget.AddChildLast(screenVignette);
			        	
            this.Transition = new CrossFadeTransition();
            this.Showing += new EventHandler(onShowing);
            this.Shown += new EventHandler(onShown);

            
			SetWidgetLayout(orientation);
			
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
            case LayoutOrientation.Vertical:
				#region vertical
				this.DesignWidth = 480;
                this.DesignHeight = 854;

                
				
				
                ChatBox.SetPosition(151, 322);
                ChatBox.SetSize(200, 200);
                ChatBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ChatBox.Visible = true;
				
				
				
                DialogueText.SetPosition(160, 313);
                DialogueText.SetSize(214, 36);
                DialogueText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueText.Visible = true;

                screenVignette.SetPosition(0, 0);
                screenVignette.SetSize(200, 200);
                screenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                screenVignette.Visible = true;

               
                break;
				#endregion
            default:
                
				this.DesignWidth = 854;
                this.DesignHeight = 480;
				               	
				
				if(Aside){
				ChatBox.SetPosition(241, -28);
                ChatBox.SetSize(377, 105);
                ChatBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ChatBox.Visible = true;

                DialogueText.SetPosition(254, 2);
                DialogueText.SetSize(353, 75);
                DialogueText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueText.Visible = true;
				}
				else
				{
					ChatBox.SetPosition(64, 317);
                ChatBox.SetSize(706, 120);
                ChatBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ChatBox.Visible = true;

                DialogueText.SetPosition(64, 354);
                DialogueText.SetSize(706, 75);
                DialogueText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueText.Visible = true;
				}
				
				
				screenVignette.SetPosition(0, 0);
                screenVignette.SetSize(853, 478);
                screenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                screenVignette.Visible = true;

               
                
				
				
				
                	break;
           		}
            _currentLayoutOrientation = orientation;
        }
        
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                   
                    LCharBoxL.Visible = false;
                    LCharboxR.Visible = false;
                    RCharBoxR.Visible = false;
                    RCharBoxL.Visible = false;
                    RCharBoxM.Visible = false;
                    ChatBox.Visible = false;
                    DialogueText.Visible = false;
                    screenVignette.Visible = false;
                }
                break;

                default:
                {
                  
                    LCharBoxL.Visible = false;
                    LCharboxR.Visible = false;
                    RCharBoxR.Visible = false;
                    RCharBoxL.Visible = false;
                    RCharBoxM.Visible = false;
                    ChatBox.Visible = false;
                    DialogueText.Visible = false;
                    screenVignette.Visible = false;
                }
                break;
            }
        }
        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    new FadeInEffect()
                    {
                        Widget = LCharBoxL,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = LCharboxR,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = RCharBoxR,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = RCharBoxL,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = RCharBoxM,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = ChatBox,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = DialogueText,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = screenVignette,
                    }
                    .Start();
                }
                break;

                default:
                {
                    
                    new FadeInEffect()
                    {
                        Widget = ChatBox,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = DialogueText,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = screenVignette,
                    }
                    .Start();
                }
                break;
            }
        }
    }
}