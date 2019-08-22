using System;
using System.Windows.Forms;
using Sharpboard.Forms;

namespace Sharpboard {
	public static class Sharpboard {
		private static Storyboard Storyboard = new Storyboard();

		/// <summary>
		// The entry point of the application
		/// </summary>
		[STAThread]
		public static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormApplication());
		}

		public static Storyboard GetStoryboard() {
			return Storyboard;
		}
	}
}
