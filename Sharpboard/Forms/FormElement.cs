using System;
using System.Windows.Forms;
using Sharpboard.Element;
using Sharpboard.Command;
using Sharpboard.Util;

namespace Sharpboard.Forms {
	public partial class FormElement : Form {
		private SBElement Element;

		public FormElement(SBElement element) {
			Element = element;

			InitializeComponent();

			// Update the list when a new command has been added
			Element.CommandAddEvent += OnCommandAdded;
			Element.CommandChangeEvent += OnCommandChanged;
			Element.CommandRemoveEvent += OnCommandRemoved;

			if (Element.Name != "") {
				inputName.Text = Element.Name;
			}

			foreach (SBCommand command in Element.GetCommands().Values) {
				containerCommands.Rows.Add(command.GetId(), command.ToString());
			}

		}

		private void buttonSave_Click(object sender, EventArgs e) {
			if (inputName.Text == "") {
				MessageBox.Show("Please enter a name for this element.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Element.Name = inputName.Text;

			Element.GetEffect().AddElement(Element);

			// Make sure to unsubscribe from any events, if you don't, it can cause nasty memory leaks.
			Element.CommandAddEvent -= OnCommandAdded;
			Element.CommandChangeEvent -= OnCommandChanged;
			Element.CommandRemoveEvent -= OnCommandRemoved;
			Close();
		}

		private void buttonAddFade_Click(object sender, EventArgs e) {
			FormUtils.OpenForm(new FormEffectFade(Element, new CommandFade()), this);
		}

		private void buttonEditCommand_Click(object sender, EventArgs e) {
			Guid id = GetSelectedId();
			if (id == Guid.Empty) return;

			SBCommand command = Element.GetCommand(id);
			FormUtils.OpenForm(command.GetForm(Element), this);
		}

		private void buttonRemoveCommand_Click(object sender, EventArgs e) {
			Guid id = GetSelectedId();
			if (id == Guid.Empty) return;

			Element.RemoveCommand(id);
			foreach (DataGridViewRow row in containerCommands.Rows) {
				if ((Guid) row.Cells["Id"].Value == id) {
					containerCommands.Rows.Remove(row);
				}
			}
		}

		private void OnCommandAdded(SBCommand command) {
			containerCommands.Rows.Add(command.GetId(), command.ToString());
		}

		private void OnCommandChanged(SBCommand command) {
			foreach (DataGridViewRow row in containerCommands.Rows) {
				if ((Guid) row.Cells["Id"].Value == command.GetId()) {
					row.Cells["Commands"].Value = command.ToString();
					break;
				}
			}
		}

		private void OnCommandRemoved(SBCommand command) {
			foreach (DataGridViewRow row in containerCommands.Rows) {
				if ((Guid) row.Cells["Id"].Value == command.GetId()) {
					containerCommands.Rows.Remove(row);
					break;
				}
			}
		}

		private Guid GetSelectedId() {
			if (containerCommands.SelectedRows.Count == 0) {
				MessageBox.Show("No command selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return Guid.Empty;
			} else if (containerCommands.SelectedRows.Count > 1) {
				MessageBox.Show("Only one command can be edited at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return Guid.Empty;
			}
			return (Guid) containerCommands.SelectedRows[0].Cells["Id"].Value;
		}
	}
}
