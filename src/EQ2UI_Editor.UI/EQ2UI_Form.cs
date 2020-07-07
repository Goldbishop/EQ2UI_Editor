using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;

namespace EQ2UI_Editor.UI {
	public class EQ2UI_Form : Form {
		protected NameValueCollection AppSettings { get { return ConfigurationManager.AppSettings; } }

	}
}
