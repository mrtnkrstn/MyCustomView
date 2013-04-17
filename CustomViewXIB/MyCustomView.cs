using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomViewXIB
{
	public partial class MyCustomView : UIView
	{ 
		public UILabel Label 
		{
			get
			{
				return this.label;
			}
			set
			{
				this.label = value;
			}
		}

		public MyCustomView (IntPtr handle) : base (handle)
		{
		}
	}
}

