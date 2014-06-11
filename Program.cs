using System;

using Sce.Pss.Core;
using Sce.Pss.Core.Environment;

namespace Magnate
{
	public static class Program
	{
		public static void Main (string[] args)
		{
			Log.SetToConsole ();
			
			Program.Run ();			
			
			Console.WriteLine ("Game Successfully Closed");
			
		}
		
		public static void Run ()
		{
			Game.Instance = new Game();
			
			var game = Game.Instance;
			
			game.Initialize ();

			while (game.Running) {
				SystemEvents.CheckEvents ();
				game.Update ();
				game.Render ();
			}
			game.Cleanup ();
		}
	}
}

