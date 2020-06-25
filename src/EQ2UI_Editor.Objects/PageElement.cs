using System.Xml.Serialization;

namespace EQ2UI_Editor.Objects {
	[XmlRoot ( ElementName = "Page" , Namespace = "" , IsNullable = false )]
	public class PageElement {
		[XmlArray ( ElementName = "include" , Namespace = "" , IsNullable = false )]
		public IncludeElement [] Includes { get; set; }
	}
}
