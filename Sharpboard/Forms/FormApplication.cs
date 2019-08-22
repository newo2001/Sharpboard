using System;
using System.Windows.Forms;
using Sharpboard.Effect;

namespace Sharpboard.Forms {
	public partial class FormApplication : Form {
		private Storyboard Storyboard = Sharpboard.GetStoryboard();

		public FormApplication() {
			InitializeComponent();

			// Update the list when a new element has been added
			Storyboard.EffectAddEvent += OnEffectAdded;
			Storyboard.EffectChangeEvent += OnEffectChanged;
			Storyboard.EffectRemoveEvent += OnEffectRemoved;
		}

		private void buttonAddEffect_Click(object sender, EventArgs e) {
			(new FormEffect(new SBEffect(Storyboard))).Show(this);
		}

		private void buttonEditEffect_Click(object sender, EventArgs e) {
			Guid id = GetSelectedId();
			if (id == Guid.Empty) return;

			SBEffect effect = Storyboard.GetEffect(id);
			(new FormEffect(effect)).Show(this);
		}

		private void buttonRemoveEffect_Click(object sender, EventArgs e) {
			Guid id = GetSelectedId();
			if (id == Guid.Empty) return;

			Storyboard.RemoveEffect(id);
			foreach (DataGridViewRow row in containerEffects.Rows) {
				if ((Guid) row.Cells["Id"].Value == id) {
					containerEffects.Rows.Remove(row);
				}
			}
		}

		private void OnEffectAdded(SBEffect effect) {
			containerEffects.Rows.Add(effect.GetId(), effect.Name);
		}

		private void OnEffectChanged(SBEffect effect) {
			foreach (DataGridViewRow row in containerEffects.Rows) {
				if ((Guid) row.Cells["Id"].Value == effect.GetId()) {
					row.Cells["Effects"].Value = effect.Name;
				}
			}
		}
		private void OnEffectRemoved(SBEffect effect) {
			foreach (DataGridViewRow row in containerEffects.Rows) {
				if ((Guid) row.Cells["Id"].Value == effect.GetId()) {
					containerEffects.Rows.Remove(row);
				}
			}
		}

		private Guid GetSelectedId() {
			if (containerEffects.SelectedRows.Count == 0) {
				MessageBox.Show("No effect selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return Guid.Empty;
			} else if (containerEffects.SelectedRows.Count > 1) {
				MessageBox.Show("Only one effect can be edited at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return Guid.Empty;
			}
			return (Guid) containerEffects.SelectedRows[0].Cells["Id"].Value;
		}
	}
}
