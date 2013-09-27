using System;
using System.Drawing;
using MonoTouch.AVFoundation;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace SoZoomy
{
	public partial class PreviewView : UIView
	{
		public AVCaptureSession Session {
			get {
				return (Layer as AVCaptureVideoPreviewLayer).Session;
			}
			set {
				(Layer as AVCaptureVideoPreviewLayer).Session = value;
			}
		}

/*		public PreviewView () : base ()
		{
		}

		public PreviewView (RectangleF frame) : base (frame)
		{
		}
*/
		public PreviewView (IntPtr handle) : base (handle)
		{
		}

		[Export ("layerClass")]
		public static Class LayerClass ()
		{
			return new Class (typeof (AVCaptureVideoPreviewLayer));
		}
	}
}