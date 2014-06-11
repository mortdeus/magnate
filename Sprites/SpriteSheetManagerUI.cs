using System;
using System.Collections.Generic;
using System.Timers;

using Sce.Pss.Core;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;



namespace MagnateUI
{
		
	public class Sprite : IDisposable
	{
				
		public string filename;
		
		public Image image;
		
		public Image charactersheet;
		
		public int state;
		
		public int oldState = -1;
		
		public bool ExitScene = false;
		
		public Position position; 
		
		public Size size;
		
		public TileXY tiles;
						
		public Rectxy rectxy;
		
		public Offsetxy offset;
		
		public bool inscene;
		
		public bool forcevisible = false;
		
		public void Dispose()
		{ 	if(image!=null)
			image.Dispose();
			if(charactersheet!=null)
			charactersheet.Dispose();
		}
		
		
	}
	
	public struct Position{public float x; public float y;}
	public struct Size{public float x; public float y;}
	public struct TileXY{public int x; public int y;}
	public struct Offsetxy{public int x; public int y;}
	public struct Rectxy{public int x; public int y;}
	
	
	public static class SpriteSheetManagerUI
	{
				
		public static void CreateImageFromList(ref List<Sprite> list)
		{
			foreach(Sprite c in list)
			{
				
			}
			
		}
		public static void CreateImage(ref Sprite c)
		{		
				if(c.charactersheet == null)
				{
				c.charactersheet = new Image(c.filename);
				
				c.charactersheet.Decode();
				}
																
				c.rectxy.x = c.charactersheet.Size.Width / c.tiles.x;
				c.rectxy.y = c.charactersheet.Size.Height / c.tiles.y;
			
				SwapState(ref c);
		}
					
		public static void SwapState(ref Sprite c)
		{
				
				int offsetx = c.rectxy.x;
				int offsety = c.rectxy.y;
				int offsetxModifier = 0;
				int offsetYmodifier = 0;
			
				int state = c.state;
			
				while((state + 1) > c.tiles.x)
				{
				state -= c.tiles.x;	
				offsetYmodifier++;
				}
				offsetxModifier = state;
			
				c.offset.x = offsetx * offsetxModifier;
				c.offset.y = offsety * offsetYmodifier;
			
				ImageRect rect = new ImageRect(c.offset.x, c.offset.y, c.rectxy.x, c.rectxy.y);
			
				var image = c.charactersheet.Crop(rect);
				
				c.image = image;
				
		}
		
		
		
		
		
		
		
	}
}

