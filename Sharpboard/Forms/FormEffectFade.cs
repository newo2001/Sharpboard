using System;
using System.Windows.Forms;
using Sharpboard.Element;
using Sharpboard.Command;

namespace Sharpboard.Forms {
	public partial class FormEffectFade : Form {
		private SBElement Element;
		private CommandFade Command;

		public FormEffectFade(SBElement element, CommandFade command) {
			Element = element;
			Command = command;

			InitializeComponent();

			inputStartTime.Value = Command.StartTime;
			inputEndTime.Value = Command.EndTime;
			inputStartOpacity.Value = (decimal) Command.StartOpacity;
			inputEndOpacity.Value = (decimal) Command.EndOpacity;
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			Command.StartTime = (int) inputStartTime.Value;
			Command.EndTime = (int) inputEndTime.Value;
			Command.StartOpacity = (double) inputStartOpacity.Value;
			Command.EndOpacity = (double) inputEndOpacity.Value;

			if (Command.EndTime < Command.StartTime) {
				MessageBox.Show("Start time was greater than end time.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Element.AddCommand(Command);
			Close();
		}
	}
}
