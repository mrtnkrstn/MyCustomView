using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace CustomViewXIB
{
	public partial class CustomViewXIBViewController : UIViewController
	{
		public CustomViewXIBViewController () : base ("CustomViewXIBViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// doesn't work
//			var nibObjects = NSBundle.MainBundle.LoadNib("MyCustomView", this, null);
//			this.myCustomView = Runtime.GetNSObject(nibObjects.ValueAt(0)) as MyCustomView;


			// doesn't work
//			this.myCustomView = new MyCustomView(this.Handle);

			// NullReferenceException!
//			this.myCustomView.Label.Text = "New Text";
		}
	}
}

