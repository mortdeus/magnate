// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class ChatDialogueUI
    {
        ImageBox ChatBox;
        Label DialogueText;
        ImageBox ImageBox_1;
        ImageBox ImageBox_2;
        ImageBox ImageBox_3;
        ImageBox ImageBox_4;
        ImageBox ImageBox_5;
        ImageBox ScreenVignette;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ChatBox = new ImageBox();
            ChatBox.Name = "ChatBox";
            DialogueText = new Label();
            DialogueText.Name = "DialogueText";
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            ImageBox_2 = new ImageBox();
            ImageBox_2.Name = "ImageBox_2";
            ImageBox_3 = new ImageBox();
            ImageBox_3.Name = "ImageBox_3";
            ImageBox_4 = new ImageBox();
            ImageBox_4.Name = "ImageBox_4";
            ImageBox_5 = new ImageBox();
            ImageBox_5.Name = "ImageBox_5";
            ScreenVignette = new ImageBox();
            ScreenVignette.Name = "ScreenVignette";

            // ChatBox
            ChatBox.Image = new ImageAsset("assets/GUI/Dialogue_ChatBox.png");

            // DialogueText
            DialogueText.TextColor = new UIColor(231f / 255f, 235f / 255f, 237f / 255f, 255f / 255f);
            DialogueText.Font = new Font( FontAlias.System, 16, FontStyle.Bold);
            DialogueText.TextTrimming = TextTrimming.Word;
            DialogueText.VerticalAlignment = VerticalAlignment.Top;

            // ImageBox_1

            // ImageBox_2

            // ImageBox_3

            // ImageBox_4

            // ImageBox_5

            // ScreenVignette
            ScreenVignette.Image = new ImageAsset("assets/GUI/Screen_Vignette.png");

            // Scene
            this.RootWidget.AddChildLast(ChatBox);
            this.RootWidget.AddChildLast(DialogueText);
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(ImageBox_2);
            this.RootWidget.AddChildLast(ImageBox_3);
            this.RootWidget.AddChildLast(ImageBox_4);
            this.RootWidget.AddChildLast(ImageBox_5);
            this.RootWidget.AddChildLast(ScreenVignette);
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
//                this.DesignWidth = 480;
//               this.DesignHeight = 854;
                
                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

                ChatBox.SetPosition(64, 317);
                ChatBox.SetSize(706, 120);
                ChatBox.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ChatBox.Visible = true;

                DialogueText.SetPosition(64, 354);
                DialogueText.SetSize(706, 75);
                DialogueText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                DialogueText.Visible = true;

                ImageBox_1.SetPosition();
                ImageBox_1.SetSize();
                ImageBox_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ImageBox_1.Visible = true;

                ImageBox_2.SetPosition();
                ImageBox_2.SetSize();
                ImageBox_2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ImageBox_2.Visible = true;

                ImageBox_3.SetPosition();
                ImageBox_3.SetSize();
                ImageBox_3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ImageBox_3.Visible = true;

                ImageBox_4.SetPosition();
                ImageBox_4.SetSize();
                ImageBox_4.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ImageBox_4.Visible = true;

                ImageBox_5.SetPosition();
                ImageBox_5.SetSize();
                ImageBox_5.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ImageBox_5.Visible = true;

                ScreenVignette.SetPosition(0, 0);
                ScreenVignette.SetSize(853, 478);
                ScreenVignette.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                ScreenVignette.Visible = true;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            DialogueText.Text = "Chat goes here";
            this.Title = "ChatDialogueUI";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    
                }
                break;

                default:
                {
                    ChatBox.Visible = false;
                    DialogueText.Visible = false;
                    ScreenVignette.Visible = false;
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
                        Widget = ScreenVignette,
                    }
                    .Start();
                }
                break;
            }
        }
    }
}
