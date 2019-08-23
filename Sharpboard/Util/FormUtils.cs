using System.Windows.Forms;

namespace Sharpboard.Util {
	public static class FormUtils {
		// Hides the old form, opens the new form and opens the old form again when the new form is closed.
		public static void OpenForm(Form newForm, Form oldForm) {
			newForm.Location = oldForm.Location;
			newForm.StartPosition = FormStartPosition.Manual;
			newForm.FormClosing += delegate {
				oldForm.Location = newForm.Location;
				oldForm.Show();
			};
			newForm.Show();
			oldForm.Hide();
		}
	}
}
