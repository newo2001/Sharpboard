using System;
using System.Windows.Forms;
using Sharpboard.Element;

namespace Sharpboard.Command {
	public abstract class SBCommand {
		private Guid Id;
		public int Easing;
		public int StartTime;
		public int EndTime;

		public SBCommand(int startTime, int endTime, int easing) {
			Id = Guid.NewGuid();
			StartTime = startTime;
			EndTime = endTime;
			Easing = easing;
		}

		public SBCommand(int startTime, int endTime) : this(startTime, endTime, 0) { }
		public SBCommand(int startTime) : this(startTime, startTime, 0) { }

		public Guid GetId() {
			return Id;
		}

		public abstract char GetFlag();
		public abstract Form GetForm(SBElement element);
	}
}
