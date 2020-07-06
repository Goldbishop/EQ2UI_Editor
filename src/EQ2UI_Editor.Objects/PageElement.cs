using System;
using System.Windows;
using System.Xml.Serialization;

namespace EQ2UI_Editor.Objects {
	[XmlRoot ( ElementName = "Page" , Namespace = "" , IsNullable = false )]
	public class EQ2UIPage : EQ2UIElement {
		public EQ2UIPage ( ) : base ( "Page" ) { }

		#region Attributes
		[XmlAttribute ( AttributeName = "AbsorbsInput" , Namespace = "" , DataType = "boolean" )]
		public Boolean AbsorbsInput { get; set; } = false;
		[XmlAttribute ( AttributeName = "Cursor" , Namespace = "" , DataType = "boolean" )]
		public String Cursor { get; set; }
		[XmlAttribute ( AttributeName = "Cursor_Set" , Namespace = "" , DataType = "boolean" )]
		public String Cursor_Set { get; set; }
		[XmlAttribute ( AttributeName = "IgnoreTab" , Namespace = "" , DataType = "boolean" )]
		public Boolean IgnoreTab { get; set; }
		[XmlAttribute ( AttributeName = "MinimumSize" , Namespace = "" , DataType = "boolean" )]
		public String MinimumSize { get; set; }
		[XmlAttribute ( AttributeName = "Name" , Namespace = "" , DataType = "boolean" )]
		public String Name { get; set; }
		[XmlAttribute ( AttributeName = "PackSize" , Namespace = "" , DataType = "boolean" )]
		public String PackSize { get; set; }

		[XmlAttribute ( AttributeName = "ScrollExtent" , Namespace = "" , DataType = "boolean" )]
		public String ScrollExtent { get; set; }
		/// <summary>
		/// TODO: Enable parsing Size class into String; both Set & Get
		/// </summary>
		/// <exception cref="InvalidOperationException">Thrown if a comma "," is not within the value</exception>
		[XmlAttribute ( AttributeName = "Size" , Namespace = "" , DataType = "boolean" )]
		public String ElementSize {
			get {
				var val = this.GetAttribute<Size> ( "Size" );

				return String.Format ( "{0},{1}" , val.Width , val.Height );
			}
			set {
				if ( value.Contains ( "," ) ) {
					this.SetAttribute<Size> ( "Size" , Size.Parse ( value ) );
				} else {
					throw new InvalidOperationException (
						"Size value is improperly formatted; Format: {Width},{Height}" );
				}

			}
		}
		[XmlAttribute ( AttributeName = "TooltipStyle" , Namespace = "" , DataType = "boolean" )]
		public String TooltipStyle {
			get { return this.GetAttribute<String> ( "TooltipStyle" ); }
			set { this.SetAttribute ( "TooltipStyle" , value ); }
		}
		#endregion

		#region Child Elements
		[XmlArray ( ElementName = "include" , Namespace = "" , IsNullable = false )]
		public Object [] Children { get; set; }
		#endregion

	}
}
