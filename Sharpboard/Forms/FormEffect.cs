using System;
using System.Windows.Forms;
using Sharpboard.Element;
using Sharpboard.Effect;

namespace Sharpboard.Forms {
	public partial class FormEffect : Form {
		private SBEffect Effect;

		public FormEffect(SBEffect effect) {
			Effect = effect;

			InitializeComponent();

			// Update the list when a new element has been added
			Effect.ElementAddEvent += OnElementAdded;
			Effect.ElementChangeEvent += OnElementChanged;
			Effect.ElementRemoveEvent += OnElementRemoved;

			if (Effect.Name != "") {
				inputName.Text = Effect.Name;
			}

			foreach (SBElement element in Effect.GetElements().Values) {
				containerElements.Rows.Add(element.GetId(), element.Name);
			}
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			if (inputName.Text == "") {
				MessageBox.Show("Please enter a name for this effect.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Effect.Name = inputName.Text;

			Effect.GetStoryboard().AddEffect(Effect);

			// Make sure to unsubscribe from any events, if you don't, it can cause nasty memory leaks.
			Effect.ElementAddEvent -= OnElementAdded;
			Effect.ElementChangeEvent -= OnElementChanged;
			Effect.ElementRemoveEvent -= OnElementRemoved;
			Close();
		}

		private void buttonAddElement_Click(object sender, EventArgs e) {
			(new FormElement(new SBElement(Effect))).Show(this);
		}

		private void buttonEditElement_Click(object sender, EventArgs e) {
			Guid id = GetSelectedId();
			if (id == Guid.Empty) return;

			SBElement element = Effect.GetElement(id);
			(new FormElement(element)).Show(this);
		}

		private void buttonRemoveElement_Click(object sender, EventArgs e) {
			Guid id = GetSelectedId();
			if (id == Guid.Empty) return;

			Effect.RemoveElement(id);
			foreach (DataGridViewRow row in containerElements.Rows) {
				if ((Guid) row.Cells["Id"].Value == id) {
					containerElements.Rows.Remove(row);
				}
			}
		}

		private void OnElementAdded(SBElement element) {
			containerElements.Rows.Add(element.GetId(), element.Name);
		}

		private void OnElementChanged(SBElement element) {
			foreach (DataGridViewRow row in containerElements.Rows) {
				if ((Guid) row.Cells["Id"].Value == element.GetId()) {
					row.Cells["Elements"].Value = element.Name;
					break;
				}
			}
		}

		private void OnElementRemoved(SBElement element) {
			foreach (DataGridViewRow row in containerElements.Rows) {
				if ((Guid) row.Cells["Id"].Value == element.GetId()) {
					containerElements.Rows.Remove(row);
					break;
				}
			}
		}

		private Guid GetSelectedId() {
			if (containerElements.SelectedRows.Count == 0) {
				MessageBox.Show("No element selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return Guid.Empty;
			} else if (containerElements.SelectedRows.Count > 1) {
				MessageBox.Show("Only one element can be edited at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return Guid.Empty;
			}
			return (Guid) containerElements.SelectedRows[0].Cells["Id"].Value;
		}
	}
}
