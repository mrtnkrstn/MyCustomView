// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace CustomViewXIB
{
	[Register ("CustomViewXIBViewController")]
	partial class CustomViewXIBViewController
	{
		[Outlet]
		CustomViewXIB.MyCustomView myCustomView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myCustomView != null) {
				myCustomView.Dispose ();
				myCustomView = null;
			}
		}
	}
}
