using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Sharpboard.Effect;
using Sharpboard.Element;
using Sharpboard.Command;

namespace Sharpboard.Forms {
	public partial class FormExport : Form {
		public FormExport() {
			InitializeComponent();
		}

		private void buttonExportTextFile_Click(object sender, EventArgs e) {
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Text|*.txt|All|*.*";
			dialog.ShowDialog();

			if (dialog.FileName != "") {
				FileStream fs = (FileStream)dialog.OpenFile();
				byte[] bytes = GetDataBytes();
				fs.Write(bytes, 0, bytes.Length);
				fs.Close();
			}
		}

		// TODO test this function
		private void buttonExportBeatmap_Click(object sender, EventArgs e) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "osu! storyboard file|*.osb|All|*.*";
			dialog.Multiselect = false;
			dialog.ShowDialog();

			if (dialog.FileName != "") {
				FileStream fs = (FileStream) dialog.OpenFile();
				byte[] bytes = GetDataBytes();
				fs.Write(bytes, (int) (new FileInfo(dialog.FileName)).Length, bytes.Length);
				fs.Close();
			}
		}

		private byte[] GetDataBytes() {
			List<byte> bytes = new List<byte>();

			foreach (SBEffect effect in Sharpboard.GetStoryboard().GetEffects().Values) {
				foreach (SBElement element in effect.GetElements().Values) {
					foreach (SBCommand command in element.GetCommands().Values) {
						bytes.AddRange(Encoding.ASCII.GetBytes(" " + command.ToString() + "\r\n"));
					}
				}
			}

			return bytes.ToArray();
		}
	}
}
