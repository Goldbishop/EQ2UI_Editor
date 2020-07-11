using System;
using System.Windows.Forms;

namespace EQ2UI_Editor.UI {
	public partial class MainForm : Form {
		public MainForm ( ) {
			this.InitializeComponent ();
		}

		private void mnuAboutSettings_Click ( Object sender , EventArgs e ) {
			var frm = new EQ2UI_Settings ();
			frm.ShowDialog ();
		}

		private void exitToolStripMenuItem_Click ( Object sender , EventArgs e ) {
			this.Close ();
		}
	}
}
