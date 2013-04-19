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

			myCustomView = MyCustomView.Create();
			myCustomView.Frame = new RectangleF(0,0,320,200);
			Add(myCustomView);
			// doesn't work


			// doesn't work
//			this.myCustomView = new MyCustomView(this.Handle);

			// NullReferenceException!
//			this.myCustomView.Label.Text = "New Text";
		}
	}
}

