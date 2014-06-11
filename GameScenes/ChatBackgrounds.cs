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
public class Mine : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		Bgm music;
		BgmPlayer player;

		public Mine () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/mine.png", ref sprite,
			                     550f, new Vector2(0,0), new Vector2i(1,1));
			
			music = new Bgm("assets/Music/creepyloop.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			;
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			player.Stop();
			music.Dispose();
			player.Dispose();
			
			sprite.TextureInfo.Dispose();
			
			this.RemoveAllChildren(true);
						
			base.OnExit ();
		}
		
		
		
		
		
	}
public class StartScreen : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		static public Bgm music;
		static public BgmPlayer player;

		
		
		public StartScreen () : base()
		{
			
			sprite = new SpriteUV();
			
			RegisterDisposeOnExitRecursive();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/Test/Black.png", ref sprite,
			                     16f, new Vector2(0,0), this.Camera2D.CalcBounds().Size, new Vector2i(1,1));
					
			music = new Bgm("assets/Music/dirgeloop.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			
			this.RegisterDisposeOnExitRecursive();
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			UnscheduleUpdate();
			
			
			
			base.OnExit ();
		}
		
		
		
		
		
	}
	
	
	
public class Hilltop  : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		Bgm music;
		BgmPlayer player;

		
		
		public Hilltop () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/hill.png", ref sprite,
			                     550f, new Vector2(0,0), new Vector2i(1,1));
					
			music = new Bgm("assets/Music/sappypianointerlude.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			player.Stop();
			music.Dispose();
			player.Dispose();
			
			this.RemoveAllChildren(true);
						
			
			base.OnExit ();
		}
		
		
		
		
		
	}

public class DestroyedTown : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
	
		public Bgm music;
		public BgmPlayer player;
		
		
		public DestroyedTown () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/town_damaged.png", ref sprite,
			                     550f, new Vector2(0,0), new Vector2i(1,1));
					
			
			music = new Bgm("assets/Music/quietloop.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			player.Stop();
			music.Dispose();
			player.Dispose();
			
			this.RemoveAllChildren(true);
						
			
			base.OnExit ();
		}
		
		
		
		
		
	}

public class GoodTown : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		Bgm music;
		BgmPlayer player;

		
		
		public GoodTown () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/good town.png", ref sprite,
			                      550f, new Vector2(0,0), new Vector2i(1,1));
			music = new Bgm("assets/Music/sappypianointerlude.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
					
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			player.Stop();
			music.Dispose();
			player.Dispose();
			
			this.RemoveAllChildren(true);
						
			
			base.OnExit ();
		}
		
		
		
		
		
	}

public class Fortress : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		public Bgm music;
		public BgmPlayer player;

		
		
		public Fortress () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/fortress-01.png", ref sprite,
			                      550f, new Vector2(0,0), new Vector2i(1,1));
					
			music = new Bgm("assets/Music/dirgeloop.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			player.Stop();
			player.Dispose();
			music.Dispose();
			
			this.RemoveAllChildren(true);
						
			
			base.OnExit ();
		}
		
		
		
		
		
	}

public class FinalBattle : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		Bgm music;
		BgmPlayer player;

		
		
		public FinalBattle () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/final battle-colour.png", ref sprite,
			                     550f, new Vector2(0,0),  new Vector2i(1,1));
					
			music = new Bgm("assets/Music/combat.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			player.Stop ();
			music.Dispose();
			player.Dispose();
			            
			
			this.RemoveAllChildren(true);
						
			
			base.OnExit ();
		}
		
		
		
		
		
	
	}

public class FirstScene : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
	
		
		
		
		public FirstScene () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/StartScreen/StartScreen.png", ref sprite,
			                      16f, new Vector2(0,0), this.Camera2D.CalcBounds().Size, new Vector2i(1,1));
					
			this.RegisterDisposeOnExitRecursive();		
			
			
			
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			
			StartScreen.player.Stop();
			StartScreen.player.Dispose();
			StartScreen.music.Dispose();
			
			this.RemoveAllChildren(true);
						
			base.OnExit ();
		}
		
		
		
		
		
	}

	
	
	
	
public class Dungeon : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		Bgm music;
		BgmPlayer player;
		
		public Dungeon () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/dungeon-colour.png", ref sprite,
			                      550f, new Vector2(0,0),  new Vector2i(1,1));
											
			music = new Bgm("assets/Music/creepyloop.mp3");
			
			player = music.CreatePlayer();
			
			player.Play();
			
			base.OnEnter ();
		}
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
				
			player.Stop();
			player.Dispose();
			music.Dispose();
			
			this.RemoveAllChildren(true);
						
			base.OnExit ();
		}
		
		
		
		
		
		
	}
public class BlackSmith : BaseScene
	{
		Game game = Game.Instance;
		
		SpriteUV sprite;
		
		public BlackSmith () : base()
		{
			
			sprite = new SpriteUV();

		}
		
		public override void OnEnter ()
		{
			BaseScene.SetUpScene(this, "assets/backdrop/Blacksmith_final.png", ref sprite,
			                      550f, new Vector2(0,0), new Vector2i(1,1));
					
			this.RegisterDisposeOnExitRecursive();		
			
			sprite.Position += new Vector2(0, 100);
			base.OnEnter ();
		}
		
		public override void OnExit ()
		{
			sprite.TextureInfo.Dispose();
			
			this.RemoveAllChildren(true);
						
			base.OnExit ();
		}
	}



}


