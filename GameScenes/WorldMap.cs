#define Debug
//#define Release

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
	public class WorldMap : BaseScene
	{
		SpriteUV worldmap;
		
		Game game = Game.Instance;

		
		
		SpriteList mineAndStrongHoldList;
		SpriteList mineDrillList;
		SpriteList lumberMillList;
		
		TextureInfo mineSheetTextureInfo;
		TextureInfo lumbermillSheetTextureInfo;
		TextureInfo strongHoldAndMineSheetTextureInfo;
		
		MinePiece[] minePieces   			= new MinePiece[8];
		MineDrillPiece[] mineDrillPieces   	= new MineDrillPiece[11];
		LumberMillPiece[] lumberMillPieces	= new LumberMillPiece[7];	
		StrongHoldPiece[] strongHoldPieces	= new StrongHoldPiece[19];
		
		BgmPlayer boombox;
		Bgm music;
		
					
		float currentx;
		float currenty;
		float height;

		
		public WorldMap()
		{
						
			
		}
		
		public override void OnEnter ()
		{
			
			worldmap = new SpriteUV();
			
			currentx = 0f;
			currenty = 0f;
			height = 320f;
						
			SetUpWorldMap(this, "assets/WorldMap/DemoWorldMapWalls.png", ref worldmap, 
			           height, new Vector2(currentx, currenty), 
			            new Vector2i(1,1));
			
			SetUpMapPieces(minePieces, mineDrillPieces, lumberMillPieces, strongHoldPieces, ref mineSheetTextureInfo, ref lumbermillSheetTextureInfo, ref strongHoldAndMineSheetTextureInfo);
			
			SetMineDrillPiecesInMineDrillList(mineSheetTextureInfo, ref mineDrillList, ref mineDrillPieces, .059f);
			
			SetLumberMillPiecesInLumberMillList(lumbermillSheetTextureInfo, ref lumberMillList, ref lumberMillPieces, .059f);
			
			SetMinePiecesInMineList(strongHoldAndMineSheetTextureInfo, ref mineAndStrongHoldList, ref minePieces, .059f);
			
			SetStrongHoldPiecesInStrongHoldList(strongHoldAndMineSheetTextureInfo, ref mineAndStrongHoldList, ref strongHoldPieces, .059f); 
			
			music = new Bgm("assets/Music/loop.mp3");
			boombox = music.CreatePlayer();
			boombox.Play();
			
			 
			
			this.AddChild(mineAndStrongHoldList);
			
			this.AddChild(lumberMillList);
			
			this.AddChild(mineDrillList);
			
			this.ScheduleUpdate();
			this.RegisterDisposeOnExitRecursive();
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			lumberMillList.RemoveAllChildren(true);
			mineAndStrongHoldList.RemoveAllChildren(true);
			mineDrillList.RemoveAllChildren(true);
			lumbermillSheetTextureInfo.Dispose();
			mineSheetTextureInfo.Dispose();
			strongHoldAndMineSheetTextureInfo.Dispose();
			
			worldmap.TextureInfo.Dispose();
			
			boombox.Stop();
			music.Dispose();
			boombox.Dispose();
			
			this.RemoveAllChildren(true);
			
			Console.WriteLine(lumbermillSheetTextureInfo.Disposed.ToString() + " " + mineSheetTextureInfo.Disposed.ToString() + " " + strongHoldAndMineSheetTextureInfo.Disposed.ToString ());
		}
		
		
		public override void Update (float dt)
		{
												
			
			if(Input2.GamePad0.Select.Press)
			{
			
				
			}
			
			base.Update (dt);
			
			}
		
		
		
		
		
		public static void SetMineDrillPiecesInMineDrillList(TextureInfo textureinfo, ref SpriteList list, 
		                                  ref MineDrillPiece[] mineDrillPieces, float scale)
		{
			if(list == null)
			list = new SpriteList(textureinfo);	
			
			foreach(MineDrillPiece mineDrillPiece in mineDrillPieces)
			{					
				mineDrillPiece.Quad.S = mineDrillPiece.TextureInfo.TextureSizef * scale;
			
				mineDrillPiece.CenterSprite();
			
				mineDrillPiece.Position = Director.Instance.CurrentScene.Camera2D.Center + mineDrillPiece.localPosition();
			
				list.AddChild(mineDrillPiece);
			}
			
			
		}
		
		public static void SetLumberMillPiecesInLumberMillList(TextureInfo textureinfo, ref SpriteList list, 
		                                  ref LumberMillPiece[] lumberMillPieces, float scale)
		{
			if(list == null)
			list = new SpriteList(textureinfo);	
			
			foreach(LumberMillPiece lumberMillPiece in lumberMillPieces)
			{					
				lumberMillPiece.Quad.S = lumberMillPiece.TextureInfo.TextureSizef * scale;
			
				lumberMillPiece.CenterSprite();
			
				lumberMillPiece.Position = Director.Instance.CurrentScene.Camera2D.Center + lumberMillPiece.localPosition();
			
				list.AddChild(lumberMillPiece);
			}
			
			
		}
		
		public static void SetMinePiecesInMineList(TextureInfo textureinfo, ref SpriteList list, 
		                                  ref MinePiece[] MinePieces, float scale)
		{
			if(list == null)
			list = new SpriteList(textureinfo);	
			
			foreach(MinePiece minePiece in MinePieces)
			{					
				minePiece.Quad.S = minePiece.TextureInfo.TextureSizef * scale;
			
				minePiece.CenterSprite();
			
				minePiece.Position = Director.Instance.CurrentScene.Camera2D.Center + minePiece.localPosition();
			
				list.AddChild(minePiece);
			}
			
			
		}
		
		public static void SetStrongHoldPiecesInStrongHoldList(TextureInfo textureinfo, ref SpriteList list, 
		                                  ref StrongHoldPiece[] strongHoldPieces, float scale)
		{
			if(list == null)
			list = new SpriteList(textureinfo);	
			
			foreach(StrongHoldPiece strongHoldPiece in strongHoldPieces)
			{					
				strongHoldPiece.Quad.S = strongHoldPiece.TextureInfo.TextureSizef * scale;
			
				strongHoldPiece.CenterSprite();
			
				strongHoldPiece.Position = Director.Instance.CurrentScene.Camera2D.Center + strongHoldPiece.localPosition();
			
				list.AddChild(strongHoldPiece);
			}
			
			
		}
		
		
		public static void SetUpMapPieces(
											MinePiece[] minePieces, MineDrillPiece[] mineDrillPieces, 
		                                	LumberMillPiece[] lumberMillPieces, StrongHoldPiece[] StrongHoldPieces,
			                            	ref TextureInfo mineDrillSheetTextureInfo, ref TextureInfo lumbermillSheetTextureInfo, ref TextureInfo strongholdAndMineSheetTextureInfo     
			                             )
		{
				mineDrillSheetTextureInfo = new TextureInfo(new Texture2D("assets/WorldMap/MapPieces/MineSheet.png", false), 
			                                       					 new Vector2i(4, 4), TRS.Quad0_1);
			
				lumbermillSheetTextureInfo = new TextureInfo(new Texture2D("assets/WorldMap/MapPieces/LumberMillSpriteSheet.png", false), 
			                                       					 new Vector2i(4, 4), TRS.Quad0_1);
				
				strongholdAndMineSheetTextureInfo = new TextureInfo(new Texture2D("assets/WorldMap/MapPieces/StrongHoldsandMinesSheet.png", false), 
			                                       					 new Vector2i(4, 4), TRS.Quad0_1);
			
			#region MineDrills		
				mineDrillPieces[0]  = new MineDrillPiece(new Vector2(-35f, 75f),/*a*/ 	mineDrillSheetTextureInfo, new Vector2i(1,3));
				mineDrillPieces[1]  = new MineDrillPiece(new Vector2(-35f ,50f),/*b*/ 	mineDrillSheetTextureInfo, new Vector2i(0,0));
				mineDrillPieces[2]  = new MineDrillPiece(new Vector2(-30f,-90f),/*c*/ 	mineDrillSheetTextureInfo, new Vector2i(1,1));
			    mineDrillPieces[3]  = new MineDrillPiece(new Vector2(-85f,-85f),/*d*/	mineDrillSheetTextureInfo, new Vector2i(0,3));
				mineDrillPieces[4]  = new MineDrillPiece(new Vector2(-90f, 5f), /*e*/	mineDrillSheetTextureInfo, new Vector2i(2,3));
				mineDrillPieces[5]  = new MineDrillPiece(new Vector2(-105f,-50f),/*f*/ 	mineDrillSheetTextureInfo, new Vector2i(0,1)); 
				mineDrillPieces[6]  = new MineDrillPiece(new Vector2(115f,-50f),/*g*/ 	mineDrillSheetTextureInfo, new Vector2i(0,3));
				mineDrillPieces[7]  = new MineDrillPiece(new Vector2(215f,-55f),/*h*/ 	mineDrillSheetTextureInfo, new Vector2i(3,3));
				mineDrillPieces[8]  = new MineDrillPiece(new Vector2(260f, 60f),/*i*/ 	mineDrillSheetTextureInfo, new Vector2i(3,2));
				mineDrillPieces[9]  = new MineDrillPiece(new Vector2(160f, 85f),/*j*/  	mineDrillSheetTextureInfo, new Vector2i(0,3)); 
			    mineDrillPieces[10] = new MineDrillPiece(new Vector2(65f,-125f),/*k*/ 	mineDrillSheetTextureInfo, new Vector2i(0,0));
			#endregion
			#region LumberMills
				lumberMillPieces[0] = new LumberMillPiece(new Vector2(40,80), 			lumbermillSheetTextureInfo, new Vector2i(3,2)); 
				lumberMillPieces[1] = new LumberMillPiece(new Vector2(85,60), 			lumbermillSheetTextureInfo, new Vector2i(3,1)); 
				lumberMillPieces[2] = new LumberMillPiece(new Vector2(120,10), 			lumbermillSheetTextureInfo, new Vector2i(0,2)); 
				lumberMillPieces[3] = new LumberMillPiece(new Vector2(215,10), 			lumbermillSheetTextureInfo, new Vector2i(1,3)); 
				lumberMillPieces[4] = new LumberMillPiece(new Vector2(0,-10), 			lumbermillSheetTextureInfo, new Vector2i(1,1)); 
				lumberMillPieces[5] = new LumberMillPiece(new Vector2(10,-50), 			lumbermillSheetTextureInfo, new Vector2i(2,2)); 
				lumberMillPieces[6] = new LumberMillPiece(new Vector2(190,-30),			lumbermillSheetTextureInfo, new Vector2i(2,0));
			#endregion
			#region Mines
				minePieces[0] = new MinePiece(new Vector2(-97,50), 						strongholdAndMineSheetTextureInfo, new Vector2i(0,3));
				minePieces[1] = new MinePiece(new Vector2(0,85), 						strongholdAndMineSheetTextureInfo, new Vector2i(3,3));
				minePieces[2] = new MinePiece(new Vector2(-70,30), 						strongholdAndMineSheetTextureInfo, new Vector2i(2,3));
				minePieces[3] = new MinePiece(new Vector2(-20,-125), 					strongholdAndMineSheetTextureInfo, new Vector2i(1,3));
				minePieces[4] = new MinePiece(new Vector2(75,100), 						strongholdAndMineSheetTextureInfo, new Vector2i(0,3));
				minePieces[5] = new MinePiece(new Vector2(-110,-20), 					strongholdAndMineSheetTextureInfo, new Vector2i(1,3));
				minePieces[6] = new MinePiece(new Vector2(130,105), 					strongholdAndMineSheetTextureInfo, new Vector2i(1,3));
				minePieces[7] = new MinePiece(new Vector2(240,90), 						strongholdAndMineSheetTextureInfo, new Vector2i(3,3));
				
			#endregion
			#region StrongHolds
				StrongHoldPieces[0]  = new StrongHoldPiece(new Vector2(-60,10), 		strongholdAndMineSheetTextureInfo, new Vector2i(1,2));
				StrongHoldPieces[1]  = new StrongHoldPiece(new Vector2(5,55), 			strongholdAndMineSheetTextureInfo, new Vector2i(2,2));
				StrongHoldPieces[2]  = new StrongHoldPiece(new Vector2(75,25), 			strongholdAndMineSheetTextureInfo, new Vector2i(3,2));
				StrongHoldPieces[3]  = new StrongHoldPiece(new Vector2(160,50), 		strongholdAndMineSheetTextureInfo, new Vector2i(0,2));
				StrongHoldPieces[4]  = new StrongHoldPiece(new Vector2(170,20), 		strongholdAndMineSheetTextureInfo, new Vector2i(2,2));
				StrongHoldPieces[5]  = new StrongHoldPiece(new Vector2(220,70), 		strongholdAndMineSheetTextureInfo, new Vector2i(3,2));
				StrongHoldPieces[6]  = new StrongHoldPiece(new Vector2(190,90), 		strongholdAndMineSheetTextureInfo, new Vector2i(3,2));
				StrongHoldPieces[7]  = new StrongHoldPiece(new Vector2(-50,-30), 		strongholdAndMineSheetTextureInfo, new Vector2i(2,2));
				StrongHoldPieces[8]  = new StrongHoldPiece(new Vector2(5,-85), 			strongholdAndMineSheetTextureInfo, new Vector2i(0,2));
				StrongHoldPieces[9]  = new StrongHoldPiece(new Vector2(15,-105), 		strongholdAndMineSheetTextureInfo, new Vector2i(2,2));
				StrongHoldPieces[10] = new StrongHoldPiece(new Vector2(70,-40), 		strongholdAndMineSheetTextureInfo, new Vector2i(1,2));
				StrongHoldPieces[11] = new StrongHoldPiece(new Vector2(150,-30), 		strongholdAndMineSheetTextureInfo, new Vector2i(1,2));
				StrongHoldPieces[12] = new StrongHoldPiece(new Vector2(-60,-60), 		strongholdAndMineSheetTextureInfo, new Vector2i(2,2));
				StrongHoldPieces[13] = new StrongHoldPiece(new Vector2(90,-90), 		strongholdAndMineSheetTextureInfo, new Vector2i(0,2));
				StrongHoldPieces[14] = new StrongHoldPiece(new Vector2(180,-70), 		strongholdAndMineSheetTextureInfo, new Vector2i(3,2));
				StrongHoldPieces[15] = new StrongHoldPiece(new Vector2(105,85), 		strongholdAndMineSheetTextureInfo, new Vector2i(3,2));
				StrongHoldPieces[16] = new StrongHoldPiece(new Vector2(-100,25), 		strongholdAndMineSheetTextureInfo, new Vector2i(2,2));
				StrongHoldPieces[17] = new StrongHoldPiece(new Vector2(-60,60),			strongholdAndMineSheetTextureInfo, new Vector2i(1,2));
				StrongHoldPieces[18] = new StrongHoldPiece(new Vector2(190,-130),		strongholdAndMineSheetTextureInfo, new Vector2i(1,2));	
		#endregion
			
		}
		
	}
			
}