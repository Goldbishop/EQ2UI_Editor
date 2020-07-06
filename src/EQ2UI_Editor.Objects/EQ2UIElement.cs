using System;
using System.Collections.Generic;

namespace EQ2UI_Editor.Objects {
	/// <summary>
	/// Class to describe an individual XML Element; Attributes and Child Elements
	/// </summary>
	public abstract class EQ2UIElement {
		private Dictionary<String , Object> _attributes;
		private List<EQ2UIElement> _children;

		public EQ2UIElement ( String name ) : this () {
			this.ElementName = name;
		}
		private EQ2UIElement ( ) {
			// Initialize Variables
			this._attributes = new Dictionary<String , Object> ();
			this._children = new List<EQ2UIElement> ();
		}

		#region Properties
		/// <summary>
		/// Returns the Name of the Element.  Name is defined upon constructor initialization
		/// </summary>
		public String ElementName { get; }

		#endregion

		#region Methods
		protected Object GetAttribute ( String key ) {
			return this.GetAttribute<Object> ( key );
		}
		protected T GetAttribute<T> ( String key ) {
			return ( T ) this._attributes [ key ];
		}
		/// <summary>
		/// Creates or Sets the <paramref name="value"/> of the <paramref name="key"/>
		/// </summary>
		/// <param name="key">String value; Represents the unique key to store</param>
		/// <param name="value"></param>
		/// <returns></returns>
		protected Boolean SetAttribute<T> ( String key , T value ) {
			Boolean result = true;

			try {
				if ( this._attributes.ContainsKey ( key ) ) {
					this._attributes [ key ] = value;
				} else {
					this._attributes.Add ( key , value );
				}
			} catch ( Exception ) {
				result = false;
			}

			return result;
		}

		#endregion
	}
}
