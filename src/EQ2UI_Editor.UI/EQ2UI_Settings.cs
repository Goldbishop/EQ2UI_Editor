using System;
using System.Windows.Forms;

namespace EQ2UI_Editor.UI {
	public partial class EQ2UI_Settings : EQ2UI_Form {

		public EQ2UI_Settings ( ) {
			this.InitializeComponent ();

			this.btnRestart.Enabled = false;
		}

		private void btnEQ2Directory_Click ( Object sender , EventArgs e ) {
			var dlg = new FolderBrowserDialog ();
			dlg.ShowNewFolderButton = false;

			var dir = @"";

			switch ( dlg.ShowDialog () ) {
				case DialogResult.OK:
				case DialogResult.Yes:
					dir = dlg.SelectedPath;
					break;
				default:
					// All non-Selection results
					break;
			}

			this.txtEQ2Directory.Text = dir;
			this.txtEQ2UIDirectory.Text = $"{dir}\\UI";

		}

		private void btnCancel_Click ( Object sender , EventArgs e ) {
			this.Close ();
		}

		private void btnApply_Click ( Object sender , EventArgs e ) {

		}

		private void btnRestart_Click ( Object sender , EventArgs e ) {

		}
	}
}
