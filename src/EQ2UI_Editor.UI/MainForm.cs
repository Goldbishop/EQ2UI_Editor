using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQ2UI_Editor.UI {
	public partial class MainForm : Form {
		public MainForm ( ) {
			InitializeComponent ();
		}

		private void mnuAboutSettings_Click ( Object sender , EventArgs e ) {
			var frm = new EQ2UI_Settings ();
			frm.ShowDialog ();
		}
	}
}
