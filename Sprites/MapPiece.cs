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
	public class MapPiece : SpriteTile
	{
		protected Vector2 position;
		protected TextureInfo textureinfo;
		protected Vector2i index;
		
		public Vector2 localPosition ()
		{
			return position;
		}
		
		public MapPiece (Vector2 Position, TextureInfo texture_info, Vector2i Index) 
			: base(texture_info, Index)
		{
			position = Position;
			textureinfo = texture_info;
			index = Index;
		}
		
		public override void OnEnter ()
		{
			RegisterDisposeOnExitRecursive();
			base.OnEnter ();
		}
		
	}
	
	public class MinePiece : MapPiece
	{
		
		
		public MinePiece (Vector2 Position, TextureInfo texture_info, Vector2i Index) 
			: base(Position, texture_info, Index)
		{
			
		}
		
		public override void OnEnter ()
		{
			ScheduleUpdate (0);
			
			base.OnEnter ();
		}
		
		
		
		
	}
	
	public class StrongHoldPiece : MapPiece
	{
				
		public StrongHoldPiece (Vector2 Position, TextureInfo texture_info, Vector2i Index) 
			: base(Position, texture_info, Index)
		{
			
		}

		public override void OnEnter ()
		{
			base.OnEnter ();
		}
	}
	
	public class LumberMillPiece : MapPiece
	{		
		
		public LumberMillPiece (Vector2 Position, TextureInfo texture_info, Vector2i Index) 
			: base(Position, texture_info, Index)
		{
			
			
		}

		public override void OnEnter ()
		{
			base.OnEnter ();
		}
		
		
	}

	public class MineDrillPiece : MapPiece
	{
		
		
		public MineDrillPiece (Vector2 Position, TextureInfo texture_info, Vector2i Index) 
			: base(Position, texture_info, Index)
		{
			
		}
		
		public override void OnEnter ()
		{
			ScheduleUpdate (0);
			
			base.OnEnter ();
		}

		public override void Update (float dt)
		{
			
			
			base.Update (dt);
		}
		
	}
		
}


