using System.Windows.Forms;
using Sharpboard.Forms;
using Sharpboard.Element;

namespace Sharpboard.Command {
	public class CommandFade : SBCommand {
		public double StartOpacity;
		public double EndOpacity;

		public CommandFade(int startTime, int endTime, int easing = 0, double startOpacity = 1.0, double endOpacity = 0.0) : base(startTime, endTime, easing) {
			StartOpacity = startOpacity;
			EndOpacity = endOpacity;
		}

		public CommandFade(int startTime = 0) : this(startTime, startTime) { }

		public override char GetFlag() {
			return 'F'; // Gotta be respectful
		}

		public override Form GetForm(SBElement element) {
			return new FormEffectFade(element, this);
		}

		public override string ToString() {
			string end = StartTime == EndTime ? "" : EndTime.ToString();
			return string.Format("F,{0},{1},{2},{3},{4}", Easing, StartTime, end, StartOpacity, EndOpacity);
		}
	}
}
