using System;
using System.Collections.Generic;

using Sce.Pss.Core;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Input;

using Sce.Pss.HighLevel.GameEngine2D;
using Sce.Pss.HighLevel.GameEngine2D.Base;

using Sce.Pss.HighLevel.UI;

using UIScene = Sce.Pss.HighLevel.UI.Scene;
using GameScene = Sce.Pss.HighLevel.GameEngine2D.Scene;

namespace Magnate
{
	public class BaseScene : GameScene
	{
		public BaseScene ()
		{
			Game.Instance.quitmusic = true;
			Game.Instance.startmusic = true;
			RegisterDisposeOnExitRecursive();
			
		}	
		
		
		protected static void SetUpScene(BaseScene scene, string filename, ref SpriteUV sprite, 
		                                 float cameraHeight, Vector2 cameraCenter, 
		                                 Vector2 quadSize, Vector2i numOftiles)
		{
			
			scene.Camera2D.SetViewFromHeightAndCenter (cameraHeight, cameraCenter);
			
			var texture_info = new TextureInfo( new Texture2D(filename, false ), numOftiles, TRS.Quad0_1);
			
			sprite.TextureInfo = texture_info;
			
			sprite.Quad.S = quadSize;
			
			sprite.CenterSprite();
			
			sprite.Position = scene.Camera.CalcBounds().Center;
			
			scene.AddChild(sprite);
			
		}
		
		protected static void SetUpWorldMap(BaseScene scene, string filename, ref SpriteUV sprite, 
		                                 float cameraHeight, Vector2 cameraCenter, 
		                                 Vector2i numOftiles)
		{
			
			scene.Camera2D.SetViewFromHeightAndCenter (cameraHeight, cameraCenter);
			
			var texture_info = new TextureInfo( new Texture2D(filename, false ), numOftiles, TRS.Quad0_1);
			
			sprite.TextureInfo = texture_info;
			
			sprite.Quad.S = texture_info.TextureSizef;
			
			sprite.CenterSprite();
			
			sprite.Position = scene.Camera.CalcBounds().Center + new Vector2(-20, 20);
			
			scene.AddChild(sprite);
			
		}
		protected static void SetUpScene(BaseScene scene, string filename, ref SpriteUV sprite, 
		                                 float cameraHeight, Vector2 cameraCenter, 
		                                 Vector2i numOftiles)
		{
			
			scene.Camera2D.SetViewFromHeightAndCenter (cameraHeight, cameraCenter);
			
			var texture_info = new TextureInfo( new Texture2D(filename, false ), numOftiles, TRS.Quad0_1);
			
			sprite.TextureInfo = texture_info;
			
			sprite.Quad.S = texture_info.TextureSizef;
			
			sprite.CenterSprite();
			
			sprite.Position = scene.Camera.CalcBounds().Center;
			
			scene.AddChild(sprite);
			
		}
		
	}
}

